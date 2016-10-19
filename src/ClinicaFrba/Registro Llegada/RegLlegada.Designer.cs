﻿namespace ClinicaFrba.Registro_Llegada
{
    partial class RegLlegada
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
            this.elegir = new System.Windows.Forms.Button();
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
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).BeginInit();
            this.filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // elegir
            // 
            this.elegir.Location = new System.Drawing.Point(489, 342);
            this.elegir.Name = "elegir";
            this.elegir.Size = new System.Drawing.Size(100, 29);
            this.elegir.TabIndex = 8;
            this.elegir.Text = "Seleccionar";
            this.elegir.UseVisualStyleBackColor = true;
            this.elegir.Click += new System.EventHandler(this.seleccinar_Click);
            // 
            // listaAfiliados
            // 
            this.listaAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaAfiliados.Location = new System.Drawing.Point(12, 160);
            this.listaAfiliados.MultiSelect = false;
            this.listaAfiliados.Name = "listaAfiliados";
            this.listaAfiliados.ReadOnly = true;
            this.listaAfiliados.Size = new System.Drawing.Size(577, 155);
            this.listaAfiliados.TabIndex = 7;
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
            this.filtros.Location = new System.Drawing.Point(12, 12);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(577, 142);
            this.filtros.TabIndex = 6;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // grupo
            // 
            this.grupo.Location = new System.Drawing.Point(86, 99);
            this.grupo.MaxLength = 20;
            this.grupo.Name = "grupo";
            this.grupo.Size = new System.Drawing.Size(121, 20);
            this.grupo.TabIndex = 11;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(309, 91);
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
            this.numeroDoc.MaxLength = 13;
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
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(321, 342);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 31;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // RegLlegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 403);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.elegir);
            this.Controls.Add(this.listaAfiliados);
            this.Controls.Add(this.filtros);
            this.Name = "RegLlegada";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaAfiliados)).EndInit();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button elegir;
        private System.Windows.Forms.DataGridView listaAfiliados;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.TextBox grupo;
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
        private System.Windows.Forms.Button cancelar;
    }
}