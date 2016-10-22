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
        public SeleccionUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = nombreUser.Text;
            Usuario usuario = new Usuario(user, "", this);
        }

        public void primerLogeo(Usuario usuario)
        {
            PrimerLogeo primer = new PrimerLogeo(usuario);
            primer.Show();
            this.Close();
        }

        public void sinRoles()
        {
            MessageBox.Show("El usuario elegido no tiene roles asignados", "Error!", MessageBoxButtons.OK);
        }

        public void noEntra()
        {
            MessageBox.Show("El usuario no existe o ya se logueo por primera vez", "Error!", MessageBoxButtons.OK);
        }
    }
}
