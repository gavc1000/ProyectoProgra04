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
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
            consultarclientes();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch
            {
                MessageBox.Show("Error de Sintaxis, favor revisar");
            }
            
        }
        private void limpiar()
        {
            txtidcliente.Text = "";
            txtnombre.Text = "";
            txtapellido1.Text = "";
            txtapellido2.Text = "";
            txtidinstitucion.Text = "";
            txtpass.Text = "";
        }
        private void consultarclientes()
        {
            Logica.Credito datos = new Logica.Credito();
            DataTable dttablas = new DataTable();

            dttablas = datos.consultarclientes();
            dtgclientes.DataSource = dttablas;
        }

        private void dtgclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregarcliente_Click(object sender, EventArgs e)
        {
            agregarclientes();
        }

        public void agregarclientes()
        {
            try
            {
                MessageBox.Show("Cliente Agregado Correctamente");
                limpiar();
            }
            catch
            {
                MessageBox.Show("Error de Sintaxis, favor revisar");
            }
            consultarclientes();
        }
    }
}
