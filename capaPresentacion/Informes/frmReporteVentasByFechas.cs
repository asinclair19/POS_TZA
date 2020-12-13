using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class frmReporteVentasByFechas : Form
    {
        private string _Fechainicial;
        private string _Fechafinal;

        public string Fechainicial
        {
            get { return _Fechainicial; }
            set { _Fechainicial = value; }
        }

        public string Fechafinal
        {
            get { return _Fechafinal; }
            set { _Fechafinal = value; }
        }

        public frmReporteVentasByFechas()
        {
            InitializeComponent();
        }

        private void frmReporteVentasByFechas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spbuscar_venta_fecha' Puede moverla o quitarla según sea necesario.
            try
            {
                
                this.spbuscar_venta_fechaTableAdapter.Fill(this.dsPrincipal.spbuscar_venta_fecha, Fechainicial, Fechafinal);
                
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.reportViewer1.RefreshReport();
            }
            
            
        }
    }
}
