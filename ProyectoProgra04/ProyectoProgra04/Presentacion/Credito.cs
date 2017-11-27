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
    public partial class Credito : Form
    {
        public Credito()
        {
            InitializeComponent();
        }

        private void Credito_Load(object sender, EventArgs e)
        {
            consultartablacontrolcredito();
        }

        private void lblIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblTasa_Click(object sender, EventArgs e)
        {

        }

        private void dtgCredito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblAmortizacion_Click(object sender, EventArgs e)
        {

        }

        private void cmbIdCliente_Click(object sender, EventArgs e)
        {
            llenarcomboid();
        }

        public void llenarcomboid()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtdatos = new DataTable();

                dtdatos = datos.llenarcomboid();
                cmbIdCliente.DisplayMember = "IdCliente";
                cmbIdCliente.DataSource = dtdatos;
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }
        public void llenarcomboidcredito()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtdatos = new DataTable();

                dtdatos = datos.llenarcomboidcredito();
                cmbidcredito.DisplayMember = "IdCredito";
                cmbidcredito.DataSource = dtdatos;
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void cmbidcredito_Click(object sender, EventArgs e)
        {
            llenarcomboidcredito();
        }
        private void consultartablacontrolcredito()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtcontrol = new DataTable();

                dtcontrol = datos.ConsultarTablaControl();
                dtgCredito.DataSource = dtcontrol;
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            consultartablacontrolcredito();
        }

        private void cmbidcredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            consultarcreditodedic();
        }
        private void consultarcreditodedic()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtcredito = new DataTable();
                dtcredito = datos.consultarcreditocliente(cmbIdCliente.Text, cmbidcredito.Text);
                dtgCredito.DataSource = dtcredito;
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        private void btngenerarpago_Click(object sender, EventArgs e)
        {

        }
    }
}
