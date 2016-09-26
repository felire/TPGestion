namespace ClinicaFrba.Abm_Afiliado
{
    partial class Modificacion
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAF = new System.Windows.Forms.Label();
            this.textBoxAF = new System.Windows.Forms.TextBox();
            this.labelNM = new System.Windows.Forms.Label();
            this.buttonL = new System.Windows.Forms.Button();
            this.textBoxNM = new System.Windows.Forms.TextBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.labelAP = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxAP = new System.Windows.Forms.TextBox();
            this.labelGR = new System.Windows.Forms.Label();
            this.labelDN = new System.Windows.Forms.Label();
            this.textBoxDN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flag_elimina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_af_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hijos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 539);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar y modificar afiliado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAF);
            this.groupBox1.Controls.Add(this.textBoxAF);
            this.groupBox1.Controls.Add(this.labelNM);
            this.groupBox1.Controls.Add(this.buttonL);
            this.groupBox1.Controls.Add(this.textBoxNM);
            this.groupBox1.Controls.Add(this.buttonB);
            this.groupBox1.Controls.Add(this.labelAP);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxAP);
            this.groupBox1.Controls.Add(this.labelGR);
            this.groupBox1.Controls.Add(this.labelDN);
            this.groupBox1.Controls.Add(this.textBoxDN);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de búsqueda";
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
            this.textBoxAF.Location = new System.Drawing.Point(98, 31);
            this.textBoxAF.Name = "textBoxAF";
            this.textBoxAF.Size = new System.Drawing.Size(109, 20);
            this.textBoxAF.TabIndex = 1;
            // 
            // labelNM
            // 
            this.labelNM.AutoSize = true;
            this.labelNM.Location = new System.Drawing.Point(223, 24);
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
            this.labelAP.Location = new System.Drawing.Point(223, 50);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(44, 13);
            this.labelAP.TabIndex = 4;
            this.labelAP.Text = "Apellido";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBoxAP
            // 
            this.textBoxAP.Location = new System.Drawing.Point(292, 50);
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new System.Drawing.Size(165, 20);
            this.textBoxAP.TabIndex = 5;
            // 
            // labelGR
            // 
            this.labelGR.AutoSize = true;
            this.labelGR.Location = new System.Drawing.Point(223, 83);
            this.labelGR.Name = "labelGR";
            this.labelGR.Size = new System.Drawing.Size(36, 13);
            this.labelGR.TabIndex = 8;
            this.labelGR.Text = "Grupo";
            // 
            // labelDN
            // 
            this.labelDN.AutoSize = true;
            this.labelDN.Location = new System.Drawing.Point(8, 60);
            this.labelDN.Name = "labelDN";
            this.labelDN.Size = new System.Drawing.Size(74, 13);
            this.labelDN.TabIndex = 6;
            this.labelDN.Text = "Doc Identidad";
            // 
            // textBoxDN
            // 
            this.textBoxDN.Location = new System.Drawing.Point(98, 57);
            this.textBoxDN.Name = "textBoxDN";
            this.textBoxDN.Size = new System.Drawing.Size(109, 20);
            this.textBoxDN.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flag_elimina,
            this.Id_Grupo,
            this.Id_af_final,
            this.Nombre,
            this.Apellido,
            this.Tipo_doc,
            this.DNI,
            this.Dirección,
            this.Teléfono,
            this.Mail,
            this.Fecha_nacimiento,
            this.Sexo,
            this.Estado_civil,
            this.hijos,
            this.habilitado});
            this.dataGridView1.Location = new System.Drawing.Point(11, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(706, 243);
            this.dataGridView1.TabIndex = 13;
            // 
            // flag_elimina
            // 
            this.flag_elimina.HeaderText = "Seleccionar";
            this.flag_elimina.Name = "flag_elimina";
            // 
            // Id_Grupo
            // 
            this.Id_Grupo.HeaderText = "Número de grupo familiar";
            this.Id_Grupo.Name = "Id_Grupo";
            this.Id_Grupo.ReadOnly = true;
            // 
            // Id_af_final
            // 
            this.Id_af_final.HeaderText = "Número de afiliado";
            this.Id_af_final.Name = "Id_af_final";
            this.Id_af_final.ReadOnly = true;
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
            // Tipo_doc
            // 
            this.Tipo_doc.HeaderText = "Tipo_doc";
            this.Tipo_doc.Name = "Tipo_doc";
            this.Tipo_doc.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Dirección
            // 
            this.Dirección.HeaderText = "Dirección";
            this.Dirección.Name = "Dirección";
            // 
            // Teléfono
            // 
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // Fecha_nacimiento
            // 
            this.Fecha_nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_nacimiento.Name = "Fecha_nacimiento";
            this.Fecha_nacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Estado_civil
            // 
            this.Estado_civil.HeaderText = "Estado Civil";
            this.Estado_civil.Name = "Estado_civil";
            // 
            // hijos
            // 
            this.hijos.HeaderText = "Familiares a Cargo";
            this.hijos.Name = "hijos";
            // 
            // habilitado
            // 
            this.habilitado.HeaderText = "Habilitado";
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(593, 280);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(110, 35);
            this.seleccionar.TabIndex = 15;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seleccionar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(17, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 330);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un afiliado";
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 599);
            this.Controls.Add(this.groupBox3);
            this.Name = "Modificacion";
            this.Text = "Modificación de Afiliado";
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAF;
        private System.Windows.Forms.TextBox textBoxAF;
        private System.Windows.Forms.Label labelNM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.TextBox textBoxNM;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxAP;
        private System.Windows.Forms.Label labelGR;
        private System.Windows.Forms.Label labelDN;
        private System.Windows.Forms.TextBox textBoxDN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn flag_elimina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_af_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn hijos;
        private System.Windows.Forms.DataGridViewTextBoxColumn habilitado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button seleccionar;

    }
}