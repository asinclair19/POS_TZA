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
    public partial class frmPlanillas : Form
    {
        private bool EsNuevo;

        private static frmPlanillas _MiInstancia;

        public static frmPlanillas GetMiInstancia()
        {
            if (_MiInstancia == null)
            {
                _MiInstancia = new frmPlanillas();
            }

            return _MiInstancia;
        }

        //establecer empleado buscado
        public void setEmpleado(string idempleado, string identidad, string nombre, string salario, string cargo)
        {
            this.txtIdempleado.Text = idempleado;
            this.txtIdentidad.Text = identidad;
            this.txtNombre.Text = nombre;
            this.txtSalario.Text = salario;
            this.txtCargo.Text = cargo;
            //MessageBox.Show(idempleado + identidad + nombre + salario + cargo);
        }

        public frmPlanillas()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtIdentidad, "Ingrese número de identidad.");
            this.ttMensaje.SetToolTip(this.cmbTipoImporte, "Seleccione el tipo de importe.");
            this.ttMensaje.SetToolTip(this.txtSubtotal, "Subtotal en base a salario de empleado.");
            this.ttMensaje.SetToolTip(this.txtSeguroSocial, "Ingrese cantidad a deducir.");
            this.ttMensaje.SetToolTip(this.txtSubtotalNeto, "Subtotal Neto calculado.");
            this.ttMensaje.SetToolTip(this.txtISR, "Ingrese cantidad impuesto sobre la renta a deducir.");
            this.ttMensaje.SetToolTip(this.txtTotalPagar, "Total a pagar a empleado.");
            this.ttMensaje.SetToolTip(this.dtpFechaPago, "Seleccione fecha de pago.");
            this.ttMensaje.SetToolTip(this.txtConceptoDe, "Ingrese razón de pago.");
            this.ttMensaje.SetToolTip(this.cmbTipoPago, "Seleccione el tipo de pago.");
            this.ttMensaje.SetToolTip(this.txtNumComprobante, "Ingrese número de comprobante de pago.");
            this.ttMensaje.SetToolTip(this.txtDescripcion, "Ingrese descripción de pago a efectuar.");
            this.txtIdempleado.ReadOnly = !false;
            this.txtIdentidad.ReadOnly = !false;
            this.txtNombre.ReadOnly = !false;
            this.txtSalario.Enabled = false;
            this.txtCargo.ReadOnly = !false;
            this.cmbTipoImporte.SelectedIndex = 0;
            this.cmbTipoPago.SelectedIndex = 0;
        }

        //Mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtIdempleado.Text = string.Empty;
            this.txtIdentidad.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtSalario.Value = 0;
            this.txtCargo.Text = string.Empty;
            this.cmbTipoImporte.SelectedIndex = 0;
            this.txtSubtotal.Value = 0;
            this.txtSeguroSocial.Value = 0;
            this.txtSubtotalNeto.Value = 0;
            this.txtISR.Value = 0;
            this.txtTotalPagar.Value = 0;
            this.txtConceptoDe.Text = string.Empty;
            this.cmbTipoPago.SelectedIndex = 0;
            this.txtNumComprobante.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.cmbTipoImporte.Enabled = valor;
            this.txtSubtotal.Enabled = valor;
            this.txtSeguroSocial.Enabled = valor;
            //this.txtSubtotalNeto.Enabled = valor;
            this.txtISR.Enabled = valor;
            //this.txtTotalPagar.Enabled = valor;
            this.dtpFechaPago.Enabled = valor;
            this.txtConceptoDe.ReadOnly = !valor;
            this.cmbTipoPago.Enabled = valor;
            this.txtNumComprobante.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            //botones
            this.btnNuevo.Enabled = !valor;
            this.btnGuardar.Enabled = valor;
            this.btnCancelar.Enabled = valor;
            this.btnBuscarEmpleado.Enabled = valor;
        }

        //habilitar botones ES NUEVO / ES EDITAR
        private void Botones()
        {
            if (this.EsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            if (this.dgvPagos.RowCount != 0)
            {
                this.dgvPagos.Columns[0].Visible = false; //chkAnular
                this.dgvPagos.Columns[1].Visible = false; //idpago
            }

        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos() //en GRIDVIEW
        {
            this.dgvPagos.DataSource = NPago_planilla.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvPagos.Rows.Count);
        }

        //Buscar por fechas columnas en DATAGRID
        private void BuscarFechas()
        {
            string textobuscar = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string textobuscar2 = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(textobuscar + "final: " + textobuscar2);
            //codigo buscar
            this.dgvPagos.DataSource = NPago_planilla.BuscarFechas(textobuscar, textobuscar2);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvPagos.Rows.Count);
        }

        private void frmPlanillas_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
            this.dtpFechaInicial.Focus();
        }

        private void frmPlanillas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _MiInstancia = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgvPagos.Columns[0].Visible = true;
            }
            else
            {
                this.dgvPagos.Columns[0].Visible = false;
            }
        }

        private void dgvPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPagos.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgvPagos.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea Anular los registros?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Id;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvPagos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Rpta = NPago_planilla.Anular(Convert.ToInt32(Id));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Anuló correctamente el Ingreso.");
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            this.EsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            //this.txtSubtotal.ReadOnly = true;
            this.abrirBuscarEmpleado();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.errorIcono.Clear();
            //this.tabControl1.SelectedIndex = 0;
        }

        //guardar datos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                this.mostrarCalculos();
                if (this.txtIdempleado.Text == string.Empty
                    || this.txtSubtotal.Value == 0
                    || this.txtSubtotalNeto.Value == 0
                    || this.txtTotalPagar.Value == 0
                    || this.txtConceptoDe.Text == string.Empty
                    || this.txtNumComprobante.Text == string.Empty
                    || this.txtDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtIdempleado, "Seleccione un empleado en el combo.");
                    errorIcono.SetError(this.txtSubtotal, "Ingrese un valor.");
                    errorIcono.SetError(this.txtSubtotalNeto, "Ingrese un valor.");
                    errorIcono.SetError(this.txtTotalPagar, "Ingrese un valor.");
                    errorIcono.SetError(this.txtConceptoDe, "Ingrese un valor.");
                    errorIcono.SetError(this.txtNumComprobante, "Ingrese un valor.");
                    errorIcono.SetError(this.txtDescripcion, "Ingrese un valor.");
                }
                else
                {
                    if (this.EsNuevo)
                    {
                        rpta = NPago_planilla.Insertar(
                            this.dtpFechaPago.Value,
                            this.txtConceptoDe.Text.Trim().ToUpper(),
                            this.cmbTipoPago.Text,
                            this.txtNumComprobante.Text,
                            this.txtDescripcion.Text.Trim().ToUpper(),
                            this.cmbTipoImporte.Text,
                            Convert.ToDecimal(txtSubtotal.Value),
                            Convert.ToDecimal(txtSeguroSocial.Value),
                            Convert.ToDecimal(txtSubtotalNeto.Value),
                            Convert.ToDecimal(txtISR.Value),
                            Convert.ToDecimal(txtTotalPagar.Value),
                            "EMITIDO",
                            Convert.ToInt32(txtIdempleado.Text)
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("Se insertó de forma correcta el Ingreso.");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    //preparamos para nuevos datos
                    this.EsNuevo = false;
                    //this.EsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.MostrarDatos();
                    this.errorIcono.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void soloNumeros(KeyPressEventArgs valor)
        {
            if (Char.IsNumber(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsControl(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsSeparator(valor.KeyChar))
            {
                valor.Handled = true;
            }
            else
            {
                valor.Handled = true;
            }
        }

        private void soloNumerosConDecimales(KeyPressEventArgs valor)
        {
            if (Char.IsNumber(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsControl(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else if (Char.IsPunctuation(valor.KeyChar))
            {
                valor.Handled = false;
            }
            else
            {
                valor.Handled = true;
            }
        }

        //CALCULAR SUBTOTAL NETO
        private decimal retornaSubtotalNeto(decimal subtotal, decimal seguro)
        {
            return subtotal - seguro;
        }

        //CALCULAR TOTAL A PAGAR
        private decimal retornaTotalAPagar(decimal subtotal, decimal isr, decimal seguro)
        {
            return subtotal - seguro - isr;
        }

        private void dgvPagos_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdempleado.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["idempleado"].Value);
            this.txtIdentidad.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["identidad"].Value);
            this.txtNombre.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["empleado"].Value);
            this.txtSalario.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["salario_base"].Value);
            this.txtCargo.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["cargo_empleado"].Value);
            this.cmbTipoImporte.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["tipo_importe"].Value);
            //this.txtSubtotal.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["total_bruto"].Value);
            this.txtSeguroSocial.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["seguro_social"].Value);
            this.txtSubtotalNeto.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["total_neto"].Value);
            this.txtISR.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["impuesto_renta"].Value);
            this.txtTotalPagar.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["neto_a_pagar"].Value);
            //datos
            this.dtpFechaPago.Value= Convert.ToDateTime(this.dgvPagos.CurrentRow.Cells["fecha_pago"].Value);
            this.txtConceptoDe.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["concepto_de"].Value);
            this.cmbTipoPago.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["tipo_pago"].Value);
            this.txtNumComprobante.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["comp_transferencia"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dgvPagos.CurrentRow.Cells["descripcion_pago"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void txtSeguroSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void txtSubtotalNeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void txtISR_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void txtTotalPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void mostrarCalculos()
        {
            this.txtSubtotalNeto.Value = retornaSubtotalNeto(txtSubtotal.Value, txtSeguroSocial.Value);
            this.txtTotalPagar.Value = retornaTotalAPagar(txtSubtotal.Value, txtISR.Value, txtSeguroSocial.Value);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this.mostrarCalculos();
        }

        private void txtSubtotal_ValueChanged(object sender, EventArgs e)
        {
            this.mostrarCalculos();
        }

        private void txtSeguroSocial_ValueChanged(object sender, EventArgs e)
        {
            //this.mostrarCalculos();
        }
        
        private void txtISR_ValueChanged(object sender, EventArgs e)
        {
            //this.mostrarCalculos();
        }

        private void abrirBuscarEmpleado()
        {
            frmVistaEmpleado_Planilla vista = new frmVistaEmpleado_Planilla();
            vista.ShowDialog();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            this.abrirBuscarEmpleado();            
        }

        private void txtSalario_ValueChanged(object sender, EventArgs e)
        {
            this.txtSubtotal.Text = this.txtSalario.Text;
        }



        //final bloque principal
    }
}
