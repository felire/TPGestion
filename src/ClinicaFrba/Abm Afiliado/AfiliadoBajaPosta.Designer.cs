namespace ClinicaFrba.Abm_Afiliado
{
    partial class AfiliadoBajaPosta
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
            this.cancelar = new System.Windows.Forms.Button();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textMotivo = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).BeginInit();
            this.filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaAfiliados
            // 
            this.listaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAfiliados.Location = new System.Drawing.Point(38, 162);
            this.listaAfiliados.MultiSelect = false;
            this.listaAfiliados.Name = "listaAfiliados";
            this.listaAfiliados.ReadOnly = true;
            this.listaAfiliados.Size = new System.Drawing.Size(577, 155);
            this.listaAfiliados.TabIndex = 4;
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.cancelar);
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
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(334, 107);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 30;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(86, 99);
            this.grupo.MaxLength = 3;
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(121, 20);
            this.grupo.TabIndex = 11;
            this.grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_grupof);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(471, 107);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(100, 29);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textMotivo);
            this.groupBox2.Controls.Add(this.eliminar);
            this.groupBox2.Location = new System.Drawing.Point(38, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 68);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motivo de Baja";
            // 
            // textMotivo
            // 
            this.textMotivo.Location = new System.Drawing.Point(32, 19);
            this.textMotivo.MaxLength = 400;
            this.textMotivo.Multiline = true;
            this.textMotivo.Name = "textMotivo";
            this.textMotivo.Size = new System.Drawing.Size(402, 38);
            this.textMotivo.TabIndex = 13;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(471, 28);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(100, 29);
            this.eliminar.TabIndex = 12;
            this.eliminar.Text = "Deshabilitar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // AfiliadoBajaPosta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listaAfiliados);
            this.Controls.Add(this.filtros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AfiliadoBajaPosta";
            this.Text = "Deshabilitar Afiliado";
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).EndInit();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textMotivo;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button cancelar;
    }
}