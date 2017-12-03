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
            this.dgvDeducciones = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RadioButton();
            this.aXml = new System.Windows.Forms.RadioButton();
            this.Excel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeducciones
            // 
            this.dgvDeducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeducciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeducciones.Location = new System.Drawing.Point(291, 3);
            this.dgvDeducciones.Name = "dgvDeducciones";
            this.dgvDeducciones.RowTemplate.Height = 24;
            this.dgvDeducciones.Size = new System.Drawing.Size(418, 418);
            this.dgvDeducciones.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(30, 194);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 35);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(9, 118);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(258, 31);
            this.txt.TabIndex = 5;
            this.txt.Text = "Exportar a Texto Plano";
            this.txt.UseVisualStyleBackColor = false;
            // 
            // aXml
            // 
            this.aXml.AutoSize = true;
            this.aXml.BackColor = System.Drawing.Color.Transparent;
            this.aXml.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aXml.ForeColor = System.Drawing.Color.White;
            this.aXml.Location = new System.Drawing.Point(12, 67);
            this.aXml.Name = "aXml";
            this.aXml.Size = new System.Drawing.Size(189, 32);
            this.aXml.TabIndex = 4;
            this.aXml.Text = "Exportar a XML";
            this.aXml.UseVisualStyleBackColor = false;
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
            this.Excel.Location = new System.Drawing.Point(12, 15);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(193, 31);
            this.Excel.TabIndex = 3;
            this.Excel.TabStop = true;
            this.Excel.Text = "Exportar a Excel";
            this.Excel.UseVisualStyleBackColor = false;
            // 
            // CreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.aXml);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvDeducciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditoCliente";
            this.Text = "Gestion de Deducciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeducciones;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton aXml;
        private System.Windows.Forms.RadioButton Excel;
    }
}