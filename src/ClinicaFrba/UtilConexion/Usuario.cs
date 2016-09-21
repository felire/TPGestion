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
        public string usuario { get; set; }
        public List<Rol> roles;

        public List<Rol> getRoles(){
            return roles;
        }
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
                usuario = user;
                if (resultado == -1)
                {
                    formu.noHabilitado();
                }
                if (resultado == 1)
                {
                    this.ObtenerRoles();
                    if (roles.Count == 0)
                    {
                        formu.sinRoles();
                    }
                    else
                    {
                        formu.logeoExitoso(this);
                    }                   
                }
                if (resultado == 2)
                {
                    formu.noContrasena();
                }

        }

        public void ObtenerRoles()
        {
            List<int> Lista = new List<int>();
            this.roles = new List<Rol>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombre", this.usuario));
            SqlDataReader lector = ConexionDB.ObtenerDataReader("SELECT Rol_id FROM kernel_panic.Roles_Usuario WHERE Usuario_id = @nombre", "T", ListaParametros);

            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    Lista.Add((int) lector["Rol_id"]);
                }
            }

            foreach (int rol_id in Lista)
            {
                this.roles.Add(new Rol(rol_id));
            }
        }


        public Boolean masDeUnRol()
        {
            return roles.Count > 1;
        }

    }
}
