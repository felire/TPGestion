using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Afiliado
    {
        public int id;
        public int numeroDeGrupo;
        public int numeroEnElGrupo;
        public bool esta_activo;
        public string nombre;
        public string apellido;
        public string tipoDoc;
        public decimal documento;
        public string direccion;
        public decimal telefono;
        public string mail;
        public DateTime fechaNac;
        public string sexo;
        public string estadoCivil;

        public Afiliado(string nombreUser)
        {
            cargarAfiliado(nombreUser);
        }

        public Afiliado() { }

        public static List<Afiliado> buscar(string nombre, string apellido, string grupo, string tipoDoc, string doc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
            ListaParametros.Add(new SqlParameter("@apellido", "%" + apellido + "%"));
            SpeakerDB speaker;
            // pueden pasar el documento o no, y el numero de grupo podria ser 0 que significa que no busca por ese campo
            if (doc.Equals(""))
            {
                if (grupo.Equals(""))
                {
                    speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo FROM kernel_panic.Afiliados WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido AND Esta_activo = 1", "T", ListaParametros);
                }
                else
                {
                    ListaParametros.Add(new SqlParameter("@grupo", Int16.Parse(grupo)));
                    speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo FROM kernel_panic.Afiliados WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido AND Numero_de_grupo LIKE @grupo AND Esta_activo = 1", "T", ListaParametros);
                }
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@tipoDoc", tipoDoc));
                ListaParametros.Add(new SqlParameter("@doc", Decimal.Parse(doc)));
                if (grupo.Equals(""))
                {
                    speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo FROM kernel_panic.Afiliados WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido AND Tipo_doc = @tipoDoc AND Numero_doc = @doc AND Esta_activo = 1", "T", ListaParametros);

                }
                else
                {
                    ListaParametros.Add(new SqlParameter("@grupo", Int16.Parse(grupo)));
                    speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo FROM kernel_panic.Afiliados WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido AND Numero_de_grupo = @grupo AND Tipo_doc = @tipoDoc AND Numero_doc = @doc AND Esta_activo = 1", "T", ListaParametros);
                }
            }

            List<Afiliado> afiliados = new List<Afiliado>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Afiliado afiliado = new Afiliado();
                    afiliado.id = (int)speaker.reader["Id"];
                    afiliado.numeroDeGrupo = (int)speaker.reader["Numero_de_grupo"];
                    afiliado.numeroEnElGrupo = (int)speaker.reader["Numero_en_el_grupo"];
                    afiliado.esta_activo = true;
                    afiliado.apellido = (string)speaker.reader["Apellido"];
                    afiliado.nombre = (string)speaker.reader["Nombre"];
                    afiliado.tipoDoc = (string)speaker.reader["Tipo_doc"];
                    afiliado.documento = (decimal)speaker.reader["Numero_doc"];
                    afiliados.Add(afiliado);
                }
            }
            speaker.close();
            return afiliados;
        }

        public void cargarAfiliado(string nombreUsuario)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo, Esta_activo FROM kernel_panic.Afiliados WHERE Nombre_usuario = @nombreUsuario", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                    speaker.reader.Read();
                    this.id = (int)speaker.reader["Id"];
                    this.numeroDeGrupo = (int)speaker.reader["Numero_de_grupo"];
                    this.numeroEnElGrupo = (int)speaker.reader["Numero_en_el_grupo"];
                    this.esta_activo = (bool)speaker.reader["Esta_activo"];
                    this.apellido = (string)speaker.reader["Apellido"];
                    this.nombre = (string)speaker.reader["Nombre"];
                    this.tipoDoc = (string)speaker.reader["Tipo_doc"];
                    this.documento = (decimal)speaker.reader["Numero_doc"];
            }
            speaker.close();    
        }

        public int proximoNumeroDeConsulta()
        {
            int proximo = 0;
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", this.id));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT COUNT(id) AS prox FROM kernel_panic.Bonos_Consultas WHERE Afiliado_Uso = @id", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                    speaker.reader.Read();
                    proximo = (int)speaker.reader["prox"];
            }
            speaker.close();
            proximo++;
            return proximo;
        }

        public int bonoAUsar()
        {
            int idBono = 0;
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idGrupo", this.numeroDeGrupo));
            string query = "SELECT TOP 1 con.Id AS num " +
                            "FROM kernel_panic.Bonos_Consultas con " +
                            "JOIN kernel_panic.Grupos_Familiares gf  ON (gf.Id = @idGrupo) " +
                            "WHERE con.Afiliado_Uso IS NULL AND con.Plan_Uso = gf.Plan_grupo AND con.Grupo_afiliado = gf.Id " +
                            "ORDER BY con.Id ASC";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                idBono = (int)speaker.reader["num"];
            }
            speaker.close();
            return idBono;
        }

        public int numeroPlan()
        {
            int numeroPlan = 0;
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idGrupo", this.numeroDeGrupo));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Plan_grupo AS planG FROM kernel_panic.Grupos_Familiares WHERE Id=@idGrupo ", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                numeroPlan = (int)speaker.reader["planG"];
            }
            speaker.close();
            return numeroPlan;
        }
    }
}
