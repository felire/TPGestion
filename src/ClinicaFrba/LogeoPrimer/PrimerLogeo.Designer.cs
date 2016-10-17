namespace ClinicaFrba.LogeoPrimer
{
    partial class PrimerLogeo
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.passNueva = new System.Windows.Forms.Label();
            this.passNuevaRepe = new System.Windows.Forms.Label();
            this.passNuevaT = new System.Windows.Forms.TextBox();
            this.passRepeT = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.Location = new System.Drawing.Point(60, 13);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.nombreUsuario.TabIndex = 1;
            this.nombreUsuario.Text = "label2";
            // 
            // passNueva
            // 
            this.passNueva.AutoSize = true;
            this.passNueva.Location = new System.Drawing.Point(29, 70);
            this.passNueva.Name = "passNueva";
            this.passNueva.Size = new System.Drawing.Size(100, 13);
            this.passNueva.TabIndex = 2;
            this.passNueva.Text = "Contraseña nueva: ";
            // 
            // passNuevaRepe
            // 
            this.passNuevaRepe.AutoSize = true;
            this.passNuevaRepe.Location = new System.Drawing.Point(13, 116);
            this.passNuevaRepe.Name = "passNuevaRepe";
            this.passNuevaRepe.Size = new System.Drawing.Size(113, 13);
            this.passNuevaRepe.TabIndex = 3;
            this.passNuevaRepe.Text = "Confirmar contraseña: ";
            // 
            // passNuevaT
            // 
            this.passNuevaT.Location = new System.Drawing.Point(133, 70);
            this.passNuevaT.MaxLength = 100;
            this.passNuevaT.Name = "passNuevaT";
            this.passNuevaT.PasswordChar = '•';
            this.passNuevaT.ShortcutsEnabled = false;
            this.passNuevaT.Size = new System.Drawing.Size(131, 20);
            this.passNuevaT.TabIndex = 4;
            // 
            // passRepeT
            // 
            this.passRepeT.Location = new System.Drawing.Point(133, 113);
            this.passRepeT.MaxLength = 100;
            this.passRepeT.Name = "passRepeT";
            this.passRepeT.PasswordChar = '•';
            this.passRepeT.ShortcutsEnabled = false;
            this.passRepeT.Size = new System.Drawing.Size(131, 20);
            this.passRepeT.TabIndex = 5;
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(133, 162);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(131, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Text = "Aceptar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Es la primera vez que entra al sistema, elija su contraseña:";
            // 
            // PrimerLogeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.passRepeT);
            this.Controls.Add(this.passNuevaT);
            this.Controls.Add(this.passNuevaRepe);
            this.Controls.Add(this.passNueva);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label1);
            this.Name = "PrimerLogeo";
            this.Text = "PrimerL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label passNueva;
        private System.Windows.Forms.Label passNuevaRepe;
        private System.Windows.Forms.TextBox passNuevaT;
        private System.Windows.Forms.TextBox passRepeT;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label label2;
    }
}