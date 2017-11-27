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
            this.btnCred = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCred
            // 
            this.btnCred.BackColor = System.Drawing.Color.Transparent;
            this.btnCred.BackgroundImage = global::ProyectoProgra04.Properties.Resources.blue_button_md;
            this.btnCred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCred.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCred.Font = new System.Drawing.Font("Californian FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCred.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCred.Location = new System.Drawing.Point(65, 39);
            this.btnCred.Margin = new System.Windows.Forms.Padding(0);
            this.btnCred.Name = "btnCred";
            this.btnCred.Size = new System.Drawing.Size(172, 167);
            this.btnCred.TabIndex = 0;
            this.btnCred.Text = "Gestion de Creditos";
            this.btnCred.UseVisualStyleBackColor = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoProgra04.Properties.Resources.thumb_1920_750482;
            this.ClientSize = new System.Drawing.Size(742, 568);
            this.Controls.Add(this.btnCred);
            this.Name = "Cliente";
            this.Text = "Banco los Cositos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCred;
    }
}