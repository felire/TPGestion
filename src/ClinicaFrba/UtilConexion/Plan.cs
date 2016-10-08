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
    class Plan
    {
        public decimal codigo { get; set; }
        public string descripcion { get; set; }

        public static List<Plan> darTodosLosPlanes()
        {
            List<Plan> planes = new List<Plan>();
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Codigo, Descripcion FROM kernel_panic.Planes", "T", new List<SqlParameter>());
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Plan plan = new Plan();
                    plan.codigo = (decimal)speaker.reader["Codigo"];
                    plan.descripcion = (string)speaker.reader["Descripcion"];
                    planes.Add(plan);
                }
            }
            speaker.close();
            return planes;
        }
    }
}
