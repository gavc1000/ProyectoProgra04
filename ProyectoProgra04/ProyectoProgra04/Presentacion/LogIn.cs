using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra04.Presentacion
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
          
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            Datos.Login log = new Datos.Login();
            int res;

            res = log.comprobar(txtuser.Text, txtpass.Text);

            if (res==true)
            {
                MessageBox.Show("Bienvenido");
               if 
                this.Hide();
            }
            else
            {
                MessageBox.Show("usuario o contraseña invalida");
                txtpass.Text = "";
            }
        }
    }
}
