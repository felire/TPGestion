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
        public int id { get; set; }
        public int numeroDeGrupo { get; set; }
        public int numeroEnElGrupo { get; set; }
        public bool esta_activo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDoc { get; set; }
        public decimal documento { get; set; }
        public string direccion { get; set; }
        public decimal telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaNac { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }

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
            Int16 grupoNum;
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

    }
}
