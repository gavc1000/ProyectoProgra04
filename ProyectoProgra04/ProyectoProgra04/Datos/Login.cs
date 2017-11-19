using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra04.Datos
{
    class Login
    {
        Datos.CRUD datos = new CRUD();

        public string comprobar(string user, string password)
        {
            string res="";
            string con;
            DataTable dt;
            con = "select * from cliente where idcliente="+user+"and pass= '"+password+"'";
            dt = datos.consultar(con);

            return res;
        }
    }
}
