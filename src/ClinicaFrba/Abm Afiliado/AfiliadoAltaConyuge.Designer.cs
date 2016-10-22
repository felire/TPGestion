namespace ClinicaFrba.Abm_Afiliado
{
    partial class AfiliadoAltaConyuge
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
            this.cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.labelAp = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.textBoxAp = new System.Windows.Forms.TextBox();
            this.comboBoxTDNI = new System.Windows.Forms.ComboBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxIDdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDire = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDire = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelFechNac = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 268);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de Cónyuge";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(293, 223);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 10;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSexo);
            this.groupBox2.Controls.Add(this.fechaNac);
            this.groupBox2.Controls.Add(this.labelAp);
            this.groupBox2.Controls.Add(this.textBoxNom);
            this.groupBox2.Controls.Add(this.labelNom);
            this.groupBox2.Controls.Add(this.textBoxAp);
            this.groupBox2.Controls.Add(this.comboBoxTDNI);
            this.groupBox2.Controls.Add(this.labelDNI);
            this.groupBox2.Controls.Add(this.textBoxIDdni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxDire);
            this.groupBox2.Controls.Add(this.labelSex);
            this.groupBox2.Controls.Add(this.labelDire);
            this.groupBox2.Controls.Add(this.textBoxTel);
            this.groupBox2.Controls.Add(this.labelFechNac);
            this.groupBox2.Controls.Add(this.labelTel);
            this.groupBox2.Controls.Add(this.textBoxMail);
            this.groupBox2.Controls.Add(this.labelMail);
            this.groupBox2.Location = new System.Drawing.Point(26, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 171);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese datos del cónyuge";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(85, 128);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSexo.TabIndex = 4;
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(374, 105);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(97, 20);
            this.fechaNac.TabIndex = 8;
            // 
            // labelAp
            // 
            this.labelAp.AutoSize = true;
            this.labelAp.Location = new System.Drawing.Point(35, 51);
            this.labelAp.Name = "labelAp";
            this.labelAp.Size = new System.Drawing.Size(44, 13);
            this.labelAp.TabIndex = 3;
            this.labelAp.Text = "Apellido";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(85, 19);
            this.textBoxNom.MaxLength = 255;
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(141, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(35, 24);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 13);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nombre";
            // 
            // textBoxAp
            // 
            this.textBoxAp.Location = new System.Drawing.Point(85, 48);
            this.textBoxAp.MaxLength = 255;
            this.textBoxAp.Name = "textBoxAp";
            this.textBoxAp.Size = new System.Drawing.Size(141, 20);
            this.textBoxAp.TabIndex = 1;
            // 
            // comboBoxTDNI
            // 
            this.comboBoxTDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTDNI.FormattingEnabled = true;
            this.comboBoxTDNI.Location = new System.Drawing.Point(85, 75);
            this.comboBoxTDNI.Name = "comboBoxTDNI";
            this.comboBoxTDNI.Size = new System.Drawing.Size(141, 21);
            this.comboBoxTDNI.TabIndex = 2;
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(35, 78);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(50, 13);
            this.labelDNI.TabIndex = 5;
            this.labelDNI.Text = "Tipo DNI";
            // 
            // textBoxIDdni
            // 
            this.textBoxIDdni.Location = new System.Drawing.Point(85, 102);
            this.textBoxIDdni.MaxLength = 8;
            this.textBoxIDdni.Name = "textBoxIDdni";
            this.textBoxIDdni.Size = new System.Drawing.Size(141, 20);
            this.textBoxIDdni.TabIndex = 3;
            this.textBoxIDdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_dni);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // textBoxDire
            // 
            this.textBoxDire.Location = new System.Drawing.Point(314, 19);
            this.textBoxDire.MaxLength = 255;
            this.textBoxDire.Name = "textBoxDire";
            this.textBoxDire.Size = new System.Drawing.Size(157, 20);
            this.textBoxDire.TabIndex = 5;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(35, 131);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 17;
            this.labelSex.Text = "Sexo";
            // 
            // labelDire
            // 
            this.labelDire.AutoSize = true;
            this.labelDire.Location = new System.Drawing.Point(256, 22);
            this.labelDire.Name = "labelDire";
            this.labelDire.Size = new System.Drawing.Size(52, 13);
            this.labelDire.TabIndex = 9;
            this.labelDire.Text = "Dirección";
            // 
            // textBoxTel
            // 
            this.textBoxTel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxTel.Location = new System.Drawing.Point(314, 48);
            this.textBoxTel.MaxLength = 255;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(157, 20);
            this.textBoxTel.TabIndex = 6;
            this.textBoxTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_telefono);
            // 
            // labelFechNac
            // 
            this.labelFechNac.AutoSize = true;
            this.labelFechNac.Location = new System.Drawing.Point(259, 109);
            this.labelFechNac.Name = "labelFechNac";
            this.labelFechNac.Size = new System.Drawing.Size(108, 13);
            this.labelFechNac.TabIndex = 15;
            this.labelFechNac.Text = "Fecha de Nacimiento";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(256, 51);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Teléfono";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(314, 77);
            this.textBoxMail.MaxLength = 255;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(157, 20);
            this.textBoxMail.TabIndex = 7;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(259, 80);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 13;
            this.labelMail.Text = "Mail";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(440, 223);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(100, 29);
            this.buttonRegistrar.TabIndex = 9;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click_1);
            // 
            // AfiliadoAltaConyuge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 300);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AfiliadoAltaConyuge";
            this.Text = "Cargar Afiliado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAp;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxAp;
        private System.Windows.Forms.ComboBox comboBoxTDNI;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxIDdni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDire;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDire;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelFechNac;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Button cancelar;
    }
}