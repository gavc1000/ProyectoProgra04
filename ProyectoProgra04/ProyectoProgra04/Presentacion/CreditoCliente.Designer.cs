﻿namespace ProyectoProgra04.Presentacion
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
            this.txt = new System.Windows.Forms.RadioButton();
            this.aXml = new System.Windows.Forms.RadioButton();
            this.Excel = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
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
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(9, 118);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(218, 28);
            this.txt.TabIndex = 5;
            this.txt.Text = "Importar a Texto Plano";
            this.txt.UseVisualStyleBackColor = false;
            // 
            // aXml
            // 
            this.aXml.AutoSize = true;
            this.aXml.BackColor = System.Drawing.Color.Transparent;
            this.aXml.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aXml.ForeColor = System.Drawing.Color.White;
            this.aXml.Location = new System.Drawing.Point(12, 67);
            this.aXml.Name = "aXml";
            this.aXml.Size = new System.Drawing.Size(162, 28);
            this.aXml.TabIndex = 4;
            this.aXml.Text = "Importar a XML";
            this.aXml.UseVisualStyleBackColor = false;
            // 
            // Excel
            // 
            this.Excel.AutoSize = true;
            this.Excel.BackColor = System.Drawing.Color.Transparent;
            this.Excel.Checked = true;
            this.Excel.FlatAppearance.BorderSize = 0;
            this.Excel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Excel.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.ForeColor = System.Drawing.Color.White;
            this.Excel.Location = new System.Drawing.Point(12, 15);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(167, 28);
            this.Excel.TabIndex = 3;
            this.Excel.TabStop = true;
            this.Excel.Text = "Importar a Excel";
            this.Excel.UseVisualStyleBackColor = false;
            this.Excel.CheckedChanged += new System.EventHandler(this.Excel_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(9, 306);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(219, 28);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Exportar a Texto Plano";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 28);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Exportar a XML";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Checked = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radioButton3.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(12, 203);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(168, 28);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Exportar a Excel";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(9, 350);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(97, 35);
            this.btnExp.TabIndex = 9;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            // 
            // CreditoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.aXml);
            this.Controls.Add(this.Excel);
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
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.RadioButton aXml;
        private System.Windows.Forms.RadioButton Excel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnExp;
    }
}