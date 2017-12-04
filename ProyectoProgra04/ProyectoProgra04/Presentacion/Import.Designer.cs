namespace ProyectoProgra04.Presentacion
{
    partial class Import
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
            this.btnImp = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.RadioButton();
            this.aXml = new System.Windows.Forms.RadioButton();
            this.Excel = new System.Windows.Forms.RadioButton();
            this.dgvlote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlote)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImp
            // 
            this.btnImp.BackColor = System.Drawing.Color.Transparent;
            this.btnImp.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImp.Location = new System.Drawing.Point(213, 371);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(110, 46);
            this.btnImp.TabIndex = 11;
            this.btnImp.Text = "Importar";
            this.btnImp.UseVisualStyleBackColor = false;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(12, 179);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(272, 31);
            this.txt.TabIndex = 10;
            this.txt.Text = "Importar de Texto Plano";
            this.txt.UseVisualStyleBackColor = false;
            // 
            // aXml
            // 
            this.aXml.AutoSize = true;
            this.aXml.BackColor = System.Drawing.Color.Transparent;
            this.aXml.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aXml.ForeColor = System.Drawing.Color.White;
            this.aXml.Location = new System.Drawing.Point(12, 113);
            this.aXml.Name = "aXml";
            this.aXml.Size = new System.Drawing.Size(200, 32);
            this.aXml.TabIndex = 9;
            this.aXml.Text = "Importar de XML";
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
            this.Excel.Location = new System.Drawing.Point(12, 37);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(207, 31);
            this.Excel.TabIndex = 8;
            this.Excel.TabStop = true;
            this.Excel.Text = "Importar de Excel";
            this.Excel.UseVisualStyleBackColor = false;
            // 
            // dgvlote
            // 
            this.dgvlote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlote.Location = new System.Drawing.Point(385, 12);
            this.dgvlote.Name = "dgvlote";
            this.dgvlote.RowTemplate.Height = 24;
            this.dgvlote.Size = new System.Drawing.Size(351, 452);
            this.dgvlote.TabIndex = 13;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.thumb_1920_750482;
            this.ClientSize = new System.Drawing.Size(748, 476);
            this.Controls.Add(this.dgvlote);
            this.Controls.Add(this.btnImp);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.aXml);
            this.Controls.Add(this.Excel);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton aXml;
        private System.Windows.Forms.RadioButton Excel;
        private System.Windows.Forms.DataGridView dgvlote;
    }
}