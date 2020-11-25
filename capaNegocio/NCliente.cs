using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NCliente
    {
        //metodo insertar
        public static string Insertar(string nombre)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idcliente, string nombre)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idcliente)
        {
            DCliente Obj = new DCliente();
            Obj.Idcliente = idcliente;
            return Obj.Eliminar(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        //buscar texto
        public static DataTable Buscar(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
