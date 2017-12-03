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
        bool banderaid=false;
        bool banderacred=false;
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
                cmbid.DisplayMember = "IdCliente";
                cmbid.DataSource = dtdatos;
            }
            catch
            {
                MessageBox.Show("Error al cargar datos");
            }
        }

        public void GenerarPago()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                Datos.credito cred = new Datos.credito();
             

                list = new List<Creditos>();

                Creditos obj = new Creditos();
                obj.IdCliente = Convert.ToInt32(cmbIdCliente.Text);
                obj.IdCredito = Convert.ToInt32(cmbidcredito.Text);
                obj.Monto = Convert.ToDecimal(txtMontoAprobado.Text);
                obj.tasa = Convert.ToDecimal(txtTasa.Text);
                obj.Periodo = Convert.ToInt32(txtperiodo.Text);
                obj.LastProy = Convert.ToDecimal(txtUltimaProyeccion.Text);
                obj.Pago = Convert.ToDecimal(txtpago.Text);
                obj.Intereses = Convert.ToDecimal(txtIntereses.Text);
                obj.Amort = Convert.ToDecimal(txtAmortizacion.Text);
                obj.Saldo = Convert.ToDecimal(txtSaldo.Text);

                list.Add(obj);
                datos.genpago(obj);




            }
            catch (Exception e)
            {

                MessageBox.Show("Error al actualizar datos" +e);
            }

        }

        public void generarcredito()
        {

            try
            {
                 Logica.Credito datos = new Logica.Credito();
                Datos.credito cred = new Datos.credito();
                list = new List<Creditos>();

                Creditos obj = new Creditos();
                obj.IdCliente = Convert.ToInt32(txt_insertidcliente.Text);
                obj.IdCredito = Convert.ToInt32(txt_insertidcred.Text);
                obj.Monto = Convert.ToDecimal(txt_insertmontoapr.Text);
                obj.tasa = Convert.ToDecimal(txt_inserttasa.Text);
                obj.Periodo = Convert.ToInt32(txt_insertperi.Text);
                obj.LastProy = Convert.ToDecimal(txt_insertultp.Text);
                obj.Pago = Convert.ToDecimal(txt_insertpago.Text);
                obj.Intereses = Convert.ToDecimal(txt_insertintere.Text);
                obj.Amort = Convert.ToDecimal(txt_insertamort.Text);
                obj.Saldo = Convert.ToDecimal(txt_insertsaldo.Text);

                list.Add(obj);
                datos.gencredit(obj);

            }
            catch (Exception e)
            {

                MessageBox.Show("Error al Insertar datos" + e);
            }
           

        }
        public void limpiar()
        {
            txtAmortizacion.Text = "";
            txtIntereses.Text = "";
            txtMontoAprobado.Text = "";
            txtpago.Text = "";
            txtperiodo.Text = "";
            txtSaldo.Text = "";
            txtTasa.Text = "";
            txtUltimaProyeccion.Text = "";
            txt_insertamort.Text = "";

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

                cmbconsultacreditos.DisplayMember = "IdCredito";
                cmbconsultacreditos.DataSource = dtdatos;
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
                dgv_insertar.DataSource = dtcontrol;
                dgvconsulta.DataSource = dtcontrol;
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
          
            consultartablacontrolcredito();
        }
        private void consultarcreditoid( string id)
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtcredito = new DataTable();
                dtcredito = datos.consultarcreditoidcliente(id);
                dgvconsulta.DataSource = dtcredito;
            }
            catch( Exception e)
            {
                MessageBox.Show("Error al consultar datos"+" " +e);
            }
        }

        private void consultarporcredito(string credito)
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtcredito = new DataTable();
                dtcredito = datos.consultarcreditocliente(credito);
                dgvconsulta.DataSource = dtcredito;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al consultar datos" + " " + e);
            }
        }


        private void cmbIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<Creditos> list;
        private void btnGenerarCredito_Click(object sender, EventArgs e)
        {
           


        }

        private void btngenerarpago_Click(object sender, EventArgs e)
        {
            GenerarPago();
            consultartablacontrolcredito();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            generarcredito();
            consultartablacontrolcredito();

        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            consultartablacontrolcredito();
        }

        private void cmbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            banderaid = true;
            banderacred = false;
            consultartablacontrolcredito();
        }

        private void cmbid_Click(object sender, EventArgs e)
        {
            llenarcomboid();
            consultartablacontrolcredito();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (banderaid==true)
            {
                MessageBox.Show("hi");
                consultarcreditoid(cmbid.Text);

            }

            if (banderacred==true)
            {
                MessageBox.Show("adios");
                consultarporcredito(cmbconsultacreditos.Text);
            }
            
            
        }

        private void cmbconsultacreditos_Click(object sender, EventArgs e)
        {
            llenarcomboidcredito();
        }

        private void cmbconsultacreditos_SelectedIndexChanged(object sender, EventArgs e)
        {
            banderacred = true;
            banderaid = false;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnconsultarefrescar_Click(object sender, EventArgs e)
        {
            consultartablacontrolcredito();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
