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
    public partial class Banco : Form
    {
        public Banco()
        {
            InitializeComponent();
        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            Credito credito = new Credito();
            credito.Show();

        }
    }
}
