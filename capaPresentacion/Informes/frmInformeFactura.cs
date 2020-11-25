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
    public partial class frmInformeFactura : Form
    {
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }

        public frmInformeFactura()
        {
            InitializeComponent();
        }

        private void frmInformeFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spinforme_factura' Puede moverla o quitarla según sea necesario.
            
            try
            {
                this.spinforme_facturaTableAdapter.Fill(this.dsPrincipal.spinforme_factura, Idventa);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                string valor = ex.ToString();
                this.reportViewer1.RefreshReport();
            }

        } //final metodo
    } //final partial class
} //final namespace
