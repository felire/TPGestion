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
    partial class AfiliadoAltaHijos : Form
    {
        public int numeroHijo { get; set; }
        public Afiliado afiliadoPadre { get; set; }
        public Afiliado afiliado { get; set; }

        public AfiliadoAltaHijos(int numeroHijo, Afiliado afiliadoPadre)
        {
            this.afiliado = new Afiliado();
            this.numeroHijo = numeroHijo;
            this.afiliadoPadre = afiliadoPadre;
            InitializeComponent();
            this.cargarDatos();
        }

        public void cargarDatos()
        {
            comboBoxSexo.Items.Add("M");
            comboBoxSexo.Items.Add("F");
            comboBoxSexo.SelectedIndex = 0;

            comboBoxCasado.Items.Add("Soltero/a");
            comboBoxCasado.Items.Add("Casado/a");
            comboBoxCasado.Items.Add("Viudo/a");
            comboBoxCasado.Items.Add("Concubinato");
            comboBoxCasado.Items.Add("Divorciado/a");
            comboBoxCasado.SelectedIndex = 0;

            comboBoxTDNI.Items.Add("");
            comboBoxTDNI.Items.Add("DNI");
            comboBoxTDNI.Items.Add("LD");
            comboBoxTDNI.Items.Add("LC");
            comboBoxTDNI.Items.Add("CI");
            comboBoxTDNI.SelectedIndex = 0;

        }

        private Boolean formularioValido()
        {
            string mensajeError = "";

            if (textBoxNom.Text == "")
            {
                mensajeError = "Complete el campo Nombre";
            }
            if (textBoxAp.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Apellido";
            }
            if (textBoxIDdni.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un dni válido";
            }
            if (comboBoxTDNI.Text == "")
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
            if (textBoxMail.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Mail";
            }
            if (textBoxTel.Text == "")
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
                afiliado.tipoDoc = comboBoxTDNI.Text;
                afiliado.estadoCivil = comboBoxCasado.Text;
                afiliado.fechaNac = fechaNac.Value;
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
                afiliado.registrarAltaHijo(numeroHijo, afiliadoPadre);
                if (afiliado.id < 0)
                {
                    MessageBox.Show("Ya existe un afiliado con este DNI", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Hijo/a registrado/a con exito", "Exito", MessageBoxButtons.OK);
                    if (numeroHijo < afiliadoPadre.familiaresACargo)
                    {
                        AfiliadoAltaHijos afiliadoAltaC = new AfiliadoAltaHijos(numeroHijo + 1, afiliado);
                        this.Close();
                        afiliadoAltaC.Show();
                    }
                    else
                    {
                        this.Close();
                    }
                    if (numeroHijo > afiliadoPadre.familiaresACargo)
                    {
                        afiliadoPadre.actualizarFamACargo();
                    }
                }
            }
        }

        private void soloNumeros_dni(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void soloNumeros_telefono(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
