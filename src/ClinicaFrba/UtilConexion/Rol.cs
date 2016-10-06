using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ClinicaFrba.UtilConexion
{
    class Rol
    {
        public int rol_id;
        public string nombreRol;
        public Boolean activo;
        public List<Funcionalidad> funcionalidades;

        public Rol() {}

        public Rol(int id)
        {
            this.rol_id = id;
            this.funcionalidades = new List<Funcionalidad>();
            this.obtenerFuncionalidades();
        }

        public List<Funcionalidad> getFuncionalidades()
        {
            return funcionalidades;
        }

        public void obtenerFuncionalidades()
        {
            List<int> idsFunc = new List<int>();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            string query = "SELECT Funcion_id "+
                           "FROM kernel_panic.Funciones_Roles "+
                           "WHERE Rol_id = @rol_id";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);

            if (speaker.reader.HasRows)
            {
                while (speaker.reader.Read())
                {
                    idsFunc.Add((int)speaker.reader["Funcion_id"]);
                }
            }
            speaker.close();
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            query = "SELECT Nombre "+
                    "FROM kernel_panic.Roles "+
                    "WHERE Id = @rol_id";
            speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.nombreRol = (string)speaker.reader["Nombre"];
            }

            foreach (int fun_id in idsFunc)
            {
                this.funcionalidades.Add(new Funcionalidad(fun_id));
            }
            speaker.close();
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
                string query = "INSERT INTO kernel_panic.Funciones_Roles "+
                               "(Rol_id, Funcion_id) "+
                               "VALUES (@rol_id, @funcionalidad_id)";
                speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
                speaker.close();
            }
            return true;
        }

        public static List<Rol> obtenerTodosLosRoles()
        {
            List<Rol> roles = new List<Rol>();
            string query = "SELECT Id,Esta_activo "+
                           "FROM kernel_panic.Roles";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", new List<SqlParameter>());
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
            string query = "UPDATE kernel_panic.Roles "+
                           "SET Esta_activo = 1 "+
                           "WHERE Id = @rol_id";
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
        }

        public void actualizarFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            this.funcionalidades.Clear();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@idRol", this.rol_id));
            string query = "DELETE FROM kernel_panic.Funciones_Roles "+
                           "WHERE Rol_id = @idRol";
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                ListaParametros.Clear();
                ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
                ListaParametros.Add(new SqlParameter("@funcionalidad_id", funcionalidad.funcionalidad_id));
                query = "INSERT INTO kernel_panic.Funciones_Roles "+
                        "(Rol_id, Funcion_id) "+
                        "VALUES (@rol_id, @funcionalidad_id)";
                speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
                speaker.close();
                this.funcionalidades.Add(funcionalidad);
            }
        }

        public void deshabilitar()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            string query = "DELETE FROM kernel_panic.Roles_Usuario "+
                           "WHERE Rol_id = @rol_id";
            SpeakerDB speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@rol_id", this.rol_id));
            query = "UPDATE kernel_panic.Roles "+
                    "SET Esta_activo = 0 "+
                    "WHERE Id = @rol_id";
            speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
        }
    }
}
