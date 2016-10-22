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

namespace ClinicaFrba.Registro_Resultado
{
    partial class ElegirAfiliado : Form
    {
        private List<Afiliado> afiliadosActuales;
        private Profesional profesional;

        public ElegirAfiliado(Profesional profesional)
        {
            InitializeComponent();
            this.profesional = profesional;
            cargarFormulario();
            listaAfiliados.AutoGenerateColumns = false;
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColId = new DataGridViewTextBoxColumn();
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "Numero de Afiliado";
            ColId.Width = listaAfiliados.Width / 5;
            listaAfiliados.Columns.Add(ColId);

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Width = listaAfiliados.Width / 5;
            listaAfiliados.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColApellido = new DataGridViewTextBoxColumn();
            ColApellido.DataPropertyName = "apellido";
            ColApellido.HeaderText = "Apellido";
            ColApellido.Width = listaAfiliados.Width / 5;
            listaAfiliados.Columns.Add(ColApellido);

            DataGridViewTextBoxColumn ColTipo = new DataGridViewTextBoxColumn();
            ColTipo.DataPropertyName = "tipoDoc";
            ColTipo.HeaderText = "Tipo";
            ColTipo.Width = listaAfiliados.Width / 5;
            listaAfiliados.Columns.Add(ColTipo);

            DataGridViewTextBoxColumn ColNumero = new DataGridViewTextBoxColumn();
            ColNumero.DataPropertyName = "documento";
            ColNumero.HeaderText = "Numero Documento";
            ColNumero.Width = listaAfiliados.Width / 5 - 44;
            listaAfiliados.Columns.Add(ColNumero);
        }

        private void cargarFormulario()
        {
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LD");
            tipoDoc.Items.Add("LC");
            tipoDoc.Items.Add("CI");
            tipoDoc.SelectedIndex = 0;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
           afiliadosActuales = Afiliado.buscar(1, nombre.Text, apellido.Text, grupo.Text, (string)tipoDoc.SelectedItem, numeroDoc.Text);
           listaAfiliados.DataSource = afiliadosActuales;
           listaAfiliados.ClearSelection();
        }

        private void elegir_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                Afiliado afiliado = (Afiliado)listaAfiliados.CurrentRow.DataBoundItem;
                ConsultaMedica consulta = new ConsultaMedica(afiliado, profesional);
                if (consulta.id == -1)
                {
                    MessageBox.Show("No tiene consultas pendientes con este afiliado!", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    Diagnostico diag = new Diagnostico(consulta);
                    diag.Show();
                    this.Close();
                }                    
            }
        }

        private Boolean seleccionValida()
        {
            if (listaAfiliados.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar un afiliado", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
