using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace ClinicaFrba.UtilConexion
{
    class Especialidad
    {
        public decimal codigo { get; set; }
        public string descripcion { get; set; }
        public TipoEspecialidad tipo { get; set; }

        public Especialidad(decimal codigo)
        {
            this.codigo = codigo;
            cargarEspecialidad();
        }

        public Especialidad() {}

        public void cargarEspecialidad()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@codigo", this.codigo));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Descripcion, Tipo FROM kernel_panic.Especialidades WHERE Codigo = @codigo", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.descripcion = (string)speaker.reader["Descripcion"];
                this.tipo = new TipoEspecialidad((decimal)speaker.reader["Tipo"]);
            }
            speaker.close();
        }

        public static List<Especialidad> darTodasEspecialidades()
        {
             List<Especialidad> especialidades = new List<Especialidad>();
             SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Codigo, Descripcion, Tipo FROM kernel_panic.Especialidades", "T", new List<SqlParameter>());
             if (speaker.reader.HasRows)
             {
                 while (speaker.reader.Read())
                {
                    Especialidad especialidad = new Especialidad();
                    especialidad.codigo = (decimal)speaker.reader["Codigo"];
                    especialidad.descripcion = (string)speaker.reader["Descripcion"];
                    especialidad.tipo = new TipoEspecialidad((decimal)speaker.reader["Tipo"]);
                    especialidades.Add(especialidad);
                }
             }
             speaker.close();
            return especialidades;
        }
    }
}
