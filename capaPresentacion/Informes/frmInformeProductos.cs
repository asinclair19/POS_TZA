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
    public partial class frmInformeProductos : Form
    {
        public frmInformeProductos()
        {
            InitializeComponent();
        }

        private void frmInformeProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spmostrar_producto' Puede moverla o quitarla según sea necesario.
            
            try
            {
                this.spmostrar_productoTableAdapter.Fill(this.dsPrincipal.spmostrar_producto);

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                string valor = ex.ToString();
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
