using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


using capaDatos;

namespace capaNegocio
{
    public class NProducto
    {
        //metodo insertar
        public static string Insertar(string codigo, string nombre, string descripcion, string busqueda, byte[] imagen, int activo, int idunidad, int idcategoria)
        {
            DProducto Obj = new DProducto();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Busqueda = busqueda;
            Obj.Imagen = imagen;
            Obj.Activo = activo;
            Obj.Idunidad = idunidad;
            Obj.Idcategoria = idcategoria;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idproducto, string codigo, string nombre, string descripcion, string busqueda, byte[] imagen, int activo, int idunidad, int idcategoria)
        {
            DProducto Obj = new DProducto();
            Obj.Idproducto = idproducto;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Busqueda = busqueda;
            Obj.Imagen = imagen;
            Obj.Activo = activo;
            Obj.Idunidad = idunidad;
            Obj.Idcategoria = idcategoria;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idproducto)
        {
            DProducto Obj = new DProducto();
            Obj.Idproducto = idproducto;
            return Obj.Eliminar(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DProducto().Mostrar();
        }

        //buscar texto
        public static DataTable Buscar(string textobuscar)
        {
            DProducto Obj = new DProducto();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarProducto(Obj);
        }

        public static string Activar(int idproducto)
        {
            DProducto Obj = new DProducto();
            Obj.Idproducto = idproducto;
            return Obj.Activar(Obj);
        }

        public static string Desactivar(int idproducto)
        {
            DProducto Obj = new DProducto();
            Obj.Idproducto = idproducto;
            return Obj.Desactivar(Obj);
        }

        //stock productos
        public static DataTable Stock_Productos()
        {
            return new DProducto().Stock_Productos();
        }
    }
}
