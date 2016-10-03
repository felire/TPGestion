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
    partial class ModificarRol : Form
    {
        private List<Rol> roles;

        public ModificarRol()
        {
            InitializeComponent();
            roles = Rol.obtenerTodosLosRoles();
            mostrarRoles();
        }

        public void mostrarRoles()
        {
            foreach (Rol rol in roles)
            {
                rolesExistentes.Items.Add(rol.nombreRol);
            }
        }

        private void habilitarRol_Click(object sender, EventArgs e)
        {
            if (seleccionoUno())
            {
                Rol rol = darRolSeleccionado();
                rol.habilitarRol();
                MessageBox.Show("Rol habilitado con exito", "Exito", MessageBoxButtons.OK);
            }
        }

        private Boolean seleccionoUno()
        {
            if (rolesExistentes.SelectedItems.Count == 0)
            {
                MessageBox.Show("No selecciono ningun rol", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else if (rolesExistentes.SelectedItems.Count > 1)
            {
                MessageBox.Show("No puede seleccionar mas de un rol a modificar", "Error!", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private Rol darRolSeleccionado()
        {
            ListViewItem nombreRol = rolesExistentes.SelectedItems[0];
            Rol rol = null;
            foreach (Rol rolEach in roles)
            {
                if (rolEach.nombreRol.Equals(nombreRol.Text))
                {
                    rol = rolEach;
                }
            }
            return rol;
        }

        private void modifRol_Click(object sender, EventArgs e)
        {
            if (seleccionoUno())
            {
                Rol rol = darRolSeleccionado();
                ModificarFuncionalidadesRol mod = new ModificarFuncionalidadesRol(rol);
                mod.Show();
            }
        }
    }
}
