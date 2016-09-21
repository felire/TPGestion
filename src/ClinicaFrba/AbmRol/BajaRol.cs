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
    partial class BajaRol : Form
    {
        public List<Rol> roles { get; set; }
        public BajaRol()
        {
            InitializeComponent();
            cargarRolesDisponibles();
        }

        private void cargarRolesDisponibles()
        {
            roles = Rol.obtenerTodosLosRoles();
            foreach (Rol rol in roles)
            {
                if (rol.activo)
                {
                    rolesExistentes.Items.Add(rol.nombreRol);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bajaRol_Load(object sender, EventArgs e)
        {

        }

        private void rolesExistentes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionados = rolesExistentes.SelectedItems.Count;
            for(int i = 0; i < cantidadSeleccionados; i++)
            {
                ListViewItem nombreRol = rolesExistentes.SelectedItems[0];
                foreach (Rol rol in roles)
                {
                    if (rol.nombreRol.Equals(nombreRol.Text))
                    {
                        rol.deshabilitar();
                    }
                }
            }
            if (cantidadSeleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar una opcion primero", "Error", MessageBoxButtons.OK);
            }
            else if(cantidadSeleccionados == 1)
            {
                MessageBox.Show("Baja realizada con exito!", "Exito", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bajas realizadas con exito!", "Exito", MessageBoxButtons.OK);
                this.Hide();
            }
        }
    }
}
