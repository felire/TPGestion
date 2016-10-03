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

namespace ClinicaFrba.Registro_Llegada
{
    partial class ListarTurnos : Form
    {
        private Profesional profesional;
        private Afiliado afiliado;
        private List<Turno> turnos;
        private ElegirProfesional elegirProfesinal;
        
        public ListarTurnos(Profesional profesional, Afiliado afiliado, ElegirProfesional elegirProfesinal)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.profesional = profesional;
            this.elegirProfesinal = elegirProfesinal;
            this.cargarDatos();
        }

        public void cargarDatos()
        {
            nombreAfiliado.Text = "Nombre Afiliado: " + afiliado.apellido + ", " + afiliado.nombre;
            this.turnos = Turno.darTurnos(afiliado, profesional);
            if (turnos.Count != 0)
            {
                
                turnosGrid.AutoGenerateColumns = false;
                turnosGrid.MultiSelect = false;
                turnosGrid.DataSource = turnos;
                this.generarGrid();
                this.elegirProfesinal.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("No tiene turnos con el profesional elegido", "Error!", MessageBoxButtons.OK);
            }
          
        }

        private void generarGrid()
        {
            DataGridViewTextBoxColumn ColDia = new DataGridViewTextBoxColumn();
            ColDia.DataPropertyName = "fecha";
            ColDia.HeaderText = "Fecha";
            ColDia.Width = 120;
            turnosGrid.Columns.Add(ColDia);

            DataGridViewTextBoxColumn ColHoraHasta = new DataGridViewTextBoxColumn();
            ColHoraHasta.DataPropertyName = "profesionalNombre";
            ColHoraHasta.HeaderText = "Profesional";
            ColHoraHasta.Width = 120;
            turnosGrid.Columns.Add(ColHoraHasta);

            DataGridViewTextBoxColumn ColEspecialidad = new DataGridViewTextBoxColumn();
            ColEspecialidad.DataPropertyName = "especialidadNombre";
            ColEspecialidad.HeaderText = "Especialidad";
            ColEspecialidad.Width = 120;
            turnosGrid.Columns.Add(ColEspecialidad);
        }

        private void elegir_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                ((Turno)turnosGrid.CurrentRow.DataBoundItem).registrarLlegada();
                MessageBox.Show("Llegada registrada con exito", "Éxito!", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private Boolean seleccionValida()
        {
            if (turnosGrid.SelectedRows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar a un turno", "Error!", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
