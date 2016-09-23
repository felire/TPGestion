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
        public Boolean activo { get; set; }
        public List<Funcionalidad> funcionalidades;

        public List<Funcionalidad> getFuncionalidades()
        {
            return funcionalidades;
        }


        public Rol() { }
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
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Funcion_id FROM kernel_panic.Funciones_Roles WHERE Rol_id = @rol_id", "T", ListaParametros);

            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    idsFunc.Add((int)speaker.reader["Funcion_id"]);
                }
            }
            speaker.reader.Close();
            speaker.conection.Close();
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            speaker = ConexionDB.ObtenerDataReader("SELECT Nombre FROM kernel_panic.Roles WHERE Id = @rol_id", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.nombreRol = (string)speaker.reader["Nombre"];
            }

            foreach (int fun_id in idsFunc)
            {
                this.funcionalidades.Add(new Funcionalidad(fun_id));
            }
            speaker.reader.Close();
            speaker.conection.Close();
        }
        public Boolean darAlta()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@nombreRol", this.nombreRol));
            SqlParameter parametroSalida = new SqlParameter("@id_rol", 0);
            parametroSalida.Direction = ParameterDirection.Output;
            ListaParametros.Add(parametroSalida);
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("kernel_panic.agregarRol", "SP", ListaParametros);
            int resultado = Int32.Parse(speaker.comando.Parameters["@id_rol"].Value.ToString());
            if(resultado == -1)
            {
                return false;
            }

            this.rol_id = resultado;
            speaker.close();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                ListaParametros.Clear();
                ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
                ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad.funcionalidad_id));
                speaker = ConexionDB.ExecuteNoQuery("INSERT INTO kernel_panic.Funciones_Roles (Rol_id, Funcion_id) VALUES (@rol_id, @funcionalidad_id)", "T", ListaParametros);
                speaker.close();
            }            
            return true;
        }


        public static List<Rol> obtenerTodosLosRoles()
        {
            List<Rol> roles = new List<Rol>();
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Id,Esta_activo FROM kernel_panic.Roles", "T", new List<SqlParameter>());
            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    Rol rol = new Rol((int)speaker.reader["Id"]);
                    rol.activo = (Boolean)speaker.reader["Esta_activo"];
                    roles.Add(rol);
                }
            }
            speaker.close();

            return roles;
        }

        public void habilitarRol()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("UPDATE kernel_panic.Roles SET Esta_activo = 1 WHERE Id = @rol_id", "T", ListaParametros);
            speaker.close();
        }

        public void actualizarFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            this.funcionalidades.Clear();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idRol", this.rol_id));
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery("DELETE FROM kernel_panic.Funciones_Roles WHERE Rol_id = @idRol", "T", ListaParametros);
            speaker.close();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                ListaParametros.Clear();
                ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
                ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad.funcionalidad_id));
                speaker = ConexionDB.ExecuteNoQuery("INSERT INTO kernel_panic.Funciones_Roles (Rol_id, Funcion_id) VALUES (@rol_id, @funcionalidad_id)", "T", ListaParametros);
                speaker.close();
                this.funcionalidades.Add(funcionalidad);
            }
        }
    }
}
