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
            this.btnagregarcliente = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncredito
            // 
            this.btncredito.BackColor = System.Drawing.Color.Transparent;
            this.btncredito.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btncredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncredito.Location = new System.Drawing.Point(22, 20);
            this.btncredito.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(171, 166);
            this.btncredito.TabIndex = 0;
            this.btncredito.Text = "Credito";
            this.btncredito.UseVisualStyleBackColor = false;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // btnagregarcliente
            // 
            this.btnagregarcliente.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarcliente.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnagregarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregarcliente.Location = new System.Drawing.Point(202, 20);
            this.btnagregarcliente.Name = "btnagregarcliente";
            this.btnagregarcliente.Size = new System.Drawing.Size(171, 166);
            this.btnagregarcliente.TabIndex = 1;
            this.btnagregarcliente.Text = "Agregar Cliente";
            this.btnagregarcliente.UseVisualStyleBackColor = false;
            this.btnagregarcliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Californian FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(527, 469);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 39);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnExpo
            // 
            this.btnExpo.BackColor = System.Drawing.Color.Transparent;
            this.btnExpo.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnExpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpo.Location = new System.Drawing.Point(263, 328);
            this.btnExpo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(171, 166);
            this.btnExpo.TabIndex = 4;
            this.btnExpo.Text = "Exportar Datos";
            this.btnExpo.UseVisualStyleBackColor = false;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // btnimp
            // 
            this.btnimp.BackColor = System.Drawing.Color.Transparent;
            this.btnimp.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnimp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimp.Location = new System.Drawing.Point(49, 328);
            this.btnimp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(171, 166);
            this.btnimp.TabIndex = 7;
            this.btnimp.Text = "Importar Datos";
            this.btnimp.UseVisualStyleBackColor = false;
            this.btnimp.Click += new System.EventHandler(this.btnimp_Click);
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.thumb_1920_750482;
            this.ClientSize = new System.Drawing.Size(656, 536);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnagregarcliente);
            this.Controls.Add(this.btncredito);
            this.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Banco";
            this.Text = "Banco Los Cositos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncredito;
        private System.Windows.Forms.Button btnagregarcliente;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnExpo;
        private System.Windows.Forms.Button btnimp;
    }
}