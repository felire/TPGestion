using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ClinicaFrba.UtilConexion
{
    class ConexionDB
    {
        public static SqlConnection ObtenerConexion(){
            string datosConexion = "Data Source=localhost\\SQLSERVER2012;" +"Initial Catalog=GD2C2016;User Id=gd; Password=gd2016";
            SqlConnection Conn = new SqlConnection(datosConexion);
            Conn.Open();
            return Conn;                   
        }
    }
}
