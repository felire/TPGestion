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

namespace ClinicaFrba.AbmRol
{
    partial class AltaRol : Form
    {
        private List<Funcionalidad> funcionalidades;
 
        public AltaRol()
        {
            InitializeComponent();
            funcionalidades = Funcionalidad.darTodasLasFuncionalidades();
            cargarOpciones();
        }

        private void cargarOpciones()
        {
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                funcionalidadesAgregables.Items.Add(funcionalidad.descripcion);
            }
        }

        private void agregarFun_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregables.SelectedItems.Count;
            for (int i = 0; i < cantidadSeleccionadas; i++)
            {
                ListViewItem descripcion = funcionalidadesAgregables.SelectedItems[0];
                funcionalidadesAgregadas.Items.Add(descripcion.Text);
                funcionalidadesAgregables.Items.Remove(descripcion);  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionadas = funcionalidadesAgregadas.SelectedItems.Count;
            for (int i = 0; i < cantidadSeleccionadas; i++)
            {
                ListViewItem descripcion = funcionalidadesAgregadas.SelectedItems[0];
                funcionalidadesAgregables.Items.Add(descripcion.Text);
                funcionalidadesAgregadas.Items.Remove(descripcion);
            }
        }

        private void agregarRol_Click(object sender, EventArgs e)
        {
            if (formularioValido())
            {
                ClinicaFrba.UtilConexion.Rol rol = new ClinicaFrba.UtilConexion.Rol();
                rol.nombreRol = nombreElegido.Text;
                rol.funcionalidades = funcionalidadesElegidas();
                if (rol.darAlta())
                {
                    MessageBox.Show("Rol agregado con exito!", "Exito", MessageBoxButtons.OK);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ya existe un Rol con ese nombre", "Error!", MessageBoxButtons.OK);
                }
            }
        }

        private Boolean formularioValido()
        {
            if (nombreElegido.Text == "")
            {
                MessageBox.Show("No a asignado un nombre al rol", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else if (funcionalidadesAgregadas.Items.Count == 0)
            {
                MessageBox.Show("No a asignado funcionalidades al rol", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<Funcionalidad> funcionalidadesElegidas()
        {
            List<Funcionalidad> funcionalidadesAAgregar = new List<Funcionalidad>();
            foreach (Funcionalidad funci in funcionalidades)
            {
                foreach (ListViewItem item in funcionalidadesAgregadas.Items)
                {
                    if (funci.descripcion.Equals(item.Text))
                    {
                        funcionalidadesAAgregar.Add(funci);
                    }
                }
            }
            return funcionalidadesAAgregar;
        }
    }
}
