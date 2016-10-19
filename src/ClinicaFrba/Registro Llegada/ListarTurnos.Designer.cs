namespace ClinicaFrba.Registro_Llegada
{
    partial class ListarTurnos
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
            this.turnosGrid = new System.Windows.Forms.DataGridView();
            this.elegir = new System.Windows.Forms.Button();
            this.nombreAfiliado = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el turno";
            // 
            // turnosGrid
            // 
            this.turnosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnosGrid.Location = new System.Drawing.Point(16, 94);
            this.turnosGrid.Name = "turnosGrid";
            this.turnosGrid.Size = new System.Drawing.Size(420, 181);
            this.turnosGrid.TabIndex = 1;
            // 
            // elegir
            // 
            this.elegir.Location = new System.Drawing.Point(336, 296);
            this.elegir.Name = "elegir";
            this.elegir.Size = new System.Drawing.Size(100, 29);
            this.elegir.TabIndex = 2;
            this.elegir.Text = "Elegir";
            this.elegir.UseVisualStyleBackColor = true;
            this.elegir.Click += new System.EventHandler(this.elegir_Click);
            // 
            // nombreAfiliado
            // 
            this.nombreAfiliado.AutoSize = true;
            this.nombreAfiliado.Location = new System.Drawing.Point(13, 26);
            this.nombreAfiliado.Name = "nombreAfiliado";
            this.nombreAfiliado.Size = new System.Drawing.Size(76, 13);
            this.nombreAfiliado.TabIndex = 3;
            this.nombreAfiliado.Text = "nombreAfiliado";
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(185, 296);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(100, 29);
            this.cancelar.TabIndex = 31;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ListarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 340);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.nombreAfiliado);
            this.Controls.Add(this.elegir);
            this.Controls.Add(this.turnosGrid);
            this.Controls.Add(this.label1);
            this.Name = "ListarTurnos";
            this.Text = "ListarTurnos";
            ((System.ComponentModel.ISupportInitialize)(this.turnosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView turnosGrid;
        private System.Windows.Forms.Button elegir;
        private System.Windows.Forms.Label nombreAfiliado;
        private System.Windows.Forms.Button cancelar;
    }
}