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

namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAfiliado : Form
    {
        private Afiliado afiliado;
        public List<Turno> listaTurnos;

        public CancelarAfiliado(Afiliado afiliado)
        {
            InitializeComponent();
            this.afiliado = afiliado;
            this.listaTurnos = Turno.darTodosLosTurnosDe(afiliado);
            cargarDatos();
        }

        public void cargarDatos()
        {
            this.nombreAfiliado.Text = afiliado.apellido + ", " + afiliado.nombre;
            turnos.AutoGenerateColumns = false;
            turnos.MultiSelect = false;
            generarGrid();
            this.turnos.DataSource = listaTurnos;
        }

        private void generarGrid()
        {
            DataGridViewTextBoxColumn ColDia = new DataGridViewTextBoxColumn();
            ColDia.DataPropertyName = "fecha";
            ColDia.HeaderText = "Día";
            ColDia.Width = 120;
            turnos.Columns.Add(ColDia);


            DataGridViewTextBoxColumn ColEspecialidad = new DataGridViewTextBoxColumn();
            ColEspecialidad.DataPropertyName = "especialidadNombre";
            ColEspecialidad.HeaderText = "Especialidad";
            ColEspecialidad.Width = 120;
            turnos.Columns.Add(ColEspecialidad);


            DataGridViewTextBoxColumn ColProfesional = new DataGridViewTextBoxColumn();
            ColProfesional.DataPropertyName = "profesionalNombre";
            ColProfesional.HeaderText = "Profesional";
            ColProfesional.Width = 120;
            turnos.Columns.Add(ColProfesional);
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                Turno turno = (Turno)turnos.CurrentRow.DataBoundItem;
                turno.cancelar(motivoCancelacion.Text, "Afiliado");
                MessageBox.Show("Turno cancelado con exito!", "Exito!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private Boolean seleccionValida()
        {
            string mensajeDeError = "";
            if (turnos.SelectedRows.Count != 1)
            {
                mensajeDeError = "Debe seleccionar un turno";
            }
            if (motivoCancelacion.Text == "")
            {
                mensajeDeError = mensajeDeError + "\r\n" + "Debe especificar el motivo de la cancelacion";
            }
            Turno turno = (Turno)turnos.CurrentRow.DataBoundItem;
            if ((turno.fecha.Date - DateTime.Parse(ArchivoDeConfiguracion.Default.Fecha).Date).Days < 1)
            {
                mensajeDeError = mensajeDeError + "\r\n" + "No puede cancelar un turno el dia que lo tiene";
            }
            if (mensajeDeError.Equals(""))
            {
                return true;
            }
            else
            {
                MessageBox.Show(mensajeDeError, "Error!", MessageBoxButtons.OK);
                return false;
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
