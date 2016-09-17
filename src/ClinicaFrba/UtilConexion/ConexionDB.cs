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
    class ConexionDB
    {
        public static SqlConnection ObtenerConexion(){
            string datosConexion = "Data Source=localhost\\SQLSERVER2012;" +"Initial Catalog=GD2C2016;User Id=gd; Password=gd2016";
            SqlConnection Conn = new SqlConnection(datosConexion);
            Conn.Open();
            return Conn;                   
        }

        public static SqlDataReader ObtenerDataReader(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            comando.CommandText = commandtext;
            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }
            switch (commandtype)
            {
                case "T":
                    comando.CommandType = CommandType.Text;
                    break;
                case "TD":
                    comando.CommandType = CommandType.TableDirect;
                    break;
                case "SP":
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }
            SqlDataReader reader = comando.ExecuteReader();
            return reader;
        }

        public static SqlCommand ExecuteNoQuery(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = ObtenerConexion();
            comando.CommandText = commandtext;
            foreach (SqlParameter elemento in ListaParametro)
            {
                comando.Parameters.Add(elemento);
            }
            switch (commandtype)
            {
                case "T":
                    comando.CommandType = CommandType.Text;
                    break;
                case "TD":
                    comando.CommandType = CommandType.TableDirect;
                    break;
                case "SP":
                    comando.CommandType = CommandType.StoredProcedure;
                    break;
            }
            comando.ExecuteNonQuery();
            return comando;
        }

    }
}
