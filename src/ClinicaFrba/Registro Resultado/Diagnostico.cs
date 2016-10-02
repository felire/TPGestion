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
    partial class Diagnostico : Form
    {
        public Afiliado afiliado { get; set; }
        public Profesional profesional { get; set; }
        public ConsultaMedica consulta { get; set; }
        public Diagnostico(ConsultaMedica consulta)
        {
            InitializeComponent();
            this.afiliado = consulta.afiliado;
            this.profesional = consulta.profesional;
            this.consulta = consulta;
            this.cargarDatos();
        }

        public void cargarDatos()
        {
            nombreAfi.Text = this.afiliado.apellido + ", " + this.afiliado.nombre;
            nombreProf.Text = this.profesional.apellido + ", "+this.profesional.nombre;
            nombreEspecialidad.Text = consulta.turno.especialidad.descripcion;
            cmbHora.DataSource = Hora.ObtenerHorasAceptables(consulta.turno);
            cmbHora.ValueMember = "LaHora";
            cmbHora.DisplayMember = "HoraAMostrar";
            cmbHora.SelectedIndex = 0;
            dtpFechaAtencion.Text = consulta.turno.fecha.ToString();
            dtpFechaAtencion.Enabled = false;
            resultado.Visible = false;
        }

        private void actualizarHoras(object sender, EventArgs e)
        {
            /*Dia dia = new Dia((int)dtpFechaAtencion.Value.Date.DayOfWeek);
            cmbHora.DataSource = Hora.obtenerHorasDia(dia);
            cmbHora.ValueMember = "LaHora";
            cmbHora.DisplayMember = "HoraAMostrar";
            cmbHora.SelectedIndex = 0;*/
        }

        private void asignarDiag_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                consulta.sintoma = txtSintomas.Text;
                consulta.enfermedad = txtEnfermedad.Text;
                consulta.fecha = new DateTime(dtpFechaAtencion.Value.Year, dtpFechaAtencion.Value.Month, dtpFechaAtencion.Value.Day, ((Hora)cmbHora.SelectedItem).LaHora.Hours, ((Hora)cmbHora.SelectedItem).LaHora.Minutes, 0);
                consulta.actualizarConsulta();
                MessageBox.Show("Diagnostico asignado con exito", "Error!", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private Boolean camposValidos()
        {
            if (txtEnfermedad.Text.Equals("") || txtSintomas.Text.Equals(""))
            {
                MessageBox.Show("Debe rellenar todos los campos", "Error!", MessageBoxButtons.OK);
                return false;
            }
            if (txtEnfermedad.Text.Length > 255 || txtSintomas.Text.Length > 255)
            {
                MessageBox.Show("Los campos no pueden superar los 255 caracteres!", "Error!", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            resultado.Visible = true;
            cmbHora.Enabled = false;
            confirmar.Visible = false;
        }
    }
}
