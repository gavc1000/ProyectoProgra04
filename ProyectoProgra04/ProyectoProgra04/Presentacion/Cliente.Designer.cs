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
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCred
            // 
            this.btnCred.BackColor = System.Drawing.Color.Transparent;
            this.btnCred.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCred.BackgroundImage")));
            this.btnCred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCred.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCred.ForeColor = System.Drawing.Color.Transparent;
            this.btnCred.Location = new System.Drawing.Point(56, 36);
            this.btnCred.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCred.Name = "btnCred";
            this.btnCred.Size = new System.Drawing.Size(229, 194);
            this.btnCred.TabIndex = 0;
            this.btnCred.Text = "Gestion de Deducciones";
            this.btnCred.UseVisualStyleBackColor = false;
            this.btnCred.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.BackgroundImage = global::ProyectoProgra04.Properties.Resources.quote_bg;
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Location = new System.Drawing.Point(656, 502);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(104, 39);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dolar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compra: 561.21";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Venta: 573.47";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de Cambio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(152, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Venta : 687.30";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(149, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Compra: 655.29";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(104, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 27);
            this.label7.TabIndex = 7;
            this.label7.Text = "Euro";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnCred);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cliente";
            this.Text = "Banco los Cositos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCred;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}