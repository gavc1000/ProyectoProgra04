﻿using System;
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
            dtidclientes = conect.ejecutar("select distinct IdCliente from Credito");
            return dtidclientes;
        }

        public DataTable llenarcomboperiodo(String idcliente)
        {
            CRUD conectar = new CRUD();
            DataTable dtidclientes;
            dtidclientes = conect.ejecutar("select Periodo from Credito where IdCliente="+ idcliente+"");
            return dtidclientes;
        }
        public DataTable llenarcomboidcredito()
        {
            CRUD conectar = new CRUD();
            DataTable dtidcredito;
            dtidcredito = conect.ejecutar("select distinct IdCredito from Credito");
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
            dtcredito = conect.ejecutar("Select IdCliente,IdCredito, Periodo,Pago,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCredito ="+idcredito+"");
            return dtcredito;
        }
        public void gencred(Presentacion.Creditos c)
        {
            string query = "insert into Credito"+
               " values("+c.IdCredito+","+c.IdCliente+","+c.IdLote + "," + c.Monto+","+c.tasa+","+c.Periodo+","+c.Pago+","+c.Intereses+","+c.Amort+","+c.Saldo+","+c.Cancelado+")";
            conect.ejecutarInsert(query);
        }

        public void genpago( Presentacion.Creditos c)
        {
            CRUD conectar= new CRUD();
            string query = "Update  Credito  set Cancelado="+c.Cancelado+" where IdCliente= "+c.IdCliente+" and Periodo="+c.Periodo+"";
           // string query2 = "Update  ContrCreditos  set MontoCredito=" + c.Monto + " where IdCliente= " + c.IdCliente + "";
            conect.ejecutar(query);
            //conect.ejecutar(query2);

        }

        public void consultarcreditosporcedula( String idcedula)
        {
            CRUD conectar = new CRUD();
            string query = "select MontoAprovado,Tasa=,Periodo,UltimaProyeccion,Intereses,Amortizacion,Saldo,Cancelado from Credito where IdCliente= " + idcedula + "";
            conect.ejecutar(query);

        }

        public void generarproyeccion(Presentacion.Creditos c)
        {
           

            conect.ejecutarInsert("insert into proyeccion (Cuota,Intereses,Amortizacion,Saldo) idcliente, idcliente, montoaprovado, tasa,periodo,ultimaproyeccion,pago,intereses,amortizacion,saldo,canceladovalues ('" + c.Pago+"','"+c.Intereses+"','"+c.Amort+"','"+c.Monto+"')");
            
        }
        public DataTable consultarproyeccion()
        {
            Datos.CRUD conectar = new Datos.CRUD();
            DataTable dtproyeccion;
            dtproyeccion = conectar.ejecutar("select * from proyeccion");
            return dtproyeccion;
        }

       


    }
}

