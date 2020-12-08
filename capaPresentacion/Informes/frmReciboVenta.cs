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
    public partial class frmReciboVenta : Form
    {
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public frmReciboVenta()
        {
            InitializeComponent();
        }

        private void frmReciboVenta_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spinforme_factura' Puede moverla o quitarla según sea necesario.
                this.spinforme_facturaTableAdapter.Fill(this.dsPrincipal.spinforme_factura, Idventa);

                this.rvReciboVenta.RefreshReport();
                this.rvReciboVenta.ZoomPercent = 90;
                this.rvReciboVenta.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            }
            catch(Exception Ex) {
                string ex = Ex.ToString();
                this.rvReciboVenta.RefreshReport();
            }
        }
    }
}
