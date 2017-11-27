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
            this.lblIdCredito = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblAmortizacion = new System.Windows.Forms.Label();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.txtAmortizacion = new System.Windows.Forms.TextBox();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.dtgCredito = new System.Windows.Forms.DataGridView();
            this.btnGenerarCredito = new System.Windows.Forms.Button();
            this.lblMontoAprobado = new System.Windows.Forms.Label();
            this.txtMontoAprobado = new System.Windows.Forms.TextBox();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblUltimaProyeccion = new System.Windows.Forms.Label();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtUltimaProyeccion = new System.Windows.Forms.TextBox();
            this.Pago = new System.Windows.Forms.Label();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.btngenerarpago = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbidcredito = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCredito
            // 
            this.lblIdCredito.AutoSize = true;
            this.lblIdCredito.Location = new System.Drawing.Point(15, 15);
            this.lblIdCredito.Name = "lblIdCredito";
            this.lblIdCredito.Size = new System.Drawing.Size(68, 17);
            this.lblIdCredito.TabIndex = 0;
            this.lblIdCredito.Text = "Id Credito";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(15, 47);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(66, 17);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Id Cliente";
            this.lblIdCliente.Click += new System.EventHandler(this.lblIdCliente_Click);
            // 
            // lblAmortizacion
            // 
            this.lblAmortizacion.AutoSize = true;
            this.lblAmortizacion.Location = new System.Drawing.Point(15, 260);
            this.lblAmortizacion.Name = "lblAmortizacion";
            this.lblAmortizacion.Size = new System.Drawing.Size(89, 17);
            this.lblAmortizacion.TabIndex = 2;
            this.lblAmortizacion.Text = "Amortizacion";
            this.lblAmortizacion.Click += new System.EventHandler(this.lblAmortizacion_Click);
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(15, 230);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(66, 17);
            this.lblIntereses.TabIndex = 3;
            this.lblIntereses.Text = "Intereses";
            // 
            // txtAmortizacion
            // 
            this.txtAmortizacion.Location = new System.Drawing.Point(145, 256);
            this.txtAmortizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmortizacion.Name = "txtAmortizacion";
            this.txtAmortizacion.Size = new System.Drawing.Size(100, 22);
            this.txtAmortizacion.TabIndex = 5;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(145, 43);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(100, 24);
            this.cmbIdCliente.TabIndex = 6;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            this.cmbIdCliente.Click += new System.EventHandler(this.cmbIdCliente_Click);
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(145, 226);
            this.txtIntereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(100, 22);
            this.txtIntereses.TabIndex = 7;
            // 
            // dtgCredito
            // 
            this.dtgCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredito.Location = new System.Drawing.Point(285, 17);
            this.dtgCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCredito.Name = "dtgCredito";
            this.dtgCredito.RowTemplate.Height = 24;
            this.dtgCredito.Size = new System.Drawing.Size(620, 304);
            this.dtgCredito.TabIndex = 8;
            this.dtgCredito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCredito_CellContentClick);
            // 
            // btnGenerarCredito
            // 
            this.btnGenerarCredito.Location = new System.Drawing.Point(12, 338);
            this.btnGenerarCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCredito.Name = "btnGenerarCredito";
            this.btnGenerarCredito.Size = new System.Drawing.Size(145, 33);
            this.btnGenerarCredito.TabIndex = 9;
            this.btnGenerarCredito.Text = "Generar Credito";
            this.btnGenerarCredito.UseVisualStyleBackColor = true;
            this.btnGenerarCredito.Click += new System.EventHandler(this.btnGenerarCredito_Click);
            // 
            // lblMontoAprobado
            // 
            this.lblMontoAprobado.AutoSize = true;
            this.lblMontoAprobado.Location = new System.Drawing.Point(15, 78);
            this.lblMontoAprobado.Name = "lblMontoAprobado";
            this.lblMontoAprobado.Size = new System.Drawing.Size(113, 17);
            this.lblMontoAprobado.TabIndex = 10;
            this.lblMontoAprobado.Text = "Monto Aprobado";
            // 
            // txtMontoAprobado
            // 
            this.txtMontoAprobado.Location = new System.Drawing.Point(145, 74);
            this.txtMontoAprobado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoAprobado.Name = "txtMontoAprobado";
            this.txtMontoAprobado.Size = new System.Drawing.Size(100, 22);
            this.txtMontoAprobado.TabIndex = 11;
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(19, 107);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(40, 17);
            this.lblTasa.TabIndex = 12;
            this.lblTasa.Text = "Tasa";
            this.lblTasa.Click += new System.EventHandler(this.lblTasa_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(15, 289);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 17);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblUltimaProyeccion
            // 
            this.lblUltimaProyeccion.AutoSize = true;
            this.lblUltimaProyeccion.Location = new System.Drawing.Point(15, 169);
            this.lblUltimaProyeccion.Name = "lblUltimaProyeccion";
            this.lblUltimaProyeccion.Size = new System.Drawing.Size(121, 17);
            this.lblUltimaProyeccion.TabIndex = 14;
            this.lblUltimaProyeccion.Text = "Ultima Proyeccion";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(145, 103);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 22);
            this.txtTasa.TabIndex = 15;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(145, 286);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 22);
            this.txtSaldo.TabIndex = 16;
            // 
            // txtUltimaProyeccion
            // 
            this.txtUltimaProyeccion.Location = new System.Drawing.Point(145, 165);
            this.txtUltimaProyeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUltimaProyeccion.Name = "txtUltimaProyeccion";
            this.txtUltimaProyeccion.Size = new System.Drawing.Size(100, 22);
            this.txtUltimaProyeccion.TabIndex = 17;
            // 
            // Pago
            // 
            this.Pago.AutoSize = true;
            this.Pago.Location = new System.Drawing.Point(15, 199);
            this.Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(41, 17);
            this.Pago.TabIndex = 18;
            this.Pago.Text = "Pago";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(145, 196);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 22);
            this.txtpago.TabIndex = 19;
            // 
            // btngenerarpago
            // 
            this.btngenerarpago.Location = new System.Drawing.Point(164, 338);
            this.btngenerarpago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenerarpago.Name = "btngenerarpago";
            this.btngenerarpago.Size = new System.Drawing.Size(112, 33);
            this.btngenerarpago.TabIndex = 20;
            this.btngenerarpago.Text = "Generar Pago";
            this.btngenerarpago.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(285, 327);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 21;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Location = new System.Drawing.Point(805, 327);
            this.btnrefrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(100, 28);
            this.btnrefrescar.TabIndex = 22;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // txtperiodo
            // 
            this.txtperiodo.Location = new System.Drawing.Point(145, 134);
            this.txtperiodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(100, 22);
            this.txtperiodo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Periodo";
            // 
            // cmbidcredito
            // 
            this.cmbidcredito.FormattingEnabled = true;
            this.cmbidcredito.Location = new System.Drawing.Point(145, 11);
            this.cmbidcredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbidcredito.Name = "cmbidcredito";
            this.cmbidcredito.Size = new System.Drawing.Size(100, 24);
            this.cmbidcredito.TabIndex = 25;
            this.cmbidcredito.SelectedIndexChanged += new System.EventHandler(this.cmbidcredito_SelectedIndexChanged);
            this.cmbidcredito.Click += new System.EventHandler(this.cmbidcredito_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Saldo";
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbidcredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btngenerarpago);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.Pago);
            this.Controls.Add(this.txtUltimaProyeccion);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.lblUltimaProyeccion);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.txtMontoAprobado);
            this.Controls.Add(this.lblMontoAprobado);
            this.Controls.Add(this.btnGenerarCredito);
            this.Controls.Add(this.dtgCredito);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.txtAmortizacion);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.lblAmortizacion);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblIdCredito);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCredito;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblAmortizacion;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.TextBox txtAmortizacion;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.DataGridView dtgCredito;
        private System.Windows.Forms.Button btnGenerarCredito;
        private System.Windows.Forms.Label lblMontoAprobado;
        private System.Windows.Forms.TextBox txtMontoAprobado;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblUltimaProyeccion;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtUltimaProyeccion;
        private System.Windows.Forms.Label Pago;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Button btngenerarpago;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbidcredito;
        private System.Windows.Forms.Label label2;
    }
}