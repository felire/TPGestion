using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.UtilConexion
{
    class Prueba
    {
        public static int Agregar(String nombre)
        {
            SqlConnection Conn = ConexionDB.ObtenerConexion();
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Prueba (Id, nombre) VALUES (2, '{0}')", nombre), Conn);// el orden de los {0}, {1} y asi, matchea con los nombres que le paso al costado
            return comando.ExecuteNonQuery();
        }

    }
}
