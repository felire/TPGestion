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
    class Funcionalidad
    {
        public int funcionalidad_id;
        public string descripcion;

        public Funcionalidad(int fun_id)
        {
            this.funcionalidad_id = fun_id;
            this.obtenerFuncionalidad();
        }

        public Funcionalidad() {}

        public void obtenerFuncionalidad()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@fun_id", this.funcionalidad_id));
            string query = "SELECT Nombre "+
                           "FROM kernel_panic.Funciones "+
                           "WHERE Id = @fun_id";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);

            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.descripcion = (string)speaker.reader["Nombre"];
            }
            speaker.close();
        }

        public static List<Funcionalidad> darTodasLasFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            string query = "SELECT Id,Nombre "+
                           "FROM kernel_panic.Funciones";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", new List<SqlParameter>());
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.funcionalidad_id = (int)speaker.reader["Id"];
                    funcionalidad.descripcion = (string)speaker.reader["Nombre"];
                    funcionalidades.Add(funcionalidad);
                }
            }
            speaker.close();
            return funcionalidades;
        }
    }
}

