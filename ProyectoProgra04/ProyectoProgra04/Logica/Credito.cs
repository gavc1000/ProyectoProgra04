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
        public DataTable consultarcreditocliente(string idcliente, string idcredito)
        {
            Datos.credito datos = new Datos.credito();
            return datos.consultarcreditocliente(idcliente, idcredito);
        }

        public void gencredit (Presentacion.Creditos obj)
        {
            Datos.credito cred = new Datos.credito();
            cred.gencred(obj);

        }

        public void genpago(Presentacion.Creditos obj)
        {
            Datos.credito cred = new Datos.credito();
            cred.genpago(obj);

        }
        public DataTable consultarclientes()
        {
            Datos.Agregarclientes datos =  new Datos.Agregarclientes();

            return datos.ConsultarClientes();
        }

        
        
        
        }
    }

   