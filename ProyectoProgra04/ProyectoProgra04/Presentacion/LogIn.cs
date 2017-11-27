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
            Banco ban = new Banco();
            Cliente cli = new Cliente();
            MASTER mas = new MASTER();
            if (res>0)
            {
                if (res == 1)
                {
                    MessageBox.Show("Bienvenido");
                    mas.Show();
                    this.Hide();
                }
                if (res == 2)
                {
                    MessageBox.Show("Bienvenido");
                    ban.Show();
                    this.Hide();
                }
                if (res == 3)
                {
                    MessageBox.Show("Bienvenido");
                    cli.Show();
                    this.Hide();
                }
             
            }
            else
            {
                MessageBox.Show("usuario o contraseña invalida");
                txtpass.Text = "";
            }
        }
    }
}
