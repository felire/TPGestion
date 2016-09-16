using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace ClinicaFrba.UtilConexion
{
    class Usuario
    {
        public string Name { get; set; }

        public Usuario(string user, string pass, Logeo formu)
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombreUsuario", user));
            ListaParametros.Add(new SqlParameter("@pass", pass));
            SqlParameter parametroSalida = new SqlParameter("@fallo",0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SqlCommand comando =  ConexionDB.ExecuteNoQuery("kernel_panic.chequearUsuario", "SP", ListaParametros);
            int resultado = Int32.Parse(comando.Parameters["@fallo"].Value.ToString());
                Name = user;
                if (resultado == -1)
                {
                    formu.noHabilitado();
                }
                if (resultado == 0)
                {
                    formu.noUsuario();
                }
                if (resultado == 1)
                {
                    formu.logeoExitoso();
                }
                if (resultado == 2)
                {
                    formu.noContrasena();
                }

        }
    }
}
