using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace capaDatos
{
    public class DConfig
    {

        //variables privadas
        private string _Title;
        private string _Name;
        private string _comercialName;
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
        private string _Rtn;
        private string _Cai;
        private string _PuntoEmision;
        private string _Establecimiento;
        private string _TipoDocumento;
        private string _rangoInicial;
        private string _rangoFinal;

        //ENCAPSULAMIENTO
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

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string ComercialName
        {
            get { return _comercialName; }
            set { _comercialName = value; }
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
            string title,
            string name,
            string comercialname,
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
            string puntoemision,
            string establecimiento,
            string tipodoc,
            string rangoinicial,
            string rangofinal
            )
        {
            this.Title = title;
            this.Name = name;
            this.ComercialName = comercialname;
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
            this.PuntoEmision = puntoemision;
            this.Establecimiento = establecimiento;
            this.TipoDocumento = tipodoc;
            this.RangoInicial = rangoinicial;
            this.RangoFinal = rangofinal;
        }

        private static void establecerValores(string pclave, string pvalor)
        {
            //crea objeto de configuracion
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //borra configuracion actual
            config.AppSettings.Settings.Remove(pclave);
            //guardar cambios
            config.Save(ConfigurationSaveMode.Modified);
            //forzar la recarga de la seccion
            ConfigurationManager.RefreshSection("appSettings");

            //guarda la configuracion
            config.AppSettings.Settings.Add(pclave, pvalor);

            //guarda cambios
            config.Save(ConfigurationSaveMode.Modified);

            //forzar la recarga de la seccion
            ConfigurationManager.RefreshSection("appSettings");

        }

        private static string RecuperarValor(string pclave)
        {
            string retorno = ConfigurationManager.AppSettings[pclave];
            if(retorno == null)
            {
                retorno = "No se encontró valor.";
            }
            return retorno;
        }

        public string Guardar(DConfig Config)
        {
            string rpta = "";
            try
            {
                establecerValores("title", Config.Title);
                establecerValores("name", Config.Name);
                establecerValores("comercialname", Config.ComercialName);
                establecerValores("sucursal", Config.Sucursal);
                establecerValores("direccion", Config.Direccion);
                establecerValores("telefono", Config.Telefono);
                establecerValores("correo", Config.Correo);
                establecerValores("slogan", Config.Slogan);
                establecerValores("propietario", Config.Propietario);
                establecerValores("rtn", Config.Rtn);
                establecerValores("cai", Config.Cai);
                establecerValores("rootuser", Config.RootUser);
                establecerValores("rootpass", Config.RootPass);
                establecerValores("ganancia", Convert.ToString(Config.Ganancia));
                establecerValores("seguro", Convert.ToString(Config.Seguro));
                establecerValores("isr", Convert.ToString(Config.Isr));
                establecerValores("isv", Convert.ToString(Config.Isv));
                establecerValores("rangoinicial", Config.RangoInicial);
                establecerValores("rangofinal", Config.RangoFinal);
                rpta = "OK";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return rpta;

        }

        public string Mostrar(string pclave)
        {
            string rtd;
            rtd = RecuperarValor(pclave);
            return rtd;
        }
    }
}
