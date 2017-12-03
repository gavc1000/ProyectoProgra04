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
            try
            {
                if (fExcel.Checked)
                {
                    fromExcel();
                }
                else
                {
                    if (ftxt.Checked)
                    {
                        fromText();
                    }
                    else
                    {
                        if (fXml.Checked)
                        {
                            fromXML();
                        }
                        else
                        {

                            MessageBox.Show("Seleccione un metodo");
                        }
                    }

                }
            }
            catch { }
        }
    

        public void fromExcel()
        {

        }
        public void fromXML()
        {

            try
            {

                XmlReader xmlFile = XmlReader.Create(@"C:\BancoLosCositos\Deducciones.xml", new XmlReaderSettings());
                DataSet dataSet = new DataSet();                
                dataSet.ReadXml(xmlFile);               
               dgvCred.DataSource = dataSet.Tables["Table1"];              
                xmlFile.Close();

            }
            catch { MessageBox.Show("Error al cargar"); }
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
