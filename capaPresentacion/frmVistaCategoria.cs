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
    public partial class frmVistaCategoria : Form
    {
        public frmVistaCategoria()
        {
            InitializeComponent();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            this.dgvCategoria.Columns[0].Visible = false; //idcategoria
            this.dgvCategoria.Columns[1].Visible = true; //nombre_categoria 
            this.dgvCategoria.Columns[2].Visible = true; //descripcion_categoria
            this.dgvCategoria.Columns[3].Visible = false; //imagen_categoria
            this.dgvCategoria.Columns[4].Visible = false; //activa_categoria
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvCategoria.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCategoria.Rows.Count);
        }

        //BUSCAR datos en columnas en DATAGRID
        private void BuscarNombre()
        {
            this.dgvCategoria.DataSource = NCategoria.Buscar(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCategoria.Rows.Count);
        }

        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            frmProductos form = frmProductos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["nombre_categoria"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void frmVistaCategoria_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }
    }
}
