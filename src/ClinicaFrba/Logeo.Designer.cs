namespace ClinicaFrba
{
    partial class Logeo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.logearse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hola2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hola3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logearse
            // 
            this.logearse.Location = new System.Drawing.Point(120, 170);
            this.logearse.Name = "logearse";
            this.logearse.Size = new System.Drawing.Size(117, 46);
            this.logearse.TabIndex = 0;
            this.logearse.Text = "Logearse";
            this.logearse.UseVisualStyleBackColor = true;
            this.logearse.Click += new System.EventHandler(this.logeoAccion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña: ";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(123, 76);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(137, 20);
            this.userName.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(123, 120);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(137, 20);
            this.password.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holaToolStripMenuItem,
            this.hola2ToolStripMenuItem,
            this.hola3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            this.holaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.holaToolStripMenuItem.Text = "Hola";
            // 
            // hola2ToolStripMenuItem
            // 
            this.hola2ToolStripMenuItem.Name = "hola2ToolStripMenuItem";
            this.hola2ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hola2ToolStripMenuItem.Text = "Hola2";
            // 
            // hola3ToolStripMenuItem
            // 
            this.hola3ToolStripMenuItem.Name = "hola3ToolStripMenuItem";
            this.hola3ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hola3ToolStripMenuItem.Text = "Hola3";
            // 
            // Logeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logearse);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Logeo";
            this.Text = "Logeo";
            this.Load += new System.EventHandler(this.Logeo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logearse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hola2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hola3ToolStripMenuItem;
    }
}

