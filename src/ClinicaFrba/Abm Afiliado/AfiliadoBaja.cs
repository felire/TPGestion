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
    public partial class AfiliadoBaja : Form
    {
        public AfiliadoBaja()
        {
            InitializeComponent();
        }
        public void confirmaEliminacion(){
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Quiere eliminar definitivamente el/los afiliados?", "Eliminar Afiliado",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes) 
            { // elimino
            }
                else {//limpio todo
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {

        }

        private void AfiliadoBaja_Load(object sender, EventArgs e)
        {

        }
    }
}