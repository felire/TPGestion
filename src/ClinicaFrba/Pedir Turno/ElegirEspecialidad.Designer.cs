namespace ClinicaFrba.Pedir_Turno
{
    partial class ElegirEspecialidad
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
            this.listaEspecialidades = new System.Windows.Forms.ListView();
            this.Elegir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidades a elegir:";
            // 
            // listaEspecialidades
            // 
            this.listaEspecialidades.Location = new System.Drawing.Point(16, 52);
            this.listaEspecialidades.Name = "listaEspecialidades";
            this.listaEspecialidades.Size = new System.Drawing.Size(357, 154);
            this.listaEspecialidades.TabIndex = 1;
            this.listaEspecialidades.UseCompatibleStateImageBehavior = false;
            this.listaEspecialidades.View = System.Windows.Forms.View.List;
            // 
            // Elegir
            // 
            this.Elegir.Location = new System.Drawing.Point(16, 260);
            this.Elegir.Name = "Elegir";
            this.Elegir.Size = new System.Drawing.Size(143, 23);
            this.Elegir.TabIndex = 2;
            this.Elegir.Text = "Elegir";
            this.Elegir.UseVisualStyleBackColor = true;
            this.Elegir.Click += new System.EventHandler(this.Elegir_Click);
            // 
            // ElegirEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 341);
            this.Controls.Add(this.Elegir);
            this.Controls.Add(this.listaEspecialidades);
            this.Controls.Add(this.label1);
            this.Name = "ElegirEspecialidad";
            this.Text = "ElegirEspecialidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listaEspecialidades;
        private System.Windows.Forms.Button Elegir;
    }
}