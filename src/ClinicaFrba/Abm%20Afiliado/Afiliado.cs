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
    public partial class Afiliado : Form
    {
        public Afiliado()
        {
            InitializeComponent();
        }

        private void afiliadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afiliadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gD2C2016DataSet);

        }

        private void Afiliado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2016DataSet.Grupos_Familiares' Puede moverla o quitarla según sea necesario.
            this.grupos_FamiliaresTableAdapter.Fill(this.gD2C2016DataSet.Grupos_Familiares);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2016DataSet.Afiliados' Puede moverla o quitarla según sea necesario.
            this.afiliadosTableAdapter.Fill(this.gD2C2016DataSet.Afiliados);

        }

        private void afiliadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
