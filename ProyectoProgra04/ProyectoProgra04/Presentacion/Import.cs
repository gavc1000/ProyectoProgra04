using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProyectoProgra04.Presentacion
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }
        OpenFileDialog openfiledialog1 = new OpenFileDialog();
        public string archivo = "";
       
        private void Import_Load(object sender, EventArgs e)
        {

        }

        public void fromExcel()
        {
            OleDbConnection conn;  //permite la conexion de excel con c#
            OleDbDataAdapter MySataAdapter;  //almacena la info y se la manda al datatable y este llena el datagridview 
            DataTable dt;//se llena con la info del oledbdataadapter


            String ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();  //ver y busca archivos dentro del ordenador
                //openfile1.Filter = "Excel files |*,xlsx";  //filtro de archivos que tengan esa extension
                //openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)   //nombre, ruta, comparada con vacio y da false , existe una ruta, no es vacia
                    {
                        ruta = openfile1.FileName;
                    }
                }
                conn = new OleDbConnection("Provider=Microsoft.Jet.OLEBD.4.0;Data Source" + ruta + ";Extended Properties='Excel 8.0; HDR=Yes'");
                //conn =new OleDbConnection("Provider=Microsoft.ACE.OLEBD.12.0;Data Source" + ruta + ";Extended Properties='Excel 12.0 Xml; HDR=Yes'");
                MySataAdapter = new OleDbDataAdapter("Select * from [Sheet1$]", conn);
                dt = new DataTable();
                MySataAdapter.Fill(dt);
                dgvlote.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void fromXML()
        {

            try
            {

                XmlReader xmlFile = XmlReader.Create(@"C:\BancoLosCositos\Deducciones.xml", new XmlReaderSettings());
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(xmlFile);
                dgvlote.DataSource = dataSet.Tables["Table1"];
                xmlFile.Close();

            }
            catch { MessageBox.Show("Error al cargar"); }
        }
        public void fromText()
        {
            try
            {
                this.openfiledialog1.ShowDialog();
                if (!string.IsNullOrEmpty(this.openfiledialog1.FileName))
                {
                    archivo = this.openfiledialog1.FileName;
                    lecturaarchivo(dgvlote, '/', archivo);
                }


            }
            catch
            {
                MessageBox.Show("Error al cargar archivo");
            }
        }
        public void lecturaarchivo(DataGridView tabla, char carcater, string ruta)
        {
            StreamReader objreader = new StreamReader(ruta);
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                sLine = objreader.ReadLine();
                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = sLine.Split(carcater).Length;
                        nombrarTitulo(tabla, sLine.Split(carcater));
                        fila = 1;
                    }
                    else
                    {
                        agregarFilaDatagridview(tabla, sLine, carcater);
                        fila = fila + 1;
                    }
                }
            }
            while (!(sLine == null));
            objreader.Close();
        }
        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {

            for (int x = 0; x <= tabla.ColumnCount - 1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (Excel.Checked)
                    {

                        fromExcel();
                    }
                    else
                    {
                        if (txt.Checked)
                        {
                            fromText();
                        }
                        else
                        {
                            if (aXml.Checked)
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
        }
        public static void agregarFilaDatagridview(DataGridView tabla, string linea, char caracter)
        {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }
    }
}
