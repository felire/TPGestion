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
        private ListView rolesExistentes;
        private Button Eliminar;
        private Label label1;
        private List<Rol> roles;

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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionados = rolesExistentes.SelectedItems.Count;
            for (int i = 0; i < cantidadSeleccionados; i++)
            {
                ListViewItem nombreRol = rolesExistentes.SelectedItems[i];
                foreach (Rol rol in roles)
                {
                    if (rol.nombreRol.Equals(nombreRol.Text))
                    {
                        rol.deshabilitar();
                        break;
                    }
                }
            }
            if (cantidadSeleccionados == 0)
            {
                MessageBox.Show("Debe seleccionar una opcion primero", "Error", MessageBoxButtons.OK);
            }
            else if (cantidadSeleccionados == 1)
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rolesExistentes = new System.Windows.Forms.ListView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles existentes:";
            // 
            // rolesExistentes
            // 
            this.rolesExistentes.Location = new System.Drawing.Point(16, 43);
            this.rolesExistentes.Name = "rolesExistentes";
            this.rolesExistentes.Size = new System.Drawing.Size(256, 153);
            this.rolesExistentes.TabIndex = 1;
            this.rolesExistentes.UseCompatibleStateImageBehavior = false;
            this.rolesExistentes.View = System.Windows.Forms.View.List;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(80, 203);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(126, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // BajaRol
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.rolesExistentes);
            this.Controls.Add(this.label1);
            this.Name = "BajaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}