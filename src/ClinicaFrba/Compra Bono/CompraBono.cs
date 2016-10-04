using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.UtilConexion;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClinicaFrba.Compra_Bono
{
    partial class CompraBono : Form
    {
        private BonoConsulta bono;
        private Afiliado afiliado;

        public CompraBono(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.bono = new BonoConsulta(afiliado);
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            
            string grupo = afiliado.numeroDeGrupo.ToString();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@grupo", Decimal.Parse(grupo)));
            string query = "SELECT Precio_bono_consulta, Plan_grupo "+
                           "FROM kernel_panic.Planes p "+
                           "JOIN kernel_panic.Grupos_Familiares gf ON (p.Codigo = gf.Plan_grupo) "+
                           "WHERE gf.Id = @grupo";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader(query, "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                bono.precioUnitario = (decimal)speaker.reader["Precio_bono_consulta"];
                bono.plan = (decimal)speaker.reader["Plan_grupo"];
                precio.Text = bono.precioUnitario.ToString();
            }
            speaker.close();
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            bono.cantidad = Int32.Parse(cantidadAComprar.Text);
            int total = bono.cantidad * (int)bono.precioUnitario;
            System.Windows.Forms.DialogResult resultado;
            if (bono.cantidad == 1)
            {
                resultado = MessageBox.Show("Esta seguro que desea comprar un bono a " + total + " pesos?", "Seguro?", MessageBoxButtons.YesNo);
            }
            else 
            {
               resultado =  MessageBox.Show("Esta seguro que desea comprar " + cantidadAComprar.Text + " bonos por un total de " + total + " pesos?", "Seguro?", MessageBoxButtons.YesNo);
            }
            if (resultado == DialogResult.Yes)
            {
                bono.comprar();
                this.Hide();
            }
        }
    }
}
