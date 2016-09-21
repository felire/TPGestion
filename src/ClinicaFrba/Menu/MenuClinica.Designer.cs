namespace ClinicaFrba.Menu
{
    partial class MenuClinica
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadisticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboElegirRol = new System.Windows.Forms.ComboBox();
            this.textElegirRol = new System.Windows.Forms.Label();
            this.botonElegirRol = new System.Windows.Forms.Button();
            this.listaFunciones = new System.Windows.Forms.ListView();
            this.labelFuncionalidades = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.afiliadoToolStripMenuItem,
            this.bonoToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.diagnosticoToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.listadoEstadisticoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificaciónToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.rolesToolStripMenuItem.Text = "Rol";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificaciónToolStripMenuItem
            // 
            this.modificaciónToolStripMenuItem.Name = "modificaciónToolStripMenuItem";
            this.modificaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificaciónToolStripMenuItem.Text = "Modificación";
            // 
            // afiliadoToolStripMenuItem
            // 
            this.afiliadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.bajaToolStripMenuItem1,
            this.visualizaciónToolStripMenuItem,
            this.modificaciónToolStripMenuItem1});
            this.afiliadoToolStripMenuItem.Name = "afiliadoToolStripMenuItem";
            this.afiliadoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.afiliadoToolStripMenuItem.Text = "Afiliado";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.bajaToolStripMenuItem1.Text = "Baja";
            // 
            // visualizaciónToolStripMenuItem
            // 
            this.visualizaciónToolStripMenuItem.Name = "visualizaciónToolStripMenuItem";
            this.visualizaciónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.visualizaciónToolStripMenuItem.Text = "Visualización";
            this.visualizaciónToolStripMenuItem.Click += new System.EventHandler(this.visualizacionAficlick);
            // 
            // modificaciónToolStripMenuItem1
            // 
            this.modificaciónToolStripMenuItem1.Name = "modificaciónToolStripMenuItem1";
            this.modificaciónToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.modificaciónToolStripMenuItem1.Text = "Modificación";
            // 
            // bonoToolStripMenuItem
            // 
            this.bonoToolStripMenuItem.Name = "bonoToolStripMenuItem";
            this.bonoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.bonoToolStripMenuItem.Text = "Bono";
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.turnoToolStripMenuItem.Text = "Turno";
            // 
            // diagnosticoToolStripMenuItem
            // 
            this.diagnosticoToolStripMenuItem.Name = "diagnosticoToolStripMenuItem";
            this.diagnosticoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.diagnosticoToolStripMenuItem.Text = "Diagnostico";
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // listadoEstadisticoToolStripMenuItem
            // 
            this.listadoEstadisticoToolStripMenuItem.Name = "listadoEstadisticoToolStripMenuItem";
            this.listadoEstadisticoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadisticoToolStripMenuItem.Text = "Listado Estadistico";
            // 
            // comboElegirRol
            // 
            this.comboElegirRol.FormattingEnabled = true;
            this.comboElegirRol.Location = new System.Drawing.Point(12, 79);
            this.comboElegirRol.Name = "comboElegirRol";
            this.comboElegirRol.Size = new System.Drawing.Size(121, 21);
            this.comboElegirRol.TabIndex = 1;
            this.comboElegirRol.SelectedIndexChanged += new System.EventHandler(this.cambioRolEvento);
            // 
            // textElegirRol
            // 
            this.textElegirRol.AutoSize = true;
            this.textElegirRol.Location = new System.Drawing.Point(12, 53);
            this.textElegirRol.Name = "textElegirRol";
            this.textElegirRol.Size = new System.Drawing.Size(97, 13);
            this.textElegirRol.TabIndex = 2;
            this.textElegirRol.Text = "Seleccione un Rol:";
            // 
            // botonElegirRol
            // 
            this.botonElegirRol.Location = new System.Drawing.Point(12, 117);
            this.botonElegirRol.Name = "botonElegirRol";
            this.botonElegirRol.Size = new System.Drawing.Size(118, 23);
            this.botonElegirRol.TabIndex = 3;
            this.botonElegirRol.Text = "Ingresar";
            this.botonElegirRol.UseVisualStyleBackColor = true;
            this.botonElegirRol.Click += new System.EventHandler(this.botonElegirRol_Click);
            // 
            // listaFunciones
            // 
            this.listaFunciones.Location = new System.Drawing.Point(177, 53);
            this.listaFunciones.Name = "listaFunciones";
            this.listaFunciones.Size = new System.Drawing.Size(328, 270);
            this.listaFunciones.TabIndex = 4;
            this.listaFunciones.UseCompatibleStateImageBehavior = false;
            this.listaFunciones.View = System.Windows.Forms.View.List;
            // 
            // labelFuncionalidades
            // 
            this.labelFuncionalidades.AutoSize = true;
            this.labelFuncionalidades.Location = new System.Drawing.Point(174, 37);
            this.labelFuncionalidades.Name = "labelFuncionalidades";
            this.labelFuncionalidades.Size = new System.Drawing.Size(87, 13);
            this.labelFuncionalidades.TabIndex = 5;
            this.labelFuncionalidades.Text = "Funcionalidades:";
            // 
            // MenuClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 350);
            this.Controls.Add(this.labelFuncionalidades);
            this.Controls.Add(this.listaFunciones);
            this.Controls.Add(this.botonElegirRol);
            this.Controls.Add(this.textElegirRol);
            this.Controls.Add(this.comboElegirRol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuClinica";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuClinica_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadisticoToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboElegirRol;
        private System.Windows.Forms.Label textElegirRol;
        private System.Windows.Forms.Button botonElegirRol;
        private System.Windows.Forms.ListView listaFunciones;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónToolStripMenuItem1;
        private System.Windows.Forms.Label labelFuncionalidades;
    }
}
