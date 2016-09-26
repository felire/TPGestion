using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ClinicaFrba.UtilConexion;
using System.Data.SqlTypes;


namespace ClinicaFrba.Abm_Afiliado
{
    public partial class Cambios : Form
    {
        public Cambios()
        {
            InitializeComponent();
        }

        private void labelGR_Click(object sender, EventArgs e)
        {

        }
        private void buscar_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCambios_Load(object sender, EventArgs e) {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            string query = "SELECT Numero_en_el_grupo, Nombre, Apellido, GD2C2016.kernel_panic.LogsCambioAfiliados.Fecha, GD2C2016.kernel_panic.LogsCambioAfiliados.Tipo, GD2C2016.kernel_panic.LogsCambioAfiliados.Descripcion, Esta_activo FROM GD2C2016.kernel_panic.Afiliados INNER JOIN GD2C2016.kernel_panic.LogsCambioAfiliados ON  GD2C2016.kernel_panic.Afiliados.Id = GD2C2016.kernel_panic.LogsCambioAfiliados.Afiliado";
            string queryPrueba = "SELECT TOP 1 Id from GD2C2016.kernel_panic.Afiliados";
            string tipo = "TD";
            string tipoPrueba = "T";
            SpeakerDB speaker = ConexionDB.ObtenerDataReader (query, tipo, ListaParametros);
            this.dataGridView1.DataSource = speaker;
            speaker.close();
            
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }
    }
}
