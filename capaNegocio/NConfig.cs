using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using capaDatos;

namespace capaNegocio
{
    public class NConfig
    {
        //obtener
        public static DataTable Obtener()
        {
            return new DConfig().Obtener();
        }

        //metodo insertar
        public static string Insertar(
            string titulo,
            string razon_social,
            string nombre_comercial,
            string sucursal,
            string direccion,
            string telefono,
            string correo,
            string slogan,
            string propietario,
            string userroot,
            string passroot,
            decimal ganancia,
            decimal seguro,
            decimal isr,
            decimal isv,
            decimal descuento,
            string rtn,
            string cai,
            string punto_emision,
            string establecimiento,
            string tipo_documento,
            string rango_inicial,
            string rango_final)
        {
            DConfig Obj = new DConfig();
            Obj.Titulo = titulo;
            Obj.Nombre = razon_social;
            Obj.ComercialNombre = nombre_comercial;
            Obj.Sucursal = sucursal;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Slogan = slogan;
            Obj.Propietario = propietario;
            Obj.RootUser = userroot;
            Obj.RootPass = passroot;
            Obj.Ganancia = ganancia;
            Obj.Seguro = seguro;
            Obj.Isr = isr;
            Obj.Isv = isv;
            Obj.Descuento = descuento;
            Obj.Rtn = rtn;
            Obj.Cai = cai;
            Obj.PuntoEmision = punto_emision;
            Obj.Establecimiento = establecimiento;
            Obj.TipoDocumento = tipo_documento;
            Obj.RangoInicial = rango_inicial;
            Obj.RangoFinal = rango_final;
            return Obj.Insertar(Obj);
        }

        //metodo Actualizar
        public static string Actualizar(
            int idconfig,
            string titulo,
            string razon_social,
            string nombre_comercial,
            string sucursal,
            string direccion,
            string telefono,
            string correo,
            string slogan,
            string propietario,
            string userroot,
            string passroot,
            decimal ganancia,
            decimal seguro,
            decimal isr,
            decimal isv,
            decimal descuento,
            string rtn,
            string cai,
            string punto_emision,
            string establecimiento,
            string tipo_documento,
            string rango_inicial,
            string rango_final)
        {
            DConfig Obj = new DConfig();
            Obj.IdConfig = idconfig;
            Obj.Titulo = titulo;
            Obj.Nombre = razon_social;
            Obj.ComercialNombre = nombre_comercial;
            Obj.Sucursal = sucursal;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Slogan = slogan;
            Obj.Propietario = propietario;
            Obj.RootUser = userroot;
            Obj.RootPass = passroot;
            Obj.Ganancia = ganancia;
            Obj.Seguro = seguro;
            Obj.Isr = isr;
            Obj.Isv = isv;
            Obj.Descuento = descuento;
            Obj.Rtn = rtn;
            Obj.Cai = cai;
            Obj.PuntoEmision = punto_emision;
            Obj.Establecimiento = establecimiento;
            Obj.TipoDocumento = tipo_documento;
            Obj.RangoInicial = rango_inicial;
            Obj.RangoFinal = rango_final;
            return Obj.Actualizar(Obj);
        }
    }
}
