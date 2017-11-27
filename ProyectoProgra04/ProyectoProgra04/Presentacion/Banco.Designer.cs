namespace ProyectoProgra04.Presentacion
{
    partial class Banco
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
            this.btncredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncredito
            // 
            this.btncredito.Location = new System.Drawing.Point(12, 12);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(113, 98);
            this.btncredito.TabIndex = 0;
            this.btncredito.Text = "Credito";
            this.btncredito.UseVisualStyleBackColor = true;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Asuna01_30;
            this.ClientSize = new System.Drawing.Size(431, 305);
            this.Controls.Add(this.btncredito);
            this.Name = "Banco";
            this.Text = "Banco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncredito;
    }
}