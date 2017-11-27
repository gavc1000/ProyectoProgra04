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
            Logica.Credito agregar = new Logica.Credito();
            try
            {
                if (txtidcliente.Text == "")
                {
                    MessageBox.Show("Favor agregar ID de cliente");
                }
                else
                {
                    if (txtnombre.Text == "")
                    {
                        MessageBox.Show("Favor agregar Nombre de cliente");
                    }
                    else
                    {
                        if (txtapellido1.Text == "")
                        {
                            MessageBox.Show("Favor agregar Primer Apellido");
                        }
                        else
                        {
                            if (txtapellido2.Text == "")
                            {
                                MessageBox.Show("Favor agregar Segundo Apellido");
                            }
                            else
                            {
                                if (txtidinstitucion.Text == "")
                                {
                                    MessageBox.Show("Favor agregar ID de Institución");
                                }
                                else
                                {
                                    if (txtpass.Text == "")
                                    {
                                        MessageBox.Show("Favor agregar una Contraseña");
                                    }
                                    else
                                    {
                                        agregar.agregarclientes(txtidcliente.Text, txtnombre.Text, txtapellido1.Text, txtapellido2.Text, txtidinstitucion.Text, txtpass.Text);
                                        MessageBox.Show("Cliente Agregado Correctamente");
                                        limpiar();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error de Sintaxis, favor revisar");
            }
            consultarclientes();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
