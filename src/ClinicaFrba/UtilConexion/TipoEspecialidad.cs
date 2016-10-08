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
    class TipoEspecialidad
    {
        public decimal codigo { get; set; }
        public string descripcion { get; set; }

        public TipoEspecialidad(decimal codigo)
        {
            this.codigo = codigo;
            cargarTipo();
        }

        private void cargarTipo()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@codigo", this.codigo));
            string query = "SELECT Descripcion "+
                           "FROM kernel_panic.Tipo_Especialidad "+
                           "WHERE Codigo = @codigo";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.descripcion = (string)speaker.reader["Descripcion"];
            }
            speaker.close();
        }
    }
}

