namespace ClinicaFrba.AbmRol
{
    partial class ModificarFuncionalidadesRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarRol = new System.Windows.Forms.Button();
            this.funcionalidadesAgregadas = new System.Windows.Forms.ListView();
            this.quitarFun = new System.Windows.Forms.Button();
            this.agregarFun = new System.Windows.Forms.Button();
            this.funcionalidadesAgregables = new System.Windows.Forms.ListView();
            this.nombreRol = new System.Windows.Forms.Label();
            this.nombreDeRol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Funcionalidades agregadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Funcionalidades disponibles:";
            // 
            // agregarRol
            // 
            this.agregarRol.Location = new System.Drawing.Point(91, 282);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(427, 47);
            this.agregarRol.TabIndex = 15;
            this.agregarRol.Text = "Guardar cambios";
            this.agregarRol.UseVisualStyleBackColor = true;
            this.agregarRol.Click += new System.EventHandler(this.agregarRol_Click);
            // 
            // funcionalidadesAgregadas
            // 
            this.funcionalidadesAgregadas.Location = new System.Drawing.Point(352, 65);
            this.funcionalidadesAgregadas.Name = "funcionalidadesAgregadas";
            this.funcionalidadesAgregadas.Size = new System.Drawing.Size(231, 211);
            this.funcionalidadesAgregadas.TabIndex = 14;
            this.funcionalidadesAgregadas.UseCompatibleStateImageBehavior = false;
            this.funcionalidadesAgregadas.View = System.Windows.Forms.View.List;
            // 
            // quitarFun
            // 
            this.quitarFun.Location = new System.Drawing.Point(283, 195);
            this.quitarFun.Name = "quitarFun";
            this.quitarFun.Size = new System.Drawing.Size(33, 35);
            this.quitarFun.TabIndex = 13;
            this.quitarFun.Text = "<";
            this.quitarFun.UseVisualStyleBackColor = true;
            this.quitarFun.Click += new System.EventHandler(this.quitarFun_Click);
            // 
            // agregarFun
            // 
            this.agregarFun.Location = new System.Drawing.Point(283, 91);
            this.agregarFun.Name = "agregarFun";
            this.agregarFun.Size = new System.Drawing.Size(33, 35);
            this.agregarFun.TabIndex = 12;
            this.agregarFun.Text = ">";
            this.agregarFun.UseVisualStyleBackColor = true;
            this.agregarFun.Click += new System.EventHandler(this.agregarFun_Click);
            // 
            // funcionalidadesAgregables
            // 
            this.funcionalidadesAgregables.Location = new System.Drawing.Point(12, 65);
            this.funcionalidadesAgregables.Name = "funcionalidadesAgregables";
            this.funcionalidadesAgregables.Size = new System.Drawing.Size(232, 211);
            this.funcionalidadesAgregables.TabIndex = 11;
            this.funcionalidadesAgregables.UseCompatibleStateImageBehavior = false;
            this.funcionalidadesAgregables.View = System.Windows.Forms.View.List;
            // 
            // nombreRol
            // 
            this.nombreRol.AutoSize = true;
            this.nombreRol.Location = new System.Drawing.Point(12, 19);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(81, 13);
            this.nombreRol.TabIndex = 9;
            this.nombreRol.Text = "Nombre de Rol:";
            // 
            // nombreDeRol
            // 
            this.nombreDeRol.AutoSize = true;
            this.nombreDeRol.Location = new System.Drawing.Point(100, 19);
            this.nombreDeRol.Name = "nombreDeRol";
            this.nombreDeRol.Size = new System.Drawing.Size(0, 13);
            this.nombreDeRol.TabIndex = 18;
            // 
            // ModificarFuncionalidadesRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 350);
            this.Controls.Add(this.nombreDeRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agregarRol);
            this.Controls.Add(this.funcionalidadesAgregadas);
            this.Controls.Add(this.quitarFun);
            this.Controls.Add(this.agregarFun);
            this.Controls.Add(this.funcionalidadesAgregables);
            this.Controls.Add(this.nombreRol);
            this.Name = "ModificarFuncionalidadesRol";
            this.Text = "ModificarFuncionalidadesRol";
            this.Load += new System.EventHandler(this.ModificarFuncionalidadesRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarRol;
        private System.Windows.Forms.ListView funcionalidadesAgregadas;
        private System.Windows.Forms.Button quitarFun;
        private System.Windows.Forms.Button agregarFun;
        private System.Windows.Forms.ListView funcionalidadesAgregables;
        private System.Windows.Forms.Label nombreRol;
        private System.Windows.Forms.Label nombreDeRol;

    }
}