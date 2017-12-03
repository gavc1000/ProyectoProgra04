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
                XmlReader xmlFile = XmlReader.Create(@"C:\BancoLosCositos\Deducciones.xml", new XmlReaderSettings());
                DataTable dt = new DataTable();             
                dt.ReadXml(xmlFile);             
               dgvDeducciones.DataSource = dt;              
                xmlFile.Close();
            }
            catch { MessageBox.Show("Se despicho tere"); }
        }
        public void fromText()
        {

        }

    }
}
