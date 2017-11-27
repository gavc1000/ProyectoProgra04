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
            dttablas = conectar.ejecutar("select IdCliente,Nombre,Apellido1,Apellido2,IdCliente,pass from Cliente");
            return dttablas;
        }
    }
}
