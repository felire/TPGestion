﻿namespace ClinicaFrba.AbmRol
{
    partial class AltaRol
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
            this.nombreRol = new System.Windows.Forms.Label();
            this.nombreElegido = new System.Windows.Forms.TextBox();
            this.funcionalidadesAgregables = new System.Windows.Forms.ListView();
            this.agregarFun = new System.Windows.Forms.Button();
            this.quitarFun = new System.Windows.Forms.Button();
            this.funcionalidadesAgregadas = new System.Windows.Forms.ListView();
            this.agregarRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreRol
            // 
            this.nombreRol.AutoSize = true;
            this.nombreRol.Location = new System.Drawing.Point(12, 24);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(81, 13);
            this.nombreRol.TabIndex = 0;
            this.nombreRol.Text = "Nombre de Rol:";
            // 
            // nombreElegido
            // 
            this.nombreElegido.Location = new System.Drawing.Point(99, 21);
            this.nombreElegido.MaxLength = 20;
            this.nombreElegido.Name = "nombreElegido";
            this.nombreElegido.Size = new System.Drawing.Size(217, 20);
            this.nombreElegido.TabIndex = 1;
            // 
            // funcionalidadesAgregables
            // 
            this.funcionalidadesAgregables.Location = new System.Drawing.Point(12, 70);
            this.funcionalidadesAgregables.Name = "funcionalidadesAgregables";
            this.funcionalidadesAgregables.Size = new System.Drawing.Size(232, 211);
            this.funcionalidadesAgregables.TabIndex = 2;
            this.funcionalidadesAgregables.UseCompatibleStateImageBehavior = false;
            this.funcionalidadesAgregables.View = System.Windows.Forms.View.List;
            // 
            // agregarFun
            // 
            this.agregarFun.Location = new System.Drawing.Point(283, 96);
            this.agregarFun.Name = "agregarFun";
            this.agregarFun.Size = new System.Drawing.Size(33, 35);
            this.agregarFun.TabIndex = 3;
            this.agregarFun.Text = ">";
            this.agregarFun.UseVisualStyleBackColor = true;
            this.agregarFun.Click += new System.EventHandler(this.agregarFun_Click);
            // 
            // quitarFun
            // 
            this.quitarFun.Location = new System.Drawing.Point(283, 200);
            this.quitarFun.Name = "quitarFun";
            this.quitarFun.Size = new System.Drawing.Size(33, 35);
            this.quitarFun.TabIndex = 4;
            this.quitarFun.Text = "<";
            this.quitarFun.UseVisualStyleBackColor = true;
            this.quitarFun.Click += new System.EventHandler(this.quitarFun_Click);
            // 
            // funcionalidadesAgregadas
            // 
            this.funcionalidadesAgregadas.Location = new System.Drawing.Point(352, 70);
            this.funcionalidadesAgregadas.Name = "funcionalidadesAgregadas";
            this.funcionalidadesAgregadas.Size = new System.Drawing.Size(231, 211);
            this.funcionalidadesAgregadas.TabIndex = 5;
            this.funcionalidadesAgregadas.UseCompatibleStateImageBehavior = false;
            this.funcionalidadesAgregadas.View = System.Windows.Forms.View.List;
            // 
            // agregarRol
            // 
            this.agregarRol.Location = new System.Drawing.Point(352, 305);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(100, 29);
            this.agregarRol.TabIndex = 6;
            this.agregarRol.Text = "Agregar Rol";
            this.agregarRol.UseVisualStyleBackColor = true;
            this.agregarRol.Click += new System.EventHandler(this.agregarRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Funcionalidades disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Funcionalidades agregadas:";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(144, 305);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 29;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 351);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarRol);
            this.Controls.Add(this.funcionalidadesAgregadas);
            this.Controls.Add(this.quitarFun);
            this.Controls.Add(this.agregarFun);
            this.Controls.Add(this.funcionalidadesAgregables);
            this.Controls.Add(this.nombreElegido);
            this.Controls.Add(this.nombreRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRol";
            this.Text = "Crear Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreRol;
        private System.Windows.Forms.TextBox nombreElegido;
        private System.Windows.Forms.ListView funcionalidadesAgregables;
        private System.Windows.Forms.Button agregarFun;
        private System.Windows.Forms.Button quitarFun;
        private System.Windows.Forms.ListView funcionalidadesAgregadas;
        private System.Windows.Forms.Button agregarRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
    }
}