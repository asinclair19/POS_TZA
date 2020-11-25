using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NCategoria
    {
        //metodo insertar
        public static string Insertar(string nombre, string descripcion, string imagen, int activa)
        {
            DCategoria Obj = new DCategoria();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Activa = activa;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idcategoria, string nombre, string descripcion, string imagen, int activa)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.Activa = activa;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Eliminar(Obj);
        }

        //mostrar categoria
        public static DataTable Mostrar()
        {
            return new DCategoria().Mostrar();
        }

        //buscar texto
        public static DataTable Buscar(string textobuscar)
        {
            DCategoria Obj = new DCategoria();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //activar categoria
        public static string Activar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Activar(Obj);
        }

        //desactivar categoria
        public static string Desactivar(int idcategoria)
        {
            DCategoria Obj = new DCategoria();
            Obj.Idcategoria = idcategoria;
            return Obj.Desactivar(Obj);
        }

    }
}
