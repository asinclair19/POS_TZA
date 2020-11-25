using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using capaDatos;

namespace capaNegocio
{
    public class NConfig
    {
        //metodo Guardar
        public static string Guardar(
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
            string rangoinicial,
            string rangofinal
            )
        {
            DConfig Obj = new DConfig();
            Obj.Title = title;
            Obj.Name = name;
            Obj.ComercialName = comercialname;
            Obj.Sucursal = sucursal;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Slogan = slogan;
            Obj.Propietario = propietario;
            Obj.Rtn = rtn;
            Obj.Cai = cai;
            Obj.RootUser = rootuser;
            Obj.RootPass = rootpass;
            Obj.Ganancia = ganancia;
            Obj.Seguro = seguro;
            Obj.Isr = isr;
            Obj.Isv = isv;
            Obj.RangoInicial = rangoinicial;
            Obj.RangoFinal = rangofinal;
            return Obj.Guardar(Obj);
        }

        public static string Mostrar(string pclave)
        {
            return new DConfig().Mostrar(pclave);
        }
    }
}
