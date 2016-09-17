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
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Rol
    {
        public int rol_id { get; set;}
        public string nombreRol { get; set; }
        public List<Funcionalidad> funcionalidades;

        public List<Funcionalidad> getFuncionalidades()
        {
            return funcionalidades;
        }
        public Rol(int id)
        {
            this.rol_id = id;
            this.funcionalidades = new List<Funcionalidad>();
            this.obtenerFuncionalidades();
        }

        public void obtenerFuncionalidades()
        {
            List<int> idsFunc = new List<int>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            SqlDataReader lector = ConexionDB.ObtenerDataReader("SELECT Funcion_id FROM kernel_panic.Funciones_Roles WHERE Rol_id = @rol_id", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    idsFunc.Add((int)lector["Funcion_id"]);
                }
            }
            List<SqlParameter> ListaParametros2 = new List<SqlParameter>();
            ListaParametros2.Add(new SqlParameter("@rol_id", this.rol_id));
            lector = ConexionDB.ObtenerDataReader("SELECT Nombre FROM kernel_panic.Roles WHERE Id = @rol_id", "T", ListaParametros2);
            if (lector.HasRows)
            {
                    lector.Read();
                    this.nombreRol = (string)lector["Nombre"];
            }

            foreach (int fun_id in idsFunc)
            {
                this.funcionalidades.Add(new Funcionalidad(fun_id));
            }
        }
    }
}
