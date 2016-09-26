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
    public partial class ModificaDatos : Form
    {
        public Afiliado afiliado { get; set; }
        //recibe objeto afiliado con esos datos busco y modifico con el store procedure
        public ModificaDatos(Afiliado afi)
        {
            InitializeComponent();
            this.afiliado = afi;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
