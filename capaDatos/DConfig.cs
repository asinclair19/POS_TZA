using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Configuration;

using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class DConfig
    {

        //variables privadas
        private int _IdConfig;
        private string _Titulo;
        private string _Nombre;
        private string _comercialNombre;
        private string _Sucursal;
        private string _Direccion;
        private string _Telefono;
        private string _Correo;
        private string _Slogan;
        private string _Propietario;
        
        //login
        private string _rootUser;
        private string _rootPass;
        //compras
        private decimal _Ganancia;
        //pagos
        private decimal _Seguro;
        private decimal _Isr;

        //ventas
        private decimal _Isv;
        private decimal _Descuento;
        private string _Rtn;
        private string _Cai;
        private string _PuntoEmision;
        private string _Establecimiento;
        private string _TipoDocumento;
        private string _rangoInicial;
        private string _rangoFinal;

        //ENCAPSULAMIENTO
        public int IdConfig
        {
            get { return _IdConfig; }
            set { _IdConfig = value; }
        }

        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        public string PuntoEmision
        {
            get { return _PuntoEmision; }
            set { _PuntoEmision = value; }
        }

        public string Establecimiento
        {
            get { return _Establecimiento; }
            set { _Establecimiento = value; }
        }

        public string TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string ComercialNombre
        {
            get { return _comercialNombre; }
            set { _comercialNombre = value; }
        }

        public string Sucursal
        {
            get { return _Sucursal; }
            set { _Sucursal = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public string Slogan
        {
            get { return _Slogan; }
            set { _Slogan = value; }
        }

        public string Propietario
        {
            get { return _Propietario; }
            set { _Propietario = value; }
        }

        public string Rtn
        {
            get { return _Rtn; }
            set { _Rtn = value; }
        }

        public string Cai
        {
            get { return _Cai; }
            set { _Cai = value; }
        }

        public string RootUser
        {
            get { return _rootUser; }
            set { _rootUser = value; }
        }

        public string RootPass
        {
            get { return _rootPass; }
            set { _rootPass = value; }
        }

        public decimal Ganancia
        {
            get { return _Ganancia; }
            set { _Ganancia = value; }
        }


        public decimal Seguro
        {
            get { return _Seguro; }
            set { _Seguro = value; }
        }

        public decimal Isr
        {
            get { return _Isr; }
            set { _Isr = value; }
        }

        public decimal Isv
        {
            get { return _Isv; }
            set { _Isv = value; }
        }

        public string RangoInicial
        {
            get { return _rangoInicial; }
            set { _rangoInicial = value; }
        }

        public string RangoFinal
        {
            get { return _rangoFinal; }
            set { _rangoFinal = value; }
        }

        //METODOS
        //CONSTRUCTOR VACIO
        public DConfig()
        { 
        
        }

        //CONSTRUCTOR CON ATRIBUTOS
        public DConfig(
            string titulo,
            string nombre,
            string comercialnombre,
            string sucursal,
            string direccion,
            string telefono,
            string correo,
            string slogan,
            string propietario,
            string rtn,
            string cai,
            string rootuser,
            string rootpass,
            decimal ganancia,
            decimal seguro,
            decimal isr,
            decimal isv,
            decimal descuento,
            string puntoemision,
            string establecimiento,
            string tipodoc,
            string rangoinicial,
            string rangofinal
            )
        {
            this.Titulo = titulo;
            this.Nombre = nombre;
            this.ComercialNombre = comercialnombre;
            this.Sucursal = sucursal;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Slogan = slogan;
            this.Propietario = propietario;
            this.Rtn = rtn;
            this.Cai = cai;
            this.RootUser = rootuser;
            this.RootPass = rootpass;
            this.Ganancia = ganancia;
            this.Seguro = seguro;
            this.Isr = isr;
            this.Isv = isv;
            this.Descuento = descuento;
            this.PuntoEmision = puntoemision;
            this.Establecimiento = establecimiento;
            this.TipoDocumento = tipodoc;
            this.RangoInicial = rangoinicial;
            this.RangoFinal = rangofinal;
        }

        //private static void establecerValores(string pclave, string pvalor)
        //{
        //    //crea objeto de configuracion
        //    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    //borra configuracion actual
        //    config.AppSettings.Settings.Remove(pclave);
        //    //guardar cambios
        //    config.Save(ConfigurationSaveMode.Modified);
        //    //forzar la recarga de la seccion
        //    ConfigurationManager.RefreshSection("appSettings");

        //    //guarda la configuracion
        //    config.AppSettings.Settings.Add(pclave, pvalor);

        //    //guarda cambios
        //    config.Save(ConfigurationSaveMode.Modified);

        //    //forzar la recarga de la seccion
        //    ConfigurationManager.RefreshSection("appSettings");

        //}

        //private static string RecuperarValor(string pclave)
        //{
        //    string retorno = ConfigurationManager.AppSettings[pclave];
        //    if(retorno == null)
        //    {
        //        retorno = "No se encontró valor.";
        //    }
        //    return retorno;
        //}

        //public string Guardar(DConfig Config)
        //{
        //    string rpta = "";
        //    try
        //    {
        //        establecerValores("title", Config.Title);
        //        establecerValores("name", Config.Name);
        //        establecerValores("comercialname", Config.ComercialName);
        //        establecerValores("sucursal", Config.Sucursal);
        //        establecerValores("direccion", Config.Direccion);
        //        establecerValores("telefono", Config.Telefono);
        //        establecerValores("correo", Config.Correo);
        //        establecerValores("slogan", Config.Slogan);
        //        establecerValores("propietario", Config.Propietario);
        //        establecerValores("rtn", Config.Rtn);
        //        establecerValores("cai", Config.Cai);
        //        establecerValores("rootuser", Config.RootUser);
        //        establecerValores("rootpass", Config.RootPass);
        //        establecerValores("ganancia", Convert.ToString(Config.Ganancia));
        //        establecerValores("seguro", Convert.ToString(Config.Seguro));
        //        establecerValores("isr", Convert.ToString(Config.Isr));
        //        establecerValores("isv", Convert.ToString(Config.Isv));
        //        establecerValores("rangoinicial", Config.RangoInicial);
        //        establecerValores("rangofinal", Config.RangoFinal);
        //        rpta = "OK";
        //    }
        //    catch (Exception ex)
        //    {
        //        ex.ToString();
        //    }
        //    return rpta;

        //}

        //public string Mostrar(string pclave)
        //{
        //    string rtd;
        //    rtd = RecuperarValor(pclave);
        //    return rtd;
        //}

        //metodo insertar
        public string Insertar(DConfig Config)
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
                SqlCmd.CommandText = "spinsertar_config";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                /*//parametros
                SqlParameter ParIdUnidad = new SqlParameter();
                ParIdUnidad.ParameterName = "@idunidad";
                ParIdUnidad.SqlDbType = SqlDbType.Int;
                ParIdUnidad.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdUnidad);*/

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 30;
                ParTitulo.Value = Config.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razon_social";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 100;
                ParRazonSocial.Value = Config.Nombre;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParNombreComercial= new SqlParameter();
                ParNombreComercial.ParameterName = "@nombre_comercial";
                ParNombreComercial.SqlDbType = SqlDbType.VarChar;
                ParNombreComercial.Size = 50;
                ParNombreComercial.Value = Config.ComercialNombre;
                SqlCmd.Parameters.Add(ParNombreComercial);

                SqlParameter ParSucursal = new SqlParameter();
                ParSucursal.ParameterName = "@nombre_sucursal";
                ParSucursal.SqlDbType = SqlDbType.VarChar;
                ParSucursal.Size = 30;
                ParSucursal.Value = Config.Sucursal;
                SqlCmd.Parameters.Add(ParSucursal);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.Text;
                ParDireccion.Value = Config.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Config.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Config.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParSlogan = new SqlParameter();
                ParSlogan.ParameterName = "@slogan";
                ParSlogan.SqlDbType = SqlDbType.VarChar;
                ParSlogan.Size = 255;
                ParSlogan.Value = Config.Slogan;
                SqlCmd.Parameters.Add(ParSlogan);

                SqlParameter ParPropietario = new SqlParameter();
                ParPropietario.ParameterName = "@propietario";
                ParPropietario.SqlDbType = SqlDbType.VarChar;
                ParPropietario.Size = 30;
                ParPropietario.Value = Config.Propietario;
                SqlCmd.Parameters.Add(ParPropietario);

                SqlParameter ParUsuarioRoot = new SqlParameter();
                ParUsuarioRoot.ParameterName = "@usuario_root";
                ParUsuarioRoot.SqlDbType = SqlDbType.VarChar;
                ParUsuarioRoot.Size = 15;
                ParUsuarioRoot.Value = Config.RootUser;
                SqlCmd.Parameters.Add(ParUsuarioRoot);

                SqlParameter ParPassRoot = new SqlParameter();
                ParPassRoot.ParameterName = "@pass_root";
                ParPassRoot.SqlDbType = SqlDbType.Text;
                ParPassRoot.Value = Config.RootPass;
                SqlCmd.Parameters.Add(ParPassRoot);

                SqlParameter ParGanancia = new SqlParameter();
                ParGanancia.ParameterName = "@ganancia";
                ParGanancia.SqlDbType = SqlDbType.Decimal;
                ParGanancia.Value = Config.Ganancia;
                SqlCmd.Parameters.Add(ParGanancia);

                SqlParameter ParSeguro = new SqlParameter();
                ParSeguro.ParameterName = "@seguro";
                ParSeguro.SqlDbType = SqlDbType.Decimal;
                ParSeguro.Value = Config.Seguro;
                SqlCmd.Parameters.Add(ParSeguro);

                SqlParameter ParIsr = new SqlParameter();
                ParIsr.ParameterName = "@isr";
                ParIsr.SqlDbType = SqlDbType.Decimal;
                ParIsr.Value = Config.Isr;
                SqlCmd.Parameters.Add(ParIsr);

                SqlParameter ParIsv = new SqlParameter();
                ParIsv.ParameterName = "@isv";
                ParIsv.SqlDbType = SqlDbType.Decimal;
                ParIsv.Value = Config.Isv;
                SqlCmd.Parameters.Add(ParIsv);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = Config.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParRtn = new SqlParameter();
                ParRtn.ParameterName = "@rtn";
                ParRtn.SqlDbType = SqlDbType.NVarChar;
                ParRtn.Size = 50;
                ParRtn.Value = Config.Rtn;
                SqlCmd.Parameters.Add(ParRtn);

                SqlParameter ParCai = new SqlParameter();
                ParCai.ParameterName = "@cai";
                ParCai.SqlDbType = SqlDbType.NVarChar;
                ParCai.Size = 50;
                ParCai.Value = Config.Cai;
                SqlCmd.Parameters.Add(ParCai);

                SqlParameter ParPuntoEmision = new SqlParameter();
                ParPuntoEmision.ParameterName = "@punto_emision";
                ParPuntoEmision.SqlDbType = SqlDbType.NVarChar;
                ParPuntoEmision.Size = 10;
                ParPuntoEmision.Value = Config.PuntoEmision;
                SqlCmd.Parameters.Add(ParPuntoEmision);

                SqlParameter ParEstablecimiento = new SqlParameter();
                ParEstablecimiento.ParameterName = "@establecimiento";
                ParEstablecimiento.SqlDbType = SqlDbType.NVarChar;
                ParEstablecimiento.Size = 10;
                ParEstablecimiento.Value = Config.Establecimiento;
                SqlCmd.Parameters.Add(ParEstablecimiento);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@tipo_documento";
                ParTipoDoc.SqlDbType = SqlDbType.NVarChar;
                ParTipoDoc.Size = 10;
                ParTipoDoc.Value = Config.TipoDocumento;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParRangoInicial = new SqlParameter();
                ParRangoInicial.ParameterName = "@rango_inicial";
                ParRangoInicial.SqlDbType = SqlDbType.NVarChar;
                ParRangoInicial.Size = 50;
                ParRangoInicial.Value = Config.RangoInicial;
                SqlCmd.Parameters.Add(ParRangoInicial);

                SqlParameter ParRangoFinal = new SqlParameter();
                ParRangoFinal.ParameterName = "@rango_final";
                ParRangoFinal.SqlDbType = SqlDbType.NVarChar;
                ParRangoFinal.Size = 50;
                ParRangoFinal.Value = Config.RangoFinal;
                SqlCmd.Parameters.Add(ParRangoFinal);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingresó el Registro.";
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

        //metodo actualizar
        public string Actualizar(DConfig Config)
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
                SqlCmd.CommandText = "spupdate_config";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //parametros
                SqlParameter ParIdConfig = new SqlParameter();
                ParIdConfig.ParameterName = "@idconfig";
                ParIdConfig.SqlDbType = SqlDbType.Int;
                ParIdConfig.Value = Config.IdConfig;
                SqlCmd.Parameters.Add(ParIdConfig);

                SqlParameter ParTitulo = new SqlParameter();
                ParTitulo.ParameterName = "@titulo";
                ParTitulo.SqlDbType = SqlDbType.VarChar;
                ParTitulo.Size = 30;
                ParTitulo.Value = Config.Titulo;
                SqlCmd.Parameters.Add(ParTitulo);

                SqlParameter ParRazonSocial = new SqlParameter();
                ParRazonSocial.ParameterName = "@razon_social";
                ParRazonSocial.SqlDbType = SqlDbType.VarChar;
                ParRazonSocial.Size = 100;
                ParRazonSocial.Value = Config.Nombre;
                SqlCmd.Parameters.Add(ParRazonSocial);

                SqlParameter ParNombreComercial = new SqlParameter();
                ParNombreComercial.ParameterName = "@nombre_comercial";
                ParNombreComercial.SqlDbType = SqlDbType.VarChar;
                ParNombreComercial.Size = 50;
                ParNombreComercial.Value = Config.ComercialNombre;
                SqlCmd.Parameters.Add(ParNombreComercial);

                SqlParameter ParSucursal = new SqlParameter();
                ParSucursal.ParameterName = "@nombre_sucursal";
                ParSucursal.SqlDbType = SqlDbType.VarChar;
                ParSucursal.Size = 30;
                ParSucursal.Value = Config.Sucursal;
                SqlCmd.Parameters.Add(ParSucursal);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";
                ParDireccion.SqlDbType = SqlDbType.Text;
                ParDireccion.Value = Config.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Config.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Config.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParSlogan = new SqlParameter();
                ParSlogan.ParameterName = "@slogan";
                ParSlogan.SqlDbType = SqlDbType.VarChar;
                ParSlogan.Size = 255;
                ParSlogan.Value = Config.Slogan;
                SqlCmd.Parameters.Add(ParSlogan);

                SqlParameter ParPropietario = new SqlParameter();
                ParPropietario.ParameterName = "@propietario";
                ParPropietario.SqlDbType = SqlDbType.VarChar;
                ParPropietario.Size = 30;
                ParPropietario.Value = Config.Propietario;
                SqlCmd.Parameters.Add(ParPropietario);

                SqlParameter ParUsuarioRoot = new SqlParameter();
                ParUsuarioRoot.ParameterName = "@usuario_root";
                ParUsuarioRoot.SqlDbType = SqlDbType.VarChar;
                ParUsuarioRoot.Size = 15;
                ParUsuarioRoot.Value = Config.RootUser;
                SqlCmd.Parameters.Add(ParUsuarioRoot);

                SqlParameter ParPassRoot = new SqlParameter();
                ParPassRoot.ParameterName = "@pass_root";
                ParPassRoot.SqlDbType = SqlDbType.Text;
                ParPassRoot.Value = Config.RootPass;
                SqlCmd.Parameters.Add(ParPassRoot);

                SqlParameter ParGanancia = new SqlParameter();
                ParGanancia.ParameterName = "@ganancia";
                ParGanancia.SqlDbType = SqlDbType.Decimal;
                ParGanancia.Value = Config.Ganancia;
                SqlCmd.Parameters.Add(ParGanancia);

                SqlParameter ParSeguro = new SqlParameter();
                ParSeguro.ParameterName = "@seguro";
                ParSeguro.SqlDbType = SqlDbType.Decimal;
                ParSeguro.Value = Config.Seguro;
                SqlCmd.Parameters.Add(ParSeguro);

                SqlParameter ParIsr = new SqlParameter();
                ParIsr.ParameterName = "@isr";
                ParIsr.SqlDbType = SqlDbType.Decimal;
                ParIsr.Value = Config.Isr;
                SqlCmd.Parameters.Add(ParIsr);

                SqlParameter ParIsv = new SqlParameter();
                ParIsv.ParameterName = "@isv";
                ParIsv.SqlDbType = SqlDbType.Decimal;
                ParIsv.Value = Config.Isv;
                SqlCmd.Parameters.Add(ParIsv);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";
                ParDescuento.SqlDbType = SqlDbType.Decimal;
                ParDescuento.Value = Config.Descuento;
                SqlCmd.Parameters.Add(ParDescuento);

                SqlParameter ParRtn = new SqlParameter();
                ParRtn.ParameterName = "@rtn";
                ParRtn.SqlDbType = SqlDbType.NVarChar;
                ParRtn.Size = 50;
                ParRtn.Value = Config.Rtn;
                SqlCmd.Parameters.Add(ParRtn);

                SqlParameter ParCai = new SqlParameter();
                ParCai.ParameterName = "@cai";
                ParCai.SqlDbType = SqlDbType.NVarChar;
                ParCai.Size = 50;
                ParCai.Value = Config.Cai;
                SqlCmd.Parameters.Add(ParCai);

                SqlParameter ParPuntoEmision = new SqlParameter();
                ParPuntoEmision.ParameterName = "@punto_emision";
                ParPuntoEmision.SqlDbType = SqlDbType.NVarChar;
                ParPuntoEmision.Size = 10;
                ParPuntoEmision.Value = Config.PuntoEmision;
                SqlCmd.Parameters.Add(ParPuntoEmision);

                SqlParameter ParEstablecimiento = new SqlParameter();
                ParEstablecimiento.ParameterName = "@establecimiento";
                ParEstablecimiento.SqlDbType = SqlDbType.NVarChar;
                ParEstablecimiento.Size = 10;
                ParEstablecimiento.Value = Config.Establecimiento;
                SqlCmd.Parameters.Add(ParEstablecimiento);

                SqlParameter ParTipoDoc = new SqlParameter();
                ParTipoDoc.ParameterName = "@tipo_documento";
                ParTipoDoc.SqlDbType = SqlDbType.NVarChar;
                ParTipoDoc.Size = 10;
                ParTipoDoc.Value = Config.TipoDocumento;
                SqlCmd.Parameters.Add(ParTipoDoc);

                SqlParameter ParRangoInicial = new SqlParameter();
                ParRangoInicial.ParameterName = "@rango_inicial";
                ParRangoInicial.SqlDbType = SqlDbType.NVarChar;
                ParRangoInicial.Size = 50;
                ParRangoInicial.Value = Config.RangoInicial;
                SqlCmd.Parameters.Add(ParRangoInicial);

                SqlParameter ParRangoFinal = new SqlParameter();
                ParRangoFinal.ParameterName = "@rango_final";
                ParRangoFinal.SqlDbType = SqlDbType.NVarChar;
                ParRangoFinal.Size = 50;
                ParRangoFinal.Value = Config.RangoFinal;
                SqlCmd.Parameters.Add(ParRangoFinal);

                //Ejecutamos el comando 
                respuesta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Modificó el Registro.";
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

        //obtener valores
        public DataTable Obtener()
        {
            DataTable DtResultado = new DataTable("configuracion");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.conexion;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spobtener_config";
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


    }
}
