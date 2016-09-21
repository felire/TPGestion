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


namespace ClinicaFrba.UtilConexion
{
    class Funcionalidad
    {
        public int funcionalidad_id {get;set;}
        public string descripcion { get; set; }

        public Funcionalidad(int fun_id){
            this.funcionalidad_id = fun_id;
            this.obtenerFuncionalidad();
        }

        public Funcionalidad() { }
        public void obtenerFuncionalidad()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@fun_id", this.funcionalidad_id));
            SqlDataReader lector = ConexionDB.ObtenerDataReader("SELECT Nombre FROM kernel_panic.Funciones WHERE Id = @fun_id", "T", ListaParametros);

            if (lector.HasRows)
            {
                lector.Read();
                this.descripcion = (string) lector["Nombre"];
            }
        }

        public static List<Funcionalidad> darTodasLasFuncionalidades()
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            SqlDataReader lector = ConexionDB.ObtenerDataReader("SELECT Id,Nombre FROM kernel_panic.Funciones", "T", new List<SqlParameter>());
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();
                    funcionalidad.funcionalidad_id = (int)lector["Id"];
                    funcionalidad.descripcion = (string)lector["Nombre"];
                    funcionalidades.Add(funcionalidad);
                }
            }

            return funcionalidades;

        }
    }

  
}
