using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;

using capaDatos;

namespace capaNegocio
{
    public class NPago_planilla
    {
        //metodo insertar
        public static string Insertar(
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
            DPago_planilla Obj = new DPago_planilla();
            Obj.Fechapago = fechapago;
            Obj.Conceptode = conceptode;
            Obj.Tipopago = tipopago;
            Obj.Numcomprobante = comprobante;
            Obj.Descripcion = descripcion;
            Obj.Tipoimporte = tipoimporte;
            Obj.Totalbruto = totalbruto;
            Obj.Seguro = seguro;
            Obj.Totalneto = totalneto;
            Obj.Impuestorenta = impuestorenta;
            Obj.Netopagar = netopagar;
            Obj.Estado = estado;
            Obj.Idempleado = idempleado;
            return Obj.Insertar(Obj);
        }

        //metodo anular
        public static string Anular(int idpago_planilla)
        {
            DPago_planilla Obj = new DPago_planilla();
            Obj.Idpago = idpago_planilla;
            Obj.Estado = "ANULADO";
            return Obj.Anular(Obj);
        }

        //mostrar
        public static DataTable Mostrar()
        {
            return new DPago_planilla().Mostrar();
        }

        //buscar texto
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DPago_planilla Obj = new DPago_planilla();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
    }
}
