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
using System.Data.OleDb;

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
            new CreditoCliente().importExcel(dgvDeducciones, "Hoja1");
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


        OleDbConnection conn;  //permite la conexion de excel con c#
        OleDbDataAdapter MySataAdapter;  //almacena la info y se la manda al datatable y este llena el datagridview 
        DataTable dt;//se llena con la info del oledbdataadapter

        public void importExcel (DataGridView dgv, String nombreHoja)
        {
            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();  //ver y busca archivos dentro del ordenador
                openfile1.Filter = "Excel files |*,xlsx";  //filtro de archivos que tengan esa extension
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("")==false)   //nombre, ruta, comparada con vacio y da false , existe una ruta, no es vacia
                    {
                        ruta = openfile1.FileName;
                    }
                }
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEBD.4.0;Data Source" + ruta + ";Extended Properties='Excel 8.0; HDR=Yes'");
                //conn =new OleDbConnection("Provider=Microsoft.ACE.OLEBD.12.0;Data Source" + ruta + ";Extended Properties='Excel 12.0 Xml; HDR=Yes'");
                MySataAdapter = new OleDbDataAdapter("Select * from [" + nombreHoja + "$]", conn);
                dt = new DataTable();
                MySataAdapter.Fill(dt);
                dgv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }//fin importexcel

        private void Excel_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
