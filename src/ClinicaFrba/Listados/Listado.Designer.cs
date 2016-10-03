﻿namespace ClinicaFrba.Listados
{
    partial class Listado
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grilla1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grilla2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grilla3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grilla4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.grilla5 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.anio = new System.Windows.Forms.Label();
            this.semestreUno = new System.Windows.Forms.RadioButton();
            this.semestre2 = new System.Windows.Forms.RadioButton();
            this.listar = new System.Windows.Forms.Button();
            this.anioElegido = new System.Windows.Forms.ComboBox();
            this.filtro2 = new System.Windows.Forms.GroupBox();
            this.filtro3 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(2, 114);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(818, 314);
            this.tabControl.TabIndex = 0;
            this.tabControl.Tag = "E";
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.cambiaTab);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grilla1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(810, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Especialidades mas canceladas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grilla1
            // 
            this.grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla1.Location = new System.Drawing.Point(-4, 0);
            this.grilla1.Name = "grilla1";
            this.grilla1.Size = new System.Drawing.Size(818, 289);
            this.grilla1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grilla2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profesionales mas consultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grilla2
            // 
            this.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla2.Location = new System.Drawing.Point(0, 0);
            this.grilla2.Name = "grilla2";
            this.grilla2.Size = new System.Drawing.Size(810, 288);
            this.grilla2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grilla3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(810, 288);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profesionales con menos horas trabajadas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grilla3
            // 
            this.grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla3.Location = new System.Drawing.Point(-4, 0);
            this.grilla3.Name = "grilla3";
            this.grilla3.Size = new System.Drawing.Size(814, 325);
            this.grilla3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grilla4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(810, 288);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Afiliados con más bonos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grilla4
            // 
            this.grilla4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla4.Location = new System.Drawing.Point(-4, 0);
            this.grilla4.Name = "grilla4";
            this.grilla4.Size = new System.Drawing.Size(814, 292);
            this.grilla4.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.grilla5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(810, 288);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Especialidades más requeridas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // grilla5
            // 
            this.grilla5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla5.Location = new System.Drawing.Point(0, 0);
            this.grilla5.Name = "grilla5";
            this.grilla5.Size = new System.Drawing.Size(810, 292);
            this.grilla5.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // anio
            // 
            this.anio.AutoSize = true;
            this.anio.Location = new System.Drawing.Point(17, 47);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(29, 13);
            this.anio.TabIndex = 1;
            this.anio.Text = "Año:";
            // 
            // semestreUno
            // 
            this.semestreUno.AutoSize = true;
            this.semestreUno.Location = new System.Drawing.Point(204, 36);
            this.semestreUno.Name = "semestreUno";
            this.semestreUno.Size = new System.Drawing.Size(99, 17);
            this.semestreUno.TabIndex = 8;
            this.semestreUno.TabStop = true;
            this.semestreUno.Text = "Primer semestre";
            this.semestreUno.UseVisualStyleBackColor = true;
            this.semestreUno.CheckedChanged += new System.EventHandler(this.semestreUno_CheckedChanged);
            // 
            // semestre2
            // 
            this.semestre2.AutoSize = true;
            this.semestre2.Location = new System.Drawing.Point(204, 60);
            this.semestre2.Name = "semestre2";
            this.semestre2.Size = new System.Drawing.Size(113, 17);
            this.semestre2.TabIndex = 9;
            this.semestre2.TabStop = true;
            this.semestre2.Text = "Segundo semestre";
            this.semestre2.UseVisualStyleBackColor = true;
            this.semestre2.CheckedChanged += new System.EventHandler(this.semestre2_CheckedChanged);
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(364, 42);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(75, 23);
            this.listar.TabIndex = 10;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // anioElegido
            // 
            this.anioElegido.FormattingEnabled = true;
            this.anioElegido.Location = new System.Drawing.Point(52, 43);
            this.anioElegido.Name = "anioElegido";
            this.anioElegido.Size = new System.Drawing.Size(85, 21);
            this.anioElegido.TabIndex = 11;
            // 
            // filtro2
            // 
            this.filtro2.Location = new System.Drawing.Point(463, 12);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(353, 100);
            this.filtro2.TabIndex = 12;
            this.filtro2.TabStop = false;
            this.filtro2.Text = " Profesionales mas consultados";
            // 
            // filtro3
            // 
            this.filtro3.Location = new System.Drawing.Point(463, 12);
            this.filtro3.Name = "filtro3";
            this.filtro3.Size = new System.Drawing.Size(353, 100);
            this.filtro3.TabIndex = 0;
            this.filtro3.TabStop = false;
            this.filtro3.Text = "Profesionales con menos horas trabajadas";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 458);
            this.Controls.Add(this.filtro3);
            this.Controls.Add(this.filtro2);
            this.Controls.Add(this.anioElegido);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.semestre2);
            this.Controls.Add(this.semestreUno);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.tabControl);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilla5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView grilla1;
        private System.Windows.Forms.DataGridView grilla2;
        private System.Windows.Forms.DataGridView grilla3;
        private System.Windows.Forms.DataGridView grilla4;
        private System.Windows.Forms.DataGridView grilla5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.RadioButton semestre2;
        private System.Windows.Forms.RadioButton semestreUno;
        private System.Windows.Forms.Label anio;
        private System.Windows.Forms.ComboBox anioElegido;
        private System.Windows.Forms.GroupBox filtro3;
        private System.Windows.Forms.GroupBox filtro2;
    }
}