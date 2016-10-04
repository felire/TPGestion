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
                ListaParametros.Add(new SqlParameter("@hoy", DateTime.Now));
                query = "INSERT INTO kernel_panic.Bonos_Consultas (Nro_consulta, Grupo_afiliado, Plan_Uso, Afiliado_Uso, Fecha_Bono_compra, Fecha_Impresion, Turno) "+
                        "VALUES (NULL, @grupo, @plan, NULL, @hoy, @hoy, NULL)";
                speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
                speaker.close();
            }
            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@cantidad", cantidad));
            ListaParametros.Add(new SqlParameter("@precioUnitario", (int)precioUnitario));
            ListaParametros.Add(new SqlParameter("@hoy", DateTime.Now));
            ListaParametros.Add(new SqlParameter("@afiliadoId", afiliado.id));
            query = "INSERT INTO kernel_panic.Transacciones (Cantidad, Precio, Fecha, Afiliado) " +
                    "VALUES (@cantidad, @precioUnitario, @hoy, @afiliadoId)";
            speaker = ConexionDB.ExecuteNoQuery(query, "T", ListaParametros);
            speaker.close();
            MessageBox.Show("Compra realizada con exito", "", MessageBoxButtons.OK);
        }
    }
}
