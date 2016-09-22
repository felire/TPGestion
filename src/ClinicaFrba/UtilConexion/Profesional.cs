using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Profesional
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Especialidad> especialidades { get; set; }
        public string tipoDoc { get; set; }
        public decimal documento { get; set; }

        public Profesional(){
            especialidades = new List<Especialidad>();
        }
        public static List<Profesional> buscar(string nombre, string apellido, string especialidad ,string tipoDoc, string doc)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombre", "%" + nombre + "%"));
            ListaParametros.Add(new SqlParameter("@apellido", "%" + apellido + "%"));

            SpeakerDB speaker = null;

            if (doc.Equals(""))
            {
                speaker = ConexionDB.ObtenerDataReader("SELECT Id, Nombre, Apellido, Tipo_doc, Numero_doc  FROM kernel_panic.Profesionales WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido ", "T", ListaParametros);
            }
            else
            {
                ListaParametros.Add(new SqlParameter("@tipoDoc", tipoDoc));
                ListaParametros.Add(new SqlParameter("@doc", Decimal.Parse(doc)));
                speaker = ConexionDB.ObtenerDataReader("SELECT Id, Nombre, Apellido, Tipo_doc, Numero_doc  FROM kernel_panic.Profesionales WHERE Nombre LIKE @nombre AND  Apellido LIKE @apellido AND Tipo_doc = @tipoDoc AND Numero_doc = @doc ", "T", ListaParametros);
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
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Especialidad_codigo FROM kernel_panic.Especialidad_Profesional WHERE Profesional_id = @profesional_id ", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    this.especialidades.Add(new Especialidad((decimal)speaker.reader["Especialidad_codigo"]));
                }
            }
            speaker.close();
        }
    }
}

