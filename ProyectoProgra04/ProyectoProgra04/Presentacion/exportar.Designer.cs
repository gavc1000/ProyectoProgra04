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
            this.Excel = new System.Windows.Forms.RadioButton();
            this.aXml = new System.Windows.Forms.RadioButton();
            this.txt = new System.Windows.Forms.RadioButton();
            this.btnexport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Excel
            // 
            this.Excel.AutoSize = true;
            this.Excel.BackColor = System.Drawing.Color.Transparent;
            this.Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Excel.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel.ForeColor = System.Drawing.Color.White;
            this.Excel.Location = new System.Drawing.Point(81, 59);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(192, 31);
            this.Excel.TabIndex = 0;
            this.Excel.TabStop = true;
            this.Excel.Text = "Exportar a Excel";
            this.Excel.UseVisualStyleBackColor = false;
            // 
            // aXml
            // 
            this.aXml.AutoSize = true;
            this.aXml.BackColor = System.Drawing.Color.Transparent;
            this.aXml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aXml.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aXml.ForeColor = System.Drawing.Color.White;
            this.aXml.Location = new System.Drawing.Point(81, 135);
            this.aXml.Name = "aXml";
            this.aXml.Size = new System.Drawing.Size(188, 32);
            this.aXml.TabIndex = 1;
            this.aXml.TabStop = true;
            this.aXml.Text = "Exportar a XML";
            this.aXml.UseVisualStyleBackColor = false;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(81, 201);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(257, 31);
            this.txt.TabIndex = 2;
            this.txt.TabStop = true;
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
            // 
            // exportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(505, 471);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.aXml);
            this.Controls.Add(this.Excel);
            this.Name = "exportar";
            this.Text = "Exportar Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Excel;
        private System.Windows.Forms.RadioButton aXml;
        private System.Windows.Forms.RadioButton txt;
        private System.Windows.Forms.Button btnexport;
    }
}