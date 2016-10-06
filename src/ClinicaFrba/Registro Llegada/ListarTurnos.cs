using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;
using ClinicaFrba.UtilConexion;

namespace ClinicaFrba.Registro_Llegada
{
    partial class ListarTurnos : Form
    {
        private Profesional profesional;
        private Afiliado afiliado;
        private List<Turno> turnos;
        private ElegirProfesional elegirProfesinal;
        private int bonoAUsar;
        
        public ListarTurnos(Profesional profesional, Afiliado afiliado, int bonoAUsar, ElegirProfesional elegirProfesinal)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.profesional = profesional;
            this.bonoAUsar = bonoAUsar;
            this.elegirProfesinal = elegirProfesinal;
            this.cargarDatos();
        }

        private void cargarDatos()
        {
            nombreAfiliado.Text = "Nombre Afiliado: " + afiliado.apellido + ", " + afiliado.nombre;
            this.turnos = Turno.darTurnos(afiliado, profesional);
            if (turnos.Count > 0)
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
                Turno turno = ((Turno)turnosGrid.CurrentRow.DataBoundItem);
                turno.registrarLlegada(bonoAUsar);
                MessageBox.Show("Llegada registrada con exito", "Éxito!", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private Boolean seleccionValida()
        {
            if (turnosGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar a un turno", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
