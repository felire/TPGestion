﻿namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class SeleccionarProfesional
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
            this.filtros = new System.Windows.Forms.GroupBox();
            this.buscar = new System.Windows.Forms.Button();
            this.comboEspecialidades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listaProfesionales = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProfesionales)).BeginInit();
            this.SuspendLayout();
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Controls.Add(this.comboEspecialidades);
            this.filtros.Controls.Add(this.label5);
            this.filtros.Controls.Add(this.numeroDoc);
            this.filtros.Controls.Add(this.label4);
            this.filtros.Controls.Add(this.tipoDoc);
            this.filtros.Controls.Add(this.label3);
            this.filtros.Controls.Add(this.apellido);
            this.filtros.Controls.Add(this.label2);
            this.filtros.Controls.Add(this.nombre);
            this.filtros.Controls.Add(this.label1);
            this.filtros.Location = new System.Drawing.Point(40, 26);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(521, 142);
            this.filtros.TabIndex = 0;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(309, 97);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(115, 23);
            this.buscar.TabIndex = 10;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // comboEspecialidades
            // 
            this.comboEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEspecialidades.FormattingEnabled = true;
            this.comboEspecialidades.Location = new System.Drawing.Point(86, 100);
            this.comboEspecialidades.Name = "comboEspecialidades";
            this.comboEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.comboEspecialidades.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Especialidad:";
            // 
            // numeroDoc
            // 
            this.numeroDoc.Location = new System.Drawing.Point(309, 58);
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.Size = new System.Drawing.Size(115, 20);
            this.numeroDoc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero:";
            // 
            // tipoDoc
            // 
            this.tipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoDoc.FormattingEnabled = true;
            this.tipoDoc.Location = new System.Drawing.Point(86, 57);
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.Size = new System.Drawing.Size(121, 21);
            this.tipoDoc.TabIndex = 5;
            this.tipoDoc.SelectedIndexChanged += new System.EventHandler(this.tipoDoc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo: ";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(309, 22);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(115, 20);
            this.apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(86, 17);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(121, 20);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // listaProfesionales
            // 
            this.listaProfesionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProfesionales.Location = new System.Drawing.Point(40, 174);
            this.listaProfesionales.Name = "listaProfesionales";
            this.listaProfesionales.Size = new System.Drawing.Size(521, 155);
            this.listaProfesionales.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(521, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Registrar Agenda Profesional";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SeleccionarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 393);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listaProfesionales);
            this.Controls.Add(this.filtros);
            this.Name = "SeleccionarProfesional";
            this.Text = "SeleccionarProfesional";
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaProfesionales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.ComboBox comboEspecialidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numeroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridView listaProfesionales;
        private System.Windows.Forms.Button button2;
    }
}