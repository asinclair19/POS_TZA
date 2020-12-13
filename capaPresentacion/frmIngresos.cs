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
    public partial class frmIngresos : Form
    {
        public int idempleado;
        private bool EsNuevo;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static frmIngresos _Instancia;

        public static frmIngresos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmIngresos();
            }

            return _Instancia;
        }

        public void setProveedor(string idproveedor, string nombreproveedor)
        {
            this.txtIdProveedor.Text = idproveedor;
            this.txtNombreProveedor.Text = nombreproveedor;
        }

        public void setProducto(string idproducto, string nombreproducto)
        {
            this.txtNombreProducto.Text = nombreproducto;
            this.txtIdProducto.Text = idproducto;
        }

        public frmIngresos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.cmbComprobante, "Seleccione el tipo de comprobante.");
            this.ttMensaje.SetToolTip(this.txtNombreProveedor, "Seleccione el proveedor.");
            this.ttMensaje.SetToolTip(this.txtNumComprobante, "Ingrese el número de comprobante de compra.");
            this.ttMensaje.SetToolTip(this.txtIsv, "Ingrese el % de impuesto sobre la renta (ISV).");
            this.ttMensaje.SetToolTip(this.txtNombreProducto, "Seleccione el producto.");
            this.ttMensaje.SetToolTip(this.txtPrecioCompra, "Ingrese el precio compra del producto.");
            this.ttMensaje.SetToolTip(this.txtPrecioVenta, "Ingrese el precio venta del producto.");
            this.ttMensaje.SetToolTip(this.dtpFechaIngreso, "Seleccione la fecha de ingreso.");
            this.ttMensaje.SetToolTip(this.dtpFechaProduccion, "Seleccione la fecha de producción del producto.");
            this.ttMensaje.SetToolTip(this.dtpFechaVencimiento, "Seleccione la fecha de vencimiento del producto.");
            this.txtIdProducto.Enabled = false;
            this.txtIdProveedor.Enabled = false;
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProveedor.ReadOnly = true;
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
            this.txtCodigo.Text = string.Empty;
            this.cmbComprobante.SelectedIndex = 0;
            this.txtNumComprobante.Text = string.Empty;
            this.txtIdProveedor.Text = string.Empty;
            this.txtNombreProveedor.Text = string.Empty;
            this.txtIsv.Text = string.Empty;
            this.txtIsv.Text = "15";
            this.CrearTabla();
            this.lblTotalPagado.Text = "000000.00";
        }

        //limpiar detalle de ingreso
        private void LimpiarDetalle()
        {
            this.txtNombreProducto.Text = string.Empty;
            this.txtIdProducto.Text = string.Empty;
            this.txtStockInicial.Text = string.Empty;
            this.txtPrecioCompra.Text = string.Empty;
            this.txtPrecioVenta.Text = string.Empty;
        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.dtpFechaIngreso.Enabled = valor;
            this.cmbComprobante.Enabled = valor;
            this.txtNumComprobante.ReadOnly = !valor;
            this.txtIdProveedor.ReadOnly = !valor;
            this.txtNombreProveedor.ReadOnly = !valor;
            this.txtIsv.ReadOnly = !valor;
            //detalle
            this.txtNombreProducto.ReadOnly = !valor;
            this.txtIdProducto.ReadOnly = !valor;
            this.txtStockInicial.ReadOnly = !valor;
            this.txtPrecioCompra.ReadOnly = !valor;
            this.txtPrecioVenta.ReadOnly = !valor;
            this.dtpFechaProduccion.Enabled = valor;
            this.dtpFechaVencimiento.Enabled = valor;
            //botones
            this.btnCargarProducto.Enabled = valor;
            this.btnCargarProveedor.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnEliminar.Enabled = valor;
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
            if (this.dgvIngresos.RowCount != 0)
            {
                this.dgvIngresos.Columns[0].Visible = false; //chkAnular
                this.dgvIngresos.Columns[1].Visible = false; //idingreso
            }
            
        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos() //en GRIDVIEW
        {
            this.dgvIngresos.DataSource = NIngreso.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvIngresos.Rows.Count);
        }

        //Buscar por fechas columnas en DATAGRID
        private void BuscarFechas()
        {
            string textobuscar = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string textobuscar2 = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(textobuscar + "final: " + textobuscar2);
            //codigo buscar
            this.dgvIngresos.DataSource = NIngreso.BuscarFechas(textobuscar, textobuscar2);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvIngresos.Rows.Count);
        }

        private void MostrarDetalle()
        {
            this.dgvDetallesIngreso.DataSource = NIngreso.MostrarDetalle(Convert.ToInt32(this.txtCodigo.Text.Trim()));
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
            this.CrearTabla();
            this.dtpFechaInicial.Focus();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            frmVistaProducto_Ingresos vista = new frmVistaProducto_Ingresos();
            vista.ShowDialog();
        }

        private void btnCargarProveedor_Click(object sender, EventArgs e)
        {
            frmVistaProveedor_Ingresos vista = new frmVistaProveedor_Ingresos();
            vista.ShowDialog();
        }

        private void frmIngresos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
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

                    foreach (DataGridViewRow row in dgvIngresos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Rpta = NIngreso.Anular(Convert.ToInt32(Id));

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

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnular.Checked)
            {
                this.dgvIngresos.Columns[0].Visible = true;
            }
            else
            {
                this.dgvIngresos.Columns[0].Visible = false;
            }
        }

        private void dgvIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvIngresos.Columns["Anular"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgvIngresos.Rows[e.RowIndex].Cells["Anular"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void CrearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("IDproducto", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));
            //a data grid
            this.dgvDetallesIngreso.DataSource = this.dtDetalle;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(true);
            this.txtCodigo.ReadOnly = true;
            this.txtStockInicial.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(false);
            this.errorIcono.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtIdProveedor.Text == string.Empty
                    || this.txtNumComprobante.Text == string.Empty
                    || this.txtIsv.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombreProveedor, "Seleccione un proveedor.");
                    errorIcono.SetError(this.txtNumComprobante, "Ingrese un número de comprobante.");
                    errorIcono.SetError(this.txtIsv, "Ingrese ISV.");
                }
                else
                {

                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        rpta = NIngreso.Insertar(
                            this.dtpFechaIngreso.Value,
                            this.cmbComprobante.Text.Trim(),
                            this.txtNumComprobante.Text.Trim(),
                            Convert.ToDecimal(this.txtIsv.Text.Trim()),
                            totalPagado,
                            "EMITIDO",
                            Convert.ToInt32(this.txtIdProveedor.Text.Trim()),
                            this.idempleado,
                            dtDetalle
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("Se inserto de forma correcta el Ingreso.");
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
                    this.LimpiarDetalle();
                    this.MostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //MensajeError("");
                if (this.txtIdProducto.Text == string.Empty
                    || this.txtStockInicial.Text == string.Empty
                    || this.txtPrecioCompra.Text == string.Empty
                    || this.txtPrecioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombreProducto, "Ingrese un valor.");
                    errorIcono.SetError(this.txtStockInicial, "Ingrese un valor.");
                    errorIcono.SetError(this.txtPrecioCompra, "Ingrese un valor.");
                    errorIcono.SetError(this.txtPrecioVenta, "Ingrese un valor.");
                }
                else
                {

                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["IDproducto"]) == Convert.ToInt32(this.txtIdProducto.Text.Trim()))
                        {
                            registrar = false;
                            this.MensajeError("YA se encuentra el producto en el detalle.");
                        }
                    }
                    if (registrar == true)
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtStockInicial.Text.Trim()) * Convert.ToDecimal(this.txtPrecioCompra.Text.Trim());
                        totalPagado = totalPagado + subTotal;
                        this.lblTotalPagado.Text = totalPagado.ToString("#0.00#");
                        //
                        DataRow row = this.dtDetalle.NewRow();
                        row["IDproducto"] = Convert.ToInt32(this.txtIdProducto.Text);
                        row["Producto"] = this.txtNombreProducto.Text;
                        row["precio_compra"] = Convert.ToDecimal(this.txtPrecioCompra.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPrecioVenta.Text);
                        row["stock_inicial"] = Convert.ToInt32(this.txtStockInicial.Text);
                        row["fecha_produccion"] = dtpFechaProduccion.Value;
                        row["fecha_vencimiento"] = dtpFechaVencimiento.Value;
                        row["Subtotal"] = subTotal;

                        this.dtDetalle.Rows.Add(row);
                        this.LimpiarDetalle();
                    } //final if 
                }
            }catch (Exception ex) 
            {
                string valor = ex.ToString();
            }
        } //final void

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dgvDetallesIngreso.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["Subtotal"].ToString());
                this.lblTotalPagado.Text = totalPagado.ToString("#0.00#");
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception)
            {
                MensajeError("No hay fila para remover.");
                throw;
            }
        }

        private void dgvIngresos_DoubleClick(object sender, EventArgs e)
        {
            this.txtCodigo.Text = Convert.ToString(this.dgvIngresos.CurrentRow.Cells["idingreso"].Value);
            //MessageBox.Show(this.dgvIngresos.CurrentRow.Cells["fecha_ingreso"].Value.ToString());
            this.dtpFechaIngreso.Value = Convert.ToDateTime(this.dgvIngresos.CurrentRow.Cells["fecha_ingreso"].Value);
            this.cmbComprobante.Text = Convert.ToString(this.dgvIngresos.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtNombreProveedor.Text = Convert.ToString(this.dgvIngresos.CurrentRow.Cells["proveedor"].Value);
            this.txtNumComprobante.Text = Convert.ToString(this.dgvIngresos.CurrentRow.Cells["num_comprobante"].Value);
            this.txtIsv.Text = Convert.ToString(this.dgvIngresos.CurrentRow.Cells["isv_ingreso"].Value);
            this.lblTotalPagado.Text = Convert.ToDecimal(this.dgvIngresos.CurrentRow.Cells["total_ingreso"].Value).ToString("#0.00#");
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void soloNumeros(KeyPressEventArgs valor)
        { 
            if (Char.IsNumber(valor.KeyChar)) 
            {
                valor.Handled = false;
            }else if (Char.IsControl(valor.KeyChar))
            {
                valor.Handled = false;
            }else if (Char.IsSeparator(valor.KeyChar)){
                valor.Handled = true;
            }else
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
        
        private void txtStockInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumeros(e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.soloNumerosConDecimales(e);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string textobuscar = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string textobuscar2 = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
            frmReporteIngresosByFechas frm = new frmReporteIngresosByFechas();
            frm.Fechainicial = textobuscar;
            frm.Fechafinal = textobuscar2;
            frm.ShowDialog();
        }


    }
}