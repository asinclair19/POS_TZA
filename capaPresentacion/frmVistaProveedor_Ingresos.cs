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
    public partial class frmVistaProveedor_Ingresos : Form
    {
        public frmVistaProveedor_Ingresos()
        {
            InitializeComponent();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            foreach (DataGridViewColumn column in this.dgvProveedor.Columns)
            {
                column.Visible = false;
            }
            this.dgvProveedor.Columns["idproveedor"].Visible = true;
            this.dgvProveedor.Columns["nombre_empresa"].Visible = true;
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvProveedor.DataSource = NProveedor.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvProveedor.Rows.Count);
        }

        //MostrarDatos columnas en DATAGRID
        private void BuscarNombre(string textoAbuscar)
        {
            this.dgvProveedor.DataSource = NProveedor.Buscar(textoAbuscar);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvProveedor.Rows.Count);
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

        private void frmVistaProveedor_Ingresos_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            frmIngresos form = frmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["idproveedor"].Value);
            par2 = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["nombre_empresa"].Value);
            form.setProveedor(par1, par2);
            this.Hide();
        }


    }
}
