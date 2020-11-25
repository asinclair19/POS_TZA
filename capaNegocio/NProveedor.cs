using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NProveedor
    {
        //metodo insertar
        public static string Insertar(string nombre, string contacto, int activo)
        {
            DProveedor Obj = new DProveedor();
            Obj.NombreEmpresa = nombre;
            Obj.NombreContacto = contacto;
            Obj.Activo = activo;
            return Obj.Insertar(Obj);
        }

        //metodo editar
        public static string Editar(int idproveedor, string nombre, string contacto, int activo)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            Obj.NombreEmpresa = nombre;
            Obj.NombreContacto = contacto;
            Obj.Activo = activo;
            return Obj.Editar(Obj);
        }

        //metodo eliminar
        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar(Obj);
        }

        //mostrar categoria
        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }

        //buscar texto
        public static DataTable Buscar(string textobuscar)
        {
            DProveedor Obj = new DProveedor();
            Obj.Textobuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //activar categoria
        public static string Activar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Activar(Obj);
        }

        //desactivar categoria
        public static string Desactivar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();
            Obj.Idproveedor = idproveedor;
            return Obj.Desactivar(Obj);
        }
    }
}
