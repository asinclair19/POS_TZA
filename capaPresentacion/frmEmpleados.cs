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
    public partial class frmEmpleados : Form
    {
        private bool EsNuevo = false;

        private bool EsEditar = false;

        public frmEmpleados()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtIdentidad, "Ingrese un número de identidad.");
            this.ttMensaje.SetToolTip(this.txtNombre, "Ingrese un nombre.");
            this.ttMensaje.SetToolTip(this.txtApellido, "Ingrese un apellido.");
            this.ttMensaje.SetToolTip(this.txtCelular, "Ingrese un numero de celular.");
            this.ttMensaje.SetToolTip(this.txtSalario, "Ingrese un salario.");
            this.ttMensaje.SetToolTip(this.txtCargo, "Ingrese cargo que desempeña.");
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese un nombre de usuario.");
            this.ttMensaje.SetToolTip(this.txtPassword, "Ingrese una contraseña.");
        }

        private void controlarChk(bool valor)
        {
            chkConfig.Checked = valor;
            chkInventario.Checked = valor;
            chkCompras.Checked = valor;
            chkEmpleados.Checked = valor;
            chkPlanilla.Checked = valor;
            chkVentas.Checked = valor;
            chkReportes.Checked = valor;
        }

        private void habilitarChk(bool valor)
        {
            chkConfig.Enabled = valor;
            chkInventario.Enabled = valor;
            chkCompras.Enabled = valor;
            chkEmpleados.Enabled = valor;
            chkPlanilla.Enabled = valor;
            chkVentas.Enabled = valor;
            chkReportes.Enabled = valor;
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
            this.txtIdempleado.Clear();
            this.txtIdentidad.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtAnioNacimiento.Clear();
            this.txtCelular.Text = "504";
            this.chkActivo.Checked = true;
            this.txtSalario.Text = "1500000";
            this.txtCargo.Clear();
            this.txtUsuario.Clear();
            this.txtPassword.Clear();
            this.txtPermisos.Clear();
            this.chkPassvisible.Checked = false;
            this.controlarChk(false);
            this.habilitarChk(false);

        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtIdempleado.ReadOnly = !valor;
            this.txtIdentidad.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtAnioNacimiento.ReadOnly = !valor;
            this.txtCelular.ReadOnly = !valor;
            this.chkActivo.Enabled = valor;
            this.txtSalario.ReadOnly = !valor;
            this.txtCargo.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtPassword.ReadOnly = !valor;
            this.txtPermisos.ReadOnly = !valor;
            this.chkPassvisible.Enabled = valor;

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
                if (this.EsEditar)
                {
                    this.btnModificarPermisos.Enabled = true;
                }
                else {
                    this.btnModificarPermisos.Enabled = false;
                }
                
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnModificarPermisos.Enabled = false;
            }
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

        //BOTON nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.EsEditar = false;
            this.Botones();
            this.LimpiarControles();
            this.Habilitar(true);
            this.habilitarChk(true);
            this.txtIdentidad.Focus();
        }

        //determinar activo
        private int determinarActivo(CheckBox chk)
        {
            int valor = 0;
            if (chk.Checked == true)
            {
                valor = 1;
            }else{
                valor = 0;
            }
            return valor;
        }

        //metodo guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtIdentidad.Text == string.Empty || 
                    this.txtNombre.Text == string.Empty ||
                    this.txtApellido.Text == string.Empty ||
                    this.txtAnioNacimiento.Text == string.Empty ||
                    this.txtCelular.Text == string.Empty ||
                    this.txtSalario.Text == string.Empty ||
                    this.txtCargo.Text == string.Empty ||
                    this.txtUsuario.Text == string.Empty ||
                    this.txtPassword.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    this.errorIcono.SetError(this.txtIdentidad, "Ingrese un número de identidad.");
                    this.errorIcono.SetError(this.txtNombre, "Ingrese un nombre.");
                    this.errorIcono.SetError(this.txtApellido, "Ingrese un apellido.");
                    this.errorIcono.SetError(this.txtCelular, "Ingrese un numero de celular.");
                    this.errorIcono.SetError(this.txtSalario, "Ingrese un salario.");
                    this.errorIcono.SetError(this.txtCargo, "Ingrese cargo que desempeña.");
                    this.errorIcono.SetError(this.txtUsuario, "Ingrese un nombre de usuario.");
                    this.errorIcono.SetError(this.txtPassword, "Ingrese una contraseña.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NEmpleado.Insertar(
                            this.txtIdentidad.Text.Trim(),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.txtAnioNacimiento.Text.Trim()),
                            this.txtCelular.Text.Trim(),
                            Convert.ToDouble(this.txtSalario.Text),
                            this.txtCargo.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.determinarActivo(chkActivo)),
                            this.txtUsuario.Text.Trim(),
                            this.txtPassword.Text.Trim(),
                            this.txtPermisos.Text.Trim()
                            );
                    }
                    else
                    {
                        //id,nombre,descripcion,imagen,activa
                        rpta = NEmpleado.Editar(
                            Convert.ToInt32(this.txtIdempleado.Text.Trim()),
                            this.txtIdentidad.Text.Trim(),
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.txtAnioNacimiento.Text.Trim()),
                            this.txtCelular.Text.Trim(),
                            Convert.ToDouble(this.txtSalario.Text),
                            this.txtCargo.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.determinarActivo(chkActivo)),
                            this.txtUsuario.Text.Trim(),
                            this.txtPassword.Text.Trim(),
                            this.txtPermisos.Text.Trim()
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
        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            int activo = 0;
            this.txtIdempleado.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["idempleado"].Value);
            this.txtIdentidad.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["identidad"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["primer_nombre"].Value);
            this.txtApellido.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["primer_apellido"].Value);
            this.txtAnioNacimiento.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["nacimiento"].Value);
            this.txtCelular.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["celular"].Value);
            this.txtSalario.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["salario_base"].Value);
            this.txtCargo.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["cargo_empleado"].Value);
            this.txtUsuario.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["username"].Value);
            this.txtPassword.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["password_user"].Value);
            this.habilitarChk(false); //deshabilita los checkbox
            this.btnModificarPermisos.Enabled = true; //habilita el boton para modificar permisos
            this.txtPermisos.Text = Convert.ToString(this.dgvEmpleado.CurrentRow.Cells["privilegios_user"].Value);
            activo = Convert.ToInt32(this.dgvEmpleado.CurrentRow.Cells["activo_empleado"].Value);
            if (activo == 1)
            {
                this.chkActivo.Checked = true;
            }else{
                this.chkActivo.Checked = false;
            }
            this.tabControl1.SelectedIndex = 1;
        }

        private void chkPassvisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPassvisible.Checked == true)
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }else{
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }

        //BOTON editar datos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdempleado.Text.Equals(string.Empty))
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
                this.dgvEmpleado.Columns[0].Visible = true;
            }
            else
            {
                this.dgvEmpleado.Columns[0].Visible = false;
            }
        }

        //Checkbox Habilitar Celda de GRIlla ELIMNAR
        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmpleado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvEmpleado.Rows[e.RowIndex].Cells["Eliminar"];
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

                    foreach (DataGridViewRow row in dgvEmpleado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Rpta = NEmpleado.Eliminar(Convert.ToInt32(Codigo));

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

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.habilitarChk(false);
            this.controlarChk(false);
            this.Botones();
        }

        private string retornaCadenaPermisos()
        {
            //cadena: config-inventario-compras-empleados-planilla-ventas-reportes-
            string cadena = "";

            if (this.chkConfig.Checked == true)
            {
                cadena += "config-";
            }
            if (this.chkInventario.Checked == true)
            {
                cadena += "inventario-";
            }
            if (this.chkCompras.Checked == true) {
                cadena += "compras-";
            }
            if (this.chkEmpleados.Checked == true)
            {
                cadena += "empleados-";
            }
            if (this.chkPlanilla.Checked == true)
            {
                cadena += "planilla-";
            }
            if (this.chkVentas.Checked == true)
            {
                cadena += "ventas-";
            }
            if (this.chkReportes.Checked == true)
            {
                cadena += "reportes-";
            }
            return cadena;
        }

        private void chkConfig_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkInventario_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkCompras_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkPlanilla_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkVentas_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void chkReportes_CheckedChanged(object sender, EventArgs e)
        {
            this.txtPermisos.Text = this.retornaCadenaPermisos();
        }

        private void btnModificarPermisos_Click(object sender, EventArgs e)
        {
            this.habilitarChk(true);
        }


    }
}
