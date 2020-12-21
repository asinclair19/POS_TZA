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
    public partial class frmProductos : Form
    {
        //variables globales
        private bool EsNuevo = false;
        private bool EsEditar = false;

        private static frmProductos _Instancia;

        public static frmProductos GetInstancia() { 
            if (_Instancia == null){
                _Instancia = new frmProductos();
            }

            return _Instancia;
        }

        public void setCategoria(string idcategoria, string nombre) {
            this.txtCodigoCategoria.Text = idcategoria;
            this.txtNombreCategoria.Text = nombre;
        }

        public frmProductos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtCodigo, "Ingrese el codigo venta de producto.");
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre de producto.");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese descripcion de producto.");
            this.ttMensaje.SetToolTip(this.txtNombreCategoria, "Seleccione una categoría para el producto.");
            this.ttMensaje.SetToolTip(this.pxImagen, "Seleccione la imagen para el producto.");

            this.txtIDProducto.Visible = false;
            this.txtCodigoCategoria.ReadOnly = true;
            this.LlenarComboUnidades();
        }

        //Mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtBusqueda.Text = string.Empty;
            this.txtIDProducto.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtCodigoCategoria.Text = string.Empty;
            this.txtNombreCategoria.Text = string.Empty;
            this.pxImagen.Image = global::capaPresentacion.Properties.Resources.img_default_01;
        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtIDProducto.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.txtNombreCategoria.ReadOnly = !valor;
            this.btnSeleccionar.Enabled = valor;
            this.cmbUnidad.Enabled = valor;
            this.btnCargar.Enabled = valor;
            this.btnDescartar.Enabled = valor;
        }

        //habilitar botones ES NUEVO / ES EDITAR
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
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            this.dgvProducto.Columns[0].Visible = false; //check eliminar
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

        private void LlenarComboUnidades()
        {
            cmbUnidad.DataSource = NUnidad.Mostrar();
            cmbUnidad.ValueMember = "idunidad";
            cmbUnidad.DisplayMember = "nombre_unidad";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::capaPresentacion.Properties.Resources.img_default_01;
        }

        //cuando inicia el formulario
        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
            this.txtBuscar.Focus();
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
        
        //BOTON nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtCodigo.Focus();
        }

        //CREAR texto de busqueda
        private string CrearTextoBusqueda()
        {
            string texto = "";
            texto = this.txtCodigo.Text.Trim() + "-" + this.txtNombre.Text.Trim() + "-" +
                this.txtNombreCategoria.Text.Trim();
            return texto.ToLower();
        }

        //metodo determinar activo
        private int DeterminarActivo(CheckBox check)
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

        //BOTON guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty 
                    || this.txtCodigo.Text == string.Empty
                    || this.txtCodigoCategoria.Text == string.Empty
                    || this.txtDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombre, "Ingrese un nombre");
                    errorIcono.SetError(this.txtCodigo, "Ingrese un codigo");
                    errorIcono.SetError(this.txtCodigoCategoria, "Ingrese un codigo");
                    errorIcono.SetError(this.txtDescripcion, "Ingrese una descripcion");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] saveimagen = ms.GetBuffer();

                    this.txtBusqueda.Text = this.CrearTextoBusqueda();

                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NProducto.Insertar(
                            this.txtCodigo.Text.Trim().ToUpper(),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim(),
                            this.txtBusqueda.Text.Trim().ToLower(),
                            saveimagen,
                            this.DeterminarActivo(chkActiva),
                            Convert.ToInt32(this.cmbUnidad.SelectedValue),
                            Convert.ToInt32(this.txtCodigoCategoria.Text)
                            );
                    }
                    else
                    {
                        //id,nombre,descripcion,imagen,activa
                        rpta = NProducto.Editar(
                            Convert.ToInt32(this.txtIDProducto.Text.Trim()),
                            this.txtCodigo.Text.Trim().ToUpper(),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim(),
                            this.txtBusqueda.Text.Trim().ToLower(),
                            saveimagen,
                            this.DeterminarActivo(chkActiva),
                            Convert.ToInt32(this.cmbUnidad.SelectedValue),
                            Convert.ToInt32(this.txtCodigoCategoria.Text)
                            );
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
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    //preparamos para nuevos datos
                    this.EsNuevo = false;
                    this.EsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //BOTON editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIDProducto.Text.Equals(string.Empty))
            {
                this.EsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Seleccionar primero el registro que desea modificar.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.EsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.errorIcono.Clear();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Text = this.CrearTextoBusqueda();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Text = this.CrearTextoBusqueda();
        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {
            this.txtBusqueda.Text = this.CrearTextoBusqueda();
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            this.txtIDProducto.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["idproducto"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["codigo_producto"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["nombre_producto"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["descripcion_producto"].Value);
            this.txtBusqueda.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["busqueda_producto"].Value);
            if (Convert.ToInt32(this.dgvProducto.CurrentRow.Cells["activo_producto"].Value) == 1)
            {
                chkActiva.Checked = true;
            }
            else {
                chkActiva.Checked = false;
            }

            this.txtCodigoCategoria.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["IDcategoria"].Value);
            this.txtNombreCategoria.Text = Convert.ToString(this.dgvProducto.CurrentRow.Cells["Categoria"].Value);

            byte[] imagenBuffer = (byte[])this.dgvProducto.CurrentRow.Cells["imagen_producto"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);

            this.pxImagen.Image = Image.FromStream(ms);
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.cmbUnidad.SelectedValue = Convert.ToString(this.dgvProducto.CurrentRow.Cells["IDunidad"].Value);

            this.tabControl1.SelectedIndex = 1;
            this.btnEditar.Enabled = true;
        }

        //Checkbox Eliminar
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvProducto.Columns[0].Visible = true;
            }
            else
            {
                this.dgvProducto.Columns[0].Visible = false;
            }
        }

        //Checkbox Habilitar Celda de GRIlla ELIMNAR
        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducto.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvProducto.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //BOTON eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Id;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvProducto.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProducto.Eliminar(Convert.ToInt32(Id));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó correctamente el registro.");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.MostrarDatos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmVistaCategoria form = new frmVistaCategoria();
            form.ShowDialog();
        }

        private void frmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmInformeProductos frm = new frmInformeProductos();
            frm.ShowDialog();
        }

        

    }
}
