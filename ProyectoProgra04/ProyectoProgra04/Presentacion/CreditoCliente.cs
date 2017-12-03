using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
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

            try
            {

                DataSet dt = new DataSet();
                dt.ReadXml(@"C:\BancoLosCositos\Deducciones.xml");
                dgvCred.DataSource = dt;

            }
            catch { MessageBox.Show("Se despicho tere"); }
        }
        public void fromText()
        {

        }

        public void fromtxt()
        {
            try
            {

            }
            catch
            {

            }
        }
        private void Excel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CreditoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
