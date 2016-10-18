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
    partial class ModificaDatos : Form
    {
        public Afiliado afiliado { get; set; }
        
        public ModificaDatos(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            cargarDatos();
        }

        public void cargarDatos()
        {
            estadoCivil.Items.Add("Soltero/a");
            estadoCivil.Items.Add("Casado/a");
            estadoCivil.Items.Add("Viudo/a");
            estadoCivil.Items.Add("Concubinato");
            estadoCivil.Items.Add("Divorciado/a");
            estadoCivil.SelectedIndex = 0;

            plan.DataSource = Plan.darTodosLosPlanes();
            plan.DisplayMember = "descripcion";
            plan.ValueMember = "codigo";

            altaFamiliar.Visible = (afiliado.numeroEnElGrupo == 1);

            id.Text = afiliado.id.ToString();
            nroDoc.Text = afiliado.documento.ToString();
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            direccion.Text = afiliado.domicilio;
            telefono.Text = afiliado.telefono.ToString();
            mail.Text = afiliado.mail;
            plan.Text = afiliado.plan.ToString();
            tipo.Text = afiliado.tipoDoc;

            comboBoxSexo.Items.Add("M");
            comboBoxSexo.Items.Add("F");
            comboBoxSexo.SelectedIndex = 0;

            if (afiliado.numeroEnElGrupo == 1)
            {
                label7.Visible = true;
                label2.Visible = true;
                plan.Visible = true;
                planAnt.Visible = true;
                planAnt.Text = afiliado.planObjeto.descripcion;
            }
            else
            {
                label7.Visible = false;
                label2.Visible = false;
                plan.Visible = false;
                planAnt.Visible = false;
            }
            if (afiliado.estadoCivil == null)
            {
                civilAnt.Text = "INEXISTENTE";
            }
            else
            {
                civilAnt.Text = afiliado.estadoCivil;
            }
            if (afiliado.sexo == null)
            {
                label9.Visible = true;
                comboBoxSexo.Visible = true;
            }
            else
            {
                label9.Visible = false;
                comboBoxSexo.Visible = false;
            }
        }
     
        private void conyuge_Click(object sender, EventArgs e)
        {
            if (civilAnt.Text.Equals("Casado/a") || civilAnt.Text.Equals("Concubinato"))
            {
                MessageBox.Show("Actualmente esta en pareja, no puede dar de alta a otro", "Error");
            }
            else
            {
                if (afiliado.estuvoCasado())
                {
                    MessageBox.Show("Usted ya estuvo casado, para dar de alta a su nuevo conyuge en el mismo grupo familiar debe darse de baja y luego de alta nuevamente", "Error");
                }
                else
                {
                    //Pantalla conyuge
                }
            }
        }

        private void hijo_Click(object sender, EventArgs e)
        {
            AfiliadoAltaHijos afiHijos = new AfiliadoAltaHijos(afiliado.familiaresACargo + 1, afiliado);
            afiHijos.Show();
        }

        private Boolean formularioValido()
        {
            string mensajeError = "";
            if (mail.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el campo Mail";
            }
            if (telefono.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un Telefono";
            }
            if (direccion.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Complete el domicilio";
            }
            if (motivo.Text == "")
            {
                mensajeError = mensajeError + "\r\n" + "Ingrese un motivo";
            }
            if (mensajeError.Equals(""))
            {
                afiliado.mail = mail.Text;
                afiliado.telefono = Decimal.Parse(telefono.Text);
                afiliado.domicilio = direccion.Text;
                afiliado.estadoCivil = estadoCivil.Text;

                if (afiliado.numeroEnElGrupo == 1)
                {
                    afiliado.plan = ((Plan)plan.SelectedItem).codigo;
                }
                else
                {
                    afiliado.plan = afiliado.planObjeto.codigo;
                }
                if (afiliado.sexo == null)
                {
                    afiliado.sexo = comboBoxSexo.Text;
                }
                return true;
            }
            else
            {
                MessageBox.Show(mensajeError, "Información");
                return false;
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                afiliado.modificar(motivo.Text);
                MessageBox.Show("Datos modificados con exito!", "Exito");
            }
        }

        private void soloNuemeros_tel(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
