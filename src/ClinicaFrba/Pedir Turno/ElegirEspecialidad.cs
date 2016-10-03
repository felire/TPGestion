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

namespace ClinicaFrba.Pedir_Turno
{
    partial class ElegirEspecialidad : Form
    {
        private Especialidad especialidadElegida;
        private Turno turno;

        public ElegirEspecialidad(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;
            this.cargarDatos(turno.profesional.especialidades);
        }

        private void cargarDatos(List<Especialidad> especialidades)
        {
            foreach (Especialidad especialidad in especialidades)
            {
                listaEspecialidades.Items.Add(especialidad.descripcion);
            }
        }

        private void Elegir_Click(object sender, EventArgs e)
        {
            if (seleccionValida())
            {
                ListViewItem item = listaEspecialidades.SelectedItems[0];
                foreach (Especialidad especialidad in turno.profesional.especialidades)
                { 
                    if(especialidad.descripcion.Equals(item.Text))
                    {
                        turno.especialidad = especialidad;
                    }
                }
                ElegirFecha elegirFecha = new ElegirFecha(turno, this);
            }
        }

        private bool seleccionValida()
        {
            return listaEspecialidades.SelectedItems.Count == 1;
        }
    }
}
