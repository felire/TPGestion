namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegAgendaMedico
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
            this.rangoFechas = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.confirmarRango = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fechaHasta = new System.Windows.Forms.DateTimePicker();
            this.fechaDesde = new System.Windows.Forms.DateTimePicker();
            this.confirmar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.horarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.especialidades = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.horaHasta = new System.Windows.Forms.ComboBox();
            this.horaDesde = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aceptar = new System.Windows.Forms.Button();
            this.nombreProfesional = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rangoFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangoFechas
            // 
            this.rangoFechas.Controls.Add(this.cancelar);
            this.rangoFechas.Controls.Add(this.confirmarRango);
            this.rangoFechas.Controls.Add(this.label6);
            this.rangoFechas.Controls.Add(this.label5);
            this.rangoFechas.Controls.Add(this.fechaHasta);
            this.rangoFechas.Controls.Add(this.fechaDesde);
            this.rangoFechas.Location = new System.Drawing.Point(15, 355);
            this.rangoFechas.Name = "rangoFechas";
            this.rangoFechas.Size = new System.Drawing.Size(558, 144);
            this.rangoFechas.TabIndex = 14;
            this.rangoFechas.TabStop = false;
            this.rangoFechas.Text = "Registrar Rango de Fechas";
            this.rangoFechas.Visible = false;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(305, 109);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 31;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // confirmarRango
            // 
            this.confirmarRango.Location = new System.Drawing.Point(452, 109);
            this.confirmarRango.Name = "confirmarRango";
            this.confirmarRango.Size = new System.Drawing.Size(100, 29);
            this.confirmarRango.TabIndex = 4;
            this.confirmarRango.Text = "Confirmar";
            this.confirmarRango.UseVisualStyleBackColor = true;
            this.confirmarRango.Click += new System.EventHandler(this.confirmarRango_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Desde:";
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(246, 71);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(200, 20);
            this.fechaHasta.TabIndex = 1;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(246, 35);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(200, 20);
            this.fechaDesde.TabIndex = 0;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(396, 301);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(100, 29);
            this.confirmar.TabIndex = 13;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(116, 301);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(100, 29);
            this.eliminar.TabIndex = 12;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // horarios
            // 
            this.horarios.AllowUserToAddRows = false;
            this.horarios.AllowUserToDeleteRows = false;
            this.horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horarios.Location = new System.Drawing.Point(15, 142);
            this.horarios.Name = "horarios";
            this.horarios.Size = new System.Drawing.Size(558, 150);
            this.horarios.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.especialidades);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.horaHasta);
            this.groupBox1.Controls.Add(this.horaDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Location = new System.Drawing.Point(15, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 108);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Dias y Horarios";
            // 
            // especialidades
            // 
            this.especialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidades.FormattingEnabled = true;
            this.especialidades.Location = new System.Drawing.Point(425, 31);
            this.especialidades.Name = "especialidades";
            this.especialidades.Size = new System.Drawing.Size(121, 21);
            this.especialidades.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Especialidad:";
            // 
            // horaHasta
            // 
            this.horaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaHasta.FormattingEnabled = true;
            this.horaHasta.Location = new System.Drawing.Point(291, 31);
            this.horaHasta.Name = "horaHasta";
            this.horaHasta.Size = new System.Drawing.Size(102, 21);
            this.horaHasta.TabIndex = 12;
            // 
            // horaDesde
            // 
            this.horaDesde.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.horaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horaDesde.FormattingEnabled = true;
            this.horaDesde.Location = new System.Drawing.Point(174, 32);
            this.horaDesde.Name = "horaDesde";
            this.horaDesde.Size = new System.Drawing.Size(102, 21);
            this.horaDesde.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hora Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora Desde:";
            // 
            // dias
            // 
            this.dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dias.FormattingEnabled = true;
            this.dias.Location = new System.Drawing.Point(7, 33);
            this.dias.Name = "dias";
            this.dias.Size = new System.Drawing.Size(121, 21);
            this.dias.TabIndex = 8;
            this.dias.SelectedIndexChanged += new System.EventHandler(this.cambiarHorasDia);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Día:";
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(446, 58);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(100, 29);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Agregar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // nombreProfesional
            // 
            this.nombreProfesional.AutoSize = true;
            this.nombreProfesional.Location = new System.Drawing.Point(143, 12);
            this.nombreProfesional.Name = "nombreProfesional";
            this.nombreProfesional.Size = new System.Drawing.Size(35, 13);
            this.nombreProfesional.TabIndex = 9;
            this.nombreProfesional.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Profesional:";
            // 
            // RegAgendaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 511);
            this.Controls.Add(this.rangoFechas);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.horarios);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nombreProfesional);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegAgendaMedico";
            this.Text = "Registrar Agenda";
            this.rangoFechas.ResumeLayout(false);
            this.rangoFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rangoFechas;
        private System.Windows.Forms.Button confirmarRango;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fechaHasta;
        private System.Windows.Forms.DateTimePicker fechaDesde;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.DataGridView horarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox especialidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox horaHasta;
        private System.Windows.Forms.ComboBox horaDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label nombreProfesional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelar;
    }
}