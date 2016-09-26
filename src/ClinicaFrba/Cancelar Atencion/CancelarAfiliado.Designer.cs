namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelarAfiliado
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
            this.nombreAfiliado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.turnos = new System.Windows.Forms.DataGridView();
            this.cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // nombreAfiliado
            // 
            this.nombreAfiliado.AutoSize = true;
            this.nombreAfiliado.Location = new System.Drawing.Point(60, 13);
            this.nombreAfiliado.Name = "nombreAfiliado";
            this.nombreAfiliado.Size = new System.Drawing.Size(35, 13);
            this.nombreAfiliado.TabIndex = 1;
            this.nombreAfiliado.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elija el turno que desea cancelar: ";
            // 
            // turnos
            // 
            this.turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnos.Location = new System.Drawing.Point(19, 84);
            this.turnos.Name = "turnos";
            this.turnos.Size = new System.Drawing.Size(579, 150);
            this.turnos.TabIndex = 3;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(422, 265);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(176, 23);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // CancelarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 319);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.turnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreAfiliado);
            this.Controls.Add(this.label1);
            this.Name = "CancelarAfiliado";
            this.Text = "CancelarAfiliado";
            ((System.ComponentModel.ISupportInitialize)(this.turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreAfiliado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView turnos;
        private System.Windows.Forms.Button cancelar;
    }
}