﻿namespace ProyectoProgra04.Presentacion
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Pago = new System.Windows.Forms.Label();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.dgvCredito = new System.Windows.Forms.DataGridView();
            this.btngenerarpago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.lbcancelado = new System.Windows.Forms.Label();
            this.rb_cancelado = new System.Windows.Forms.RadioButton();
            this.rbnocancelado = new System.Windows.Forms.RadioButton();
            this.cmbperiodo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnconsultarefrescar = new System.Windows.Forms.Button();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.lbidcred = new System.Windows.Forms.Label();
            this.lbidcredito = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.cmbconsultacreditos = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_insertidcliente = new System.Windows.Forms.TextBox();
            this.txt_insertidcred = new System.Windows.Forms.TextBox();
            this.txt_insertmontoapr = new System.Windows.Forms.TextBox();
            this.txt_inserttasa = new System.Windows.Forms.TextBox();
            this.txt_insertperi = new System.Windows.Forms.TextBox();
            this.txt_insertintere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_insertamort = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_insertsaldo = new System.Windows.Forms.TextBox();
            this.lbcuota = new System.Windows.Forms.Label();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.btnproyeccion = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.dgv_insertar = new System.Windows.Forms.DataGridView();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastProy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idcredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chklp = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidlote = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insertar)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProyectoProgra04.Properties.Resources.fullimage;
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
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1311, 673);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Actualizar";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Pago
            // 
            this.Pago.AutoSize = true;
            this.Pago.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.Pago.Location = new System.Drawing.Point(3, 260);
            this.Pago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(0, 17);
            this.Pago.TabIndex = 18;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(107, 32);
            this.cmbIdCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(100, 24);
            this.cmbIdCliente.TabIndex = 6;
            this.cmbIdCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIdCliente_SelectedIndexChanged);
            this.cmbIdCliente.Click += new System.EventHandler(this.cmbIdCliente_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.ForeColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.lblIdCliente.Location = new System.Drawing.Point(7, 42);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(66, 17);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Id Cliente";
            this.lblIdCliente.Click += new System.EventHandler(this.lblIdCliente_Click);
            // 
            // dgvCredito
            // 
            this.dgvCredito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredito.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredito.Location = new System.Drawing.Point(285, 22);
            this.dgvCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCredito.Name = "dgvCredito";
            this.dgvCredito.RowTemplate.Height = 24;
            this.dgvCredito.Size = new System.Drawing.Size(972, 314);
            this.dgvCredito.TabIndex = 8;
            this.dgvCredito.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCredito_CellMouseClick);
            // 
            // btngenerarpago
            // 
            this.btngenerarpago.BackColor = System.Drawing.Color.Transparent;
            this.btngenerarpago.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btngenerarpago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarpago.ForeColor = System.Drawing.Color.Transparent;
            this.btngenerarpago.Location = new System.Drawing.Point(592, 353);
            this.btngenerarpago.Margin = new System.Windows.Forms.Padding(4);
            this.btngenerarpago.Name = "btngenerarpago";
            this.btngenerarpago.Size = new System.Drawing.Size(112, 33);
            this.btngenerarpago.TabIndex = 20;
            this.btngenerarpago.Text = "Generar Pago";
            this.btngenerarpago.UseVisualStyleBackColor = false;
            this.btngenerarpago.Click += new System.EventHandler(this.btngenerarpago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Periodo";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.Location = new System.Drawing.Point(917, 353);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 33);
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
            this.btnrefrescar.Location = new System.Drawing.Point(747, 353);
            this.btnrefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(100, 33);
            this.btnrefrescar.TabIndex = 22;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = false;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // lbcancelado
            // 
            this.lbcancelado.AutoSize = true;
            this.lbcancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbcancelado.Location = new System.Drawing.Point(4, 425);
            this.lbcancelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcancelado.Name = "lbcancelado";
            this.lbcancelado.Size = new System.Drawing.Size(0, 17);
            this.lbcancelado.TabIndex = 26;
            // 
            // rb_cancelado
            // 
            this.rb_cancelado.AutoSize = true;
            this.rb_cancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rb_cancelado.ForeColor = System.Drawing.Color.Transparent;
            this.rb_cancelado.Location = new System.Drawing.Point(7, 197);
            this.rb_cancelado.Margin = new System.Windows.Forms.Padding(4);
            this.rb_cancelado.Name = "rb_cancelado";
            this.rb_cancelado.Size = new System.Drawing.Size(96, 21);
            this.rb_cancelado.TabIndex = 27;
            this.rb_cancelado.TabStop = true;
            this.rb_cancelado.Text = "Cancelado";
            this.rb_cancelado.UseVisualStyleBackColor = false;
            this.rb_cancelado.CheckedChanged += new System.EventHandler(this.rb_cancelado_CheckedChanged);
            // 
            // rbnocancelado
            // 
            this.rbnocancelado.AutoSize = true;
            this.rbnocancelado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rbnocancelado.ForeColor = System.Drawing.Color.Transparent;
            this.rbnocancelado.Location = new System.Drawing.Point(128, 197);
            this.rbnocancelado.Margin = new System.Windows.Forms.Padding(4);
            this.rbnocancelado.Name = "rbnocancelado";
            this.rbnocancelado.Size = new System.Drawing.Size(118, 21);
            this.rbnocancelado.TabIndex = 28;
            this.rbnocancelado.TabStop = true;
            this.rbnocancelado.Text = "No Cancelado";
            this.rbnocancelado.UseVisualStyleBackColor = false;
            this.rbnocancelado.CheckedChanged += new System.EventHandler(this.rbnocancelado_CheckedChanged);
            // 
            // cmbperiodo
            // 
            this.cmbperiodo.FormattingEnabled = true;
            this.cmbperiodo.Location = new System.Drawing.Point(107, 80);
            this.cmbperiodo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbperiodo.Name = "cmbperiodo";
            this.cmbperiodo.Size = new System.Drawing.Size(100, 24);
            this.cmbperiodo.TabIndex = 31;
            this.cmbperiodo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbperiodo_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(11, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Estado de Cuota";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ProyectoProgra04.Properties.Resources.fullimage;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.cmbconsultacreditos);
            this.tabPage1.Controls.Add(this.cmbid);
            this.tabPage1.Controls.Add(this.lbidcredito);
            this.tabPage1.Controls.Add(this.lbidcred);
            this.tabPage1.Controls.Add(this.dgvconsulta);
            this.tabPage1.Controls.Add(this.btnconsultarefrescar);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1311, 673);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Consultar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnconsultarefrescar
            // 
            this.btnconsultarefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnconsultarefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsultarefrescar.ForeColor = System.Drawing.Color.Transparent;
            this.btnconsultarefrescar.Image = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnconsultarefrescar.Location = new System.Drawing.Point(11, 514);
            this.btnconsultarefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnconsultarefrescar.Name = "btnconsultarefrescar";
            this.btnconsultarefrescar.Size = new System.Drawing.Size(100, 28);
            this.btnconsultarefrescar.TabIndex = 1;
            this.btnconsultarefrescar.Text = "Refrescar";
            this.btnconsultarefrescar.UseVisualStyleBackColor = false;
            this.btnconsultarefrescar.Click += new System.EventHandler(this.btnconsultarefrescar_Click);
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvconsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(11, 245);
            this.dgvconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(1297, 262);
            this.dgvconsulta.TabIndex = 3;
            // 
            // lbidcred
            // 
            this.lbidcred.AutoSize = true;
            this.lbidcred.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbidcred.ForeColor = System.Drawing.Color.Transparent;
            this.lbidcred.Location = new System.Drawing.Point(31, 36);
            this.lbidcred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbidcred.Name = "lbidcred";
            this.lbidcred.Size = new System.Drawing.Size(204, 17);
            this.lbidcred.TabIndex = 4;
            this.lbidcred.Text = "Consultar Credito por Id Cliente";
            // 
            // lbidcredito
            // 
            this.lbidcredito.AutoSize = true;
            this.lbidcredito.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbidcredito.ForeColor = System.Drawing.Color.Transparent;
            this.lbidcredito.Location = new System.Drawing.Point(37, 137);
            this.lbidcredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbidcredito.Name = "lbidcredito";
            this.lbidcredito.Size = new System.Drawing.Size(161, 17);
            this.lbidcredito.TabIndex = 7;
            this.lbidcredito.Text = "Consultar por id Credito ";
            // 
            // cmbid
            // 
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(35, 79);
            this.cmbid.Margin = new System.Windows.Forms.Padding(4);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(160, 24);
            this.cmbid.TabIndex = 8;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            this.cmbid.Click += new System.EventHandler(this.cmbid_Click);
            // 
            // cmbconsultacreditos
            // 
            this.cmbconsultacreditos.FormattingEnabled = true;
            this.cmbconsultacreditos.Location = new System.Drawing.Point(35, 180);
            this.cmbconsultacreditos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbconsultacreditos.Name = "cmbconsultacreditos";
            this.cmbconsultacreditos.Size = new System.Drawing.Size(160, 24);
            this.cmbconsultacreditos.TabIndex = 9;
            this.cmbconsultacreditos.SelectedIndexChanged += new System.EventHandler(this.cmbconsultacreditos_SelectedIndexChanged);
            this.cmbconsultacreditos.Click += new System.EventHandler(this.cmbconsultacreditos_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ProyectoProgra04.Properties.Resources.fullimage;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.txtidlote);
            this.tabPage4.Controls.Add(this.txtcuota);
            this.tabPage4.Controls.Add(this.txt_insertsaldo);
            this.tabPage4.Controls.Add(this.txt_insertamort);
            this.tabPage4.Controls.Add(this.txt_insertintere);
            this.tabPage4.Controls.Add(this.txt_insertperi);
            this.tabPage4.Controls.Add(this.txt_inserttasa);
            this.tabPage4.Controls.Add(this.txt_insertmontoapr);
            this.tabPage4.Controls.Add(this.txt_insertidcred);
            this.tabPage4.Controls.Add(this.txt_insertidcliente);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.chklp);
            this.tabPage4.Controls.Add(this.dgv_insertar);
            this.tabPage4.Controls.Add(this.btn_insertar);
            this.tabPage4.Controls.Add(this.btnproyeccion);
            this.tabPage4.Controls.Add(this.lbcuota);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1311, 673);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Insertar";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(23, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id Credito";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(23, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Aprobado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.ForeColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(23, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Periodo";
            // 
            // txt_insertidcliente
            // 
            this.txt_insertidcliente.Location = new System.Drawing.Point(157, 7);
            this.txt_insertidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertidcliente.Name = "txt_insertidcliente";
            this.txt_insertidcliente.Size = new System.Drawing.Size(132, 22);
            this.txt_insertidcliente.TabIndex = 1;
            // 
            // txt_insertidcred
            // 
            this.txt_insertidcred.Location = new System.Drawing.Point(157, 39);
            this.txt_insertidcred.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertidcred.Name = "txt_insertidcred";
            this.txt_insertidcred.Size = new System.Drawing.Size(132, 22);
            this.txt_insertidcred.TabIndex = 2;
            // 
            // txt_insertmontoapr
            // 
            this.txt_insertmontoapr.Location = new System.Drawing.Point(157, 71);
            this.txt_insertmontoapr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertmontoapr.Name = "txt_insertmontoapr";
            this.txt_insertmontoapr.Size = new System.Drawing.Size(132, 22);
            this.txt_insertmontoapr.TabIndex = 3;
            // 
            // txt_inserttasa
            // 
            this.txt_inserttasa.Location = new System.Drawing.Point(157, 103);
            this.txt_inserttasa.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inserttasa.Name = "txt_inserttasa";
            this.txt_inserttasa.Size = new System.Drawing.Size(132, 22);
            this.txt_inserttasa.TabIndex = 4;
            // 
            // txt_insertperi
            // 
            this.txt_insertperi.Location = new System.Drawing.Point(157, 135);
            this.txt_insertperi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertperi.Name = "txt_insertperi";
            this.txt_insertperi.Size = new System.Drawing.Size(132, 22);
            this.txt_insertperi.TabIndex = 5;
            // 
            // txt_insertintere
            // 
            this.txt_insertintere.Location = new System.Drawing.Point(157, 199);
            this.txt_insertintere.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertintere.Name = "txt_insertintere";
            this.txt_insertintere.ReadOnly = true;
            this.txt_insertintere.Size = new System.Drawing.Size(132, 22);
            this.txt_insertintere.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(23, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intereses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Highlight;
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(23, 235);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Amortizacion";
            // 
            // txt_insertamort
            // 
            this.txt_insertamort.Location = new System.Drawing.Point(157, 231);
            this.txt_insertamort.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertamort.Name = "txt_insertamort";
            this.txt_insertamort.ReadOnly = true;
            this.txt_insertamort.Size = new System.Drawing.Size(132, 22);
            this.txt_insertamort.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Highlight;
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(23, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Saldo";
            // 
            // txt_insertsaldo
            // 
            this.txt_insertsaldo.Location = new System.Drawing.Point(157, 263);
            this.txt_insertsaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_insertsaldo.Name = "txt_insertsaldo";
            this.txt_insertsaldo.ReadOnly = true;
            this.txt_insertsaldo.Size = new System.Drawing.Size(132, 22);
            this.txt_insertsaldo.TabIndex = 13;
            // 
            // lbcuota
            // 
            this.lbcuota.AutoSize = true;
            this.lbcuota.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbcuota.ForeColor = System.Drawing.Color.Transparent;
            this.lbcuota.Location = new System.Drawing.Point(23, 171);
            this.lbcuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcuota.Name = "lbcuota";
            this.lbcuota.Size = new System.Drawing.Size(45, 17);
            this.lbcuota.TabIndex = 17;
            this.lbcuota.Text = "Cuota";
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(157, 167);
            this.txtcuota.Margin = new System.Windows.Forms.Padding(4);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(132, 22);
            this.txtcuota.TabIndex = 19;
            // 
            // btnproyeccion
            // 
            this.btnproyeccion.BackColor = System.Drawing.Color.Transparent;
            this.btnproyeccion.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnproyeccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnproyeccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproyeccion.ForeColor = System.Drawing.Color.Transparent;
            this.btnproyeccion.Location = new System.Drawing.Point(11, 331);
            this.btnproyeccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnproyeccion.Name = "btnproyeccion";
            this.btnproyeccion.Size = new System.Drawing.Size(148, 28);
            this.btnproyeccion.TabIndex = 20;
            this.btnproyeccion.Text = "Generar Proyección";
            this.btnproyeccion.UseVisualStyleBackColor = false;
            this.btnproyeccion.Click += new System.EventHandler(this.btnproyeccion_Click_1);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Transparent;
            this.btn_insertar.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btn_insertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insertar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_insertar.Location = new System.Drawing.Point(191, 331);
            this.btn_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(100, 28);
            this.btn_insertar.TabIndex = 21;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click_1);
            // 
            // dgv_insertar
            // 
            this.dgv_insertar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_insertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_insertar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcredito,
            this.LastProy,
            this.IDCliente,
            this.Monto,
            this.tasa,
            this.Periodo,
            this.Cuota,
            this.Intereses,
            this.Amort,
            this.Saldo,
            this.Cancel,
            this.IdLote});
            this.dgv_insertar.Location = new System.Drawing.Point(299, 7);
            this.dgv_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_insertar.Name = "dgv_insertar";
            this.dgv_insertar.Size = new System.Drawing.Size(999, 327);
            this.dgv_insertar.TabIndex = 22;
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "ID Lote";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            this.IdLote.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.DataPropertyName = "Cancelado";
            this.Cancel.HeaderText = "Cancelado";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Visible = false;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "Saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Visible = false;
            // 
            // Amort
            // 
            this.Amort.DataPropertyName = "Amort";
            this.Amort.HeaderText = "Amortizacion";
            this.Amort.Name = "Amort";
            this.Amort.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.DataPropertyName = "Intereses";
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // Cuota
            // 
            this.Cuota.DataPropertyName = "Pago";
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            this.Cuota.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // tasa
            // 
            this.tasa.DataPropertyName = "tasa";
            this.tasa.HeaderText = "Tasa";
            this.tasa.Name = "tasa";
            this.tasa.ReadOnly = true;
            this.tasa.Visible = false;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto Aprobado";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // IDCliente
            // 
            this.IDCliente.DataPropertyName = "IdCliente";
            this.IDCliente.HeaderText = "Cliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Visible = false;
            // 
            // LastProy
            // 
            this.LastProy.DataPropertyName = "LastProy";
            this.LastProy.HeaderText = "LastProy";
            this.LastProy.Name = "LastProy";
            this.LastProy.ReadOnly = true;
            this.LastProy.Visible = false;
            // 
            // Idcredito
            // 
            this.Idcredito.DataPropertyName = "IdCredito";
            this.Idcredito.HeaderText = "Credito";
            this.Idcredito.Name = "Idcredito";
            this.Idcredito.ReadOnly = true;
            this.Idcredito.Visible = false;
            // 
            // chklp
            // 
            this.chklp.AutoSize = true;
            this.chklp.BackColor = System.Drawing.Color.DodgerBlue;
            this.chklp.ForeColor = System.Drawing.Color.Transparent;
            this.chklp.Location = new System.Drawing.Point(11, 378);
            this.chklp.Margin = new System.Windows.Forms.Padding(4);
            this.chklp.Name = "chklp";
            this.chklp.Size = new System.Drawing.Size(106, 21);
            this.chklp.TabIndex = 25;
            this.chklp.Text = "Largo Plazo";
            this.chklp.UseVisualStyleBackColor = false;
            this.chklp.CheckedChanged += new System.EventHandler(this.chklp_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(23, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Id Lote";
            // 
            // txtidlote
            // 
            this.txtidlote.Location = new System.Drawing.Point(157, 295);
            this.txtidlote.Margin = new System.Windows.Forms.Padding(4);
            this.txtidlote.Name = "txtidlote";
            this.txtidlote.Size = new System.Drawing.Size(132, 22);
            this.txtidlote.TabIndex = 27;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1319, 705);
            this.tabControl2.TabIndex = 27;
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 667);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Credito";
            this.Text = "Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredito)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insertar)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbperiodo;
        private System.Windows.Forms.RadioButton rbnocancelado;
        private System.Windows.Forms.RadioButton rb_cancelado;
        private System.Windows.Forms.Label lbcancelado;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngenerarpago;
        private System.Windows.Forms.DataGridView dgvCredito;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.Label Pago;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbconsultacreditos;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Label lbidcredito;
        private System.Windows.Forms.Label lbidcred;
        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.Button btnconsultarefrescar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtidlote;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.TextBox txt_insertsaldo;
        private System.Windows.Forms.TextBox txt_insertamort;
        private System.Windows.Forms.TextBox txt_insertintere;
        private System.Windows.Forms.TextBox txt_insertperi;
        private System.Windows.Forms.TextBox txt_inserttasa;
        private System.Windows.Forms.TextBox txt_insertmontoapr;
        private System.Windows.Forms.TextBox txt_insertidcred;
        private System.Windows.Forms.TextBox txt_insertidcliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chklp;
        private System.Windows.Forms.DataGridView dgv_insertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastProy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btnproyeccion;
        private System.Windows.Forms.Label lbcuota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
    }
}