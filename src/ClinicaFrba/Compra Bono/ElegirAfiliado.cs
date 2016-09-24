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

namespace ClinicaFrba.Compra_Bono
{
    partial class ElegirAfiliado : Form
    {
        public List<Afiliado> afiliadosActuales { get; set; }

        public ElegirAfiliado()
        {
            InitializeComponent();

            cargarFormulario();
        }

        private void cargarFormulario()
        {
            tipoDoc.Items.Add("");
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LD");
            tipoDoc.Items.Add("LC");
            tipoDoc.Items.Add("CI");
            tipoDoc.SelectedIndex = 0;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
           afiliadosActuales = Afiliado.buscar(nombre.Text, apellido.Text, grupo.Text, (string)tipoDoc.SelectedItem, numeroDoc.Text);
           listaAfiliados.DataSource = afiliadosActuales;
           listaAfiliados.ClearSelection();
        }

        private void elegir_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                Afiliado afiliado = (Afiliado)listaAfiliados.CurrentRow.DataBoundItem;
                if (afiliado.esta_activo)
                {
                    CompraBono compraForm = new CompraBono(afiliado);
                    compraForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El afiliado debe estar activo", "Error!", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean seleccionValida()
        {
            if (listaAfiliados.SelectedRows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un afiliado", "Error!", MessageBoxButtons.OK);
                return false;
            }

        }
    }
}
