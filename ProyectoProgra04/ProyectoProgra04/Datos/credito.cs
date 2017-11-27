using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Datos
{
    public class credito
    {
        CRUD conect = new CRUD();
        CRUD consultar = new CRUD();

        public DataTable llenarcomboidcliente()
        {
            CRUD conectar = new CRUD();
            DataTable dtidclientes;
            dtidclientes = conect.ejecutar("select IdCliente from Cliente");
            return dtidclientes;
        }
        public DataTable llenarcomboidcredito()
        {
            CRUD conectar = new CRUD();
            DataTable dtidcredito;
            dtidcredito = conect.ejecutar("select * from ContrCreditos;");
            return dtidcredito;
        }
        public DataTable ConsultarTablaControl()
        {
            CRUD conectar = new CRUD();
            DataTable dtcontrolcredito;
            dtcontrolcredito = conect.ejecutar("select * from ContrCreditos;");
            return dtcontrolcredito;
        }
        public DataTable consultarcreditocliente(string idcliente, string idcredito)
        {
            CRUD conectar = new CRUD();
            DataTable dtcredito;
            dtcredito = conect.ejecutar("Select Periodo,Pago,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCliente = '" + idcliente+"' and IdCredito = '" + idcredito + "'");
            return dtcredito;
        }
        public void gencred(Presentacion.Creditos c)
        {
            string query = "insert into Credito (idcliente,montoaprovado,tasa,periodo,ultimaproyeccion,pago,intereses,amortizacion,saldo,cancelado) "+
               " values("+c.IdCliente+","+c.Monto+","+c.tasa+","+c.Periodo+","+c.LastProy+","+c.Pago+","+c.Intereses+","+c.Amort+","+c.Saldo+","+c.Cancelado+")";
            conect.ejecutarInsert(query);
        }
    }
}

