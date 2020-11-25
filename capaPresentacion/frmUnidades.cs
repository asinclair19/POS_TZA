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
    public partial class frmUnidades : Form
    {
        private bool EsNuevo = false;

        private bool EsEditar = false;

        public frmUnidades()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese el nombre de unidad.");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese un contacto de unidad.");
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
            this.txtDescripcion.Text = string.Empty;
        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;

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
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            this.dgvUnidad.Columns[0].Visible = false;
            this.dgvUnidad.Columns[1].Visible = false;
            this.dgvUnidad.Columns[2].Visible = true;
            this.dgvUnidad.Columns[3].Visible = true;
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos()
        {
            this.dgvUnidad.DataSource = NUnidad.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvUnidad.Rows.Count);
        }

        //Buscar columnas en DATAGRID
        private void BuscarNombre(string textoAbuscar)
        {
            this.dgvUnidad.DataSource = NUnidad.Buscar(textoAbuscar);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvUnidad.Rows.Count);
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

        //BOTON nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.LimpiarControles();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        //metodo guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombre, "Ingrese un nombre");
                    errorIcono.SetError(this.txtDescripcion, "Ingrese una descripcion");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NUnidad.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper());
                    }
                    else
                    {
                        //id,nombre,descripcion,imagen,activa
                        rpta = NUnidad.Editar(Convert.ToInt32(this.txtCodigo.Text),
                            this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim().ToUpper());
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
        private void dgvUnidad_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvUnidad.CurrentRow.Cells["idunidad"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvUnidad.CurrentRow.Cells["nombre_unidad"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvUnidad.CurrentRow.Cells["descripcion_unidad"].Value);

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
                this.dgvUnidad.Columns[0].Visible = true;
            }
            else
            {
                this.dgvUnidad.Columns[0].Visible = false;
            }
        }

        //Checkbox Habilitar Celda de GRIlla ELIMNAR
        private void dgvUnidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUnidad.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvUnidad.Rows[e.RowIndex].Cells["Eliminar"];
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

                    foreach (DataGridViewRow row in dgvUnidad.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NUnidad.Eliminar(Convert.ToInt32(Codigo));

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

        //inicio de formulario
        private void frmUnidades_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
        }
    }
}
