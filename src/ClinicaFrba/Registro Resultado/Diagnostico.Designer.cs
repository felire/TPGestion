namespace ClinicaFrba.Registro_Resultado
{
    partial class Diagnostico
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.nombreAfi = new System.Windows.Forms.Label();
            this.gpHistoriaClinica = new System.Windows.Forms.GroupBox();
            this.txtEnfermedad = new System.Windows.Forms.RichTextBox();
            this.txtSintomas = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreProf = new System.Windows.Forms.Label();
            this.asignarDiag = new System.Windows.Forms.Button();
            this.asd = new System.Windows.Forms.Label();
            this.nombreEspecialidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaTurno = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.gpHistoriaClinica.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.fechaTurno);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.nombreAfi);
            this.gbDatos.Controls.Add(this.lbl2);
            this.gbDatos.Controls.Add(this.cmbHora);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.dtpFechaAtencion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(482, 110);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Atención";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(6, 16);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 60;
            this.lbl2.Text = "Afiliado:";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(249, 66);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(144, 21);
            this.cmbHora.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hora de la Atención:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de la Atención:";
            // 
            // dtpFechaAtencion
            // 
            this.dtpFechaAtencion.Location = new System.Drawing.Point(8, 67);
            this.dtpFechaAtencion.Name = "dtpFechaAtencion";
            this.dtpFechaAtencion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaAtencion.TabIndex = 5;
            this.dtpFechaAtencion.ValueChanged += new System.EventHandler(this.actualizarHoras);
            // 
            // nombreAfi
            // 
            this.nombreAfi.AutoSize = true;
            this.nombreAfi.Location = new System.Drawing.Point(57, 16);
            this.nombreAfi.Name = "nombreAfi";
            this.nombreAfi.Size = new System.Drawing.Size(35, 13);
            this.nombreAfi.TabIndex = 61;
            this.nombreAfi.Text = "label3";
            // 
            // gpHistoriaClinica
            // 
            this.gpHistoriaClinica.Controls.Add(this.nombreEspecialidad);
            this.gpHistoriaClinica.Controls.Add(this.asd);
            this.gpHistoriaClinica.Controls.Add(this.txtEnfermedad);
            this.gpHistoriaClinica.Controls.Add(this.txtSintomas);
            this.gpHistoriaClinica.Controls.Add(this.label5);
            this.gpHistoriaClinica.Controls.Add(this.label4);
            this.gpHistoriaClinica.Location = new System.Drawing.Point(12, 137);
            this.gpHistoriaClinica.Name = "gpHistoriaClinica";
            this.gpHistoriaClinica.Size = new System.Drawing.Size(482, 167);
            this.gpHistoriaClinica.TabIndex = 7;
            this.gpHistoriaClinica.TabStop = false;
            this.gpHistoriaClinica.Text = "Resultado";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(259, 56);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(182, 96);
            this.txtEnfermedad.TabIndex = 12;
            this.txtEnfermedad.Text = "";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(9, 56);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(185, 96);
            this.txtSintomas.TabIndex = 11;
            this.txtSintomas.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enfermedad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sintomas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesional: ";
            // 
            // nombreProf
            // 
            this.nombreProf.AutoSize = true;
            this.nombreProf.Location = new System.Drawing.Point(72, 377);
            this.nombreProf.Name = "nombreProf";
            this.nombreProf.Size = new System.Drawing.Size(35, 13);
            this.nombreProf.TabIndex = 9;
            this.nombreProf.Text = "label6";
            // 
            // asignarDiag
            // 
            this.asignarDiag.Location = new System.Drawing.Point(187, 340);
            this.asignarDiag.Name = "asignarDiag";
            this.asignarDiag.Size = new System.Drawing.Size(117, 23);
            this.asignarDiag.TabIndex = 10;
            this.asignarDiag.Text = "Asignar diagnostico";
            this.asignarDiag.UseVisualStyleBackColor = true;
            this.asignarDiag.Click += new System.EventHandler(this.asignarDiag_Click);
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Location = new System.Drawing.Point(7, 20);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(73, 13);
            this.asd.TabIndex = 13;
            this.asd.Text = "Especialidad: ";
            // 
            // nombreEspecialidad
            // 
            this.nombreEspecialidad.AutoSize = true;
            this.nombreEspecialidad.Location = new System.Drawing.Point(59, 20);
            this.nombreEspecialidad.Name = "nombreEspecialidad";
            this.nombreEspecialidad.Size = new System.Drawing.Size(102, 13);
            this.nombreEspecialidad.TabIndex = 14;
            this.nombreEspecialidad.Text = "nombreEspecialidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Fecha del turno: ";
            // 
            // fechaTurno
            // 
            this.fechaTurno.AutoSize = true;
            this.fechaTurno.Location = new System.Drawing.Point(90, 34);
            this.fechaTurno.Name = "fechaTurno";
            this.fechaTurno.Size = new System.Drawing.Size(62, 13);
            this.fechaTurno.TabIndex = 63;
            this.fechaTurno.Text = "fechaTurno";
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 402);
            this.Controls.Add(this.asignarDiag);
            this.Controls.Add(this.nombreProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpHistoriaClinica);
            this.Controls.Add(this.gbDatos);
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gpHistoriaClinica.ResumeLayout(false);
            this.gpHistoriaClinica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label nombreAfi;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaAtencion;
        private System.Windows.Forms.GroupBox gpHistoriaClinica;
        private System.Windows.Forms.RichTextBox txtEnfermedad;
        private System.Windows.Forms.RichTextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreProf;
        private System.Windows.Forms.Button asignarDiag;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label fechaTurno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombreEspecialidad;
    }
}