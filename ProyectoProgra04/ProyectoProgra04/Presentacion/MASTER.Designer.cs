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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MASTER));
            this.btncredito = new System.Windows.Forms.Button();
            this.btnagregarclientes = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnimp = new System.Windows.Forms.Button();
            this.btnExpo = new System.Windows.Forms.Button();
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
            this.btncredito.Location = new System.Drawing.Point(16, 15);
            this.btncredito.Margin = new System.Windows.Forms.Padding(4);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(231, 212);
            this.btncredito.TabIndex = 0;
            this.btncredito.Text = "Credito";
            this.btncredito.UseVisualStyleBackColor = false;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // btnagregarclientes
            // 
            this.btnagregarclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarclientes.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnagregarclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnagregarclientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregarclientes.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarclientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagregarclientes.Location = new System.Drawing.Point(255, 16);
            this.btnagregarclientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregarclientes.Name = "btnagregarclientes";
            this.btnagregarclientes.Size = new System.Drawing.Size(231, 212);
            this.btnagregarclientes.TabIndex = 1;
            this.btnagregarclientes.Text = "Agregar Clientes";
            this.btnagregarclientes.UseVisualStyleBackColor = false;
            this.btnagregarclientes.Click += new System.EventHandler(this.btnagregarclientes_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(839, 566);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 39);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnimp
            // 
            this.btnimp.BackColor = System.Drawing.Color.Transparent;
            this.btnimp.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnimp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnimp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimp.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnimp.Location = new System.Drawing.Point(16, 235);
            this.btnimp.Margin = new System.Windows.Forms.Padding(5);
            this.btnimp.Name = "btnimp";
            this.btnimp.Size = new System.Drawing.Size(231, 212);
            this.btnimp.TabIndex = 8;
            this.btnimp.Text = "Importar Datos";
            this.btnimp.UseVisualStyleBackColor = false;
            // 
            // btnExpo
            // 
            this.btnExpo.BackColor = System.Drawing.Color.Transparent;
            this.btnExpo.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnExpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExpo.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpo.Location = new System.Drawing.Point(712, 325);
            this.btnExpo.Margin = new System.Windows.Forms.Padding(5);
            this.btnExpo.Name = "btnExpo";
            this.btnExpo.Size = new System.Drawing.Size(231, 212);
            this.btnExpo.TabIndex = 7;
            this.btnExpo.Text = "Exportar Datos";
            this.btnExpo.UseVisualStyleBackColor = false;
            this.btnExpo.Click += new System.EventHandler(this.btnExpo_Click);
            // 
            // MASTER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.Asuna01_50;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 617);
            this.Controls.Add(this.btnimp);
            this.Controls.Add(this.btnExpo);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnagregarclientes);
            this.Controls.Add(this.btncredito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MASTER";
            this.Text = "Master";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncredito;
        private System.Windows.Forms.Button btnagregarclientes;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnimp;
        private System.Windows.Forms.Button btnExpo;
    }
}