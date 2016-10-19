namespace ClinicaFrba.Pedir_Turno
{
    partial class ElegirFecha
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
            this.nombreProfesional = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elegir = new System.Windows.Forms.Button();
            this.comboFecha = new System.Windows.Forms.ComboBox();
            this.comboHorario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreProfesional
            // 
            this.nombreProfesional.AutoSize = true;
            this.nombreProfesional.Location = new System.Drawing.Point(142, 4);
            this.nombreProfesional.Name = "nombreProfesional";
            this.nombreProfesional.Size = new System.Drawing.Size(35, 13);
            this.nombreProfesional.TabIndex = 16;
            this.nombreProfesional.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre del Profesional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dia del turno:";
            // 
            // elegir
            // 
            this.elegir.Location = new System.Drawing.Point(327, 121);
            this.elegir.Name = "elegir";
            this.elegir.Size = new System.Drawing.Size(100, 29);
            this.elegir.TabIndex = 21;
            this.elegir.Text = "Aceptar";
            this.elegir.UseVisualStyleBackColor = true;
            this.elegir.Click += new System.EventHandler(this.acepto);
            // 
            // comboFecha
            // 
            this.comboFecha.FormattingEnabled = true;
            this.comboFecha.Location = new System.Drawing.Point(103, 44);
            this.comboFecha.Name = "comboFecha";
            this.comboFecha.Size = new System.Drawing.Size(121, 21);
            this.comboFecha.TabIndex = 23;
            this.comboFecha.SelectedIndexChanged += new System.EventHandler(this.eligioDia);
            // 
            // comboHorario
            // 
            this.comboHorario.FormattingEnabled = true;
            this.comboHorario.Location = new System.Drawing.Point(307, 44);
            this.comboHorario.Name = "comboHorario";
            this.comboHorario.Size = new System.Drawing.Size(121, 21);
            this.comboHorario.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Horario:";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(201, 121);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 30;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ElegirFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 171);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboHorario);
            this.Controls.Add(this.comboFecha);
            this.Controls.Add(this.elegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreProfesional);
            this.Controls.Add(this.label1);
            this.Name = "ElegirFecha";
            this.Text = "ElegirFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button elegir;
        private System.Windows.Forms.ComboBox comboFecha;
        private System.Windows.Forms.ComboBox comboHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelar;
    }
}