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
        public static SqlConnection ObtenerConexion()
        {
            string datosConexion = "Data Source=localhost\\SQLSERVER2012;" +"Initial Catalog=GD2C2016;User Id=gd; Password=gd2016";
            SqlConnection Conn = new SqlConnection(datosConexion);
            Conn.Open();
            return Conn;                   
        }

        public static SpeakerDB ObtenerDataReader(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = ObtenerConexion();
            comando.Connection = conexion;
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
            SpeakerDB speaker = new SpeakerDB();
            speaker.conection = conexion;
            speaker.reader = comando.ExecuteReader();
            return speaker;
        }

        public static SpeakerDB ExecuteNoQuery(string commandtext, string commandtype, List<SqlParameter> ListaParametro)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = ObtenerConexion();
            comando.Connection = conexion;
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
            SpeakerDB speaker = new SpeakerDB();
            speaker.conection = conexion;
            speaker.reader = null;
            speaker.comando = comando;
            comando.ExecuteNonQuery();
            return speaker;
        }
    }
}

