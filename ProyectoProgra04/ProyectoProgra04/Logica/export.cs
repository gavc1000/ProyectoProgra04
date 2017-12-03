using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Logica
{
    class export
    {
        Datos.export ex = new Datos.export();


        public DataTable cargardatos(string lote)
        {

            DataTable dt;
            dt = ex.cargardatos(lote);

            return dt;
        }

        public DataTable Cargarcbo()
        {

            DataTable dt;

            dt = ex.Cargarcbo();
            return dt;

        }
    }
}
