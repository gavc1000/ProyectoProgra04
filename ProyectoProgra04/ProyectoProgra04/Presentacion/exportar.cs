using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgra04.Presentacion
{
    public partial class exportar : Form
    {
        public exportar()
        {
            InitializeComponent();
        }
        Logica.export ex = new Logica.export();
        private void exportar_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ex.Cargarcbo();
                cbolote.DataSource = dt;
                cbolote.ValueMember = "idlote";
            }
            catch
            {
            }
        }

        public void Elote()
        {

            try
            {

                DataTable dt;
                dt = ex.cargardatos(cbolote.Text);
                dgvlote.DataSource = dt;
               
            }
            catch
            {
            }

        }

        private void cbolote_Click(object sender, EventArgs e)
        {

            Elote();
        }

        private void cbolote_SelectedIndexChanged(object sender, EventArgs e)
        {
            Elote();

        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Excel.Checked)
                {
                    toExcel();
                }
                else
                {
                    if (txt.Checked)
                    {
                        toText();
                    }
                    else
                    {
                        if (aXml.Checked)
                        {
                            toXML();
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

        private void toExcel()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); //creo el objeto, creo el archivo de excel desde cero
            excel.Application.Workbooks.Add(true); //aca se agrega una hoja de excel
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in dgvlote.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndiceFila = 0;
            foreach (DataGridViewRow row in dgvlote.Rows)
            {
                IndiceFila++;
                IndiceColumna = 0;


                foreach (DataGridViewColumn col in dgvlote.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void toXML()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            dt = ex.cargardatos(cbolote.Text);
            ds.Tables.Add(dt);
            dt.WriteXml(@"C:\BancoLosCositos\Deducciones.xml");
            

        }
        private void toText()
        {
            try
            {
                if (!Directory.Exists(@"C:\BancoLosCositos"))
                {
                    Directory.CreateDirectory(@"C:\BancoLosCositos");
                }

                TextWriter sw = new StreamWriter(@"C:\BancoLosCositos\Deducciones.txt");
                int rowcount = dgvlote.Rows.Count;
                for (int i = 0; i < rowcount - 1; i = i + 1)
                {
                    sw.WriteLine(dgvlote.Rows[i].Cells[0].Value.ToString() + "\t"
                                 + dgvlote.Rows[i].Cells[1].Value.ToString() + "\t"
                                  + dgvlote.Rows[i].Cells[2].Value.ToString() + "\t");
                }
                sw.Close();
                MessageBox.Show("Datos Exportados correctamente");
            }
            catch
            {
                MessageBox.Show("Error al exportar datos");
            }

        }

    }
}
