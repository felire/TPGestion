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

namespace ClinicaFrba.Registro_Llegada
{
    partial class RegLlegada : Form
    {

        public RegLlegada()
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
           listaAfiliados.DataSource = Afiliado.buscar(nombre.Text, apellido.Text, grupo.Text, (string)tipoDoc.SelectedItem, numeroDoc.Text);
           listaAfiliados.ClearSelection();
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

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void seleccinar_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                Afiliado afiliado = (Afiliado)listaAfiliados.CurrentRow.DataBoundItem;
                int bonoAUsar = afiliado.bonoAUsar();
                if (bonoAUsar > 0)
                {
                    ElegirProfesional elegirProfesinal = new ElegirProfesional(afiliado, bonoAUsar);
                    this.Hide();
                    elegirProfesinal.Show();
                }
                else
                {
                    MessageBox.Show("No tiene bonos disponibles", "Error!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
