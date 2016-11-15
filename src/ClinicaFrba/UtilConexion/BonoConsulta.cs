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
    class BonoConsulta
    {
        public decimal precioUnitario { get; set; }
        public int cantidad { get; set; }
        public decimal plan { get; set; }
        public Afiliado afiliado { get; set; }

        public BonoConsulta(Afiliado afiliado)
        {
            this.afiliado = afiliado;
            this.cargarPrecioYPlan();
        }

        private void cargarPrecioYPlan()
        {
            string grupo = afiliado.numeroDeGrupo.ToString();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@grupo", Decimal.Parse(grupo)));
            string query = "SELECT Precio_bono_consulta, Plan_grupo " +
                           "FROM kernel_panic.Planes p "+
                           "JOIN kernel_panic.Grupos_Familiares gf ON (p.Codigo = gf.Plan_grupo) "+
                           "WHERE gf.Id = @grupo";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                this.precioUnitario = (decimal)speaker.reader["Precio_bono_consulta"];
                this.plan = (decimal)speaker.reader["Plan_grupo"];
            }
            speaker.close();
        }
        
        public void comprar()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            SpeakerDB speaker;
            string query;
            for (int i = 0; i < cantidad; i++)
            {
                ListaParametros.Clear();
                ListaParametros.Add(new SqlParameter("@grupo", afiliado.numeroDeGrupo));
                ListaParametros.Add(new SqlParameter("@plan", plan));
                ListaParametros.Add(new SqlParameter("@hoy", DateTime.Parse(ArchivoDeConfiguracion.Default.Fecha).Date));
                query = "INSERT INTO kernel_panic.Bonos_Consultas (Nro_consulta, Grupo, Plan_asociado, Afiliado, Fecha_de_compra, Fecha_de_uso, Turno) " +
                        "VALUES (NULL, @grupo, @plan, NULL, @hoy, NULL, NULL)";
                speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
                speaker.close();
            }
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@cantidad", cantidad));
            ListaParametros.Add(new SqlParameter("@precioTotal", (int)precioUnitario*cantidad ));
            ListaParametros.Add(new SqlParameter("@hoy", DateTime.Parse(ArchivoDeConfiguracion.Default.Fecha).Date));
            ListaParametros.Add(new SqlParameter("@afiliadoId", afiliado.id));
            query = "INSERT INTO kernel_panic.Transacciones (Cantidad, Precio, Fecha, Afiliado) " +
                    "VALUES (@cantidad, @precioTotal, @hoy, @afiliadoId)";
            speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
        }
    }
}
