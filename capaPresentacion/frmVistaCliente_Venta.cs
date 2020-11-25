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
    public partial class frmVistaCliente_Venta : Form
    {
        public frmVistaCliente_Venta()
        {
            InitializeComponent();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            foreach (DataGridViewColumn column in this.dgvCliente.Columns)
            {
                column.Visible = false;
            }
            this.dgvCliente.Columns[3].Visible = true;
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvCliente.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCliente.Rows.Count);
        }

        //Buscar columnas en DATAGRID
        private void BuscarNombre(string textoAbuscar)
        {
            this.dgvCliente.DataSource = NCliente.Buscar(textoAbuscar);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCliente.Rows.Count);
        }

        //mostrar datos de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre(this.txtBuscar.Text);
        }

        //mostrar datos de busqueda por BOTON
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre(this.txtBuscar.Text);
        }

        private void frmVistaCliente_Venta_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            frmVentas form = frmVentas.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dgvCliente.CurrentRow.Cells["idcliente"].Value);
            par2 = Convert.ToString(this.dgvCliente.CurrentRow.Cells["nombre_cliente"].Value);
            form.setCliente(par1, par2);
            this.Hide();
        }

    }
}
