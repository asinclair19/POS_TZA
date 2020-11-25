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
    public partial class frmVistaProducto_Ingresos : Form
    {
        public frmVistaProducto_Ingresos()
        {
            InitializeComponent();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            //this.dgvProducto.Columns[0].Visible = false; //check eliminar
            this.dgvProducto.Columns["idproducto"].Visible = false; //id
            this.dgvProducto.Columns["codigo_producto"].Visible = true; //codigo
            this.dgvProducto.Columns["nombre_producto"].Visible = true; //nombre
            this.dgvProducto.Columns["descripcion_producto"].Visible = false; //descripcion
            this.dgvProducto.Columns["busqueda_producto"].Visible = false; //busqueda
            this.dgvProducto.Columns["imagen_producto"].Visible = true; //imagen
            this.dgvProducto.Columns["activo_producto"].Visible = false; //activo
            this.dgvProducto.Columns["IDcategoria"].Visible = false; //idcategoria
            this.dgvProducto.Columns["Categoria"].Visible = true; //nombre categoria
            this.dgvProducto.Columns["IDunidad"].Visible = false; //id unidad
            this.dgvProducto.Columns["Unidad"].Visible = true; //nombre unidad
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvProducto.DataSource = NProducto.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvProducto.Rows.Count);
        }

        //MostrarDatos columnas en DATAGRID
        private void BuscarProducto(string textoAbuscar)
        {
            this.dgvProducto.DataSource = NProducto.Buscar(textoAbuscar);
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

        private void frmVistaProducto_Ingresos_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
            this.txtBuscar.Focus();
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            frmIngresos form = frmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dgvProducto.CurrentRow.Cells["idproducto"].Value);
            par2 = Convert.ToString(this.dgvProducto.CurrentRow.Cells["nombre_producto"].Value);
            form.setProducto(par1, par2);
            this.Hide();
        }
    }
}
