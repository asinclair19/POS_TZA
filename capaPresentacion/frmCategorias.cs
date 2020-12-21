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
    public partial class frmCategorias : Form
    {
        private bool EsNuevo = false;

        private bool EsEditar = false;


        public frmCategorias()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre,"Ingrese el nombre de la categoría.");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese una descripción de la categoría.");
        }

        //Mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema POS",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void LimpiarControles()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.chkActiva.Checked = false;
            this.chkActiva.CheckState = CheckState.Unchecked;

        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.chkActiva.Checked = true;

        }

        //habilitar botones
        private void Botones()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            this.dgvCategoria.Columns[0].Visible = false;
            this.dgvCategoria.Columns[1].Visible = false;
            this.dgvCategoria.Columns[4].Visible = false;
            this.dgvCategoria.Columns[5].Visible = false;
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvCategoria.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCategoria.Rows.Count);
        }

        //MostrarDatos columnas en DATAGRID
        private void BuscarNombre(string textoAbuscar)
        {
            this.dgvCategoria.DataSource = NCategoria.Buscar(textoAbuscar);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvCategoria.Rows.Count);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
            this.txtBuscar.Focus();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.LimpiarControles();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        //metodo determinar activa
        private int CategoriaActiva(CheckBox check)
        {
            int activa = 1;
            //determinar activo o no
            if (check.Checked == true)
            {
                activa = 1;
            }
            else
            {
                activa = 0;
            }

            return activa;
        }
        //guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string rutaimagen = "";
            

            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombre, "Ingrese un nombre");
                }
                else {
                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NCategoria.Insertar(this.txtNombre.Text.Trim().ToUpper(), 
                            this.txtDescripcion.Text.Trim(), rutaimagen, Convert.ToInt32(this.CategoriaActiva(chkActiva)));
                    }
                    else
                    {
                        //id,nombre,descripcion,imagen,activa
                        rpta = NCategoria.Editar(Convert.ToInt32(this.txtCodigo.Text),
                            this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim(), rutaimagen, Convert.ToInt32(this.CategoriaActiva(chkActiva)));
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("Se inserto de forma correcta el registro.");
                        }
                        else
                        {
                            this.MensajeOK("Se modificó de forma correcta el registro.");
                        }
                    }
                    else {
                        this.MensajeError(rpta);
                    }

                    //preparamos para nuevos datos
                    this.EsNuevo = false;
                    this.EsEditar = false;
                    this.Botones();
                    this.LimpiarControles();
                    this.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        //mostrar datos
        private void dgvCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["idcategoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["nombre_categoria"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvCategoria.CurrentRow.Cells["descripcion_categoria"].Value);

            if (Convert.ToInt32(this.dgvCategoria.CurrentRow.Cells["activa_categoria"].Value)== 1)
            {
                this.chkActiva.Checked = true;
            }else{
                this.chkActiva.Checked = false;
            }
            
            this.tabControl1.SelectedIndex = 1;
        }
        
        //BOTON editar datos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(string.Empty)){
                this.EsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }else{
                this.MensajeError("Seleccionar primero el registro que desea modificar.");
            }
        }

        //BOTON Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.EsEditar = false;
            this.Botones();
            this.LimpiarControles();
            this.Habilitar(false);
            this.errorIcono.Clear();
        }

        //Checkbox Eliminar
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvCategoria.Columns[0].Visible = true;
            }
            else {
                this.dgvCategoria.Columns[0].Visible = false;
            }
        }

        //Checkbox Habilitar Celda de GRIlla ELIMNAR
        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgvCategoria.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //BOTON eliminar CLICK
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?","Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Codigo;
                    string Rpta = "";
                    
                    foreach (DataGridViewRow row in dgvCategoria.Rows){
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Convert.ToInt32(Codigo));

                            if (Rpta.Equals("OK")){
                                this.MensajeOK("Se eliminó correctamente el registro.");
                            }else{
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.MostrarDatos();
                }

            }catch (Exception ex){
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


    }
}
