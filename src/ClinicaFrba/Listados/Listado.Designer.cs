namespace ClinicaFrba.Listados
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
            this.comboBoxEspecialidades = new System.Windows.Forms.ComboBox();
            this.filtroEspecialidad = new System.Windows.Forms.GroupBox();
            this.filtrarEspYPlan = new System.Windows.Forms.GroupBox();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.comboBoxEspecialidad2 = new System.Windows.Forms.ComboBox();
            this.salir = new System.Windows.Forms.Button();
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
            this.filtroEspecialidad.SuspendLayout();
            this.filtrarEspYPlan.SuspendLayout();
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
            this.grilla3.Size = new System.Drawing.Size(814, 310);
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
            // comboBoxEspecialidades
            // 
            this.comboBoxEspecialidades.FormattingEnabled = true;
            this.comboBoxEspecialidades.Location = new System.Drawing.Point(16, 35);
            this.comboBoxEspecialidades.Name = "comboBoxEspecialidades";
            this.comboBoxEspecialidades.Size = new System.Drawing.Size(203, 21);
            this.comboBoxEspecialidades.TabIndex = 0;
            this.comboBoxEspecialidades.Text = "Especialidad";
            // 
            // filtroEspecialidad
            // 
            this.filtroEspecialidad.Controls.Add(this.comboBoxEspecialidades);
            this.filtroEspecialidad.Location = new System.Drawing.Point(532, 8);
            this.filtroEspecialidad.Name = "filtroEspecialidad";
            this.filtroEspecialidad.Size = new System.Drawing.Size(237, 100);
            this.filtroEspecialidad.TabIndex = 0;
            this.filtroEspecialidad.TabStop = false;
            this.filtroEspecialidad.Text = "Filtrar Especialidad";
            // 
            // filtrarEspYPlan
            // 
            this.filtrarEspYPlan.Controls.Add(this.comboBoxPlan);
            this.filtrarEspYPlan.Controls.Add(this.comboBoxEspecialidad2);
            this.filtrarEspYPlan.Location = new System.Drawing.Point(532, 8);
            this.filtrarEspYPlan.Name = "filtrarEspYPlan";
            this.filtrarEspYPlan.Size = new System.Drawing.Size(237, 100);
            this.filtrarEspYPlan.TabIndex = 12;
            this.filtrarEspYPlan.TabStop = false;
            this.filtrarEspYPlan.Text = "Filtrar Especialidad y Plan";
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Location = new System.Drawing.Point(16, 63);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(203, 21);
            this.comboBoxPlan.TabIndex = 1;
            this.comboBoxPlan.Text = "Plan";
            // 
            // comboBoxEspecialidad2
            // 
            this.comboBoxEspecialidad2.FormattingEnabled = true;
            this.comboBoxEspecialidad2.Location = new System.Drawing.Point(16, 28);
            this.comboBoxEspecialidad2.Name = "comboBoxEspecialidad2";
            this.comboBoxEspecialidad2.Size = new System.Drawing.Size(203, 21);
            this.comboBoxEspecialidad2.TabIndex = 0;
            this.comboBoxEspecialidad2.Text = "Especialidad";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(716, 434);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 29);
            this.salir.TabIndex = 30;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(840, 468);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.filtrarEspYPlan);
            this.Controls.Add(this.anioElegido);
            this.Controls.Add(this.filtroEspecialidad);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.semestre2);
            this.Controls.Add(this.semestreUno);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.filtroEspecialidad.ResumeLayout(false);
            this.filtrarEspYPlan.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBoxEspecialidades;
        private System.Windows.Forms.GroupBox filtroEspecialidad;
        private System.Windows.Forms.GroupBox filtrarEspYPlan;
        private System.Windows.Forms.ComboBox comboBoxPlan;
        private System.Windows.Forms.ComboBox comboBoxEspecialidad2;
        private System.Windows.Forms.Button salir;
    }
}