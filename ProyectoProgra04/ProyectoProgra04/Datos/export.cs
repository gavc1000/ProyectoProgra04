using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Datos
{
    class export
    {
        CRUD conect = new CRUD();

        public DataTable Cargarcbo()
        {
            DataTable dt;
            string query;
            query = " select distinct idlote from credito";
            dt = conect.ejecutar(query);
            return dt;

        }

        public DataTable cargardatos(string lote)
        {
            DataTable dt;
            string query;
            query = " select distinct idlote from credito";
            dt = conect.ejecutar(query);
            return dt;
        }
    }
}
