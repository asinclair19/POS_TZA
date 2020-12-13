using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using capaNegocio;

namespace capaPresentacion
{
    public partial class frmVistaProducto_Ventas : Form
    {
        public frmVistaProducto_Ventas()
        {
            InitializeComponent();
            this.txtBuscar.Focus();
        }

        private void frmVistaProducto_Ventas_Load(object sender, EventArgs e)
        {
            this.txtBuscar.Focus();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            //this.dgvProducto.Columns[0].Visible = false; //check eliminar
            //foreach (DataGridViewColumn column in this.dgvProducto.Columns)
            //{
            //    column.Visible = true;
            //}
        }

        //MostrarDatos columnas en DATAGRID
        //private void MostrarDatos()
        //{
        //    this.dgvProducto.DataSource = NProducto.Mostrar();
        //    this.OcultarColumnas();
        //    this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvProducto.Rows.Count);
        //}

        //MostrarDatos columnas en DATAGRID
        private void BuscarProducto(string textoAbuscar)
        {
            this.dgvProducto.DataSource = NVenta.BuscarProductoVenta(textoAbuscar);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvProducto.Rows.Count);
        }

        //buscar con boton
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProducto(this.txtBuscar.Text);
        }

        //buscar cuando el texto cambia
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarProducto(this.txtBuscar.Text);
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            frmVentas form = frmVentas.GetInstancia();
            string iddetalle, nombre;
            int stock;
            decimal pventa, pcompra;
            DateTime fechav;
            iddetalle = Convert.ToString(this.dgvProducto.CurrentRow.Cells["iddetalleIngreso"].Value);
            nombre = Convert.ToString(this.dgvProducto.CurrentRow.Cells["nombre_producto"].Value);
            stock = Convert.ToInt32(this.dgvProducto.CurrentRow.Cells["stock_final"].Value);
            pventa = Convert.ToDecimal(this.dgvProducto.CurrentRow.Cells["precio_venta"].Value);
            pcompra = Convert.ToDecimal(this.dgvProducto.CurrentRow.Cells["precio_compra"].Value);
            fechav = Convert.ToDateTime(this.dgvProducto.CurrentRow.Cells["fecha_vencimiento"].Value);
            form.setProducto(iddetalle, nombre, stock, pventa, pcompra, fechav);
            this.Hide();
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
