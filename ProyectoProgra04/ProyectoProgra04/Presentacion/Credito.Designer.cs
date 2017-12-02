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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito));
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_insertar = new System.Windows.Forms.DataGridView();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.btn_Insertar = new System.Windows.Forms.Button();
            this.txt_insertsaldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_insertamort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insertintere = new System.Windows.Forms.TextBox();
            this.txt_insertpago = new System.Windows.Forms.TextBox();
            this.txt_insertultp = new System.Windows.Forms.TextBox();
            this.txt_insertperi = new System.Windows.Forms.TextBox();
            this.txt_inserttasa = new System.Windows.Forms.TextBox();
            this.txt_insertmontoapr = new System.Windows.Forms.TextBox();
            this.txt_insertidcred = new System.Windows.Forms.TextBox();
            this.txt_insertidcliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbconsultacreditos = new System.Windows.Forms.ComboBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredito)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insertar)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdCredito
            // 
            this.lblIdCredito.AutoSize = true;
            this.lblIdCredito.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblIdCredito.Location = new System.Drawing.Point(12, 38);
            this.lblIdCredito.Name = "lblIdCredito";
            this.lblIdCredito.Size = new System.Drawing.Size(68, 17);
            this.lblIdCredito.TabIndex = 0;
            this.lblIdCredito.Text = "Id Credito";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblIdCliente.Location = new System.Drawing.Point(12, 91);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(66, 17);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Id Cliente";
            this.lblIdCliente.Click += new System.EventHandler(this.lblIdCliente_Click);
            // 
            // lblAmortizacion
            // 
            this.lblAmortizacion.AutoSize = true;
            this.lblAmortizacion.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblAmortizacion.Location = new System.Drawing.Point(7, 345);
            this.lblAmortizacion.Name = "lblAmortizacion";
            this.lblAmortizacion.Size = new System.Drawing.Size(89, 17);
            this.lblAmortizacion.TabIndex = 2;
            this.lblAmortizacion.Text = "Amortizacion";
            this.lblAmortizacion.Click += new System.EventHandler(this.lblAmortizacion_Click);
            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblIntereses.Location = new System.Drawing.Point(7, 299);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(66, 17);
            this.lblIntereses.TabIndex = 3;
            this.lblIntereses.Text = "Intereses";
            // 
            // txtAmortizacion
            // 
            this.txtAmortizacion.Location = new System.Drawing.Point(121, 345);
            this.txtAmortizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmortizacion.Name = "txtAmortizacion";
            this.txtAmortizacion.Size = new System.Drawing.Size(100, 22);
            this.txtAmortizacion.TabIndex = 5;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(121, 81);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(100, 24);
            this.cmbIdCliente.TabIndex = 6;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            this.cmbIdCliente.Click += new System.EventHandler(this.cmbIdCliente_Click);
            // 
            // txtIntereses
            // 
            this.txtIntereses.Location = new System.Drawing.Point(131, 299);
            this.txtIntereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.Size = new System.Drawing.Size(100, 22);
            this.txtIntereses.TabIndex = 7;
            // 
            // dtgCredito
            // 
            this.dtgCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCredito.Location = new System.Drawing.Point(324, 22);
            this.dtgCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgCredito.Name = "dtgCredito";
            this.dtgCredito.RowTemplate.Height = 24;
            this.dtgCredito.Size = new System.Drawing.Size(675, 271);
            this.dtgCredito.TabIndex = 8;
            this.dtgCredito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCredito_CellContentClick);
            // 
            // btnGenerarCredito
            // 
            this.btnGenerarCredito.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarCredito.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnGenerarCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarCredito.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarCredito.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnGenerarCredito.Location = new System.Drawing.Point(307, 379);
            this.btnGenerarCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarCredito.Name = "btnGenerarCredito";
            this.btnGenerarCredito.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGenerarCredito.Size = new System.Drawing.Size(145, 33);
            this.btnGenerarCredito.TabIndex = 9;
            this.btnGenerarCredito.Text = "Generar Credito";
            this.btnGenerarCredito.UseVisualStyleBackColor = false;
            this.btnGenerarCredito.Click += new System.EventHandler(this.btnGenerarCredito_Click);
            // 
            // lblMontoAprobado
            // 
            this.lblMontoAprobado.AutoSize = true;
            this.lblMontoAprobado.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblMontoAprobado.Location = new System.Drawing.Point(3, 134);
            this.lblMontoAprobado.Name = "lblMontoAprobado";
            this.lblMontoAprobado.Size = new System.Drawing.Size(113, 17);
            this.lblMontoAprobado.TabIndex = 10;
            this.lblMontoAprobado.Text = "Monto Aprobado";
            // 
            // txtMontoAprobado
            // 
            this.txtMontoAprobado.Location = new System.Drawing.Point(133, 130);
            this.txtMontoAprobado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoAprobado.Name = "txtMontoAprobado";
            this.txtMontoAprobado.Size = new System.Drawing.Size(100, 22);
            this.txtMontoAprobado.TabIndex = 11;
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblTasa.Location = new System.Drawing.Point(7, 164);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(40, 17);
            this.lblTasa.TabIndex = 12;
            this.lblTasa.Text = "Tasa";
            this.lblTasa.Click += new System.EventHandler(this.lblTasa_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblSaldo.Location = new System.Drawing.Point(7, 379);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 17);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblUltimaProyeccion
            // 
            this.lblUltimaProyeccion.AutoSize = true;
            this.lblUltimaProyeccion.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblUltimaProyeccion.Location = new System.Drawing.Point(3, 238);
            this.lblUltimaProyeccion.Name = "lblUltimaProyeccion";
            this.lblUltimaProyeccion.Size = new System.Drawing.Size(121, 17);
            this.lblUltimaProyeccion.TabIndex = 14;
            this.lblUltimaProyeccion.Text = "Ultima Proyeccion";
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(133, 164);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 22);
            this.txtTasa.TabIndex = 15;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(121, 384);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 22);
            this.txtSaldo.TabIndex = 16;
            // 
            // txtUltimaProyeccion
            // 
            this.txtUltimaProyeccion.Location = new System.Drawing.Point(131, 234);
            this.txtUltimaProyeccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUltimaProyeccion.Name = "txtUltimaProyeccion";
            this.txtUltimaProyeccion.Size = new System.Drawing.Size(100, 22);
            this.txtUltimaProyeccion.TabIndex = 17;
            // 
            // Pago
            // 
            this.Pago.AutoSize = true;
            this.Pago.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.Pago.Location = new System.Drawing.Point(3, 268);
            this.Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(41, 17);
            this.Pago.TabIndex = 18;
            this.Pago.Text = "Pago";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(133, 268);
            this.txtpago.Margin = new System.Windows.Forms.Padding(4);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(100, 22);
            this.txtpago.TabIndex = 19;
            // 
            // btngenerarpago
            // 
            this.btngenerarpago.BackColor = System.Drawing.Color.Transparent;
            this.btngenerarpago.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btngenerarpago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarpago.Location = new System.Drawing.Point(512, 379);
            this.btngenerarpago.Margin = new System.Windows.Forms.Padding(4);
            this.btngenerarpago.Name = "btngenerarpago";
            this.btngenerarpago.Size = new System.Drawing.Size(112, 33);
            this.btngenerarpago.TabIndex = 20;
            this.btngenerarpago.Text = "Generar Pago";
            this.btngenerarpago.UseVisualStyleBackColor = false;
            this.btngenerarpago.Click += new System.EventHandler(this.btngenerarpago_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.Location = new System.Drawing.Point(756, 379);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 33);
            this.btnlimpiar.TabIndex = 21;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefrescar.Location = new System.Drawing.Point(648, 379);
            this.btnrefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(100, 33);
            this.btnrefrescar.TabIndex = 22;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // txtperiodo
            // 
            this.txtperiodo.Location = new System.Drawing.Point(133, 198);
            this.txtperiodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(100, 22);
            this.txtperiodo.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.label1.Location = new System.Drawing.Point(7, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Periodo";
            // 
            // cmbidcredito
            // 
            this.cmbidcredito.FormattingEnabled = true;
            this.cmbidcredito.Location = new System.Drawing.Point(121, 38);
            this.cmbidcredito.Margin = new System.Windows.Forms.Padding(4);
            this.cmbidcredito.Name = "cmbidcredito";
            this.cmbidcredito.Size = new System.Drawing.Size(100, 24);
            this.cmbidcredito.TabIndex = 25;
            this.cmbidcredito.SelectedIndexChanged += new System.EventHandler(this.cmbidcredito_SelectedIndexChanged);
            this.cmbidcredito.Click += new System.EventHandler(this.cmbidcredito_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1117, 705);
            this.tabControl2.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.dgv_insertar);
            this.tabPage4.Controls.Add(this.btn_refrescar);
            this.tabPage4.Controls.Add(this.btn_Insertar);
            this.tabPage4.Controls.Add(this.txt_insertsaldo);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txt_insertamort);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txt_insertintere);
            this.tabPage4.Controls.Add(this.txt_insertpago);
            this.tabPage4.Controls.Add(this.txt_insertultp);
            this.tabPage4.Controls.Add(this.txt_insertperi);
            this.tabPage4.Controls.Add(this.txt_inserttasa);
            this.tabPage4.Controls.Add(this.txt_insertmontoapr);
            this.tabPage4.Controls.Add(this.txt_insertidcred);
            this.tabPage4.Controls.Add(this.txt_insertidcliente);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1109, 673);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Insertar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dgv_insertar
            // 
            this.dgv_insertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_insertar.Location = new System.Drawing.Point(336, 31);
            this.dgv_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_insertar.Name = "dgv_insertar";
            this.dgv_insertar.Size = new System.Drawing.Size(741, 277);
            this.dgv_insertar.TabIndex = 16;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.button;
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refrescar.Location = new System.Drawing.Point(192, 432);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(100, 28);
            this.btn_refrescar.TabIndex = 15;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // btn_Insertar
            // 
            this.btn_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Insertar.Image = global::ProyectoProgra04.Properties.Resources.button;
            this.btn_Insertar.Location = new System.Drawing.Point(84, 432);
            this.btn_Insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Insertar.Name = "btn_Insertar";
            this.btn_Insertar.Size = new System.Drawing.Size(100, 28);
            this.btn_Insertar.TabIndex = 14;
            this.btn_Insertar.Text = "Insertar";
            this.btn_Insertar.UseVisualStyleBackColor = true;
            this.btn_Insertar.Click += new System.EventHandler(this.btn_Insertar_Click);
            // 
            // txt_insertsaldo
            // 
            this.txt_insertsaldo.Location = new System.Drawing.Point(157, 357);
            this.txt_insertsaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertsaldo.Name = "txt_insertsaldo";
            this.txt_insertsaldo.Size = new System.Drawing.Size(132, 22);
            this.txt_insertsaldo.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(25, 366);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Saldo";
            // 
            // txt_insertamort
            // 
            this.txt_insertamort.Location = new System.Drawing.Point(157, 306);
            this.txt_insertamort.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertamort.Name = "txt_insertamort";
            this.txt_insertamort.Size = new System.Drawing.Size(132, 22);
            this.txt_insertamort.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(25, 329);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Amortizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(25, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intereses";
            // 
            // txt_insertintere
            // 
            this.txt_insertintere.Location = new System.Drawing.Point(157, 272);
            this.txt_insertintere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertintere.Name = "txt_insertintere";
            this.txt_insertintere.Size = new System.Drawing.Size(132, 22);
            this.txt_insertintere.TabIndex = 8;
            // 
            // txt_insertpago
            // 
            this.txt_insertpago.Location = new System.Drawing.Point(157, 203);
            this.txt_insertpago.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertpago.Name = "txt_insertpago";
            this.txt_insertpago.Size = new System.Drawing.Size(132, 22);
            this.txt_insertpago.TabIndex = 7;
            // 
            // txt_insertultp
            // 
            this.txt_insertultp.Location = new System.Drawing.Point(157, 169);
            this.txt_insertultp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertultp.Name = "txt_insertultp";
            this.txt_insertultp.Size = new System.Drawing.Size(132, 22);
            this.txt_insertultp.TabIndex = 6;
            // 
            // txt_insertperi
            // 
            this.txt_insertperi.Location = new System.Drawing.Point(157, 238);
            this.txt_insertperi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertperi.Name = "txt_insertperi";
            this.txt_insertperi.Size = new System.Drawing.Size(132, 22);
            this.txt_insertperi.TabIndex = 5;
            // 
            // txt_inserttasa
            // 
            this.txt_inserttasa.Location = new System.Drawing.Point(157, 100);
            this.txt_inserttasa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inserttasa.Name = "txt_inserttasa";
            this.txt_inserttasa.Size = new System.Drawing.Size(132, 22);
            this.txt_inserttasa.TabIndex = 4;
            // 
            // txt_insertmontoapr
            // 
            this.txt_insertmontoapr.Location = new System.Drawing.Point(157, 134);
            this.txt_insertmontoapr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertmontoapr.Name = "txt_insertmontoapr";
            this.txt_insertmontoapr.Size = new System.Drawing.Size(132, 22);
            this.txt_insertmontoapr.TabIndex = 3;
            // 
            // txt_insertidcred
            // 
            this.txt_insertidcred.Location = new System.Drawing.Point(157, 65);
            this.txt_insertidcred.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertidcred.Name = "txt_insertidcred";
            this.txt_insertidcred.Size = new System.Drawing.Size(132, 22);
            this.txt_insertidcred.TabIndex = 2;
            // 
            // txt_insertidcliente
            // 
            this.txt_insertidcliente.Location = new System.Drawing.Point(157, 31);
            this.txt_insertidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertidcliente.Name = "txt_insertidcliente";
            this.txt_insertidcliente.Size = new System.Drawing.Size(132, 22);
            this.txt_insertidcliente.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(25, 255);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Periodo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(25, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(25, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ultima Proyeccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(25, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Aprobado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(27, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id Credito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage1.Controls.Add(this.cmbconsultacreditos);
            this.tabPage1.Controls.Add(this.cmbid);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.dgvconsulta);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1109, 673);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Consultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbconsultacreditos
            // 
            this.cmbconsultacreditos.FormattingEnabled = true;
            this.cmbconsultacreditos.Location = new System.Drawing.Point(139, 124);
            this.cmbconsultacreditos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbconsultacreditos.Name = "cmbconsultacreditos";
            this.cmbconsultacreditos.Size = new System.Drawing.Size(160, 24);
            this.cmbconsultacreditos.TabIndex = 9;
            this.cmbconsultacreditos.SelectedIndexChanged += new System.EventHandler(this.cmbconsultacreditos_SelectedIndexChanged);
            this.cmbconsultacreditos.Click += new System.EventHandler(this.cmbconsultacreditos_Click);
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(139, 70);
            this.cmbid.Margin = new System.Windows.Forms.Padding(4);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(160, 24);
            this.cmbid.TabIndex = 8;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            this.cmbid.Click += new System.EventHandler(this.cmbid_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 124);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 70);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "label12";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(203, 212);
            this.dgvconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(655, 224);
            this.dgvconsulta.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 443);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 443);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage3.Controls.Add(this.cmbidcredito);
            this.tabPage3.Controls.Add(this.btnrefrescar);
            this.tabPage3.Controls.Add(this.txtperiodo);
            this.tabPage3.Controls.Add(this.btnlimpiar);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btngenerarpago);
            this.tabPage3.Controls.Add(this.lblIdCredito);
            this.tabPage3.Controls.Add(this.btnGenerarCredito);
            this.tabPage3.Controls.Add(this.txtSaldo);
            this.tabPage3.Controls.Add(this.dtgCredito);
            this.tabPage3.Controls.Add(this.txtpago);
            this.tabPage3.Controls.Add(this.lblIdCliente);
            this.tabPage3.Controls.Add(this.txtUltimaProyeccion);
            this.tabPage3.Controls.Add(this.txtAmortizacion);
            this.tabPage3.Controls.Add(this.txtIntereses);
            this.tabPage3.Controls.Add(this.cmbIdCliente);
            this.tabPage3.Controls.Add(this.lblMontoAprobado);
            this.tabPage3.Controls.Add(this.Pago);
            this.tabPage3.Controls.Add(this.lblTasa);
            this.tabPage3.Controls.Add(this.txtTasa);
            this.tabPage3.Controls.Add(this.lblUltimaProyeccion);
            this.tabPage3.Controls.Add(this.txtMontoAprobado);
            this.tabPage3.Controls.Add(this.lblSaldo);
            this.tabPage3.Controls.Add(this.lblIntereses);
            this.tabPage3.Controls.Add(this.lblAmortizacion);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1109, 673);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Actulizar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1109, 673);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.thumb_1920_750482;
            this.ClientSize = new System.Drawing.Size(1117, 517);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCredito)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insertar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Insertar;
        private System.Windows.Forms.TextBox txt_insertsaldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_insertamort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_insertintere;
        private System.Windows.Forms.TextBox txt_insertpago;
        private System.Windows.Forms.TextBox txt_insertultp;
        private System.Windows.Forms.TextBox txt_insertperi;
        private System.Windows.Forms.TextBox txt_inserttasa;
        private System.Windows.Forms.TextBox txt_insertmontoapr;
        private System.Windows.Forms.TextBox txt_insertidcred;
        private System.Windows.Forms.TextBox txt_insertidcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView dgv_insertar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.ComboBox cmbconsultacreditos;

    }
}