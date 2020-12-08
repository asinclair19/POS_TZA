using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class DVenta
    {
        //varibales globales
        private int _Idventa;
        private DateTime _Fechaventa;
        private string _Tipocomprobante;
        private string _Numcomprobante;
        private decimal _Subtotal;
        private string _PorcIsv;
        private decimal _Isv;
        private decimal _Total;
        private int _Idcliente;
        private int _Idempleado;

        //encapsulamiento
        public string PorcIsv
        {
            get { return _PorcIsv; }
            set { _PorcIsv = value; }
        }

        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }

        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public DateTime Fechaventa
        {
            get { return _Fechaventa; }
            set { _Fechaventa = value; }
        }

        public string Tipocomprobante
        {
            get { return _Tipocomprobante; }
            set { _Tipocomprobante = value; }
        }

        public string Numcomprobante
        {
            get { return _Numcomprobante; }
            set { _Numcomprobante = value; }
        }

        public decimal Isv
        {
            get { return _Isv; }
            set { _Isv = value; }
        }

        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }

        public int Idempleado
        {
            get { return _Idempleado; }
            set { _Idempleado = value; }
        }

        //constructor vacio
        public DVenta()
        { 
        
        }

        //constructor con parametros
        public DVenta(
            int idventa,
            DateTime fecha,
            string tipocomprobante,
            string numcomprobante,
            string porcisv,
            decimal subtotal,
            decimal isv,
            decimal total,
            int idcliente,
            int idempleado
            )
        {
            this.Idventa = idventa;
            this.Fechaventa = fecha;
            this.Tipocomprobante = tipocomprobante;
            this.Numcomprobante = numcomprobante;
            this.PorcIsv = porcisv;
            this.Subtotal = subtotal;
            this.Isv = isv;
            this.Total = total;
            this.Idcliente = idcliente;
            this.Idempleado = idempleado;
        }

        //metodo anular
        public string DisminuirStock(int iddetalleingreso, int cantidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdisminuir_stock";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdDetalle = new SqlParameter();
                ParIdDetalle.ParameterName = "@iddetalleingreso";
                ParIdDetalle.SqlDbType = SqlDbType.Int;
                ParIdDetalle.Value = iddetalleingreso;
                SqlCmd.Parameters.Add(ParIdDetalle);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                SqlCmd.Parameters.Add(ParCantidad);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizó el stock de ingreso.";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        //metodo insertar
        public string Insertar(DVenta Venta, List<DDetalle_venta> Detalle)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                //transaccion
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@idventa";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdVenta);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_venta";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fechaventa;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParTipoComp = new SqlParameter();
                ParTipoComp.ParameterName = "@tipo_comprobante";
                ParTipoComp.SqlDbType = SqlDbType.VarChar;
                ParTipoComp.Size = 50;
                ParTipoComp.Value = Venta.Tipocomprobante;
                SqlCmd.Parameters.Add(ParTipoComp);

                SqlParameter ParNumComp = new SqlParameter();
                ParNumComp.ParameterName = "@num_comprobante";
                ParNumComp.SqlDbType = SqlDbType.VarChar;
                ParNumComp.Size = 50;
                ParNumComp.Value = Venta.Numcomprobante;
                SqlCmd.Parameters.Add(ParNumComp);

                SqlParameter ParPorcISV = new SqlParameter();
                ParPorcISV.ParameterName = "@porc_isv";
                ParPorcISV.SqlDbType = SqlDbType.VarChar;
                ParPorcISV.Size = 7;
                ParPorcISV.Value = Venta.PorcIsv;
                SqlCmd.Parameters.Add(ParPorcISV);

                SqlParameter ParSubtotal = new SqlParameter();
                ParSubtotal.ParameterName = "@subtotal";
                ParSubtotal.SqlDbType = SqlDbType.Money;
                ParSubtotal.Value = Venta.Subtotal;
                SqlCmd.Parameters.Add(ParSubtotal);

                SqlParameter ParIsv = new SqlParameter();
                ParIsv.ParameterName = "@isv";
                ParIsv.SqlDbType = SqlDbType.Money;
                ParIsv.Value = Venta.Isv;
                SqlCmd.Parameters.Add(ParIsv);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Venta.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venta.Idcliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Venta.Idempleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro.";
                if (respuesta.Equals("OK"))
                {
                    this.Idventa = Convert.ToInt32(SqlCmd.Parameters["@idventa"].Value);
                    foreach (DDetalle_venta det in Detalle)
                    {
                        det.Idventa = this.Idventa;
                        det.Insertar(det, ref SqlCon, ref SqlTra);
                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                        else { 
                            //actualizar stock
                            respuesta = DisminuirStock(det.Iddetalle_ingreso, det.Cantidad);
                            if (!respuesta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        //metodo eliminar venta
        public string Eliminar(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idventa";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Venta.Idventa;
                SqlCmd.Parameters.Add(ParId);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return respuesta;
        }

        //mostrar valores
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("ventas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }

        //mostrar ultima venta
        public int MostrarUltimaVenta()
        {
            int idUltimaVenta = 0;
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spobtener_ultimaventa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                idUltimaVenta = (Int32)SqlCmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                idUltimaVenta = 0;
                string valor = ex.ToString();
            }

            return idUltimaVenta;
        }
        
        //buscar por fechas
        public DataTable BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("ventas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venta_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }

        //mostrar
        public DataTable MostrarDetalle(int TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalle_venta");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }

        //Mostrar productos por su nombre
        public DataTable BuscarProducto_venta(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("producto");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarproducto_venta";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }


        //Mostrar productos por su codigo de barras
        public DataTable BuscarProducto_venta_codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("producto");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarproducto_venta_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
                string valor = ex.ToString();
            }

            return DtResultado;
        }

    }
}
