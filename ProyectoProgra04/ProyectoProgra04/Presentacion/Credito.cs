﻿using System;
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
        string cancelado;
        string nocancelado;
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
            llenarcamposact();
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

        public void llenarcomboperiodo()
        {
            try
            {
                

                Logica.Credito datos = new Logica.Credito();
                DataTable dtdatos = new DataTable();

                dtdatos = datos.llenarcomboperiodo(cmbIdCliente.Text);
                cmbperiodo.DisplayMember = "Periodo";
                cmbperiodo.DataSource = dtdatos;
                
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
                obj.Periodo = Convert.ToInt32(cmbperiodo.Text);
                
               obj.Cancelado = Convert.ToInt32(cancelado);

              
                

                list.Add(obj);
                datos.genpago(obj);

                


            }
            catch (Exception e)
            {

                MessageBox.Show("Error al actualizar datos" +e);
            }

        }

        public void llenarcamposact()
        {
            try
            {
                MessageBox.Show("He aqui");
               cmbIdCliente.Text=dgvCredito.CurrentRow.Cells[0].Value.ToString();
                cmbperiodo.Text= dgvCredito.CurrentRow.Cells[5].Value.ToString();
                
                string rb= dgvCredito.CurrentRow.Cells[10].Value.ToString();

                if (rb=="True")
                {
                    rbnocancelado.Checked = true;

                }
                if (rb=="False")
                {
                    rbnocancelado.Checked = false;
                }

                
              

                


            }
            catch (Exception e)
            {

                MessageBox.Show("Error al cargar los campos"+""+ e);
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
                
                obj.Pago = PMT(Convert.ToDouble(txt_insertmontoapr.Text),Convert.ToDouble(txt_inserttasa.Text),Convert.ToDouble(txt_insertperi.Text));
                obj.Intereses = calculointereses(Convert.ToDouble(txt_insertmontoapr.Text),Convert.ToDouble(txt_inserttasa.Text));
                obj.Amort = calculoamortizacion(Convert.ToDouble(txtcuota.Text),Convert.ToDouble(txt_insertintere.Text));
                obj.Saldo = calculonuevocapital(Convert.ToDouble(txt_insertmontoapr.Text),Convert.ToDouble(obj.Amort));
               

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
            cmbperiodo.Text = "";
            txt_insertamort.Text = "";
            txt_insertidcliente.Text = "";
            txt_insertidcred.Text = "";
            txt_insertintere.Text = "";
            txt_insertmontoapr.Text = "";
            
            txt_insertperi.Text = "";
            txt_insertsaldo.Text = "";
            txt_inserttasa.Text = "";
            
            cmbconsultacreditos.Text = "";
            cmbid.Text = "";
        
            cmbconsultacreditos.Text = "";


        }
        public void llenarcomboidcredito()
        {
            try
            {
                Logica.Credito datos = new Logica.Credito();
                DataTable dtdatos = new DataTable();

                dtdatos = datos.llenarcomboidcredito();
                

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
                dgvCredito.DataSource = dtcontrol;
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
            limpiar();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvCredito_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            llenarcamposact();
        }
        public double PMT(double capital, double tasa, double periodo)
        {

            double pago;
            pago = (tasa * capital) / (1 - (Math.Pow((1 + tasa), (-1 * periodo))));
            return pago;
        }
        public double calculointereses(double capital, double tasa)
        {
            double intereses;
            intereses = (capital * tasa);
            return intereses;
        }
        public double calculoamortizacion(double pago, double intereses)
        {
            double amortizacion;
            amortizacion = pago - intereses;
            return amortizacion;
        }
        public double calculonuevocapital(double capital, double amotizacion)
        {
            double nuevocapital;
            nuevocapital = capital - amotizacion;
            return nuevocapital;
        }



        private void rb_cancelado_CheckedChanged(object sender, EventArgs e)
        {
             cancelado = "1";
            
        }

        private void rbnocancelado_CheckedChanged(object sender, EventArgs e)
        {
             cancelado = "0";
            
        }

        private void cmbperiodo_MouseClick(object sender, MouseEventArgs e)
        {
            llenarcomboperiodo();
        }

        private void btnproyeccion_Click(object sender, EventArgs e)


        {

            try
            {
                double pmt = PMT(Convert.ToDouble(txt_insertmontoapr.Text), Convert.ToDouble(txt_inserttasa.Text), Convert.ToDouble(txt_insertperi.Text));
                txtcuota.Text = Convert.ToString(pmt);

                double Intereses = calculointereses(Convert.ToDouble(txt_insertmontoapr.Text), Convert.ToDouble(txt_inserttasa.Text));
                txt_insertintere.Text = Convert.ToString(Intereses);
                double Amort = calculoamortizacion(Convert.ToDouble(txtcuota.Text), Convert.ToDouble(txt_insertintere.Text));
                txt_insertamort.Text = Convert.ToString(Amort);
                double Saldo = calculonuevocapital(Convert.ToDouble(txt_insertmontoapr.Text), Convert.ToDouble(Amort));
                txt_insertsaldo.Text = Convert.ToString(Saldo);
               
               

            }
            catch (Exception ea)
            {

                MessageBox.Show("Error de Proyeccion" + "" + ea); 
            }
           

        }
    }
}
