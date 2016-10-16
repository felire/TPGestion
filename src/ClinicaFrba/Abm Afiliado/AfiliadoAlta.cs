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

namespace ClinicaFrba.Abm_Afiliado
{
    partial class AfiliadoAlta : Form
    {

        public Afiliado afiliado { get; set; }
        public AfiliadoAlta()
        {
            InitializeComponent();
            this.afiliado = new Afiliado();
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

            comboBoxPlan.DataSource = Plan.darTodosLosPlanes();
            comboBoxPlan.DisplayMember = "descripcion";
            comboBoxPlan.ValueMember = "codigo";
        }


        private void textBoxIDdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTel_Click(object sender, EventArgs e)
        {

        }

        private Boolean formularioValido()
        {
            uint i;
            string mensajeError = "";

            if (textBoxNom.Text == "")
            {
                mensajeError = "Complete el campo Nombre";
            }
            if (textBoxAp.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Apellido";
            }
            if (!uint.TryParse(textBoxIDdni.Text, out i))
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un dni válido";
            }
            if (comboBoxTdoc.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Seleccione el tipo de Dni";
            }
            if (textBoxIDdni.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete la fecha de nacimiento";
            }
            if (comboBoxCasado.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el estado civil";
            }
            if (comboBoxPlan.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Seleccione el plan médico";
            }
            if (textBoxHijos.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete la cantidad de Hijos";
            }
            if (textBoxMail.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Mail";
            }
            if (!uint.TryParse(textBoxTel.Text, out i))
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un Telefono válido";
            }
            if (textBoxDire.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el domicilio";
            }

            if (mensajeError.Equals(""))
            {
                afiliado.apellido = textBoxAp.Text;
                afiliado.nombre = textBoxNom.Text;
                afiliado.documento = Decimal.Parse(textBoxIDdni.Text);
                afiliado.tipoDoc = comboBoxTdoc.Text;
                afiliado.estadoCivil = comboBoxCasado.Text;
                afiliado.fechaNac = fechaNac.Value;
                afiliado.plan = ((Plan)comboBoxPlan.SelectedItem).codigo;
                afiliado.familiaresACargo = int.Parse(textBoxHijos.Text);
                if (textBoxHijos.Text.Equals(""))
                {
                    afiliado.familiaresACargo = 0;
                }
                afiliado.mail = textBoxMail.Text;
                afiliado.telefono = Decimal.Parse(textBoxTel.Text);
                afiliado.domicilio = textBoxDire.Text;
                afiliado.sexo = comboBoxSexo.Text;
                return true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Información");
                return false;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {   
                afiliado.registrarAltaPrincipal();
                if (afiliado.id < 0)
                {
                    MessageBox.Show("Afiliado existente", "Exito", MessageBoxButtons.OK);
                    this.Hide();
                    return;
                }
                MessageBox.Show("Afiliado registrado/a con exito", "Exito", MessageBoxButtons.OK);
                if (afiliado.estadoCivil.Equals("Casado/a") || afiliado.estadoCivil.Equals("Concubinato"))
                {
                    DialogResult resultado = MessageBox.Show("Desea registrar a su pareja?", "Confirme", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        AfiliadoAltaConyuge afiliadoAltaC = new AfiliadoAltaConyuge(this);
                        this.Hide();
                        afiliadoAltaC.Show();
                    }
                    else
                    {
                        preguntarHijos();
                    }
                }
                else
                {
                    preguntarHijos();
                }
                
            }
        }

        public void preguntarHijos()
        {
            DialogResult resultado = MessageBox.Show("Desea registrar a su/s "+afiliado.familiaresACargo+" hijo/s?", "Confirme", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                AfiliadoAltaHijos afiliadoAltaC = new AfiliadoAltaHijos(1, afiliado);
                this.Hide();
                afiliadoAltaC.Show();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
