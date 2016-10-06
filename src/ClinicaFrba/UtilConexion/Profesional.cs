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
using ClinicaFrba.UtilConexion;

namespace ClinicaFrba.UtilConexion
{
    class Profesional
    {
        public int id;
        public string nombre;
        public string apellido;
        public List<Especialidad> especialidades;
        public string tipoDoc;
        public decimal documento;

        public Profesional()
        {
            especialidades = new List<Especialidad>();
        }

        public Profesional(int id)
        {
            especialidades = new List<Especialidad>();
            this.id = id;
            cargarProfesional();
        }

        public Profesional(string nombreUser)
        {
            especialidades = new List<Especialidad>();
            cargarProfesional(nombreUser);
        }

        public void cargarProfesional(string nombreUser)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombreUser", nombreUser));
            string query = "SELECT Id,Nombre, Apellido, Tipo_doc, Numero_doc "+
                           "FROM kernel_panic.Profesionales "+
                           "WHERE Usuario_id = @nombreUser ";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.id = (int)speaker.reader["Id"];
                this.nombre = (string)speaker.reader["Nombre"];
                this.apellido = (string)speaker.reader["Apellido"];
                this.tipoDoc = (string)speaker.reader["Tipo_doc"];
                this.documento = (decimal)speaker.reader["Numero_doc"];
                this.cargarEspecialidades();
            }
            speaker.close();

        }
        public void cargarProfesional()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", this.id));
            string query = "SELECT Nombre, Apellido, Tipo_doc, Numero_doc "+
                           "FROM kernel_panic.Profesionales "+
                           "WHERE Id = @id ";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                    speaker.reader.Read();
                    this.nombre = (string)speaker.reader["Nombre"];
                    this.apellido = (string)speaker.reader["Apellido"];
                    this.tipoDoc = (string)speaker.reader["Tipo_doc"];
                    this.documento = (decimal)speaker.reader["Numero_doc"];
                    this.cargarEspecialidades();
            }
            speaker.close();
        }
        public static List<Profesional> buscar(string nombre, string apellido, string especialidad ,string tipoDoc, string doc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
            ListaParametros.Add(new SqlParameter("@apellido", "%" + apellido + "%"));

            SpeakerDB speaker;

            if (doc.Equals("")) /*no quiere buscar por documento*/
            {
                string query = "SELECT Id, Nombre, Apellido, Tipo_doc, Numero_doc  "+
                               "FROM kernel_panic.Profesionales "+
                               "WHERE Nombre LIKE @nombre "+
                               "AND  Apellido LIKE @apellido ";
                speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            }
            else /*busca por documento*/
            {
                ListaParametros.Add(new SqlParameter("@tipoDoc", tipoDoc));
                ListaParametros.Add(new SqlParameter("@doc", Decimal.Parse(doc)));
                string query = "SELECT Id, Nombre, Apellido, Tipo_doc, Numero_doc  "+
                               "FROM kernel_panic.Profesionales "+
                               "WHERE Nombre LIKE @nombre "+
                               "AND  Apellido LIKE @apellido "+
                               "AND Tipo_doc = @tipoDoc "+
                               "AND Numero_doc = @doc ";
                speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            }
            List<Profesional> profesionales = new List<Profesional>();
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Profesional profesional = new Profesional();
                    profesional.id = (int)speaker.reader["Id"];
                    profesional.nombre = (string)speaker.reader["Nombre"];
                    profesional.apellido = (string)speaker.reader["Apellido"];
                    profesional.tipoDoc = (string)speaker.reader["Tipo_doc"];
                    profesional.documento = (decimal)speaker.reader["Numero_doc"];
                    profesional.cargarEspecialidades();
                    profesionales.Add(profesional);
                }
            }
            speaker.close();
            if (especialidad.Equals(""))
            {
                return profesionales;
            }
            else
            {
                return filtrarProfesionales(profesionales, especialidad);
            }
        }

        public static List<Profesional> filtrarProfesionales(List<Profesional> profesionales, string especialidad)
        {
            List<Profesional> listafiltrada = new List<Profesional>();
            foreach (Profesional prof in profesionales)
            {
                List<Especialidad> especialidades = prof.especialidades;
                foreach (Especialidad espe in especialidades)
                {
                    if (espe.descripcion.Equals(especialidad))
                    {
                        listafiltrada.Add(prof);
                    }
                }

            }
            return listafiltrada;
        }

        private void cargarEspecialidades()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@profesional_id", this.id));
            string query = "SELECT Especialidad_codigo "+
                           "FROM kernel_panic.Especialidad_Profesional "+
                           "WHERE Profesional_id = @profesional_id ";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    this.especialidades.Add(new Especialidad((decimal)speaker.reader["Especialidad_codigo"]));
                }
            }
            speaker.close();
        }

        public int cancelarDia(DateTime dia, string detalle, string tipo)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@dia", dia.Date));
            ListaParametros.Add(new SqlParameter("@profesional", this.id));
            ListaParametros.Add(new SqlParameter("@detalle", detalle));
            ListaParametros.Add(new SqlParameter("@tipo", tipo));
            SqlParameter parametroSalida = new SqlParameter("@fallo", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.cancelarDiaProfesional", "SP", ListaParametros);
            int resultado = Int32.Parse(speaker.comando.Parameters["@fallo"].Value.ToString());
            speaker.close();
            return resultado;
        }

        public int cancelarFranja(DateTime desde, DateTime hasta, string detalle, string tipo)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@desde", desde.Date));
            ListaParametros.Add(new SqlParameter("@hasta", hasta.Date));
            ListaParametros.Add(new SqlParameter("@profesional", this.id));
            ListaParametros.Add(new SqlParameter("@detalle", detalle));
            ListaParametros.Add(new SqlParameter("@tipo", tipo));
            SqlParameter parametroSalida = new SqlParameter("@fallo", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.cancelarFranjaProfesional", "SP", ListaParametros);
            int resultado = Int32.Parse(speaker.comando.Parameters["@fallo"].Value.ToString());
            speaker.close();
            return resultado;
        }

        public List<FranjaCancelada> darFranjasCanceladas()
        {
            List<FranjaCancelada> franjas = new List<FranjaCancelada>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@id", this.id));
            string query = "SELECT c.Desde AS fechaDesde, c.Hasta AS fechaHasta " +
                           "FROM kernel_panic.Franjas_Canceladas c " +
                           "JOIN kernel_panic.Esquema_Trabajo et ON(c.EsquemaTrabajo = et.Id) " +
                           "WHERE et.Profesional = @id ";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    DateTime fechaDesde = (DateTime)speaker.reader["fechaDesde"];
                    DateTime fechaHasta = (DateTime)speaker.reader["fechaHasta"];
                    FranjaCancelada franja = new FranjaCancelada(fechaDesde, fechaHasta);
                    franjas.Add(franja);
                }
            }
            speaker.close();
            return franjas;
        }
    }
}

