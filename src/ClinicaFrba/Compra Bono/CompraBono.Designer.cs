namespace ClinicaFrba.Compra_Bono
{
    partial class CompraBono
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comprar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cantidadAComprar = new System.Windows.Forms.NumericUpDown();
            this.nombre = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.precioTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadAComprar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de bonos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "cantidad de bonos a comprar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio unitario:";
            // 
            // comprar
            // 
            this.comprar.Location = new System.Drawing.Point(19, 171);
            this.comprar.Name = "comprar";
            this.comprar.Size = new System.Drawing.Size(100, 29);
            this.comprar.TabIndex = 5;
            this.comprar.Text = "Comprar";
            this.comprar.UseVisualStyleBackColor = true;
            this.comprar.Click += new System.EventHandler(this.comprar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Los bonos pueden ser usados una unica vez por un miembro del grupo familiar,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "siempre que el plan no cambie.";
            // 
            // cantidadAComprar
            // 
            this.cantidadAComprar.Location = new System.Drawing.Point(161, 78);
            this.cantidadAComprar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadAComprar.Name = "cantidadAComprar";
            this.cantidadAComprar.Size = new System.Drawing.Size(38, 20);
            this.cantidadAComprar.TabIndex = 12;
            this.cantidadAComprar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadAComprar.ValueChanged += new System.EventHandler(this.cambioCantidad);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(57, 45);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(35, 13);
            this.nombre.TabIndex = 13;
            this.nombre.Text = "label8";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(277, 44);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(35, 13);
            this.apellido.TabIndex = 14;
            this.apellido.Text = "label8";
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(308, 80);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(35, 13);
            this.precio.TabIndex = 15;
            this.precio.Text = "label8";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(424, 171);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 29;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Precio total:";
            // 
            // precioTotal
            // 
            this.precioTotal.AutoSize = true;
            this.precioTotal.Location = new System.Drawing.Point(432, 79);
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.Size = new System.Drawing.Size(35, 13);
            this.precioTotal.TabIndex = 31;
            this.precioTotal.Text = "label9";
            // 
            // CompraBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 223);
            this.Controls.Add(this.precioTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cantidadAComprar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompraBono";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cantidadAComprar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button comprar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cantidadAComprar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label precioTotal;
    }
}