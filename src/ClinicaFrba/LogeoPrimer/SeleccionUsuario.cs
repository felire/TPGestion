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
using ClinicaFrba.Menu;
using ClinicaFrba.LogeoPrimer;


namespace ClinicaFrba.LogeoPrimer
{
    partial class SeleccionUsuario : Form
    {
        public Logeo logeo { get; set; }
        public SeleccionUsuario(Logeo logeo)
        {
            InitializeComponent();
            this.logeo = logeo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = nombreUser.Text;
            Usuario usuario = new Usuario(user, "", this);
        }

        public void primerLogeo(Usuario usuario)
        {
            PrimerLogeo primer = new PrimerLogeo(usuario, logeo);
            primer.Show();
            this.Hide();
        }
        public void sinRoles()
        {
            MessageBox.Show("El usuario elegido no tiene roles asignados", "Error!", MessageBoxButtons.OK);
        }
        public void noEntra()
        {
            MessageBox.Show("No es posible logearse con este usuario", "Error!", MessageBoxButtons.OK);
        }
    }
}
