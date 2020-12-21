using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using WL;

using capaNegocio;

namespace capaPresentacion
{
    public partial class frmVentas : Form
    {
        private bool EsNuevo;
        public int idEmpleado = 1;
        private DataTable dtDetalle;
        private DataRow drConfig = NConfig.Obtener().Rows[0];
        //Tickets ticket1 = new Tickets();

        private decimal totalPagado = 0;
        private decimal ISVTotal = 0;
        private decimal GranTotal = 0;

        private static frmVentas _Instancia;

        public static frmVentas GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmVentas();
            }

            return _Instancia;
        }

        public void setCliente(string idcliente, string nombrecliente)
        {
            this.txtIdCliente.Text = idcliente;
            this.txtNombreCliente.Text = nombrecliente;
        }

        public void setProducto(string id, string nombre, int stock, decimal precio_venta, decimal precio_compra, DateTime fechav)
        {
            this.txtNombreProducto.Text = nombre;
            this.txtIdDetalle.Text = id;
            this.txtStockActual.Text = Convert.ToString(stock);
            this.txtPrecioVenta.Value = precio_venta;
            this.txtPrecioCompra.Value = precio_compra;
            this.dtpVencimiento.Value = fechav;
            this.txtCantidad.Value = 1;
            this.maskedDescuento.Text = Convert.ToInt32((Convert.ToDecimal(drConfig["default_porc_descuento"]) * 100)).ToString();
        }

        public frmVentas()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.dtpFechaVenta, "Ingrese fecha de venta.");
            this.ttMensaje.SetToolTip(this.cmbComprobante, "Seleccione tipo de comprobante.");
            this.ttMensaje.SetToolTip(this.txtNombreCliente, "Seleccione cliente registrado.");
            this.ttMensaje.SetToolTip(this.txtNumComprobante, "Ingrese número de comprobante.");
            this.ttMensaje.SetToolTip(this.txtIsv, "Ingrese impuesto sobre venta (ISV).");
            this.ttMensaje.SetToolTip(this.txtNombreProducto, "Ingrese/Seleccione producto registrado.");
            this.ttMensaje.SetToolTip(this.btnCargarProducto, "Ingrese/Seleccione producto registrado.");
            this.ttMensaje.SetToolTip(this.txtCantidad, "Ingrese cantidad a vender.");
            this.ttMensaje.SetToolTip(this.txtDescuento, "Ingrese porcentaje de descuento.");
            this.ttMensaje.SetToolTip(this.maskedDescuento, "Ingrese porcentaje de descuento.");
            this.Top = 0;
            this.Left = 0;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        //ultima factura
        private string ultima_factura(int factura)
        {
            int num_factura = factura + 1;
            int length_factura = num_factura.ToString().Length;
            string ceros = "";
            //code

            for (int i = 0; i < (8 - length_factura); i++)
            {
                ceros += "0";
            }
                
            //end code
            return ceros + num_factura.ToString();
        }

        //INICIO DE FORMULARIO
        private void frmVentas_Load(object sender, EventArgs e)
        {
            this.MostrarDatos();
            this.Habilitar(false);
            this.Botones();
            this.CrearTabla();
            //this.Limpiar();
            //this.LimpiarDetalle();
            this.dtpFechaInicial.Focus();
        }

        private void frmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            frmVistaCliente_Venta vista = new frmVistaCliente_Venta();
            vista.ShowDialog();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            frmVistaProducto_Ventas vista = new frmVistaProducto_Ventas();
            vista.ShowDialog();
        }

        private void maskedDescuento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //decimal descuento = (Convert.ToDecimal(maskedDescuento.Text) * txtPrecioVenta.Value);
            //MessageBox.Show(descuento.ToString());
            //txtDescuento.Value = Convert.ToDecimal(txtPrecioVenta.Value - descuento);
        }

        public void CalcularDescuento()
        {
            decimal descuento = 0;
            if (this.maskedDescuento.Text != string.Empty)
            {
                descuento = Convert.ToDecimal(this.maskedDescuento.Text) / 100;
            }
            this.txtDescuento.Value = descuento * this.txtPrecioVenta.Value;
            //this.txtPrecioVenta.Value = txtPrecioVenta.Value - txtDescuento.Value;
        }

        private void maskedDescuento_TextChanged(object sender, EventArgs e)
        {
            this.CalcularDescuento();
        }

        private void txtStockActual_TextChanged(object sender, EventArgs e)
        {
            //if(this.txtStockActual.Text != string.Empty){
            //    txtCantidad.Maximum = Convert.ToInt32(txtStockActual.Text);
            //}
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            this.maskedDescuento.Text = "0";
        }

        //Mensaje de confirmacion
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, drConfig["titulo_sistema"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, drConfig["titulo_sistema"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txtIdVenta.Text = string.Empty;
            this.dtpFechaVenta.ResetText();
            this.cmbComprobante.SelectedIndex = 0;
            this.txtNombreCliente.Text = string.Empty;
            this.txtIdCliente.Text = string.Empty;
            // drConfig["punto_emision"].ToString(); //+ drConfig["establecimiento"].ToString() + drConfig["tipo_documento"].ToString();
            this.txtNumComprobante.Text = drConfig["punto_emision"].ToString() + drConfig["establecimiento"].ToString() + drConfig["tipo_documento"].ToString();
            this.txtNumFactura.Text = ultima_factura(NVenta.ObtenerUltimaFactura());
            this.txtIsv.Text = (Convert.ToDecimal(drConfig["default_isv"])*100).ToString();
            this.CrearTabla();
            this.txtTotalAPagar.Text = "0.00";
            this.txtISVTotal.Text = "0.00";
            this.txtGranTotal.Text = "0.00";
            //this.groupVenta.Enabled = true;
        }

        //limpiar detalle de ingreso
        private void LimpiarDetalle()
        {
            this.txtIdDetalle.Text = string.Empty;
            this.dtpVencimiento.ResetText();
            this.txtNombreProducto.Text = string.Empty;
            this.txtCantidad.Text = "0";
            this.txtStockActual.Text = string.Empty;
            this.txtPrecioCompra.Text = "0.00";
            this.txtPrecioVenta.Text = "0.00";
            this.txtDescuento.Text = "0.00";
            this.maskedDescuento.Text = string.Empty;
            this.groupProducto.Enabled = true;
        }

        //habilitar cajas de texto
        private void Habilitar(bool valor)
        {
            //venta
            this.txtIdVenta.ReadOnly = true;
            this.dtpFechaVenta.Enabled = valor;
            this.cmbComprobante.Enabled = valor;
            this.txtNombreCliente.ReadOnly = true;
            this.txtIdCliente.ReadOnly = true;
            this.txtNumComprobante.ReadOnly = true;
            this.txtNumFactura.ReadOnly = true;
            this.txtIsv.Enabled = valor;
            //detalle
            this.txtIdDetalle.ReadOnly = true;
            this.txtNombreProducto.ReadOnly = true;
            this.txtCantidad.Enabled = valor;
            this.txtPrecioCompra.Enabled = false;
            this.txtPrecioVenta.Enabled = false;
            this.dtpVencimiento.Enabled = valor;
            this.txtDescuento.Enabled = false;
            this.maskedDescuento.ReadOnly = !valor;
            this.txtTotalAPagar.Enabled = false;
            this.txtISVTotal.Enabled = false;
            this.txtGranTotal.Enabled = false;
            //botones
            this.btnCargarCliente.Enabled = valor;
            this.btnCargarProducto.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.btnQuitar.Enabled = valor;
        }

        //habilitar botones ES NUEVO / ES EDITAR
        private void Botones()
        {
            if (this.EsNuevo == true)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                //this.btnRecibo.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                //this.btnRecibo.Enabled = false;
            }
        }

        //ocultar columnas en DATAGIRD
        private void OcultarColumnas()
        {
            if (this.dgvVentas.RowCount != 0)
            {
                this.dgvVentas.Columns[0].Visible = false; //chkEliminar
                this.dgvVentas.Columns[1].Visible = false; //idventa
            }

        }

        //MostrarDatos columnas en DATAGRID
        private void MostrarDatos() //en GRIDVIEW
        {
            this.dgvVentas.DataSource = NVenta.Mostrar();
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvVentas.Rows.Count);
        }

        //Buscar por fechas columnas en DATAGRID
        private void BuscarFechas()
        {
            string textobuscar = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string textobuscar2 = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(textobuscar + "final: " + textobuscar2);
            //codigo buscar
            this.dgvVentas.DataSource = NVenta.BuscarFechas(textobuscar, textobuscar2);
            this.OcultarColumnas();
            this.lblNumElementos.Text = "Elementos: " + Convert.ToString(this.dgvVentas.Rows.Count);
        }

        private void MostrarDetalle()
        {
            this.dgvDetallesVenta.DataSource = NVenta.MostrarDetalle(Convert.ToInt32(this.txtIdVenta.Text.Trim()));
        }

        private void CrearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("iddetalleingreso", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("nombre_producto", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));
            //a data grid
            this.dgvDetallesVenta.DataSource = this.dtDetalle;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea Eliminar los registros?", "Sistema POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    string Id;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Rpta = NVenta.Eliminar(Convert.ToInt32(Id));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Eliminó correctamente el Ingreso.");
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dgvVentas.Columns[0].Visible = true;
            }
            else
            {
                this.dgvVentas.Columns[0].Visible = false;
            }
        }

        private void dgvVentas_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdVenta.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["idventa"].Value);
            this.dtpFechaVenta.Value = Convert.ToDateTime(this.dgvVentas.CurrentRow.Cells["fecha_venta"].Value);
            this.cmbComprobante.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtNombreCliente.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["nombre_cliente"].Value);
            this.txtNumComprobante.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["num_comprobante"].Value);
            this.txtNumFactura.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["num_factura"].Value);
            this.txtIsv.Text = Convert.ToString(this.dgvVentas.CurrentRow.Cells["porc_isv"].Value);
            this.txtTotalAPagar.Text = Convert.ToDecimal(this.dgvVentas.CurrentRow.Cells["subtotalventa"].Value).ToString("#0.00#");
            this.txtISVTotal.Text = Convert.ToDecimal(this.dgvVentas.CurrentRow.Cells["isv"].Value).ToString("#0.00#");
            this.txtGranTotal.Text = Convert.ToDecimal(this.dgvVentas.CurrentRow.Cells["total"].Value).ToString("#0.00#");
            this.MostrarDetalle();
            //this.groupVenta.Enabled = false;
            this.tabControl1.SelectedIndex = 1;
            this.LimpiarDetalle();
            this.groupProducto.Enabled = false;
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvVentas.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkAnular = (DataGridViewCheckBoxCell)dgvVentas.Rows[e.RowIndex].Cells["Eliminar"];
                ChkAnular.Value = !Convert.ToBoolean(ChkAnular.Value);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(true);
            this.txtNumComprobante.Focus();
        }

        private void mostrarVentanaEfectivo()
        {
            frmEfectivo_Venta vista = new frmEfectivo_Venta();
            vista.TotalAPagar = txtGranTotal.Value;
            vista.ShowDialog();
        }

        private void GuardarVenta()
        {
            //insertar datos
            try
            {
                string rpta = "";
                if (this.txtIdCliente.Text == string.Empty
                    || this.txtNumComprobante.Text == string.Empty
                    || this.txtNumFactura.Text == string.Empty
                    || this.txtIsv.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombreCliente, "Seleccione cliente.");
                    errorIcono.SetError(this.txtNumComprobante, "Ingrese número de comprobante.");
                    errorIcono.SetError(this.txtNumFactura, "Ingrese número de factura.");
                    errorIcono.SetError(this.txtIsv, "Ingrese ISV.");
                }
                else
                {

                    if (this.EsNuevo)
                    {
                        //nombre,descripcion,imagen,activa
                        //this.mostrarVentanaEfectivo();
                        rpta = NVenta.Insertar(
                            Convert.ToDateTime(dtpFechaVenta.Value),
                            cmbComprobante.Text,
                            txtNumComprobante.Text,
                            txtNumFactura.Text,
                            Convert.ToString(txtIsv.Value),
                            txtTotalAPagar.Value,
                            txtISVTotal.Value,
                            txtGranTotal.Value,
                            Convert.ToInt32(txtIdCliente.Text),
                            this.idEmpleado,
                            dtDetalle
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.EsNuevo)
                        {
                            this.MensajeOK("La venta se guardo con éxito.");
                            this.mostrarReciboVenta(NVenta.MostrarUltimaVenta());
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
                    totalPagado = 0;
                    ISVTotal = 0;
                    GranTotal = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.dgvDetallesVenta.RowCount == 0)
            {
                MensajeError("No hay productos agregados a la venta.");
            }
            else {
                this.mostrarVentanaEfectivo(); //INGRESAR EFECTIVO DE CLIENTE
                if(NVenta.Listosave){ //VERIFICA SI PUEDE GUARDAR LA VENTA
                    this.GuardarVenta();
                }
                
            }
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

        private decimal calcularTotalISV(decimal porcentaje_isv, decimal subtotal)
        {
            decimal resultado = (porcentaje_isv / 100) * subtotal;

            return resultado;
        }

        private decimal calcularGranTotalaPagar(decimal subtotal, decimal isv_cantidad)
        {
            decimal resultado = subtotal + isv_cantidad;

            return resultado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool producto_duplicado = false;
            foreach (DataRow row in dtDetalle.Rows)
            {
                if (Convert.ToString(row["nombre_producto"]) == Convert.ToString(this.txtNombreProducto.Text.Trim()))
                {
                    producto_duplicado = true;
                }
            }
            try
            {
                //MensajeError("");
                if (this.txtIdDetalle.Text == string.Empty
                    || this.txtCantidad.Value == 0)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    errorIcono.SetError(this.txtNombreProducto, "Seleccione/Busque producto.");
                    errorIcono.SetError(this.txtCantidad, "Ingrese un valor.");
                }
                else
                {
                    if (producto_duplicado != true)
                    {
                        if (Convert.ToInt32(txtCantidad.Value) <= Convert.ToInt32(txtStockActual.Text))
                        {
                            decimal descuentoTotal = txtDescuento.Value * txtCantidad.Value;
                            decimal subTotal = (Convert.ToDecimal(this.txtCantidad.Text) * (Convert.ToDecimal(this.txtPrecioVenta.Text))) - descuentoTotal;
                            totalPagado = totalPagado + subTotal;
                            ISVTotal = calcularTotalISV(txtIsv.Value, totalPagado);
                            GranTotal = calcularGranTotalaPagar(totalPagado, ISVTotal);
                            DataRow row = this.dtDetalle.NewRow();
                            row["iddetalleingreso"] = Convert.ToInt32(this.txtIdDetalle.Text);
                            row["nombre_producto"] = this.txtNombreProducto.Text;
                            row["cantidad"] = Convert.ToInt32(this.txtCantidad.Text);
                            row["precio_venta"] = Convert.ToDecimal(this.txtPrecioVenta.Text);
                            row["descuento"] = descuentoTotal;
                            row["Subtotal"] = subTotal;
                            this.dtDetalle.Rows.Add(row);
                            this.txtTotalAPagar.Text = totalPagado.ToString("#0.00#");
                            this.txtISVTotal.Text = ISVTotal.ToString("#0.00#");
                            this.txtGranTotal.Text = GranTotal.ToString("#0.00#");
                            this.LimpiarDetalle();
                        }
                        else
                        {
                            MensajeError("No hay stock suficiente.");
                        }
                    }
                    else {
                        MensajeError("El producto que desea agregar ya esta en lista de venta!");
                    }
                     //final else hijo
                } //final else padre   
            }
            catch (Exception ex)
            {
                string valor = ex.ToString();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetallesVenta.RowCount != 0) { 
                try
                {
                    int indiceFila = this.dgvDetallesVenta.CurrentCell.RowIndex;
                    DataRow row = this.dtDetalle.Rows[indiceFila];
                    this.totalPagado = this.totalPagado - Convert.ToDecimal(row["Subtotal"].ToString());
                    this.txtTotalAPagar.Text = totalPagado.ToString("#0.00#");
                    decimal interes = txtIsv.Value / 100;
                    this.txtISVTotal.Text = calcularTotalISV(interes, txtTotalAPagar.Value).ToString("#0.00#");
                    this.txtGranTotal.Text = calcularGranTotalaPagar(txtTotalAPagar.Value, txtISVTotal.Value).ToString("#0.00#");
                    this.dtDetalle.Rows.Remove(row);
                }
                catch (Exception)
                {
                    MensajeError("No hay fila para remover.");
                    throw;
                }
            }
        }

        private void groupVenta_Enter(object sender, EventArgs e)
        {

        }

        private void txtISVTotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalAPagar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtGranTotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dgvDetallesVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtIsv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            frmInformeFactura frm = new frmInformeFactura();
            frm.Idventa = Convert.ToInt32(this.dgvVentas.CurrentRow.Cells["idventa"].Value);
            frm.ShowDialog();
        }

        private void mostrarReciboVenta(int idventa)
        {
            frmReciboVenta frm = new frmReciboVenta();
            frm.Idventa = idventa;
            frm.ShowDialog();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if(this.txtIdVenta.Text != string.Empty){
                this.mostrarReciboVenta(Convert.ToInt32(txtIdVenta.Text));
            }else{
                MensajeError("¡No hay venta que mostrar!.");
            }

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string textobuscar = dtpFechaInicial.Value.ToString("yyyy-MM-dd");
            string textobuscar2 = dtpFechaFinal.Value.ToString("yyyy-MM-dd");
            frmReporteVentasByFechas frm = new frmReporteVentasByFechas();
            frm.Fechainicial = textobuscar;
            frm.Fechafinal = textobuscar2;
            frm.ShowDialog();
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
        //fin de metodo

    //Final de clase
    }
}
