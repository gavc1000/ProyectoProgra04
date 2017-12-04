using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Presentacion
{
    public class Creditos
    {
        public int IdCredito { get; set; }
        public int IdCliente { get; set; }
        public double Monto { get; set; }
        public double tasa { get; set; }
        public int Periodo { get; set; }
        public decimal LastProy { get; set; }
        public double Pago { get; set; }
        public double Intereses { get; set; }
        public double Amort { get; set; }
        public double Saldo { get; set; }
        public int Cancelado { get; set; }

    }
}
