namespace ProyectoProgra04.Presentacion
{
    partial class Credito
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
            this.txtIdCredito = new System.Windows.Forms.TextBox();
            this.lblIdCredito = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.lblAmortizacion = new System.Windows.Forms.Label();
            this.txtAmortizacion = new System.Windows.Forms.TextBox();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdCredito
            // 
            this.txtIdCredito.Location = new System.Drawing.Point(154, 61);
            this.txtIdCredito.Name = "txtIdCredito";
            this.txtIdCredito.Size = new System.Drawing.Size(100, 22);
            this.txtIdCredito.TabIndex = 0;
            this.txtIdCredito.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblIdCredito
            // 
            this.lblIdCredito.AutoSize = true;
            this.lblIdCredito.Location = new System.Drawing.Point(47, 64);
            this.lblIdCredito.Name = "lblIdCredito";
            this.lblIdCredito.Size = new System.Drawing.Size(68, 17);
            this.lblIdCredito.TabIndex = 1;
            this.lblIdCredito.Text = "Id Credito";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(47, 108);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(66, 17);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "Id Cliente";
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(154, 108);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(121, 24);
            this.cmbIdCliente.TabIndex = 3;
            // 
            // lblAmortizacion
            // 
            this.lblAmortizacion.AutoSize = true;
            this.lblAmortizacion.Location = new System.Drawing.Point(47, 161);
            this.lblAmortizacion.Name = "lblAmortizacion";
            this.lblAmortizacion.Size = new System.Drawing.Size(89, 17);
            this.lblAmortizacion.TabIndex = 4;
            this.lblAmortizacion.Text = "Amortizacion";
            // 
            // txtAmortizacion
            // 
            this.txtAmortizacion.Location = new System.Drawing.Point(154, 161);
            this.txtAmortizacion.Name = "txtAmortizacion";
            this.txtAmortizacion.Size = new System.Drawing.Size(100, 22);
            this.txtAmortizacion.TabIndex = 5;
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(56, 212);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(66, 17);
            this.lblIntereses.TabIndex = 6;
            this.lblIntereses.Text = "Intereses";
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(154, 212);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(100, 22);
            this.txtIntereses.TabIndex = 7;
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 436);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.txtAmortizacion);
            this.Controls.Add(this.lblAmortizacion);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblIdCredito);
            this.Controls.Add(this.txtIdCredito);
            this.Name = "Credito";
            this.Text = "Credito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCredito;
        private System.Windows.Forms.Label lblIdCredito;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.Label lblAmortizacion;
        private System.Windows.Forms.TextBox txtAmortizacion;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.TextBox txtIntereses;
    }
}