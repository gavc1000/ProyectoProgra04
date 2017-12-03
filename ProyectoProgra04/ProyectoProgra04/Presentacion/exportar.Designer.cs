namespace ProyectoProgra04.Presentacion
{
    partial class exportar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exportar));
            this.Excel = new System.Windows.Forms.RadioButton();
            this.aXml = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.RadioButton();
            this.btnexport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbolote = new System.Windows.Forms.ComboBox();
            this.dgvlote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlote)).BeginInit();
            this.SuspendLayout();
            // 
            // Excel
            // 
            this.Excel.AutoSize = true;
            this.Excel.BackColor = System.Drawing.Color.Transparent;
            this.Excel.Checked = true;
            this.Excel.FlatAppearance.BorderSize = 0;
            this.Excel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Excel.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.ForeColor = System.Drawing.Color.White;
            this.Excel.Location = new System.Drawing.Point(81, 59);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(193, 31);
            this.Excel.TabIndex = 0;
            this.Excel.TabStop = true;
            this.Excel.Text = "Exportar a Excel";
            this.Excel.UseVisualStyleBackColor = false;
            // 
            // aXml
            // 
            this.aXml.AutoSize = true;
            this.aXml.BackColor = System.Drawing.Color.Transparent;
            this.aXml.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aXml.ForeColor = System.Drawing.Color.White;
            this.aXml.Location = new System.Drawing.Point(81, 135);
            this.aXml.Name = "aXml";
            this.aXml.Size = new System.Drawing.Size(189, 32);
            this.aXml.TabIndex = 1;
            this.aXml.Text = "Exportar a XML";
            this.aXml.UseVisualStyleBackColor = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(81, 201);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(258, 31);
            this.txt.TabIndex = 2;
            this.txt.Text = "Exportar a Texto Plano";
            this.txt.UseVisualStyleBackColor = false;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.Transparent;
            this.btnexport.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexport.Location = new System.Drawing.Point(338, 391);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(110, 46);
            this.btnexport.TabIndex = 3;
            this.btnexport.Text = "Exportar";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lote";
            // 
            // cbolote
            // 
            this.cbolote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolote.FormattingEnabled = true;
            this.cbolote.Items.AddRange(new object[] {
            "0"});
            this.cbolote.Location = new System.Drawing.Point(115, 292);
            this.cbolote.Name = "cbolote";
            this.cbolote.Size = new System.Drawing.Size(224, 24);
            this.cbolote.TabIndex = 6;
            this.cbolote.SelectedIndexChanged += new System.EventHandler(this.cbolote_SelectedIndexChanged);
            this.cbolote.Click += new System.EventHandler(this.cbolote_Click);
            // 
            // dgvlote
            // 
            this.dgvlote.AllowUserToAddRows = false;
            this.dgvlote.AllowUserToDeleteRows = false;
            this.dgvlote.AllowUserToResizeColumns = false;
            this.dgvlote.AllowUserToResizeRows = false;
            this.dgvlote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvlote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlote.Enabled = false;
            this.dgvlote.Location = new System.Drawing.Point(504, 3);
            this.dgvlote.Name = "dgvlote";
            this.dgvlote.RowTemplate.Height = 24;
            this.dgvlote.Size = new System.Drawing.Size(441, 467);
            this.dgvlote.TabIndex = 7;
            // 
            // exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(946, 471);
            this.Controls.Add(this.dgvlote);
            this.Controls.Add(this.cbolote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.aXml);
            this.Controls.Add(this.Excel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "exportar";
            this.Text = "Exportar Datos";
            this.Load += new System.EventHandler(this.exportar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Excel;
        private System.Windows.Forms.RadioButton aXml;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbolote;
        private System.Windows.Forms.DataGridView dgvlote;
    }
}