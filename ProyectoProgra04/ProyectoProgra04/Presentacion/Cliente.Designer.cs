namespace ProyectoProgra04.Presentacion
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnCred = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCred
            // 
            this.btnCred.BackColor = System.Drawing.Color.Transparent;
            this.btnCred.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCred.BackgroundImage")));
            this.btnCred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCred.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCred.ForeColor = System.Drawing.Color.Transparent;
            this.btnCred.Location = new System.Drawing.Point(56, 36);
            this.btnCred.Name = "btnCred";
            this.btnCred.Size = new System.Drawing.Size(229, 194);
            this.btnCred.TabIndex = 0;
            this.btnCred.Text = "Gestion de Creditos";
            this.btnCred.UseVisualStyleBackColor = false;
            this.btnCred.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(310, 36);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(227, 194);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Gestion de Empleados";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(656, 502);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 39);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 573);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCred);
            this.Name = "Cliente";
            this.Text = "Banco los Cositos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCred;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnlogout;
    }
}