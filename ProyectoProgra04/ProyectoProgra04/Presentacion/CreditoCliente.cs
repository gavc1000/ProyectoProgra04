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
    public partial class CreditoCliente : Form
    {
        public CreditoCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            fromXML();
        }

        public void fromExcel()
        {

        }
        public void fromXML()
        {
            DataTable dt = new DataTable();
            try
            {
                dt.ReadXml(@"C:\BancoLosCositos\Deducciones.xml");
                MessageBox.Show(dt.Rows[0][1].ToString());
                dgvDeducciones.DataSource = dt;
            }
            catch { MessageBox.Show("Se despicho tere"); }
        }
        public void fromText()
        {

        }

    }
}
