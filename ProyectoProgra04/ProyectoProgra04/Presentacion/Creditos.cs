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
        public decimal Monto { get; set; }
        public decimal tasa { get; set; }
        public int Periodo { get; set; }
        public decimal LastProy { get; set; }
        public decimal Pago { get; set; }
        public decimal Intereses { get; set; }
        public decimal Amort { get; set; }
        public decimal Saldo { get; set; }
        public int Cancelado { get; set; }

    }
}
