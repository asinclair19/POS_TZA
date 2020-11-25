using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NUnidad
    {
        //metodo insertar
        public static string Insertar(string nombre, string descripcion)
        {
            DUnidad Obj = new DUnidad();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idunidad, string nombre, string descripcion)
        {
            DUnidad Obj = new DUnidad();
            Obj.Idunidad = idunidad;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idunidad)
        {
            DUnidad Obj = new DUnidad();
            Obj.Idunidad = idunidad;
            return Obj.Eliminar(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DUnidad().Mostrar();
        }

        //buscar texto
        public static DataTable Buscar(string textobuscar)
        {
            DUnidad Obj = new DUnidad();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

    }
}
