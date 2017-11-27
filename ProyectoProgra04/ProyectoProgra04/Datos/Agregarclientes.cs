using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoProgra04.Datos
{
    public class Agregarclientes
    {
        CRUD conect = new CRUD();
        CRUD consultar = new CRUD();

        public DataTable ConsultarClientes()
        {
            Datos.CRUD conectar = new Datos.CRUD();
            DataTable dttablas;
            dttablas = conectar.ejecutar("select IdCliente,Nombre,Apellido1,Apellido2, IdInstitucion,pass from Cliente");
            return dttablas;
        }
        public bool agregarclientes(string idcliente, string Nombre, string Apellido1, string Apellido2, string idinstitucion, string pass)
        {
            bool agregandoclientes;
            agregandoclientes = conect.ejecutarInsert("insert into Cliente values ('"+idcliente+"','"+Nombre+"','"+Apellido1+"','"+Apellido2+"','"+idinstitucion+"','"+pass+"',3)");
            if (agregandoclientes)
            {
                return true;
            }
            return false;
        }
    }
}
