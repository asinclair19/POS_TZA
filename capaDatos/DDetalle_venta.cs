using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class DDetalle_venta
    {
        //variables globales
        private int _Iddetalle_venta;
        private int _Cantidad;
        private decimal _Precioventa;
        private decimal _Descuento;
        private int _Idventa;
        private int _Iddetalle_ingreso;

        //encapsulamiento de variables
        public int Iddetalle_venta
        {
            get { return _Iddetalle_venta; }
            set { _Iddetalle_venta = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal Precioventa
        {
            get { return _Precioventa; }
            set { _Precioventa = value; }
        }

        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public int Iddetalle_ingreso
        {
            get { return _Iddetalle_ingreso; }
            set { _Iddetalle_ingreso = value; }
        }
        //constructor vacio
        public DDetalle_venta()
        {
    
        }

        //constructor con parametros
        public DDetalle_venta(
            int iddetalleventa,
            int cantidad,
            decimal precioventa,
            decimal descuento,
            int idventa,
            int iddetalleingreso
            )
        {
            this.Iddetalle_venta = iddetalleventa;
            this.Cantidad = cantidad;
            this.Precioventa = precioventa;
            this.Descuento = descuento;
            this.Idventa = idventa;
            this.Iddetalle_ingreso = iddetalleingreso;
        }

        //metodo insertar
        public string Insertar(DDetalle_venta DetalleVenta, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string respuesta = "";
            try
            {
                //codigo
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdDetalle = new SqlParameter();
                ParIdDetalle.ParameterName = "@iddetalleventa";
                ParIdDetalle.SqlDbType = SqlDbType.Int;
                ParIdDetalle.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDetalle);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = DetalleVenta.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = DetalleVenta.Precioventa;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = DetalleVenta.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@idventa";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = DetalleVenta.Idventa;
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdDetalleIngreso = new SqlParameter();
                ParIdDetalleIngreso.ParameterName = "@iddetalleingreso";
                ParIdDetalleIngreso.SqlDbType = SqlDbType.Int;
                ParIdDetalleIngreso.Value = DetalleVenta.Iddetalle_ingreso;
                SqlCmd.Parameters.Add(ParIdDetalleIngreso);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }
    }
}
