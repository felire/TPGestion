namespace ClinicaFrba.Abm_Afiliado
{
    partial class Logs
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
            this.listaAfiliados = new System.Windows.Forms.DataGridView();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.grupo = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verLogs = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreAfi = new System.Windows.Forms.Label();
            this.gridLogs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).BeginInit();
            this.filtros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAfiliados
            // 
            this.listaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAfiliados.Location = new System.Drawing.Point(38, 149);
            this.listaAfiliados.MultiSelect = false;
            this.listaAfiliados.Name = "listaAfiliados";
            this.listaAfiliados.ReadOnly = true;
            this.listaAfiliados.Size = new System.Drawing.Size(577, 155);
            this.listaAfiliados.TabIndex = 4;
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.grupo);
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Controls.Add(this.label5);
            this.filtros.Controls.Add(this.numeroDoc);
            this.filtros.Controls.Add(this.label4);
            this.filtros.Controls.Add(this.tipoDoc);
            this.filtros.Controls.Add(this.label3);
            this.filtros.Controls.Add(this.apellido);
            this.filtros.Controls.Add(this.label2);
            this.filtros.Controls.Add(this.nombre);
            this.filtros.Controls.Add(this.label1);
            this.filtros.Location = new System.Drawing.Point(38, 1);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(577, 142);
            this.filtros.TabIndex = 3;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(86, 99);
            this.grupo.MaxLength = 100;
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(121, 20);
            this.grupo.TabIndex = 5;
            this.grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_grupoF);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grupo familiar:";
            // 
            // numeroDoc
            // 
            this.numeroDoc.Location = new System.Drawing.Point(309, 58);
            this.numeroDoc.MaxLength = 8;
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.Size = new System.Drawing.Size(115, 20);
            this.numeroDoc.TabIndex = 7;
            this.numeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_doc);
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
            this.apellido.MaxLength = 255;
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
            this.nombre.MaxLength = 255;
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
            // verLogs
            // 
            this.verLogs.Location = new System.Drawing.Point(38, 333);
            this.verLogs.Name = "verLogs";
            this.verLogs.Size = new System.Drawing.Size(100, 29);
            this.verLogs.TabIndex = 16;
            this.verLogs.Text = "Ver Logs";
            this.verLogs.UseVisualStyleBackColor = true;
            this.verLogs.Click += new System.EventHandler(this.modificar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(509, 649);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 29;
            this.cancelar.Text = "Salir";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreAfi);
            this.groupBox1.Controls.Add(this.gridLogs);
            this.groupBox1.Location = new System.Drawing.Point(32, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 230);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // nombreAfi
            // 
            this.nombreAfi.AutoSize = true;
            this.nombreAfi.Location = new System.Drawing.Point(6, 20);
            this.nombreAfi.Name = "nombreAfi";
            this.nombreAfi.Size = new System.Drawing.Size(76, 13);
            this.nombreAfi.TabIndex = 1;
            this.nombreAfi.Text = "nombreAfiliado";
            // 
            // gridLogs
            // 
            this.gridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLogs.Location = new System.Drawing.Point(6, 56);
            this.gridLogs.Name = "gridLogs";
            this.gridLogs.Size = new System.Drawing.Size(571, 168);
            this.gridLogs.TabIndex = 0;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.verLogs);
            this.Controls.Add(this.listaAfiliados);
            this.Controls.Add(this.filtros);
            this.Name = "Logs";
            this.Text = "ElegirAfiliado";
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).EndInit();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaAfiliados;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numeroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grupo;
        private System.Windows.Forms.Button verLogs;
        private System.Windows.Forms.Button habilitar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridLogs;
        private System.Windows.Forms.Label nombreAfi;
    }
}