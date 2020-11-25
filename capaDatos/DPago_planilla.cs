using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class DPago_planilla
    {
        //VARIABLES GLOBALES
        private int _Idpago; //idpago_planilla
        private DateTime _Fechapago; //fecha_pago
        private string _Conceptode; //nvarchar(100) concepto_de
        private string _Tipopago; //nvarchar(45) tipo_pago
        private string _Numcomprobante; //nvarchar(45) comp_transferencia
        private string _Descripcion; //nvarchar(max) descripcion_pago
        private string _Tipoimporte; //nvarchar(45) tipo_importe
        private decimal _Totalbruto; //money total_bruto
        private decimal _Seguro; //money seguro_social
        private decimal _Totalneto; //money total_neto
        private decimal _Impuestorenta; //money impuesto_renta
        private decimal _Netopagar; //money neto_a_pagar
        private string _Estado; //varchar(10) estado
        private int _Idempleado; //int IDempleado

        public int Idpago
        {
            get { return _Idpago; }
            set { _Idpago = value; }
        }

        public DateTime Fechapago
        {
            get { return _Fechapago; }
            set { _Fechapago = value; }
        }

        public string Conceptode
        {
            get { return _Conceptode; }
            set { _Conceptode = value; }
        }

        public string Tipopago
        {
            get { return _Tipopago; }
            set { _Tipopago = value; }
        }

        public string Numcomprobante
        {
            get { return _Numcomprobante; }
            set { _Numcomprobante = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public string Tipoimporte
        {
            get { return _Tipoimporte; }
            set { _Tipoimporte = value; }
        }

        public decimal Totalbruto
        {
            get { return _Totalbruto; }
            set { _Totalbruto = value; }
        }

        public decimal Seguro
        {
            get { return _Seguro; }
            set { _Seguro = value; }
        }

        public decimal Totalneto
        {
            get { return _Totalneto; }
            set { _Totalneto = value; }
        }

        public decimal Impuestorenta
        {
            get { return _Impuestorenta; }
            set { _Impuestorenta = value; }
        }

        public decimal Netopagar
        {
            get { return _Netopagar; }
            set { _Netopagar = value; }
        }

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public int Idempleado
        {
            get { return _Idempleado; }
            set { _Idempleado = value; }
        }

        //final ENCAPSULAMIENTO
        //CONSTRUCTOR VACIO
        public DPago_planilla()
        {

        }

        //constructor GLOBAL
        public DPago_planilla(
            int idpago,
            DateTime fechapago,
            string conceptode,
            string tipopago,
            string comprobante,
            string descripcion,
            string tipoimporte,
            decimal totalbruto,
            decimal seguro,
            decimal totalneto,
            decimal impuestorenta,
            decimal netopagar,
            string estado,
            int idempleado
            )
        {
            this.Idpago = idpago;
            this.Fechapago = fechapago;
            this.Conceptode = conceptode;
            this.Tipopago = tipopago;
            this.Numcomprobante = comprobante;
            this.Descripcion = descripcion;
            this.Tipoimporte = tipoimporte;
            this.Totalbruto = totalbruto;
            this.Seguro = seguro;
            this.Totalneto = totalneto;
            this.Impuestorenta = impuestorenta;
            this.Netopagar = netopagar;
            this.Estado = estado;
            this.Idempleado = idempleado;
        }

        //metodo insertar
        public string Insertar(DPago_planilla Pago_planilla)
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
                SqlCmd.CommandText = "spinsertar_pago_planilla";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdpago = new SqlParameter();
                ParIdpago.ParameterName = "@idpago_planilla";
                ParIdpago.SqlDbType = SqlDbType.Int;
                ParIdpago.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpago);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_pago";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Pago_planilla.Fechapago;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParConceptode = new SqlParameter();
                ParConceptode.ParameterName = "@concepto_de";
                ParConceptode.SqlDbType = SqlDbType.NVarChar;
                ParConceptode.Size = 100;
                ParConceptode.Value = Pago_planilla.Conceptode;
                SqlCmd.Parameters.Add(ParConceptode);

                SqlParameter ParTipopago = new SqlParameter();
                ParTipopago.ParameterName = "@tipo_pago";
                ParTipopago.SqlDbType = SqlDbType.NVarChar;
                ParTipopago.Size = 45;
                ParTipopago.Value = Pago_planilla.Tipopago;
                SqlCmd.Parameters.Add(ParTipopago);

                SqlParameter ParComprobante = new SqlParameter();
                ParComprobante.ParameterName = "@comp_transferencia";
                ParComprobante.SqlDbType = SqlDbType.NVarChar;
                ParComprobante.Size = 45;
                ParComprobante.Value = Pago_planilla.Numcomprobante;
                SqlCmd.Parameters.Add(ParComprobante);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion_pago";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                ParDescripcion.Value = Pago_planilla.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParTipoImporte = new SqlParameter();
                ParTipoImporte.ParameterName = "@tipo_importe";
                ParTipoImporte.SqlDbType = SqlDbType.NVarChar;
                ParTipoImporte.Size = 45;
                ParTipoImporte.Value = Pago_planilla.Tipoimporte;
                SqlCmd.Parameters.Add(ParTipoImporte);

                SqlParameter ParTotalBruto = new SqlParameter();
                ParTotalBruto.ParameterName = "@total_bruto";
                ParTotalBruto.SqlDbType = SqlDbType.Money;
                ParTotalBruto.Value = Pago_planilla.Totalbruto;
                SqlCmd.Parameters.Add(ParTotalBruto);

                SqlParameter ParSeguroSocial = new SqlParameter();
                ParSeguroSocial.ParameterName = "@seguro_social";
                ParSeguroSocial.SqlDbType = SqlDbType.Money;
                ParSeguroSocial.Value = Pago_planilla.Seguro;
                SqlCmd.Parameters.Add(ParSeguroSocial);

                SqlParameter ParTotalNeto = new SqlParameter();
                ParTotalNeto.ParameterName = "@total_neto";
                ParTotalNeto.SqlDbType = SqlDbType.Money;
                ParTotalNeto.Value = Pago_planilla.Totalneto;
                SqlCmd.Parameters.Add(ParTotalNeto);

                SqlParameter ParImpuestoRenta = new SqlParameter();
                ParImpuestoRenta.ParameterName = "@impuesto_renta";
                ParImpuestoRenta.SqlDbType = SqlDbType.Money;
                ParImpuestoRenta.Value = Pago_planilla.Impuestorenta;
                SqlCmd.Parameters.Add(ParImpuestoRenta);

                SqlParameter ParNetoPagar = new SqlParameter();
                ParNetoPagar.ParameterName = "@neto_a_pagar";
                ParNetoPagar.SqlDbType = SqlDbType.Money;
                ParNetoPagar.Value = Pago_planilla.Netopagar;
                SqlCmd.Parameters.Add(ParNetoPagar);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Pago_planilla.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = Pago_planilla.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se realizó el Registro del Pago.";
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
            DataTable DtResultado = new DataTable("pagos_planilla");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_pago_planilla";
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
            DataTable DtResultado = new DataTable("pagos_planilla");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_pago_planilla";
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

        //metodo anular
        public string Anular(DPago_planilla Pago_planilla)
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
                SqlCmd.CommandText = "spanular_pago_planilla";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdPagoplanilla = new SqlParameter();
                ParIdPagoplanilla.ParameterName = "@idpago_planilla";
                ParIdPagoplanilla.SqlDbType = SqlDbType.Int;
                ParIdPagoplanilla.Value = Pago_planilla.Idpago;
                SqlCmd.Parameters.Add(ParIdPagoplanilla);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Pago_planilla.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Anuló el Pago.";
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

    }
}
