namespace ClinicaFrba.Abm_Afiliado
{
    partial class ModificaDatos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ButtonModificar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonLimpiar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCasado = new System.Windows.Forms.ComboBox();
            this.labelCasado = new System.Windows.Forms.Label();
            this.labelCantHij = new System.Windows.Forms.Label();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxDire = new System.Windows.Forms.TextBox();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDire = new System.Windows.Forms.Label();
            this.textBoxHijos = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelId = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nroDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.habilitado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.ButtonModificar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.ButtonLimpiar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 586);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificación de Afiliado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(22, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 51);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Confirme si desea habilitar/inhabilitar al afiliado";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(80, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Inhabilitar Afiliado";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(385, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Habilitar Afiliado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ButtonModificar
            // 
            this.ButtonModificar.Location = new System.Drawing.Point(349, 494);
            this.ButtonModificar.Name = "ButtonModificar";
            this.ButtonModificar.Size = new System.Drawing.Size(110, 35);
            this.ButtonModificar.TabIndex = 29;
            this.ButtonModificar.Text = "Modificar";
            this.ButtonModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(23, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 97);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivo de la modificación";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 72);
            this.textBox1.TabIndex = 13;
            // 
            // ButtonLimpiar
            // 
            this.ButtonLimpiar.Location = new System.Drawing.Point(92, 494);
            this.ButtonLimpiar.Name = "ButtonLimpiar";
            this.ButtonLimpiar.Size = new System.Drawing.Size(110, 35);
            this.ButtonLimpiar.TabIndex = 12;
            this.ButtonLimpiar.Text = "Limpiar";
            this.ButtonLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPlan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxCasado);
            this.groupBox2.Controls.Add(this.labelCasado);
            this.groupBox2.Controls.Add(this.labelCantHij);
            this.groupBox2.Controls.Add(this.comboBoxSexo);
            this.groupBox2.Controls.Add(this.textBoxDire);
            this.groupBox2.Controls.Add(this.labelSex);
            this.groupBox2.Controls.Add(this.labelDire);
            this.groupBox2.Controls.Add(this.textBoxHijos);
            this.groupBox2.Controls.Add(this.textBoxTel);
            this.groupBox2.Controls.Add(this.labelTel);
            this.groupBox2.Controls.Add(this.textBoxMail);
            this.groupBox2.Controls.Add(this.labelMail);
            this.groupBox2.Location = new System.Drawing.Point(23, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 157);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese datos a modificar";
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Location = new System.Drawing.Point(339, 119);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(147, 21);
            this.comboBoxPlan.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Plan Medico";
            // 
            // comboBoxCasado
            // 
            this.comboBoxCasado.FormattingEnabled = true;
            this.comboBoxCasado.Location = new System.Drawing.Point(85, 61);
            this.comboBoxCasado.Name = "comboBoxCasado";
            this.comboBoxCasado.Size = new System.Drawing.Size(147, 21);
            this.comboBoxCasado.TabIndex = 21;
            // 
            // labelCasado
            // 
            this.labelCasado.AutoSize = true;
            this.labelCasado.Location = new System.Drawing.Point(18, 64);
            this.labelCasado.Name = "labelCasado";
            this.labelCasado.Size = new System.Drawing.Size(61, 13);
            this.labelCasado.TabIndex = 20;
            this.labelCasado.Text = "Estado civil";
            // 
            // labelCantHij
            // 
            this.labelCantHij.AutoSize = true;
            this.labelCantHij.Location = new System.Drawing.Point(19, 33);
            this.labelCantHij.Name = "labelCantHij";
            this.labelCantHij.Size = new System.Drawing.Size(88, 13);
            this.labelCantHij.TabIndex = 19;
            this.labelCantHij.Text = "Cantidad de hijos";
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(70, 88);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSexo.TabIndex = 18;
            // 
            // textBoxDire
            // 
            this.textBoxDire.Location = new System.Drawing.Point(339, 30);
            this.textBoxDire.Name = "textBoxDire";
            this.textBoxDire.Size = new System.Drawing.Size(148, 20);
            this.textBoxDire.TabIndex = 8;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(19, 91);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(31, 13);
            this.labelSex.TabIndex = 17;
            this.labelSex.Text = "Sexo";
            // 
            // labelDire
            // 
            this.labelDire.AutoSize = true;
            this.labelDire.Location = new System.Drawing.Point(272, 33);
            this.labelDire.Name = "labelDire";
            this.labelDire.Size = new System.Drawing.Size(52, 13);
            this.labelDire.TabIndex = 9;
            this.labelDire.Text = "Dirección";
            // 
            // textBoxHijos
            // 
            this.textBoxHijos.Location = new System.Drawing.Point(110, 30);
            this.textBoxHijos.Name = "textBoxHijos";
            this.textBoxHijos.Size = new System.Drawing.Size(123, 20);
            this.textBoxHijos.TabIndex = 16;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(339, 59);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(148, 20);
            this.textBoxTel.TabIndex = 10;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(272, 62);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(49, 13);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "Teléfono";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(339, 87);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(148, 20);
            this.textBoxMail.TabIndex = 12;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(275, 90);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 13;
            this.labelMail.Text = "Mail";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.habilitado);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nroDoc);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.apellido);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.nombre);
            this.groupBox5.Controls.Add(this.labelId);
            this.groupBox5.Controls.Add(this.id);
            this.groupBox5.Location = new System.Drawing.Point(22, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(522, 103);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos de selección";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(19, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 13);
            this.labelId.TabIndex = 26;
            this.labelId.Text = "Id Afiliado";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(86, 16);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(123, 20);
            this.id.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(340, 20);
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Size = new System.Drawing.Size(123, 20);
            this.nombre.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(340, 46);
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Size = new System.Drawing.Size(123, 20);
            this.apellido.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nro Doc";
            // 
            // nroDoc
            // 
            this.nroDoc.Location = new System.Drawing.Point(86, 42);
            this.nroDoc.Name = "nroDoc";
            this.nroDoc.ReadOnly = true;
            this.nroDoc.Size = new System.Drawing.Size(123, 20);
            this.nroDoc.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Habilitado";
            // 
            // habilitado
            // 
            this.habilitado.Location = new System.Drawing.Point(340, 72);
            this.habilitado.Name = "habilitado";
            this.habilitado.ReadOnly = true;
            this.habilitado.Size = new System.Drawing.Size(123, 20);
            this.habilitado.TabIndex = 33;
            // 
            // ModificaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 592);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificaDatos";
            this.Text = "ModificaDatos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCasado;
        private System.Windows.Forms.Label labelCasado;
        private System.Windows.Forms.Label labelCantHij;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox textBoxDire;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDire;
        private System.Windows.Forms.TextBox textBoxHijos;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Button ButtonModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonLimpiar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox habilitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nroDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox id;
    }
}