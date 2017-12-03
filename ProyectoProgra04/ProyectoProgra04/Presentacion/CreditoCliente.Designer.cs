namespace ProyectoProgra04.Presentacion
{
    partial class CreditoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditoCliente));
            this.dgvCred = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.ftxt = new System.Windows.Forms.RadioButton();
            this.fXml = new System.Windows.Forms.RadioButton();
            this.fExcel = new System.Windows.Forms.RadioButton();
            this.tText = new System.Windows.Forms.RadioButton();
            this.tXML = new System.Windows.Forms.RadioButton();
            this.tExcel = new System.Windows.Forms.RadioButton();
            this.btnExp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCred)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCred
            // 
            this.dgvCred.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCred.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCred.Location = new System.Drawing.Point(291, 3);
            this.dgvCred.Name = "dgvCred";
            this.dgvCred.RowTemplate.Height = 24;
            this.dgvCred.Size = new System.Drawing.Size(418, 418);
            this.dgvCred.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 162);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 35);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // ftxt
            // 
            this.ftxt.AutoSize = true;
            this.ftxt.BackColor = System.Drawing.Color.Transparent;
            this.ftxt.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftxt.ForeColor = System.Drawing.Color.White;
            this.ftxt.Location = new System.Drawing.Point(9, 118);
            this.ftxt.Name = "ftxt";
            this.ftxt.Size = new System.Drawing.Size(218, 28);
            this.ftxt.TabIndex = 5;
            this.ftxt.Text = "Importar a Texto Plano";
            this.ftxt.UseVisualStyleBackColor = false;
            // 
            // fXml
            // 
            this.fXml.AutoSize = true;
            this.fXml.BackColor = System.Drawing.Color.Transparent;
            this.fXml.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fXml.ForeColor = System.Drawing.Color.White;
            this.fXml.Location = new System.Drawing.Point(12, 67);
            this.fXml.Name = "fXml";
            this.fXml.Size = new System.Drawing.Size(162, 28);
            this.fXml.TabIndex = 4;
            this.fXml.Text = "Importar a XML";
            this.fXml.UseVisualStyleBackColor = false;
            // 
            // fExcel
            // 
            this.fExcel.AutoSize = true;
            this.fExcel.BackColor = System.Drawing.Color.Transparent;
            this.fExcel.Checked = true;
            this.fExcel.FlatAppearance.BorderSize = 0;
            this.fExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.fExcel.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fExcel.ForeColor = System.Drawing.Color.White;
            this.fExcel.Location = new System.Drawing.Point(12, 15);
            this.fExcel.Name = "fExcel";
            this.fExcel.Size = new System.Drawing.Size(167, 28);
            this.fExcel.TabIndex = 3;
            this.fExcel.TabStop = true;
            this.fExcel.Text = "Importar a Excel";
            this.fExcel.UseVisualStyleBackColor = false;
            this.fExcel.CheckedChanged += new System.EventHandler(this.Excel_CheckedChanged);
            // 
            // tText
            // 
            this.tText.AutoSize = true;
            this.tText.BackColor = System.Drawing.Color.Transparent;
            this.tText.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tText.ForeColor = System.Drawing.Color.White;
            this.tText.Location = new System.Drawing.Point(9, 306);
            this.tText.Name = "tText";
            this.tText.Size = new System.Drawing.Size(219, 28);
            this.tText.TabIndex = 8;
            this.tText.Text = "Exportar a Texto Plano";
            this.tText.UseVisualStyleBackColor = false;
            // 
            // tXML
            // 
            this.tXML.AutoSize = true;
            this.tXML.BackColor = System.Drawing.Color.Transparent;
            this.tXML.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tXML.ForeColor = System.Drawing.Color.White;
            this.tXML.Location = new System.Drawing.Point(12, 255);
            this.tXML.Name = "tXML";
            this.tXML.Size = new System.Drawing.Size(163, 28);
            this.tXML.TabIndex = 7;
            this.tXML.Text = "Exportar a XML";
            this.tXML.UseVisualStyleBackColor = false;
            // 
            // tExcel
            // 
            this.tExcel.AutoSize = true;
            this.tExcel.BackColor = System.Drawing.Color.Transparent;
            this.tExcel.Checked = true;
            this.tExcel.FlatAppearance.BorderSize = 0;
            this.tExcel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.tExcel.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tExcel.ForeColor = System.Drawing.Color.White;
            this.tExcel.Location = new System.Drawing.Point(12, 203);
            this.tExcel.Name = "tExcel";
            this.tExcel.Size = new System.Drawing.Size(168, 28);
            this.tExcel.TabIndex = 6;
            this.tExcel.TabStop = true;
            this.tExcel.Text = "Exportar a Excel";
            this.tExcel.UseVisualStyleBackColor = false;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(9, 350);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(97, 35);
            this.btnExp.TabIndex = 9;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // CreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.tText);
            this.Controls.Add(this.tXML);
            this.Controls.Add(this.tExcel);
            this.Controls.Add(this.ftxt);
            this.Controls.Add(this.fXml);
            this.Controls.Add(this.fExcel);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvCred);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditoCliente";
            this.Text = "Gestion de Deducciones";
            this.Load += new System.EventHandler(this.CreditoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCred;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton ftxt;
        private System.Windows.Forms.RadioButton fXml;
        private System.Windows.Forms.RadioButton fExcel;
        private System.Windows.Forms.RadioButton tText;
        private System.Windows.Forms.RadioButton tXML;
        private System.Windows.Forms.RadioButton tExcel;
        private System.Windows.Forms.Button btnExp;
    }
}