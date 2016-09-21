namespace ClinicaFrba.AbmRol
{
    partial class ModificarRol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rolesExistentes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.modifRol = new System.Windows.Forms.Button();
            this.habilitarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rolesExistentes
            // 
            this.rolesExistentes.Location = new System.Drawing.Point(12, 82);
            this.rolesExistentes.Name = "rolesExistentes";
            this.rolesExistentes.Size = new System.Drawing.Size(211, 218);
            this.rolesExistentes.TabIndex = 0;
            this.rolesExistentes.UseCompatibleStateImageBehavior = false;
            this.rolesExistentes.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roles existentes:";
            // 
            // modifRol
            // 
            this.modifRol.Location = new System.Drawing.Point(282, 123);
            this.modifRol.Name = "modifRol";
            this.modifRol.Size = new System.Drawing.Size(175, 38);
            this.modifRol.TabIndex = 2;
            this.modifRol.Text = "Modificar Rol";
            this.modifRol.UseVisualStyleBackColor = true;
            // 
            // habilitarRol
            // 
            this.habilitarRol.Location = new System.Drawing.Point(282, 208);
            this.habilitarRol.Name = "habilitarRol";
            this.habilitarRol.Size = new System.Drawing.Size(175, 38);
            this.habilitarRol.TabIndex = 3;
            this.habilitarRol.Text = "Habilitar Rol";
            this.habilitarRol.UseVisualStyleBackColor = true;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 371);
            this.Controls.Add(this.habilitarRol);
            this.Controls.Add(this.modifRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolesExistentes);
            this.Name = "ModificarRol";
            this.Text = "ModificarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView rolesExistentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button modifRol;
        private System.Windows.Forms.Button habilitarRol;
    }
}