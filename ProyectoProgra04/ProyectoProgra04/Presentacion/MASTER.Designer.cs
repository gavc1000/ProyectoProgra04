namespace ProyectoProgra04.Presentacion
{
    partial class MASTER
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
            this.btnagregarclientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncredito
            // 
            this.btncredito.BackColor = System.Drawing.Color.Transparent;
            this.btncredito.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btncredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncredito.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncredito.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncredito.Location = new System.Drawing.Point(12, 12);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(173, 172);
            this.btncredito.TabIndex = 0;
            this.btncredito.Text = "Credito";
            this.btncredito.UseVisualStyleBackColor = false;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // btnagregarclientes
            // 
            this.btnagregarclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarclientes.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnagregarclientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregarclientes.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarclientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregarclientes.Location = new System.Drawing.Point(191, 13);
            this.btnagregarclientes.Name = "btnagregarclientes";
            this.btnagregarclientes.Size = new System.Drawing.Size(173, 172);
            this.btnagregarclientes.TabIndex = 1;
            this.btnagregarclientes.Text = "Agregar Clientes";
            this.btnagregarclientes.UseVisualStyleBackColor = false;
            this.btnagregarclientes.Click += new System.EventHandler(this.btnagregarclientes_Click);
            // 
            // MASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Asuna01_50;
            this.ClientSize = new System.Drawing.Size(716, 501);
            this.Controls.Add(this.btnagregarclientes);
            this.Controls.Add(this.btncredito);
            this.Name = "MASTER";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncredito;
        private System.Windows.Forms.Button btnagregarclientes;
    }
}