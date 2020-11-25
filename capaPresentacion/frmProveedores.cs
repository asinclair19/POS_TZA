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
    public partial class frmProveedores : Form
    {
        private bool EsNuevo = false;

        private bool EsEditar = false;

        public frmProveedores()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre del proveedor.");
            this.ttMensaje.SetToolTip(this.txtContacto, "Ingrese un contacto del proveedor.");
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
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
        private void LimpiarControles()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtContacto.Text = string.Empty;
            this.chkActivo.Checked = false;
            this.chkActivo.CheckState = CheckState.Unchecked;

        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtContacto.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;

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
            else
            {
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
            this.dgvProveedor.Columns[0].Visible = false;
            this.dgvProveedor.Columns[1].Visible = false;
            this.dgvProveedor.Columns[4].Visible = false;
            this.dgvProveedor.Columns[5].Visible = false;
            this.dgvProveedor.Columns[6].Visible = false;
            this.dgvProveedor.Columns[7].Visible = false;
            this.dgvProveedor.Columns[8].Visible = false;
            this.dgvProveedor.Columns[9].Visible = false;
            this.dgvProveedor.Columns[10].Visible = false;
            this.dgvProveedor.Columns[11].Visible = false;
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

        //BOTON nuevo click
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.LimpiarControles();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        //metodo determinar activo
        private int CheckearActivo(CheckBox check)
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

        //metodo guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtContacto.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombre, "Ingrese un nombre");
                    errorIcono.SetError(this.txtContacto, "Ingrese un contacto");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NProveedor.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtContacto.Text.Trim().ToUpper(), Convert.ToInt32(this.CheckearActivo(chkActivo)));
                    }
                    else
                    {
                        //id,nombre,descripcion,imagen,activa
                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtCodigo.Text),
                            this.txtNombre.Text.Trim().ToUpper(), this.txtContacto.Text.Trim().ToUpper(), Convert.ToInt32(this.CheckearActivo(chkActivo)));
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
        private void dgvProveedor_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["idproveedor"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["nombre_empresa"].Value);
            this.txtContacto.Text = Convert.ToString(this.dgvProveedor.CurrentRow.Cells["nombre_contacto"].Value);

            if (Convert.ToInt32(this.dgvProveedor.CurrentRow.Cells["activo_proveedor"].Value) == 1)
            {
                this.chkActivo.Checked = true;
            }
            else
            {
                this.chkActivo.Checked = false;
            }

            this.tabControl1.SelectedIndex = 1;
        }

        //BOTON editar datos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtCodigo.Text.Equals(string.Empty))
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
                this.dgvProveedor.Columns[0].Visible = true;
            }
            else
            {
                this.dgvProveedor.Columns[0].Visible = false;
            }
        }


        //Checkbox Habilitar Celda de GRIlla ELIMNAR
        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProveedor.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvProveedor.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        //BOTON eliminar CLICK
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar los registros?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvProveedor.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NProveedor.Eliminar(Convert.ToInt32(Codigo));

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
    
    }
}
