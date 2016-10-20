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
            this.confirmar = new System.Windows.Forms.Button();
            this.nombreAfi = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.resultado = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.asignarDiag = new System.Windows.Forms.Button();
            this.nombreEspecialidad = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.RichTextBox();
            this.txtSintomas = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreProf = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.asignarDiagnostico = new System.Windows.Forms.Button();
            this.ausenciaConsulta = new System.Windows.Forms.Button();
            this.datos1 = new System.Windows.Forms.GroupBox();
            this.nombreAfi2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.resultado.SuspendLayout();
            this.datos1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.confirmar);
            this.gbDatos.Controls.Add(this.nombreAfi);
            this.gbDatos.Controls.Add(this.lbl2);
            this.gbDatos.Controls.Add(this.cmbHora);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.dtpFechaAtencion);
            this.gbDatos.Location = new System.Drawing.Point(12, 21);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(482, 119);
            this.gbDatos.TabIndex = 5;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Atención";
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(399, 64);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 62;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // nombreAfi
            // 
            this.nombreAfi.AutoSize = true;
            this.nombreAfi.Location = new System.Drawing.Point(56, 16);
            this.nombreAfi.Name = "nombreAfi";
            this.nombreAfi.Size = new System.Drawing.Size(35, 13);
            this.nombreAfi.TabIndex = 61;
            this.nombreAfi.Text = "label3";
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
            this.cmbHora.Location = new System.Drawing.Point(238, 67);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(144, 21);
            this.cmbHora.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 50);
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
            // resultado
            // 
            this.resultado.Controls.Add(this.cancelar);
            this.resultado.Controls.Add(this.asignarDiag);
            this.resultado.Controls.Add(this.nombreEspecialidad);
            this.resultado.Controls.Add(this.asd);
            this.resultado.Controls.Add(this.txtEnfermedad);
            this.resultado.Controls.Add(this.txtSintomas);
            this.resultado.Controls.Add(this.label5);
            this.resultado.Controls.Add(this.label4);
            this.resultado.Location = new System.Drawing.Point(15, 163);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(482, 212);
            this.resultado.TabIndex = 7;
            this.resultado.TabStop = false;
            this.resultado.Text = "Resultado";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(179, 168);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 67;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // asignarDiag
            // 
            this.asignarDiag.Location = new System.Drawing.Point(341, 168);
            this.asignarDiag.Name = "asignarDiag";
            this.asignarDiag.Size = new System.Drawing.Size(100, 29);
            this.asignarDiag.TabIndex = 10;
            this.asignarDiag.Text = "Asignar diagnostico";
            this.asignarDiag.UseVisualStyleBackColor = true;
            this.asignarDiag.Click += new System.EventHandler(this.asignarDiag_Click);
            // 
            // nombreEspecialidad
            // 
            this.nombreEspecialidad.AutoSize = true;
            this.nombreEspecialidad.Location = new System.Drawing.Point(77, 20);
            this.nombreEspecialidad.Name = "nombreEspecialidad";
            this.nombreEspecialidad.Size = new System.Drawing.Size(102, 13);
            this.nombreEspecialidad.TabIndex = 14;
            this.nombreEspecialidad.Text = "nombreEspecialidad";
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
            this.label3.Location = new System.Drawing.Point(12, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesional: ";
            // 
            // nombreProf
            // 
            this.nombreProf.AutoSize = true;
            this.nombreProf.Location = new System.Drawing.Point(83, 378);
            this.nombreProf.Name = "nombreProf";
            this.nombreProf.Size = new System.Drawing.Size(35, 13);
            this.nombreProf.TabIndex = 9;
            this.nombreProf.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha programada para el turno: ";
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(202, 43);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(195, 20);
            this.fecha2.TabIndex = 63;
            // 
            // asignarDiagnostico
            // 
            this.asignarDiagnostico.Location = new System.Drawing.Point(44, 75);
            this.asignarDiagnostico.Name = "asignarDiagnostico";
            this.asignarDiagnostico.Size = new System.Drawing.Size(131, 23);
            this.asignarDiagnostico.TabIndex = 64;
            this.asignarDiagnostico.Text = "Asignar diagnostico ";
            this.asignarDiagnostico.UseVisualStyleBackColor = true;
            this.asignarDiagnostico.Click += new System.EventHandler(this.asignarDiagnostico_Click);
            // 
            // ausenciaConsulta
            // 
            this.ausenciaConsulta.Location = new System.Drawing.Point(222, 75);
            this.ausenciaConsulta.Name = "ausenciaConsulta";
            this.ausenciaConsulta.Size = new System.Drawing.Size(174, 23);
            this.ausenciaConsulta.TabIndex = 65;
            this.ausenciaConsulta.Text = "Declarar ausencia a la consulta";
            this.ausenciaConsulta.UseVisualStyleBackColor = true;
            this.ausenciaConsulta.Click += new System.EventHandler(this.ausenciaConsulta_Click);
            // 
            // datos1
            // 
            this.datos1.Controls.Add(this.nombreAfi2);
            this.datos1.Controls.Add(this.label6);
            this.datos1.Controls.Add(this.label8);
            this.datos1.Controls.Add(this.ausenciaConsulta);
            this.datos1.Controls.Add(this.fecha2);
            this.datos1.Controls.Add(this.asignarDiagnostico);
            this.datos1.Location = new System.Drawing.Point(15, 21);
            this.datos1.Name = "datos1";
            this.datos1.Size = new System.Drawing.Size(479, 114);
            this.datos1.TabIndex = 66;
            this.datos1.TabStop = false;
            this.datos1.Text = "Datos Atención";
            // 
            // nombreAfi2
            // 
            this.nombreAfi2.AutoSize = true;
            this.nombreAfi2.Location = new System.Drawing.Point(91, 16);
            this.nombreAfi2.Name = "nombreAfi2";
            this.nombreAfi2.Size = new System.Drawing.Size(35, 13);
            this.nombreAfi2.TabIndex = 68;
            this.nombreAfi2.Text = "label3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Afiliado:";
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 415);
            this.Controls.Add(this.datos1);
            this.Controls.Add(this.nombreProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diagnostico";
            this.Text = "Diagnostico";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.resultado.ResumeLayout(false);
            this.resultado.PerformLayout();
            this.datos1.ResumeLayout(false);
            this.datos1.PerformLayout();
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
        private System.Windows.Forms.GroupBox resultado;
        private System.Windows.Forms.RichTextBox txtEnfermedad;
        private System.Windows.Forms.RichTextBox txtSintomas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nombreProf;
        private System.Windows.Forms.Button asignarDiag;
        private System.Windows.Forms.Label asd;
        private System.Windows.Forms.Label nombreEspecialidad;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button asignarDiagnostico;
        private System.Windows.Forms.Button ausenciaConsulta;
        private System.Windows.Forms.GroupBox datos1;
        private System.Windows.Forms.Label nombreAfi2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelar;
    }
}