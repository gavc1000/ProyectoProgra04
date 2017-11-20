﻿using System;
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
    }
}
   