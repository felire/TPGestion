using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Data.Sql;

namespace ClinicaFrba.UtilConexion
{
    class SpeakerDB
    {
        public SqlConnection conection { get; set; }
        public SqlDataReader reader { get; set; }
        public SqlCommand comando { get; set; }

        public void close()
        {
            if (reader == null)
            {
                conection.Close();
            }
            else
            {
                reader.Close();
                conection.Close();
            }
        }
    }
}
