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

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (tExcel.Checked)
                {
                    fromExcel();
                }
                else
                {
                    if (tText.Checked)
                    {
                        fromText();
                    }
                    else
                    {
                        if (tXML.Checked)
                        {

                        }
                    }
                }
            }
            catch { }
            }
                
            
        

        public void toExcel()
        {

        }
        public void toXML()
        {

            if (!Directory.Exists(@"C:\BancoLosCositos"))
            {
                Directory.CreateDirectory(@"C:\BancoLosCositos");
            }
            #region from dgv to dt
            DataTable dt = new DataTable();
            DataColumn[] dcs = new DataColumn[] { };

            foreach (DataGridViewColumn c in dgvCred.Columns)
            {
                DataColumn dc = new DataColumn();
                dc.ColumnName = c.Name;
                dc.DataType = c.ValueType;
                dt.Columns.Add(dc);

            }

            foreach (DataGridViewRow r in dgvCred.Rows)
            {
                DataRow drow = dt.NewRow();

                foreach (DataGridViewCell cell in r.Cells)
                {
                    drow[cell.OwningColumn.Name] = cell.Value;
                }

                dt.Rows.Add(drow);
                #endregion
                try
                {
                    DataSet ds = new DataSet();

                    ds.Tables.Add(dt);

                    dt.WriteXml(@"C:\BancoLosCositos\DeduccionesAplicadas");
                    MessageBox.Show("Se genero exitosamente el archivo");
                }
                catch
                {
                    MessageBox.Show("No se pudo generar el archivo");
                }





            }
        }

        
        public void toText()
        {

        }

    }
}
