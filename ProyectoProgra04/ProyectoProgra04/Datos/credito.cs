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
            dtidclientes = conect.ejecutar("select IdCliente from Credito");
            return dtidclientes;
        }
        public DataTable llenarcomboidcredito()
        {
            CRUD conectar = new CRUD();
            DataTable dtidcredito;
            dtidcredito = conect.ejecutar("select * from Credito");
            return dtidcredito;
        }
        public DataTable ConsultarTablaControl()
        {
            CRUD conectar = new CRUD();
            DataTable dtcontrolcredito;
            dtcontrolcredito = conect.ejecutar("select * from Credito");
            return dtcontrolcredito;
        }
        public DataTable consultarcreditoidcliente(string idcliente)
        {
            CRUD conectar = new CRUD();
            DataTable dtcredito;
            dtcredito = conect.ejecutar("Select IdCliente,IdCredito, Periodo,Pago,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCliente = " + idcliente+"");
            return dtcredito;
        }

        public DataTable consultarcreditoporid(string idcredito)
        {
            CRUD conectar = new CRUD();
            DataTable dtcredito;
            dtcredito = conect.ejecutar("Select IdCliente,IdCredito, Periodo,Pago,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCredito =");
            return dtcredito;
        }
        public void gencred(Presentacion.Creditos c)
        {
            string query = "insert into Credito (idcliente,montoaprovado,tasa,periodo,ultimaproyeccion,pago,intereses,amortizacion,saldo,cancelado) "+
               " values("+c.IdCliente+","+c.Monto+","+c.tasa+","+c.Periodo+","+c.LastProy+","+c.Pago+","+c.Intereses+","+c.Amort+","+c.Saldo+",0)";
            conect.ejecutarInsert(query);
        }

        public void genpago( Presentacion.Creditos c)
        {
            CRUD conectar= new CRUD();
            string query = "Update  Credito  set MontoAprovado= "+ c.Monto+",Tasa="+c.tasa+",Periodo="+c.Periodo+",UltimaProyeccion="+c.LastProy+",Intereses="+c.Intereses+",Amortizacion="+c.Amort+",Saldo="+c.Saldo+",Cancelado=0 where IdCliente= "+c.IdCliente+"";
           // string query2 = "Update  ContrCreditos  set MontoCredito=" + c.Monto + " where IdCliente= " + c.IdCliente + "";
            conect.ejecutar(query);
            //conect.ejecutar(query2);

        }

        public void consultarcreditosporcedula( Presentacion.Creditos c)
        {
            CRUD conectar = new CRUD();
            string query = "select MontoAprovado,Tasa=,Periodo,UltimaProyeccion,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCliente= " + c.IdCliente + "";
            conect.ejecutar(query);

        }
    }
}

