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
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            precio.Text = bono.precioUnitario.ToString();
            precioTotal.Text = bono.precioUnitario.ToString();
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
                this.Close();
            }
        }

        private void cambioCantidad(object sender, EventArgs e)
        {
            precioTotal.Text = (bono.precioUnitario * cantidadAComprar.Value).ToString();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
