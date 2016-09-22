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
        private Label label1;
        private Button button1;
        private ListView rolesExistentes;
        private Label Roles;
    
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
            for (int i = 0; i < cantidadSeleccionados; i++)
            {
                ListViewItem nombreRol = rolesExistentes.SelectedItems[i];
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
            this.Roles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rolesExistentes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Roles
            // 
            this.Roles.AutoSize = true;
            this.Roles.Location = new System.Drawing.Point(13, 13);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(84, 13);
            this.Roles.TabIndex = 0;
            this.Roles.Text = "Roles existentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roles";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // rolesExistentes
            // 
            this.rolesExistentes.Location = new System.Drawing.Point(16, 40);
            this.rolesExistentes.Name = "rolesExistentes";
            this.rolesExistentes.Size = new System.Drawing.Size(246, 191);
            this.rolesExistentes.TabIndex = 4;
            this.rolesExistentes.UseCompatibleStateImageBehavior = false;
            this.rolesExistentes.View = System.Windows.Forms.View.List;
            // 
            // BajaRol
            // 
            this.ClientSize = new System.Drawing.Size(598, 357);
            this.Controls.Add(this.rolesExistentes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roles);
            this.Name = "BajaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}