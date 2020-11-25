using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class DIngreso
    {
        //variables
        private int _Idingreso;
        private DateTime _Fecha_ingreso;
        private string _Tipo_comprobante;
        private string _Num_comprobante;
        //private decimal _Subtotal_ingreso;
        private decimal _Isv_ingreso;
        private decimal _Total_ingreso;
        private string _Estado;
        private int _Idproveedor;
        private int _Idempleado;

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }

        public DateTime Fecha_ingreso
        {
            get { return _Fecha_ingreso; }
            set { _Fecha_ingreso = value; }
        }

        public string Tipo_comprobante
        {
            get { return _Tipo_comprobante; }
            set { _Tipo_comprobante = value; }
        }

        public string Num_comprobante
        {
            get { return _Num_comprobante; }
            set { _Num_comprobante = value; }
        }

        //public decimal Subtotal_ingreso
        //{
        //    get { return _Subtotal_ingreso; }
        //    set { _Subtotal_ingreso = value; }
        //}

        public decimal Isv_ingreso
        {
            get { return _Isv_ingreso; }
            set { _Isv_ingreso = value; }
        }

        public decimal Total_ingreso
        {
            get { return _Total_ingreso; }
            set { _Total_ingreso = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public int Idproveedor
        {
            get { return _Idproveedor; }
            set { _Idproveedor = value; }
        }

        public int Idempleado
        {
            get { return _Idempleado; }
            set { _Idempleado = value; }
        }

        //CONSTRUCTOR VACIO
        public DIngreso()
        {

        }

        //constructor GLOBAL
        public DIngreso(
            int idingreso,
            DateTime fechaingreso,
            string tipocomprobante,
            string numcomprobante,
            //decimal subtotal,
            decimal isv,
            decimal total,
            string estado,
            int idproveedor,
            int idempleado
            ) {
            //asignacion
            this.Idingreso = idingreso;
            this.Fecha_ingreso = fechaingreso;
            this.Tipo_comprobante = tipocomprobante;
            this.Num_comprobante = numcomprobante;
            //this.Subtotal_ingreso = subtotal;
            this.Isv_ingreso = isv;
            this.Total_ingreso = total;
            this.Estado = estado;
            this.Idproveedor = idproveedor;
            this.Idempleado = idempleado;
        }

        //metodo insertar
        public string Insertar(DIngreso Ingreso, List<DDetalle_ingreso> Detalle)
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
                SqlCmd.CommandText = "spinsertar_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdIngreso = new SqlParameter();
                ParIdIngreso.ParameterName = "@idingreso";
                ParIdIngreso.SqlDbType = SqlDbType.Int;
                ParIdIngreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdIngreso);

                SqlParameter ParFechaIngreso = new SqlParameter();
                ParFechaIngreso.ParameterName = "@fecha_ingreso";
                ParFechaIngreso.SqlDbType = SqlDbType.Date;
                ParFechaIngreso.Value = Ingreso.Fecha_ingreso;
                SqlCmd.Parameters.Add(ParFechaIngreso);

                SqlParameter ParTipoComprobante = new SqlParameter();
                ParTipoComprobante.ParameterName = "@tipo_comprobante";
                ParTipoComprobante.SqlDbType = SqlDbType.NVarChar;
                ParTipoComprobante.Size = 100;
                ParTipoComprobante.Value = Ingreso.Tipo_comprobante;
                SqlCmd.Parameters.Add(ParTipoComprobante);

                SqlParameter ParNumComprobante = new SqlParameter();
                ParNumComprobante.ParameterName = "@num_comprobante";
                ParNumComprobante.SqlDbType = SqlDbType.NVarChar;
                ParNumComprobante.Size = 100;
                ParNumComprobante.Value = Ingreso.Num_comprobante;
                SqlCmd.Parameters.Add(ParNumComprobante);

                //SqlParameter ParSubtotal = new SqlParameter();
                //ParSubtotal.ParameterName = "@subtotal_ingreso";
                //ParSubtotal.SqlDbType = SqlDbType.Money;
                //ParSubtotal.Value = Ingreso.Subtotal_ingreso;
                //SqlCmd.Parameters.Add(ParSubtotal);

                SqlParameter ParIsv = new SqlParameter();
                ParIsv.ParameterName = "@isv_ingreso";
                ParIsv.SqlDbType = SqlDbType.Money;
                ParIsv.Value = Ingreso.Isv_ingreso;
                SqlCmd.Parameters.Add(ParIsv);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total_ingreso";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Ingreso.Total_ingreso;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 7;
                ParEstado.Value = Ingreso.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Ingreso.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParIdEmpleado = new SqlParameter();
                ParIdEmpleado.ParameterName = "@idempleado";
                ParIdEmpleado.SqlDbType = SqlDbType.Int;
                ParIdEmpleado.Value = Ingreso.Idempleado;
                SqlCmd.Parameters.Add(ParIdEmpleado);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro.";
                if (respuesta.Equals("OK"))
                {
                    this.Idingreso = Convert.ToInt32(SqlCmd.Parameters["@idingreso"].Value);
                    foreach (DDetalle_ingreso det in Detalle)
                    {
                        det.Idingreso = this.Idingreso;
                        det.Insertar(det,ref SqlCon,ref SqlTra);
                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else {
                    SqlTra.Rollback();
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;
        }

        //metodo anular
        public string Anular(DIngreso Ingreso)
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
                SqlCmd.CommandText = "spanular_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdIngreso = new SqlParameter();
                ParIdIngreso.ParameterName = "@idingreso";
                ParIdIngreso.SqlDbType = SqlDbType.Int;
                ParIdIngreso.Value = Ingreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdIngreso);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Anuló el Ingreso.";
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
            DataTable DtResultado = new DataTable("ingresos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ingreso";
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

        //buscar
        public DataTable BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("ingresos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_ingreso_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
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
            DataTable DtResultado = new DataTable("detalle_ingresos");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_ingreso";
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


    }
}
