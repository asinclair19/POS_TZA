using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using capaDatos;

namespace capaNegocio
{
    public class NIngreso
    {
        //metodo insertar
        public static string Insertar(
            DateTime fecha, 
            string tipo, 
            string num,
            decimal isv,
            decimal total,
            string estado,
            int idproveedor,
            int idempleado,
            DataTable dtDetalles
            )
        {
            DIngreso Obj = new DIngreso();
            Obj.Fecha_ingreso = fecha;
            Obj.Tipo_comprobante = tipo;
            Obj.Num_comprobante = num;
            //Obj.Subtotal_ingreso = subtotat;
            Obj.Isv_ingreso = isv;
            Obj.Total_ingreso = total;
            Obj.Estado = estado;
            Obj.Idproveedor = idproveedor;
            Obj.Idempleado = idempleado;
            List<DDetalle_ingreso> detalles =  new List<DDetalle_ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_ingreso detalle = new DDetalle_ingreso();                
                detalle.Precio_compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_final = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalle.Idproducto = Convert.ToInt32(row["IDproducto"].ToString());
                detalles.Add(detalle);
            }
            return Obj.Insertar(Obj, detalles);
        }

        //metodo anular
        public static string Anular(int idingreso)
        {
            DIngreso Obj = new DIngreso();
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DIngreso().Mostrar();
        }

        //buscar texto
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DIngreso Obj = new DIngreso();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //mostrar detalle de ingreso
        public static DataTable MostrarDetalle(int textobuscar)
        {
            DIngreso Obj = new DIngreso();
            return Obj.MostrarDetalle(textobuscar);
        }

    }
}
