using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using capaDatos;

namespace capaNegocio
{
    public class NVenta
    {
        private static bool _Listosave;

        public static bool Listosave
        {
            get { return NVenta._Listosave; }
            set { NVenta._Listosave = value; }
        }


        //metodo insertar
        public static string Insertar(
            DateTime fecha,
            string tipocomprobante,
            string numcomprobante,
            string numfactura,
            string porcisv,
            decimal subtotal,
            decimal isv,
            decimal total,
            int idcliente,
            int idempleado,
            DataTable dtdetalles
            )
        {
            DVenta Obj = new DVenta();
            Obj.Fechaventa = fecha;
            Obj.Tipocomprobante = tipocomprobante;
            Obj.Numcomprobante = numcomprobante;
            Obj.Numfactura = numfactura;
            Obj.Subtotal = subtotal;
            Obj.PorcIsv = porcisv;
            Obj.Isv = isv;
            Obj.Total = total;
            Obj.Idcliente = idcliente;
            Obj.Idempleado = idempleado;
            List<DDetalle_venta> detalles = new List<DDetalle_venta>();
            foreach (DataRow row in dtdetalles.Rows)
            {
                DDetalle_venta detalle = new DDetalle_venta();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["IDdetalleingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precioventa = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        //metodo eliminar
        public static string Eliminar(int idventa)
        {
            DVenta Obj = new DVenta();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }

        //mostrar ultima venta
        public static int MostrarUltimaVenta()
        {
            return new DVenta().MostrarUltimaVenta();
        }

        //obtener ultima factura
        public static int ObtenerUltimaFactura()
        {
            return new DVenta().ObtenerUltimaFactura();
        }

        //buscar texto
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //mostrar detalle de ingreso
        public static DataTable MostrarDetalle(int textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.MostrarDetalle(textobuscar);
        }

        //mostrar producto por nombre
        public static DataTable BuscarProductoVenta(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarProducto_venta(textobuscar);
        }

        //mostrar producto por codigo
        public static DataTable MostrarProductoVentaCodigo(string textobuscar)
        {
            DVenta Obj = new DVenta();
            return Obj.BuscarProducto_venta_codigo(textobuscar);
        }
    }
}
