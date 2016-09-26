using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AfiliadoAlta : Form
    {
        public AfiliadoAlta()
        {
            InitializeComponent();
            cargarComboBoxs();
        }
        private void cargarComboBoxs()
        {
            comboBoxCasado.Items.Add("Soltero/a");
            comboBoxCasado.Items.Add("Casado/a");
            comboBoxCasado.Items.Add("Viudo/a");
            comboBoxCasado.Items.Add("Concubinato");
            comboBoxCasado.Items.Add("Divorciado/a");
            comboBoxCasado.SelectedIndex = 0;

            comboBoxSexo.Items.Add("M");
            comboBoxSexo.Items.Add("F");
            comboBoxSexo.SelectedIndex = 0;

            comboBoxTdoc.Items.Add("");
            comboBoxTdoc.Items.Add("DNI");
            comboBoxTdoc.Items.Add("LD");
            comboBoxTdoc.Items.Add("LC");
            comboBoxTdoc.Items.Add("CI");
            comboBoxTdoc.SelectedIndex = 0;

            //hacer select Codigo from GD2C2016.kernel_panic.Planes group by Codigo
            comboBoxPlan.Items.Add("");
        }


        private void textBoxIDdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTel_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            int flag;
            uint i;
           if (textBoxNom.Text == "") { MessageBox.Show("Complete el campo Nombre", "Información"); flag = 1; }
            if (textBoxAp.Text == "") { MessageBox.Show("Complete el campo Apellido", "Información"); flag = 1; }
            if (textBoxIDdni.Text == "") { MessageBox.Show("Complete el campo Dni", "Información"); flag = 1; }
			else { if (!uint.TryParse(textBoxIDdni.Text, out i)) { MessageBox.Show("Ingrese un dni válido", "Información"); return; }}
			if (comboBoxTdoc.Text == "") { MessageBox.Show("Seleccione el tipo de Dni", "Información"); flag = 1; }
			if (comboBoxSexo.Text == "") { MessageBox.Show("Complete el sexo", "Información"); flag = 1; }
			if (textBoxIDdni.Text == "") { MessageBox.Show("Complete la fecha de nacimiento", "Información"); flag = 1; }
			if (comboBoxCasado.Text == "") { MessageBox.Show("Complete el estado civil", "Información"); flag = 1; }
			if (comboBoxPlan.Text == "") { MessageBox.Show("Seleccione el plan médico", "Información"); flag = 1; }
            if (textBoxHijos.Text == "") { MessageBox.Show("Complete la cantidad de Hijos", "Información"); flag = 1; }
            else { if (!uint.TryParse(textBoxIDdni.Text, out i)) { MessageBox.Show("Ingrese un dni válido", "Información"); return; } }
            if (textBoxMail.Text == "") { MessageBox.Show("Complete el campo Mail", "Información"); flag = 1; }
            if (textBoxTel.Text == "") { MessageBox.Show("Complete el campo Telefono", "Información"); flag = 1; }
            else { if (!uint.TryParse(textBoxTel.Text, out i)) { MessageBox.Show("Ingrese un Telefono válido", "Información"); return; } }
            if (textBoxDire.Text == "") { MessageBox.Show("Complete el domicilio", "Información"); flag = 1; }
            }
    }
}
