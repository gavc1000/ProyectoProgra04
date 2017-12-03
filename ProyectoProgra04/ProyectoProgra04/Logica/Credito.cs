using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Logica
{
    public class Credito
    {
        public DataTable llenarcomboid()
        {
            Datos.credito datos = new Datos.credito();
            return datos.llenarcomboidcliente();
        }
        public DataTable llenarcomboidcredito()
        {
            Datos.credito datos = new Datos.credito();
            return datos.llenarcomboidcredito();
        }
        public DataTable ConsultarTablaControl()
        {
            Datos.credito datos = new Datos.credito();
            return datos.ConsultarTablaControl();
        }
        public DataTable consultarcreditoidcliente(string idcliente)
        {
            Datos.credito datos = new Datos.credito();
            return datos.consultarcreditoidcliente(idcliente);
        }

        public DataTable consultarcreditocliente(string creditocliente)
        {
            Datos.credito datos = new Datos.credito();
            return datos.consultarcreditoporid(creditocliente);
        }

        public void gencredit(Presentacion.Creditos obj)
        {
            Datos.credito cred = new Datos.credito();
            cred.gencred(obj);

        }

       

        public void genpago(Presentacion.Creditos obj)
        {
            Datos.credito cred = new Datos.credito();
            cred.genpago( obj);

        }
        public DataTable consultarclientes()
        {
            Datos.Agregarclientes datos = new Datos.Agregarclientes();

            return datos.ConsultarClientes();
        }

        public bool agregarclientes(string idcliente, string Nombre, string Apellido1, string Apellido2, string idinstitucion, string pass)
        {
            return new Datos.Agregarclientes().agregarclientes(idcliente, Nombre, Apellido1, Apellido2, idinstitucion, pass);
        }

      
    }
}

