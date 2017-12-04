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
    public partial class Cliente : Form
    {
       
        
        public Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreditoCliente cred = new CreditoCliente();
            cred.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados();
            emp.Show();
        }

        private void btnExpo_Click(object sender, EventArgs e)
        {
            exportar ex = new exportar();
            ex.Show();
        }

        private void btnimp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
