namespace ClinicaFrba.Abm_Afiliado
{
    partial class Cambios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAF = new System.Windows.Forms.Label();
            this.textBoxAF = new System.Windows.Forms.TextBox();
            this.labelNM = new System.Windows.Forms.Label();
            this.buttonL = new System.Windows.Forms.Button();
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.labelAP = new System.Windows.Forms.Label();
            this.comboBoxTdoc = new System.Windows.Forms.ComboBox();
            this.textBoxAP = new System.Windows.Forms.TextBox();
            this.labelGR = new System.Windows.Forms.Label();
            this.labelDN = new System.Windows.Forms.Label();
            this.textBoxDN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelAF);
            this.groupBox1.Controls.Add(this.textBoxAF);
            this.groupBox1.Controls.Add(this.labelNM);
            this.groupBox1.Controls.Add(this.buttonL);
            this.groupBox1.Controls.Add(this.textBoxNM);
            this.groupBox1.Controls.Add(this.buttonB);
            this.groupBox1.Controls.Add(this.labelAP);
            this.groupBox1.Controls.Add(this.comboBoxTdoc);
            this.groupBox1.Controls.Add(this.textBoxAP);
            this.groupBox1.Controls.Add(this.labelGR);
            this.groupBox1.Controls.Add(this.labelDN);
            this.groupBox1.Controls.Add(this.textBoxDN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha Hasta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 13;
            // 
            // labelAF
            // 
            this.labelAF.AutoSize = true;
            this.labelAF.Location = new System.Drawing.Point(29, 31);
            this.labelAF.Name = "labelAF";
            this.labelAF.Size = new System.Drawing.Size(53, 13);
            this.labelAF.TabIndex = 0;
            this.labelAF.Text = "Id Afiliado";
            // 
            // textBoxAF
            // 
            this.textBoxAF.Location = new System.Drawing.Point(106, 31);
            this.textBoxAF.MaxLength = 5;
            this.textBoxAF.Name = "textBoxAF";
            this.textBoxAF.Size = new System.Drawing.Size(109, 20);
            this.textBoxAF.TabIndex = 1;
            this.textBoxAF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_id);
            // 
            // labelNM
            // 
            this.labelNM.AutoSize = true;
            this.labelNM.Location = new System.Drawing.Point(242, 24);
            this.labelNM.Name = "labelNM";
            this.labelNM.Size = new System.Drawing.Size(44, 13);
            this.labelNM.TabIndex = 2;
            this.labelNM.Text = "Nombre";
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(533, 80);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(110, 35);
            this.buttonL.TabIndex = 11;
            this.buttonL.Text = "Limpiar";
            this.buttonL.UseVisualStyleBackColor = true;
            // 
            // textBoxNM
            // 
            this.textBoxNM.Location = new System.Drawing.Point(292, 24);
            this.textBoxNM.MaxLength = 255;
            this.textBoxNM.Name = "textBoxNM";
            this.textBoxNM.Size = new System.Drawing.Size(165, 20);
            this.textBoxNM.TabIndex = 3;
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(533, 23);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(110, 35);
            this.buttonB.TabIndex = 10;
            this.buttonB.Text = "Buscar";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.Location = new System.Drawing.Point(242, 50);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(44, 13);
            this.labelAP.TabIndex = 4;
            this.labelAP.Text = "Apellido";
            // 
            // comboBoxTdoc
            // 
            this.comboBoxTdoc.FormattingEnabled = true;
            this.comboBoxTdoc.Location = new System.Drawing.Point(292, 80);
            this.comboBoxTdoc.Name = "comboBoxTdoc";
            this.comboBoxTdoc.Size = new System.Drawing.Size(165, 21);
            this.comboBoxTdoc.TabIndex = 9;
            // 
            // textBoxAP
            // 
            this.textBoxAP.Location = new System.Drawing.Point(292, 50);
            this.textBoxAP.MaxLength = 255;
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new System.Drawing.Size(165, 20);
            this.textBoxAP.TabIndex = 5;
            // 
            // labelGR
            // 
            this.labelGR.AutoSize = true;
            this.labelGR.Location = new System.Drawing.Point(242, 83);
            this.labelGR.Name = "labelGR";
            this.labelGR.Size = new System.Drawing.Size(28, 13);
            this.labelGR.TabIndex = 8;
            this.labelGR.Text = "Tipo";
            this.labelGR.Click += new System.EventHandler(this.labelGR_Click);
            // 
            // labelDN
            // 
            this.labelDN.AutoSize = true;
            this.labelDN.Location = new System.Drawing.Point(29, 57);
            this.labelDN.Name = "labelDN";
            this.labelDN.Size = new System.Drawing.Size(71, 13);
            this.labelDN.TabIndex = 6;
            this.labelDN.Text = "Fecha Desde";
            // 
            // textBoxDN
            // 
            this.textBoxDN.Location = new System.Drawing.Point(106, 54);
            this.textBoxDN.Name = "textBoxDN";
            this.textBoxDN.Size = new System.Drawing.Size(109, 20);
            this.textBoxDN.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.fecha,
            this.Tipo,
            this.descripcion,
            this.estado});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 241);
            this.dataGridView1.TabIndex = 16;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id de Afiliado";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado Actual";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 266);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del log";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(721, 443);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 29);
            this.salir.TabIndex = 29;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 484);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cambios";
            this.Text = "Registro de Cambios";
            this.Load += new System.EventHandler(this.FormCambios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAF;
        private System.Windows.Forms.TextBox textBoxAF;
        private System.Windows.Forms.Label labelNM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.ComboBox comboBoxTdoc;
        private System.Windows.Forms.TextBox textBoxAP;
        private System.Windows.Forms.Label labelGR;
        private System.Windows.Forms.Label labelDN;
        private System.Windows.Forms.TextBox textBoxDN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button salir;
    }
}