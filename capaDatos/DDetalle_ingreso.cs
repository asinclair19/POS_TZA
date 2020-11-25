using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;


namespace capaDatos
{
    public class DDetalle_ingreso
    {
        private int _Iddetalle_ingreso;
        private decimal _Precio_compra;
        private decimal _Precio_venta;
        private int _Stock_inicial;
        private int _Stock_final;
        private DateTime _Fecha_produccion;
        private DateTime _Fecha_vencimiento;
        private int _Idingreso;
        private int _Idproducto;

        public int Iddetalle_ingreso
        {
            get { return _Iddetalle_ingreso; }
            set { _Iddetalle_ingreso = value; }
        }

        public decimal Precio_compra
        {
            get { return _Precio_compra; }
            set { _Precio_compra = value; }
        }

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }

        public int Stock_inicial
        {
            get { return _Stock_inicial; }
            set { _Stock_inicial = value; }
        }

        public int Stock_final
        {
            get { return _Stock_final; }
            set { _Stock_final = value; }
        }

        public DateTime Fecha_produccion
        {
            get { return _Fecha_produccion; }
            set { _Fecha_produccion = value; }
        }

        public DateTime Fecha_vencimiento
        {
            get { return _Fecha_vencimiento; }
            set { _Fecha_vencimiento = value; }
        }

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }

        public int Idproducto
        {
            get { return _Idproducto; }
            set { _Idproducto = value; }
        }

        //CONSTRUCTOR VACIO
        public DDetalle_ingreso()
        {

        }

        //constructor GLOBAL
        public DDetalle_ingreso(
            int iddetalle, 
            decimal precio_compra,
            decimal precio_venta,
            int stock_inicial,
            int stock_final,
            DateTime fecha_produccion,
            DateTime fecha_vencimiento,
            int idingreso,
            int idproducto
            ) {
            //asignacion
            this.Iddetalle_ingreso = iddetalle;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Stock_inicial = stock_inicial;
            this.Stock_final = stock_final;
            this.Fecha_produccion = fecha_produccion;
            this.Fecha_vencimiento = fecha_vencimiento;
            this.Idingreso = idingreso;
            this.Idproducto = idproducto;
        }

        //metodo insertar
        public string Insertar(DDetalle_ingreso DetalleIngreso, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string respuesta = "";
            try
            {
                //codigo
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdDetalle = new SqlParameter();
                ParIdDetalle.ParameterName = "@iddetalleIngreso";
                ParIdDetalle.SqlDbType = SqlDbType.Int;
                ParIdDetalle.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdDetalle);

                SqlParameter ParPrecioCompra = new SqlParameter();
                ParPrecioCompra.ParameterName = "@precio_compra";
                ParPrecioCompra.SqlDbType = SqlDbType.Money;
                ParPrecioCompra.Value = DetalleIngreso.Precio_compra;
                SqlCmd.Parameters.Add(ParPrecioCompra);

                SqlParameter ParPrecioVenta = new SqlParameter();
                ParPrecioVenta.ParameterName = "@precio_venta";
                ParPrecioVenta.SqlDbType = SqlDbType.Money;
                ParPrecioVenta.Value = DetalleIngreso.Precio_venta;
                SqlCmd.Parameters.Add(ParPrecioVenta);

                SqlParameter ParStockInicial = new SqlParameter();
                ParStockInicial.ParameterName = "@stock_inicial";
                ParStockInicial.SqlDbType = SqlDbType.Int;
                ParStockInicial.Value = DetalleIngreso.Stock_inicial;
                SqlCmd.Parameters.Add(ParStockInicial);

                SqlParameter ParStockFinal = new SqlParameter();
                ParStockFinal.ParameterName = "@stock_final";
                ParStockFinal.SqlDbType = SqlDbType.Int;
                ParStockFinal.Value = DetalleIngreso.Stock_final;
                SqlCmd.Parameters.Add(ParStockFinal);

                SqlParameter ParFechaProduccion = new SqlParameter();
                ParFechaProduccion.ParameterName = "@fecha_produccion";
                ParFechaProduccion.SqlDbType = SqlDbType.Date;
                ParFechaProduccion.Value = DetalleIngreso.Fecha_produccion;
                SqlCmd.Parameters.Add(ParFechaProduccion);

                SqlParameter ParFechaVencimiento = new SqlParameter();
                ParFechaVencimiento.ParameterName = "@fecha_vencimiento";
                ParFechaVencimiento.SqlDbType = SqlDbType.Date;
                ParFechaVencimiento.Value = DetalleIngreso.Fecha_vencimiento;
                SqlCmd.Parameters.Add(ParFechaVencimiento);

                SqlParameter ParIdIngreso = new SqlParameter();
                ParIdIngreso.ParameterName = "@idingreso";
                ParIdIngreso.SqlDbType = SqlDbType.Int;
                ParIdIngreso.Value = DetalleIngreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdIngreso);

                SqlParameter ParIdProducto = new SqlParameter();
                ParIdProducto.ParameterName = "@idproducto";
                ParIdProducto.SqlDbType = SqlDbType.Int;
                ParIdProducto.Value = DetalleIngreso.Idproducto;
                SqlCmd.Parameters.Add(ParIdProducto);

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
