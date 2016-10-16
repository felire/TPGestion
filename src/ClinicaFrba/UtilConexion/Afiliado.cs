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
        public decimal telefono { get; set; }
        public string mail { get; set; }
        public DateTime fechaNac { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public decimal plan { get; set; }
        public int familiaresACargo { get; set; }
        public string domicilio { get; set; }
        public Plan planObjeto { get; set; }

        public Afiliado(string nombreUser)
        {
            cargarAfiliado(nombreUser);
        }

        public Afiliado() { }


        public void habilitar()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@IdAfiliado", id));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.rehabilitar", "SP", ListaParametros);
            speaker.close();
        }

        public void deshabilitar(string motivo)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Id", id));
            ListaParametros.Add(new SqlParameter("@Motivo", motivo));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.baja_logica_afiliado", "SP", ListaParametros);
            speaker.close();
        }

        public void registrarAltaPrincipal()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Nom", nombre));
            ListaParametros.Add(new SqlParameter("@Ape", apellido));
            ListaParametros.Add(new SqlParameter("@Tipo_doc", tipoDoc));
            ListaParametros.Add(new SqlParameter("@Doc", documento));
            ListaParametros.Add(new SqlParameter("@Dire", domicilio));
            ListaParametros.Add(new SqlParameter("@Tel", telefono));
            ListaParametros.Add(new SqlParameter("@Mail", mail));
            ListaParametros.Add(new SqlParameter("@Fecha_nac", fechaNac));
            ListaParametros.Add(new SqlParameter("@Sexo", sexo));
            ListaParametros.Add(new SqlParameter("@Estado_civil", estadoCivil));
            ListaParametros.Add(new SqlParameter("@Hijos", familiaresACargo));
            ListaParametros.Add(new SqlParameter("@Plan_Medico", plan));
            SqlParameter parametroSalida = new SqlParameter("@IdAfiReal", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.alta_afiliado", "SP", ListaParametros);
            int idAfiliado = Int32.Parse(speaker.comando.Parameters["@IdAfiReal"].Value.ToString());
            this.id = idAfiliado;
        }

        public void registrarAltaConyuge(Afiliado conyuge)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Nom", nombre));
            ListaParametros.Add(new SqlParameter("@Ape", apellido));
            ListaParametros.Add(new SqlParameter("@Tipo_doc", tipoDoc));
            ListaParametros.Add(new SqlParameter("@Doc", documento));
            ListaParametros.Add(new SqlParameter("@Dire", domicilio));
            ListaParametros.Add(new SqlParameter("@Tel", telefono));
            ListaParametros.Add(new SqlParameter("@Mail", mail));
            ListaParametros.Add(new SqlParameter("@Fecha_nac", fechaNac));
            ListaParametros.Add(new SqlParameter("@Sexo", sexo));
            ListaParametros.Add(new SqlParameter("@IdAfiInput", conyuge.id));
            SqlParameter parametroSalida = new SqlParameter("@IdAfiReal", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.alta_conyuge", "SP", ListaParametros);
            int idAfiliado = Int32.Parse(speaker.comando.Parameters["@IdAfiReal"].Value.ToString());
            this.id = idAfiliado;
        }


        public void rehabilitar()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@IdAfiliado", this.id));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.rehabilitar", "SP", ListaParametros);
            speaker.close();
        }

        public Boolean afiliadoActivo()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Id", -this.id));
            Boolean activo = false;
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Esta_activo FROM kernel_panic.Afiliados WHERE Id = @Id", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                activo = (Boolean)speaker.reader["Esta_activo"];
            }
            speaker.close();
            return activo;
        }


        public void registrarAfiliadoRehabilitado()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Nom", nombre));
            ListaParametros.Add(new SqlParameter("@Ape", apellido));
            ListaParametros.Add(new SqlParameter("@Tipo_doc", tipoDoc));
            ListaParametros.Add(new SqlParameter("@Doc", documento));
            ListaParametros.Add(new SqlParameter("@Dire", domicilio));
            ListaParametros.Add(new SqlParameter("@Tel", telefono));
            ListaParametros.Add(new SqlParameter("@Mail", mail));
            ListaParametros.Add(new SqlParameter("@Fecha_nac", fechaNac));
            ListaParametros.Add(new SqlParameter("@Sexo", sexo));
            ListaParametros.Add(new SqlParameter("@Estado_civil", estadoCivil));
            ListaParametros.Add(new SqlParameter("@Hijos", familiaresACargo));
            ListaParametros.Add(new SqlParameter("@Plan_Medico", plan));
            SqlParameter parametroSalida = new SqlParameter("@IdAfiReal", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.rehabilitacion_afiliado", "SP", ListaParametros);
            int idAfiliado = Int32.Parse(speaker.comando.Parameters["@IdAfiReal"].Value.ToString());
            this.id = idAfiliado;
        }


        public void registrarAltaHijo(int numeroHijo, Afiliado padre)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Nom", nombre));
            ListaParametros.Add(new SqlParameter("@Ape", apellido));
            ListaParametros.Add(new SqlParameter("@Tipo_doc", tipoDoc));
            ListaParametros.Add(new SqlParameter("@Doc", documento));
            ListaParametros.Add(new SqlParameter("@Dire", domicilio));
            ListaParametros.Add(new SqlParameter("@Tel", telefono));
            ListaParametros.Add(new SqlParameter("@Mail", mail));
            ListaParametros.Add(new SqlParameter("@Fecha_nac", fechaNac));
            ListaParametros.Add(new SqlParameter("@Sexo", sexo));
            ListaParametros.Add(new SqlParameter("@NroHijo", numeroHijo));
            ListaParametros.Add(new SqlParameter("@IdAfiInput", padre.id));
            SqlParameter parametroSalida = new SqlParameter("@IdAfiReal", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.alta_hermano", "SP", ListaParametros);
            int idAfiliado = Int32.Parse(speaker.comando.Parameters["@IdAfiReal"].Value.ToString());
            this.id = idAfiliado;
        }

        public void obtenerTodosLosDatos()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@Id", this.id));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Numero_de_grupo, Numero_en_el_grupo, Nombre, Apellido, Tipo_doc, Numero_doc, Direccion, Telefono, Mail, "+
                                                               "Fecha_nacimiento, Sexo, Estado_civil, Familiares_a_cargo, GF.Plan_grupo FROM kernel_panic.Afiliados A JOIN kernel_panic.Grupos_Familiares GF ON (A.Numero_de_grupo=GF.Id) WHERE A.Id = @Id", "T", ListaParametros);

            if (speaker.reader.HasRows)
            {
                    speaker.reader.Read();

                    this.numeroDeGrupo = (int)speaker.reader["Numero_de_grupo"];
                    this.numeroEnElGrupo = (int)speaker.reader["Numero_en_el_grupo"];
                    this.nombre = (string)speaker.reader["Nombre"];
                    this.apellido = (string)speaker.reader["Apellido"];
                    this.tipoDoc = (string)speaker.reader["Tipo_doc"];
                    this.documento = (decimal)speaker.reader["Numero_doc"];
                    this.domicilio = (string)speaker.reader["Direccion"];
                    this.telefono = (decimal)speaker.reader["Telefono"];
                    this.mail = (string)speaker.reader["Mail"];
                    this.fechaNac = (DateTime)speaker.reader["Fecha_nacimiento"];                   
                    if (speaker.reader["Estado_civil"] == DBNull.Value)
                    {
                        this.estadoCivil = null;
                    }
                    else
                    {
                        this.estadoCivil = (string)speaker.reader["Estado_civil"];
                    }
                    if (speaker.reader["Sexo"] == DBNull.Value)
                    {
                        this.sexo = null;
                    }
                    else
                    {
                        this.sexo = (string)speaker.reader["Sexo"];
                    }
                    this.planObjeto = new Plan((decimal)speaker.reader["Plan_grupo"]);
                    this.familiaresACargo = (int)speaker.reader["Familiares_a_cargo"];
            }
            speaker.close();

        }

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


        public static List<Afiliado> buscarDeshabilitados(string nombre, string apellido, string grupo, string tipoDoc, string doc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
            ListaParametros.Add(new SqlParameter("@apellido", "%" + apellido + "%"));
            SpeakerDB speaker;
            // pueden pasar el documento o no, y el numero de grupo podria ser 0 que significa que no busca por ese campo
            string query = "";
            if (doc.Equals(""))
            {
                if (grupo.Equals(""))
                {
                    query = "SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo "+
                            "FROM kernel_panic.Afiliados a1 "+
                            "WHERE Nombre LIKE @nombre "+ 
                            "AND  Apellido LIKE @apellido "+
                            "AND Esta_activo = 0 "+
                            "AND (SELECT COUNT(*) "+
                                 "FROM kernel_panic.Afiliados a2 "+
                                 "WHERE a2.Esta_activo = 1 "+
                                 "AND a2.Tipo_doc = a1.Tipo_doc "+
                                 "AND a2.Numero_doc = a1.Numero_doc) = 0 ";
                    speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
                }
                else
                {
                    ListaParametros.Add(new SqlParameter("@grupo", Int32.Parse(grupo)));
                    query = "SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo " +
                            "FROM kernel_panic.Afiliados a1 " +
                            "WHERE Nombre LIKE @nombre " +
                            "AND Nombre LIKE @nombre "+
                            "AND  Apellido LIKE @apellido "+
                            "AND Numero_de_grupo LIKE @grupo "+
                            "AND Esta_activo = 0 " +
                            "AND (SELECT COUNT(*) " +
                                 "FROM kernel_panic.Afiliados a2 " +
                                 "WHERE a2.Esta_activo = 1 " +
                                 "AND a2.Tipo_doc = a1.Tipo_doc " +
                                 "AND a2.Numero_doc = a1.Numero_doc) = 0 ";
                    speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
                }
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@tipoDoc", tipoDoc));
                ListaParametros.Add(new SqlParameter("@doc", Decimal.Parse(doc)));
                if (grupo.Equals(""))
                {
                    query = "SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo " +
                            "FROM kernel_panic.Afiliados a1 " +
                            "WHERE Nombre LIKE @nombre " +
                            "AND Nombre LIKE @nombre "+
                            "AND  Apellido LIKE @apellido "+
                            "AND Tipo_doc = @tipoDoc "+
                            "AND Numero_doc = @doc "+
                            "AND Esta_activo = 0 " +
                            "AND (SELECT COUNT(*) " +
                                 "FROM kernel_panic.Afiliados a2 " +
                                 "WHERE a2.Esta_activo = 1 " +
                                 "AND a2.Tipo_doc = a1.Tipo_doc " +
                                 "AND a2.Numero_doc = a1.Numero_doc) = 0 ";
                    speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);

                }
                else
                {
                    ListaParametros.Add(new SqlParameter("@grupo", Int32.Parse(grupo)));
                    query = "SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo " +
                            "FROM kernel_panic.Afiliados a1 " +
                            "WHERE Nombre LIKE @nombre " +
                            "AND Nombre LIKE @nombre "+
                            "AND  Apellido LIKE @apellido "+
                            "AND Numero_de_grupo = @grupo "+
                            "AND Tipo_doc = @tipoDoc "+
                            "AND Numero_doc = @doc "+
                            "AND Esta_activo = 0 " +
                            "AND (SELECT COUNT(*) " +
                                 "FROM kernel_panic.Afiliados a2 " +
                                 "WHERE a2.Esta_activo = 1 " +
                                 "AND a2.Tipo_doc = a1.Tipo_doc " +
                                 "AND a2.Numero_doc = a1.Numero_doc) = 0 ";
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
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Nombre, Apellido, Tipo_doc, Numero_doc, Id, Numero_de_grupo, Numero_en_el_grupo FROM kernel_panic.Afiliados WHERE Nombre_usuario = @nombreUsuario", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                    speaker.reader.Read();
                    this.id = (int)speaker.reader["Id"];
                    this.numeroDeGrupo = (int)speaker.reader["Numero_de_grupo"];
                    this.numeroEnElGrupo = (int)speaker.reader["Numero_en_el_grupo"];
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
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT COUNT(id) AS prox FROM kernel_panic.Bonos_Consultas WHERE Afiliado = @id", "T", ListaParametros);
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
                            "WHERE con.Afiliado IS NULL AND con.Plan_asociado = gf.Plan_grupo AND con.Grupo = gf.Id " +
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
