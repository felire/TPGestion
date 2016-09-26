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
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();

        }

        private void seleccionar_Click(object sender, EventArgs e) {
        int contador = 0;
         foreach (DataGridViewRow row in dataGridView1.Rows){ 
            if (row.Cells[0].Value.Equals(true)){
                contador++;
              }
         }
             if (contador > 1) {MessageBox.Show("Seleccione un sólo afiliado", "Información");}
             if (contador == 1) {
                 //instanciar la clase y guardar los datos del select
                 Afiliado afi = new Afiliado();
                 ModificaDatos modificar = new ModificaDatos(afi);
                 
             }
         }
        
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
