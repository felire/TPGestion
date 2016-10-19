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
        private Afiliado afiliado;
        private Profesional profesional;
        private ConsultaMedica consulta;

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
            nombreAfi2.Text = this.afiliado.apellido + ", " + this.afiliado.nombre;
            cmbHora.DataSource = Hora.ObtenerHorasAceptables(consulta.turno);
            cmbHora.ValueMember = "LaHora";
            cmbHora.DisplayMember = "HoraAMostrar";
            cmbHora.SelectedIndex = 0;
            dtpFechaAtencion.Text = consulta.turno.fecha.ToString();
            dtpFechaAtencion.Enabled = false;
            fecha2.Text = dtpFechaAtencion.Text = consulta.turno.fecha.ToString();
            fecha2.Enabled = false;
            gbDatos.Visible = false;
            resultado.Visible = false;
        }

        private void actualizarHoras(object sender, EventArgs e) {} //santi: es horripilante esto

        private void asignarDiag_Click(object sender, EventArgs e)
        {
            if (camposValidos())
            {
                consulta.sintoma = txtSintomas.Text;
                consulta.enfermedad = txtEnfermedad.Text;
                consulta.fecha = new DateTime(dtpFechaAtencion.Value.Year, dtpFechaAtencion.Value.Month, dtpFechaAtencion.Value.Day, ((Hora)cmbHora.SelectedItem).LaHora.Hours, ((Hora)cmbHora.SelectedItem).LaHora.Minutes, 0);
                consulta.actualizarConsulta();
                MessageBox.Show("Diagnostico asignado con exito", "Éxito", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private Boolean camposValidos()
        {
            string mensajeDeError = "";
            if (txtEnfermedad.Text.Equals("") || txtSintomas.Text.Equals(""))
            {
                mensajeDeError = "Debe rellenar todos los campos";
            }
            if (txtEnfermedad.Text.Length > 255 || txtSintomas.Text.Length > 255)
            {
                mensajeDeError = mensajeDeError + "\r\n" + "Los campos tienen un máximo de 255 caracteres";
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

        private void confirmar_Click(object sender, EventArgs e)
        {
            resultado.Visible = true;
            cmbHora.Enabled = false;
            confirmar.Visible = false;
        }

        private void ausenciaConsulta_Click(object sender, EventArgs e)
        {
            consulta.fecha = fecha2.Value;
            consulta.ausenciaConsulta();
            MessageBox.Show("Ausencia registrada corectamente", "Éxito!", MessageBoxButtons.OK);
            this.Close();
        }

        private void asignarDiagnostico_Click(object sender, EventArgs e)
        {
            datos1.Visible = false;
            gbDatos.Visible = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
