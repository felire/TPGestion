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
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ClinicaFrba.Compra_Bono
{
    partial class CompraBono : Form
    {
        public decimal precioUnitario { get; set; }
        public decimal plan { get; set; }
        public int cantidad { get; set; }
        public Afiliado afiliado { get; set; }

        public CompraBono(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            cargarDatos();
        }

        private void cargarDatos()
        {
            nombre.Text = afiliado.nombre;
            apellido.Text = afiliado.apellido;
            
            string grupo = afiliado.numeroDeGrupo.ToString();
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            ListaParametros.Add(new SqlParameter("@grupo", Decimal.Parse(grupo)));
            SpeakerDB speaker = ConexionDB.ObtenerDataReader("SELECT Precio_bono_consulta, Plan_grupo FROM kernel_panic.Planes p JOIN kernel_panic.Grupos_Familiares gf ON (p.Codigo = gf.Plan_grupo) WHERE gf.Id = @grupo", "T", ListaParametros);
            if (speaker.reader.HasRows)
            {
                speaker.reader.Read();
                precioUnitario = (decimal)speaker.reader["Precio_bono_consulta"];
                plan = (decimal)speaker.reader["Plan_grupo"];
                precio.Text = precioUnitario.ToString();
            }
            speaker.close();
        }

        private void comprar_Click(object sender, EventArgs e)
        {
            if (cantidadAComprar.Text.Equals(""))    /* Santi: no checkeo que solo me ingrese numeros, hay que hacerlo*/
            {
                MessageBox.Show("Debe ingresar cuantos bonos va a comprar", "Error!", MessageBoxButtons.OK);
                return;
            }
            cantidad = Int32.Parse(cantidadAComprar.Text);
            int total = cantidad * (int)precioUnitario;
            System.Windows.Forms.DialogResult resultado;
            if (Int32.Parse(cantidadAComprar.Text) == 1)
            {
                resultado = MessageBox.Show("Esta seguro que desea comprar un bono a " + total + " pesos?", "Seguro?", MessageBoxButtons.YesNo);
            }
            else 
            {
               resultado =  MessageBox.Show("Esta seguro que desea comprar " + cantidadAComprar.Text + " bonos por un total de " + total + " pesos?", "Seguro?", MessageBoxButtons.YesNo);
            }
            if (resultado == DialogResult.Yes)
            {
                comprarBonos();
            }
        }

        private void comprarBonos()
        {
            List<SqlParameter> ListaParametros = new List<SqlParameter>();
            for (int i = 0; i < cantidad; i++)
            {

                ListaParametros.Clear();
                ListaParametros.Add(new SqlParameter("@grupo", afiliado.numeroDeGrupo));
                ListaParametros.Add(new SqlParameter("@plan", plan));
                ListaParametros.Add(new SqlParameter("@hoy", DateTime.Now));
                SpeakerDB speaker = ConexionDB.ExecuteNoQuery("INSERT INTO kernel_panic.Bonos_Consultas (Nro_consulta, Grupo_afiliado, Plan_Uso, Afiliado_Uso, Fecha_Bono_compra, Fecha_Impresion, Turno) VALUES (NULL, @grupo, @plan, NULL, @hoy, @hoy, NULL)", "T", ListaParametros);
                speaker.close();
            }
            MessageBox.Show("Compra realizada con exito", "", MessageBoxButtons.OK);
            this.Hide();
        }
    }
}
