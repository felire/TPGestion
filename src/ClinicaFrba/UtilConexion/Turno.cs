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
    class Turno
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public Especialidad especialidad { get; set; }
        public Profesional profesional { get; set; }
        public Afiliado afiliado { get; set; }

        public static List<Turno> darTodosLosTurnosDe(Afiliado afiliado)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@afiliadoId", afiliado.id));
            List<Turno> turnos = new List<Turno>();
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Id, Fecha, Especialidad, Profesional_id FROM kernel_panic.Turnos WHERE Afiliado_id = @afiliadoId", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Turno turno = new Turno();
                    turno.id = (int)speaker.reader["Id"];
                    turno.fecha = (DateTime)speaker.reader["Fecha"];
                    turno.especialidad = new Especialidad((decimal) speaker.reader["Especialidad"]);
                    turno.profesional = new Profesional((int)speaker.reader["Profesional_id"]);
                    turnos.Add(turno);
                }
            }
            speaker.close();
            return turnos;
        }

    }
}
