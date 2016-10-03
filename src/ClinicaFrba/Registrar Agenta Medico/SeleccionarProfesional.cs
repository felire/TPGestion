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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class SeleccionarProfesional : Form
    {
        private List<Especialidad> especialidades;
        private List<Profesional> profesionalesActuales;

        public SeleccionarProfesional()
        {
            InitializeComponent();
            especialidades = Especialidad.darTodasEspecialidades();
            profesionalesActuales = new List<Profesional>();
            cargarFormulario();
            listaProfesionales.AutoGenerateColumns = false;
            this.cargarGrilla();
        }

        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColId = new DataGridViewTextBoxColumn();
            ColId.DataPropertyName = "id";
            ColId.HeaderText = "Numero de Profesional";
            ColId.Width = listaProfesionales.Width / 5;
            listaProfesionales.Columns.Add(ColId);

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Width = listaProfesionales.Width / 5;
            listaProfesionales.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColApellido = new DataGridViewTextBoxColumn();
            ColApellido.DataPropertyName = "apellido";
            ColApellido.HeaderText = "Apellido";
            ColApellido.Width = listaProfesionales.Width / 5;
            listaProfesionales.Columns.Add(ColApellido);

            DataGridViewTextBoxColumn ColTipo = new DataGridViewTextBoxColumn();
            ColTipo.DataPropertyName = "tipoDoc";
            ColTipo.HeaderText = "Tipo";
            ColTipo.Width = listaProfesionales.Width / 5;
            listaProfesionales.Columns.Add(ColTipo);

            DataGridViewTextBoxColumn ColNumero = new DataGridViewTextBoxColumn();
            ColNumero.DataPropertyName = "documento";
            ColNumero.HeaderText = "Numero Documento";
            ColNumero.Width = listaProfesionales.Width / 5 - 44;
            listaProfesionales.Columns.Add(ColNumero);
        }

        private void cargarFormulario()
        {
            Especialidad noElige = new Especialidad();
            noElige.codigo = -1;
            noElige.descripcion = "";
            List<Especialidad> listaConNoElige = new List<Especialidad>();
            listaConNoElige.Add(noElige);
            foreach (Especialidad esp in this.especialidades)
            {
                listaConNoElige.Add(esp);
            }
            comboEspecialidades.DataSource = listaConNoElige;
            comboEspecialidades.DisplayMember = "descripcion";
            comboEspecialidades.ValueMember = "codigo";
            comboEspecialidades.SelectedItem = noElige;

            tipoDoc.Items.Add("");
            tipoDoc.Items.Add("DNI");
            tipoDoc.Items.Add("LD");
            tipoDoc.Items.Add("LC");
            tipoDoc.Items.Add("CI");
            tipoDoc.SelectedIndex = 0;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            profesionalesActuales.Clear();
            profesionalesActuales = Profesional.buscar(nombre.Text, apellido.Text, ((Especialidad)comboEspecialidades.SelectedItem).descripcion, (string)tipoDoc.SelectedItem, numeroDoc.Text);
            listaProfesionales.DataSource = profesionalesActuales;
            listaProfesionales.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                Profesional profesional = (Profesional)listaProfesionales.CurrentRow.DataBoundItem;
                RegAgendaMedico agenda = new RegAgendaMedico(profesional);
                agenda.Show();
                this.Hide();
            }
        }

        private Boolean seleccionValida()
        {
            if (listaProfesionales.SelectedRows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesional", "Error!", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
