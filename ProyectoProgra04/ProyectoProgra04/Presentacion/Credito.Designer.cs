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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.Pago = new System.Windows.Forms.Label();
            this.btngenerarpago = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chklp = new System.Windows.Forms.CheckBox();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btn_refrescar = new System.Windows.Forms.Button();
            this.dgv_insertar = new System.Windows.Forms.DataGridView();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btnproyeccion = new System.Windows.Forms.Button();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.lbcuota = new System.Windows.Forms.Label();
            this.txt_insertsaldo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_insertamort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_insertintere = new System.Windows.Forms.TextBox();
            this.txt_insertperi = new System.Windows.Forms.TextBox();
            this.txt_inserttasa = new System.Windows.Forms.TextBox();
            this.txt_insertmontoapr = new System.Windows.Forms.TextBox();
            this.txt_insertidcred = new System.Windows.Forms.TextBox();
            this.txt_insertidcliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbconsultacreditos = new System.Windows.Forms.ComboBox();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.lbidcredito = new System.Windows.Forms.Label();
            this.lbidcred = new System.Windows.Forms.Label();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.Limpiar = new System.Windows.Forms.Button();
            this.btnconsultarefrescar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbperiodo = new System.Windows.Forms.ComboBox();
            this.rbnocancelado = new System.Windows.Forms.RadioButton();
            this.rb_cancelado = new System.Windows.Forms.RadioButton();
            this.lbcancelado = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insertar)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblIdCliente.Location = new System.Drawing.Point(5, 34);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(51, 13);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Id Cliente";
            this.lblIdCliente.Click += new System.EventHandler(this.lblIdCliente_Click);
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(80, 26);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(76, 21);
            this.cmbIdCliente.TabIndex = 6;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            this.cmbIdCliente.Click += new System.EventHandler(this.cmbIdCliente_Click);
            // 
            // dgvCredito
            // 
            this.dgvCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredito.Location = new System.Drawing.Point(214, 18);
            this.dgvCredito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.RowTemplate.Height = 24;
            this.dgvCredito.Size = new System.Drawing.Size(729, 255);
            this.dgvCredito.TabIndex = 8;
            this.dgvCredito.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCredito_CellMouseClick);
            // 
            // Pago
            // 
            this.Pago.AutoSize = true;
            this.Pago.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.Pago.Location = new System.Drawing.Point(2, 211);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(0, 13);
            this.Pago.TabIndex = 18;
            // 
            // btngenerarpago
            // 
            this.btngenerarpago.BackColor = System.Drawing.Color.Transparent;
            this.btngenerarpago.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btngenerarpago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarpago.ForeColor = System.Drawing.Color.Transparent;
            this.btngenerarpago.Location = new System.Drawing.Point(444, 287);
            this.btngenerarpago.Name = "btngenerarpago";
            this.btngenerarpago.Size = new System.Drawing.Size(84, 27);
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
            this.btnlimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.Location = new System.Drawing.Point(688, 287);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnlimpiar.TabIndex = 21;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnrefrescar.Location = new System.Drawing.Point(560, 287);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(75, 27);
            this.btnrefrescar.TabIndex = 22;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Periodo";
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
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(989, 573);
            this.tabControl2.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.chklp);
            this.tabPage4.Controls.Add(this.btnlimp);
            this.tabPage4.Controls.Add(this.btn_refrescar);
            this.tabPage4.Controls.Add(this.dgv_insertar);
            this.tabPage4.Controls.Add(this.btn_insertar);
            this.tabPage4.Controls.Add(this.btnproyeccion);
            this.tabPage4.Controls.Add(this.txtcuota);
            this.tabPage4.Controls.Add(this.lbcuota);
            this.tabPage4.Controls.Add(this.txt_insertsaldo);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.txt_insertamort);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txt_insertintere);
            this.tabPage4.Controls.Add(this.txt_insertperi);
            this.tabPage4.Controls.Add(this.txt_inserttasa);
            this.tabPage4.Controls.Add(this.txt_insertmontoapr);
            this.tabPage4.Controls.Add(this.txt_insertidcred);
            this.tabPage4.Controls.Add(this.txt_insertidcliente);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(981, 544);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Insertar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // chklp
            // 
            this.chklp.AutoSize = true;
            this.chklp.BackColor = System.Drawing.Color.DodgerBlue;
            this.chklp.ForeColor = System.Drawing.Color.Transparent;
            this.chklp.Location = new System.Drawing.Point(8, 284);
            this.chklp.Name = "chklp";
            this.chklp.Size = new System.Drawing.Size(82, 17);
            this.chklp.TabIndex = 25;
            this.chklp.Text = "Largo Plazo";
            this.chklp.UseVisualStyleBackColor = false;
            this.chklp.CheckedChanged += new System.EventHandler(this.chklp_CheckedChanged);
            // 
            // btnlimp
            // 
            this.btnlimp.BackColor = System.Drawing.Color.Transparent;
            this.btnlimp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimp.ForeColor = System.Drawing.Color.Transparent;
            this.btnlimp.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlimp.Location = new System.Drawing.Point(898, 278);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(75, 23);
            this.btnlimp.TabIndex = 24;
            this.btnlimp.Text = "Limpiar";
            this.btnlimp.UseVisualStyleBackColor = false;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.BackColor = System.Drawing.Color.Transparent;
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_refrescar.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btn_refrescar.Location = new System.Drawing.Point(224, 278);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(75, 23);
            this.btn_refrescar.TabIndex = 23;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = false;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click_1);
            // 
            // dgv_insertar
            // 
            this.dgv_insertar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_insertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_insertar.Location = new System.Drawing.Point(224, 6);
            this.dgv_insertar.Name = "dgv_insertar";
            this.dgv_insertar.Size = new System.Drawing.Size(749, 266);
            this.dgv_insertar.TabIndex = 22;
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Transparent;
            this.btn_insertar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_insertar.Location = new System.Drawing.Point(143, 249);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(75, 23);
            this.btn_insertar.TabIndex = 21;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click_1);
            // 
            // btnproyeccion
            // 
            this.btnproyeccion.BackColor = System.Drawing.Color.Transparent;
            this.btnproyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproyeccion.ForeColor = System.Drawing.Color.Transparent;
            this.btnproyeccion.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnproyeccion.Location = new System.Drawing.Point(8, 249);
            this.btnproyeccion.Name = "btnproyeccion";
            this.btnproyeccion.Size = new System.Drawing.Size(111, 23);
            this.btnproyeccion.TabIndex = 20;
            this.btnproyeccion.Text = "Generar Proyección";
            this.btnproyeccion.UseVisualStyleBackColor = false;
            this.btnproyeccion.Click += new System.EventHandler(this.btnproyeccion_Click_1);
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(118, 136);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(100, 20);
            this.txtcuota.TabIndex = 19;
            // 
            // lbcuota
            // 
            this.lbcuota.AutoSize = true;
            this.lbcuota.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbcuota.ForeColor = System.Drawing.Color.Transparent;
            this.lbcuota.Location = new System.Drawing.Point(17, 139);
            this.lbcuota.Name = "lbcuota";
            this.lbcuota.Size = new System.Drawing.Size(35, 13);
            this.lbcuota.TabIndex = 17;
            this.lbcuota.Text = "Cuota";
            // 
            // txt_insertsaldo
            // 
            this.txt_insertsaldo.Location = new System.Drawing.Point(118, 214);
            this.txt_insertsaldo.Name = "txt_insertsaldo";
            this.txt_insertsaldo.ReadOnly = true;
            this.txt_insertsaldo.Size = new System.Drawing.Size(100, 20);
            this.txt_insertsaldo.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(17, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Saldo";
            // 
            // txt_insertamort
            // 
            this.txt_insertamort.Location = new System.Drawing.Point(118, 188);
            this.txt_insertamort.Name = "txt_insertamort";
            this.txt_insertamort.ReadOnly = true;
            this.txt_insertamort.Size = new System.Drawing.Size(100, 20);
            this.txt_insertamort.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(17, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Amortizacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intereses";
            // 
            // txt_insertintere
            // 
            this.txt_insertintere.Location = new System.Drawing.Point(118, 162);
            this.txt_insertintere.Name = "txt_insertintere";
            this.txt_insertintere.ReadOnly = true;
            this.txt_insertintere.Size = new System.Drawing.Size(100, 20);
            this.txt_insertintere.TabIndex = 8;
            // 
            // txt_insertperi
            // 
            this.txt_insertperi.Location = new System.Drawing.Point(118, 110);
            this.txt_insertperi.Name = "txt_insertperi";
            this.txt_insertperi.Size = new System.Drawing.Size(100, 20);
            this.txt_insertperi.TabIndex = 5;
            // 
            // txt_inserttasa
            // 
            this.txt_inserttasa.Location = new System.Drawing.Point(118, 84);
            this.txt_inserttasa.Name = "txt_inserttasa";
            this.txt_inserttasa.Size = new System.Drawing.Size(100, 20);
            this.txt_inserttasa.TabIndex = 4;
            // 
            // txt_insertmontoapr
            // 
            this.txt_insertmontoapr.Location = new System.Drawing.Point(118, 58);
            this.txt_insertmontoapr.Name = "txt_insertmontoapr";
            this.txt_insertmontoapr.Size = new System.Drawing.Size(100, 20);
            this.txt_insertmontoapr.TabIndex = 3;
            // 
            // txt_insertidcred
            // 
            this.txt_insertidcred.Location = new System.Drawing.Point(118, 32);
            this.txt_insertidcred.Name = "txt_insertidcred";
            this.txt_insertidcred.Size = new System.Drawing.Size(100, 20);
            this.txt_insertidcred.TabIndex = 2;
            // 
            // txt_insertidcliente
            // 
            this.txt_insertidcliente.Location = new System.Drawing.Point(118, 6);
            this.txt_insertidcliente.Name = "txt_insertidcliente";
            this.txt_insertidcliente.Size = new System.Drawing.Size(100, 20);
            this.txt_insertidcliente.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(17, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Periodo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Aprobado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tasa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id Credito";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Cliente";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.cmbconsultacreditos);
            this.tabPage1.Controls.Add(this.cmbid);
            this.tabPage1.Controls.Add(this.lbidcredito);
            this.tabPage1.Controls.Add(this.lbidcred);
            this.tabPage1.Controls.Add(this.dgvconsulta);
            this.tabPage1.Controls.Add(this.Limpiar);
            this.tabPage1.Controls.Add(this.btnconsultarefrescar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(981, 544);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Consultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbconsultacreditos
            // 
            this.cmbconsultacreditos.FormattingEnabled = true;
            this.cmbconsultacreditos.Location = new System.Drawing.Point(26, 146);
            this.cmbconsultacreditos.Name = "cmbconsultacreditos";
            this.cmbconsultacreditos.Size = new System.Drawing.Size(121, 21);
            this.cmbconsultacreditos.TabIndex = 9;
            this.cmbconsultacreditos.SelectedIndexChanged += new System.EventHandler(this.cmbconsultacreditos_SelectedIndexChanged);
            this.cmbconsultacreditos.Click += new System.EventHandler(this.cmbconsultacreditos_Click);
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(26, 64);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(121, 21);
            this.cmbid.TabIndex = 8;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            this.cmbid.Click += new System.EventHandler(this.cmbid_Click);
            // 
            // lbidcredito
            // 
            this.lbidcredito.AutoSize = true;
            this.lbidcredito.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbidcredito.ForeColor = System.Drawing.Color.Transparent;
            this.lbidcredito.Location = new System.Drawing.Point(28, 111);
            this.lbidcredito.Name = "lbidcredito";
            this.lbidcredito.Size = new System.Drawing.Size(119, 13);
            this.lbidcredito.TabIndex = 7;
            this.lbidcredito.Text = "Consultar por id Credito ";
            // 
            // lbidcred
            // 
            this.lbidcred.AutoSize = true;
            this.lbidcred.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbidcred.ForeColor = System.Drawing.Color.Transparent;
            this.lbidcred.Location = new System.Drawing.Point(23, 29);
            this.lbidcred.Name = "lbidcred";
            this.lbidcred.Size = new System.Drawing.Size(152, 13);
            this.lbidcred.TabIndex = 4;
            this.lbidcred.Text = "Consultar Credito por Id Cliente";
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvconsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(8, 199);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(973, 213);
            this.dgvconsulta.TabIndex = 3;
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Transparent;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Limpiar.ForeColor = System.Drawing.Color.Transparent;
            this.Limpiar.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.Limpiar.Location = new System.Drawing.Point(100, 418);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnconsultarefrescar
            // 
            this.btnconsultarefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnconsultarefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsultarefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnconsultarefrescar.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnconsultarefrescar.Location = new System.Drawing.Point(8, 418);
            this.btnconsultarefrescar.Name = "btnconsultarefrescar";
            this.btnconsultarefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultarefrescar.TabIndex = 1;
            this.btnconsultarefrescar.Text = "Refrescar";
            this.btnconsultarefrescar.UseVisualStyleBackColor = false;
            this.btnconsultarefrescar.Click += new System.EventHandler(this.btnconsultarefrescar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cmbperiodo);
            this.tabPage3.Controls.Add(this.rbnocancelado);
            this.tabPage3.Controls.Add(this.rb_cancelado);
            this.tabPage3.Controls.Add(this.lbcancelado);
            this.tabPage3.Controls.Add(this.btnrefrescar);
            this.tabPage3.Controls.Add(this.btnlimpiar);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btngenerarpago);
            this.tabPage3.Controls.Add(this.dgvCredito);
            this.tabPage3.Controls.Add(this.lblIdCliente);
            this.tabPage3.Controls.Add(this.cmbIdCliente);
            this.tabPage3.Controls.Add(this.Pago);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 544);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Actulizar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(8, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Estado de Cuota";
            // 
            // cmbperiodo
            // 
            this.cmbperiodo.FormattingEnabled = true;
            this.cmbperiodo.Location = new System.Drawing.Point(80, 65);
            this.cmbperiodo.Name = "cmbperiodo";
            this.cmbperiodo.Size = new System.Drawing.Size(76, 21);
            this.cmbperiodo.TabIndex = 31;
            this.cmbperiodo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbperiodo_MouseClick);
            // 
            // rbnocancelado
            // 
            this.rbnocancelado.AutoSize = true;
            this.rbnocancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rbnocancelado.ForeColor = System.Drawing.Color.Transparent;
            this.rbnocancelado.Location = new System.Drawing.Point(96, 160);
            this.rbnocancelado.Name = "rbnocancelado";
            this.rbnocancelado.Size = new System.Drawing.Size(93, 17);
            this.rbnocancelado.TabIndex = 28;
            this.rbnocancelado.TabStop = true;
            this.rbnocancelado.Text = "No Cancelado";
            this.rbnocancelado.UseVisualStyleBackColor = false;
            this.rbnocancelado.CheckedChanged += new System.EventHandler(this.rbnocancelado_CheckedChanged);
            // 
            // rb_cancelado
            // 
            this.rb_cancelado.AutoSize = true;
            this.rb_cancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rb_cancelado.ForeColor = System.Drawing.Color.Transparent;
            this.rb_cancelado.Location = new System.Drawing.Point(5, 160);
            this.rb_cancelado.Name = "rb_cancelado";
            this.rb_cancelado.Size = new System.Drawing.Size(76, 17);
            this.rb_cancelado.TabIndex = 27;
            this.rb_cancelado.TabStop = true;
            this.rb_cancelado.Text = "Cancelado";
            this.rb_cancelado.UseVisualStyleBackColor = false;
            this.rb_cancelado.CheckedChanged += new System.EventHandler(this.rb_cancelado_CheckedChanged);
            // 
            // lbcancelado
            // 
            this.lbcancelado.AutoSize = true;
            this.lbcancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbcancelado.Location = new System.Drawing.Point(3, 345);
            this.lbcancelado.Name = "lbcancelado";
            this.lbcancelado.Size = new System.Drawing.Size(0, 13);
            this.lbcancelado.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(981, 544);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Eliminar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.thumb_1920_750482;
            this.ClientSize = new System.Drawing.Size(989, 586);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
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
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.Label Pago;
        private System.Windows.Forms.Button btngenerarpago;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_insertsaldo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_insertamort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_insertintere;
        private System.Windows.Forms.TextBox txt_insertperi;
        private System.Windows.Forms.TextBox txt_inserttasa;
        private System.Windows.Forms.TextBox txt_insertmontoapr;
        private System.Windows.Forms.TextBox txt_insertidcred;
        private System.Windows.Forms.TextBox txt_insertidcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbidcredito;
        private System.Windows.Forms.Label lbidcred;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button btnconsultarefrescar;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.ComboBox cmbconsultacreditos;
        private System.Windows.Forms.Label lbcancelado;
        private System.Windows.Forms.RadioButton rbnocancelado;
        private System.Windows.Forms.RadioButton rb_cancelado;
        private System.Windows.Forms.ComboBox cmbperiodo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.Label lbcuota;
        private System.Windows.Forms.Button btn_refrescar;
        private System.Windows.Forms.DataGridView dgv_insertar;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btnproyeccion;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.CheckBox chklp;
    }
}