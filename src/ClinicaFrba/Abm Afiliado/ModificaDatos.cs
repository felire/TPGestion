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
        //recibe objeto afiliado con esos datos busco y modifico con el store procedure
        public ModificaDatos(Afiliado afi)
        {
            InitializeComponent();
            this.afiliado = afi;
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

            if (afiliado.numeroEnElGrupo == 1)
            {
                altaFamiliar.Visible = true;
            }
            else
            {
                altaFamiliar.Visible = false;
            }

            id.Text = afiliado.id.ToString();
            nroDoc.Text = afiliado.documento.ToString();
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            direccion.Text = afiliado.domicilio;
            telefono.Text = afiliado.telefono.ToString();
            mail.Text = afiliado.mail;
            plan.Text = afiliado.plan.ToString();
            tipo.Text = afiliado.tipoDoc;
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
        }
     

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
