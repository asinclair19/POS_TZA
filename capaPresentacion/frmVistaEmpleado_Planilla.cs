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
    public partial class frmVistaEmpleado_Planilla : Form
    {
        public frmVistaEmpleado_Planilla()
        {
            InitializeComponent();
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgvEmpleado.Columns)
            {
                column.Visible = false;
            }
            dgv.Columns["identidad"].Visible = true; //identidad
            dgv.Columns["primer_nombre"].Visible = true; //nombre
            dgv.Columns["primer_apellido"].Visible = true;
            dgv.Columns["celular"].Visible = true;
            dgv.Columns["username"].Visible = true;
            dgv.Columns["privilegios_user"].Visible = true;
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvEmpleado.DataSource = NEmpleado.Mostrar();
            this.OcultarColumnas(dgvEmpleado);
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvEmpleado.Rows.Count);
        }

        //Buscar columnas en DATAGRID
        private void BuscarNombre(string textoAbuscar)
        {
            this.dgvEmpleado.DataSource = NEmpleado.BuscarEmpleado(textoAbuscar);
            this.OcultarColumnas(this.dgvEmpleado);
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvEmpleado.Rows.Count);
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

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmVistaEmpleado_Planilla_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
        }

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            frmPlanillas form = frmPlanillas.GetMiInstancia();
            string par1, par2, par3, par4, par5;
            par1 = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["idempleado"].Value);
            par2 = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["identidad"].Value);
            par3 = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["primer_nombre"].Value) +
                " " + Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["primer_apellido"].Value);
            par4 = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["salario_base"].Value);
            par5 = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["cargo_empleado"].Value);
            //MessageBox.Show(par1 + par2 + par3 + par4 + par5);
            form.setEmpleado(par1, par2, par3, par4, par5);
            this.Hide();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
