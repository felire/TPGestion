namespace ClinicaFrba.AbmRol
{
    partial class BajaRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.rolesExistentes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles existentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(16, 271);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // rolesExistentes
            // 
            this.rolesExistentes.Location = new System.Drawing.Point(12, 29);
            this.rolesExistentes.Name = "rolesExistentes";
            this.rolesExistentes.Size = new System.Drawing.Size(271, 207);
            this.rolesExistentes.TabIndex = 4;
            this.rolesExistentes.UseCompatibleStateImageBehavior = false;
            this.rolesExistentes.View = System.Windows.Forms.View.List;
            this.rolesExistentes.SelectedIndexChanged += new System.EventHandler(this.rolesExistentes_SelectedIndexChanged_1);
            // 
            // BajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 337);
            this.Controls.Add(this.rolesExistentes);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.label1);
            this.Name = "BajaRol";
            this.Text = "bajaRol";
            this.Load += new System.EventHandler(this.bajaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ListView rolesExistentes;
    }
}