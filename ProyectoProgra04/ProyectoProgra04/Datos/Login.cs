using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Datos
{
    public class Login
    {
        Datos.CRUD datos = new CRUD();

        public bool comprobar(string user, string password)
        {
            bool res;
            string con;
            DataTable dt;
            con = "select * from cliente where idcliente="+user+"and pass= '"+password+"'";
            dt = datos.consultar(con);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
