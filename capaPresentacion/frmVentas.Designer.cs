namespace capaPresentacion
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnComprobante = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblNumElementos = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_isv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupVenta = new System.Windows.Forms.GroupBox();
            this.grupoBotones = new System.Windows.Forms.GroupBox();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.txtTotalAPagar = new System.Windows.Forms.NumericUpDown();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtGranTotal = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtISVTotal = new System.Windows.Forms.NumericUpDown();
            this.txtIsv = new System.Windows.Forms.NumericUpDown();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.groupProducto = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedDescuento = new System.Windows.Forms.MaskedTextBox();
            this.txtDescuento = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumComprobante = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetallesVenta = new System.Windows.Forms.DataGridView();
            this.iddetalleingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupVenta.SuspendLayout();
            this.grupoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGranTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISVTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsv)).BeginInit();
            this.groupProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1141, 504);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnComprobante);
            this.tabPage1.Controls.Add(this.dtpFechaFinal);
            this.tabPage1.Controls.Add(this.lblFechaFinal);
            this.tabPage1.Controls.Add(this.dtpFechaInicial);
            this.tabPage1.Controls.Add(this.lblNumElementos);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.dgvVentas);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblFechaInicial);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1133, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnComprobante
            // 
            this.btnComprobante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobante.Image = global::capaPresentacion.Properties.Resources.print;
            this.btnComprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprobante.Location = new System.Drawing.Point(497, 26);
            this.btnComprobante.Name = "btnComprobante";
            this.btnComprobante.Size = new System.Drawing.Size(96, 23);
            this.btnComprobante.TabIndex = 11;
            this.btnComprobante.Text = "Comprobante";
            this.btnComprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprobante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComprobante.UseVisualStyleBackColor = true;
            this.btnComprobante.Click += new System.EventHandler(this.btnComprobante_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(81, 46);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(127, 26);
            this.dtpFechaFinal.TabIndex = 10;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(6, 46);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 9;
            this.lblFechaFinal.Text = "Fecha final:";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(81, 14);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(127, 26);
            this.dtpFechaInicial.TabIndex = 8;
            // 
            // lblNumElementos
            // 
            this.lblNumElementos.AutoSize = true;
            this.lblNumElementos.Location = new System.Drawing.Point(426, 90);
            this.lblNumElementos.Name = "lblNumElementos";
            this.lblNumElementos.Size = new System.Drawing.Size(65, 13);
            this.lblNumElementos.TabIndex = 7;
            this.lblNumElementos.Text = "# elementos";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(9, 89);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 6;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::capaPresentacion.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(416, 26);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::capaPresentacion.Properties.Resources.cancel;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(335, 26);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToOrderColumns = true;
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.idventa,
            this.fecha_venta,
            this.nombre_cliente,
            this.empleado,
            this.tipo_comprobante,
            this.num_comprobante,
            this.porc_isv,
            this.subtotalventa,
            this.isv,
            this.total});
            this.dgvVentas.Location = new System.Drawing.Point(9, 112);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(1106, 347);
            this.dgvVentas.TabIndex = 3;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            this.dgvVentas.DoubleClick += new System.EventHandler(this.dgvVentas_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // idventa
            // 
            this.idventa.DataPropertyName = "idventa";
            this.idventa.HeaderText = "# VENTA";
            this.idventa.Name = "idventa";
            this.idventa.ReadOnly = true;
            this.idventa.Visible = false;
            // 
            // fecha_venta
            // 
            this.fecha_venta.DataPropertyName = "fecha_venta";
            this.fecha_venta.HeaderText = "FECHA VENTA";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.DataPropertyName = "nombre_cliente";
            this.nombre_cliente.HeaderText = "CLIENTE";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // empleado
            // 
            this.empleado.DataPropertyName = "empleado";
            this.empleado.HeaderText = "EMPLEADO";
            this.empleado.Name = "empleado";
            this.empleado.ReadOnly = true;
            // 
            // tipo_comprobante
            // 
            this.tipo_comprobante.DataPropertyName = "tipo_comprobante";
            this.tipo_comprobante.HeaderText = "TIPO COMPROBANTE";
            this.tipo_comprobante.Name = "tipo_comprobante";
            this.tipo_comprobante.ReadOnly = true;
            // 
            // num_comprobante
            // 
            this.num_comprobante.DataPropertyName = "num_comprobante";
            this.num_comprobante.HeaderText = "# COMPROBANTE";
            this.num_comprobante.Name = "num_comprobante";
            this.num_comprobante.ReadOnly = true;
            // 
            // porc_isv
            // 
            this.porc_isv.DataPropertyName = "porc_isv";
            dataGridViewCellStyle9.NullValue = null;
            this.porc_isv.DefaultCellStyle = dataGridViewCellStyle9;
            this.porc_isv.HeaderText = "% ISV";
            this.porc_isv.Name = "porc_isv";
            this.porc_isv.ReadOnly = true;
            // 
            // subtotalventa
            // 
            this.subtotalventa.DataPropertyName = "subtotal";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.subtotalventa.DefaultCellStyle = dataGridViewCellStyle10;
            this.subtotalventa.HeaderText = "SUBTOTAL";
            this.subtotalventa.Name = "subtotalventa";
            this.subtotalventa.ReadOnly = true;
            // 
            // isv
            // 
            this.isv.DataPropertyName = "isv";
            dataGridViewCellStyle11.Format = "C2";
            this.isv.DefaultCellStyle = dataGridViewCellStyle11;
            this.isv.HeaderText = "ISV";
            this.isv.Name = "isv";
            this.isv.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle12;
            this.total.HeaderText = "TOTAL VENTA";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::capaPresentacion.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(254, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(6, 20);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(69, 13);
            this.lblFechaInicial.TabIndex = 0;
            this.lblFechaInicial.Text = "Fecha inicial:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupVenta);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1133, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Punto de Venta";
            // 
            // groupVenta
            // 
            this.groupVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVenta.Controls.Add(this.grupoBotones);
            this.groupVenta.Controls.Add(this.txtIsv);
            this.groupVenta.Controls.Add(this.txtIdCliente);
            this.groupVenta.Controls.Add(this.label12);
            this.groupVenta.Controls.Add(this.label11);
            this.groupVenta.Controls.Add(this.dtpFechaVenta);
            this.groupVenta.Controls.Add(this.groupProducto);
            this.groupVenta.Controls.Add(this.txtNumComprobante);
            this.groupVenta.Controls.Add(this.label4);
            this.groupVenta.Controls.Add(this.cmbComprobante);
            this.groupVenta.Controls.Add(this.label3);
            this.groupVenta.Controls.Add(this.btnCargarCliente);
            this.groupVenta.Controls.Add(this.txtNombreCliente);
            this.groupVenta.Controls.Add(this.label2);
            this.groupVenta.Controls.Add(this.txtIdVenta);
            this.groupVenta.Controls.Add(this.label1);
            this.groupVenta.Controls.Add(this.dgvDetallesVenta);
            this.groupVenta.Location = new System.Drawing.Point(11, 9);
            this.groupVenta.Name = "groupVenta";
            this.groupVenta.Size = new System.Drawing.Size(1116, 452);
            this.groupVenta.TabIndex = 0;
            this.groupVenta.TabStop = false;
            this.groupVenta.Text = "Ventas";
            this.groupVenta.Enter += new System.EventHandler(this.groupVenta_Enter);
            // 
            // grupoBotones
            // 
            this.grupoBotones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoBotones.Controls.Add(this.btnRecibo);
            this.grupoBotones.Controls.Add(this.txtTotalAPagar);
            this.grupoBotones.Controls.Add(this.btnNuevo);
            this.grupoBotones.Controls.Add(this.label17);
            this.grupoBotones.Controls.Add(this.btnGuardar);
            this.grupoBotones.Controls.Add(this.txtGranTotal);
            this.grupoBotones.Controls.Add(this.btnCancelar);
            this.grupoBotones.Controls.Add(this.label16);
            this.grupoBotones.Controls.Add(this.label15);
            this.grupoBotones.Controls.Add(this.txtISVTotal);
            this.grupoBotones.Location = new System.Drawing.Point(545, 276);
            this.grupoBotones.Name = "grupoBotones";
            this.grupoBotones.Size = new System.Drawing.Size(565, 157);
            this.grupoBotones.TabIndex = 77;
            this.grupoBotones.TabStop = false;
            // 
            // btnRecibo
            // 
            this.btnRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibo.Image = global::capaPresentacion.Properties.Resources.print;
            this.btnRecibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibo.Location = new System.Drawing.Point(248, 113);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(82, 33);
            this.btnRecibo.TabIndex = 76;
            this.btnRecibo.Text = "&Recibo";
            this.btnRecibo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecibo.UseVisualStyleBackColor = true;
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.DecimalPlaces = 2;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(463, 16);
            this.txtTotalAPagar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.Size = new System.Drawing.Size(127, 22);
            this.txtTotalAPagar.TabIndex = 71;
            this.txtTotalAPagar.ValueChanged += new System.EventHandler(this.txtTotalAPagar_ValueChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = global::capaPresentacion.Properties.Resources.add;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(336, 113);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 33);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(357, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 16);
            this.label17.TabIndex = 75;
            this.label17.Text = "Total + ISV (L.):";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::capaPresentacion.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(424, 113);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 33);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtGranTotal
            // 
            this.txtGranTotal.DecimalPlaces = 2;
            this.txtGranTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGranTotal.Location = new System.Drawing.Point(463, 74);
            this.txtGranTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtGranTotal.Name = "txtGranTotal";
            this.txtGranTotal.Size = new System.Drawing.Size(127, 22);
            this.txtGranTotal.TabIndex = 74;
            this.txtGranTotal.ValueChanged += new System.EventHandler(this.txtGranTotal_ValueChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::capaPresentacion.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(512, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 33);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(401, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 73;
            this.label16.Text = "ISV (L.):";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(391, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 71;
            this.label15.Text = "Total (L.):";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtISVTotal
            // 
            this.txtISVTotal.DecimalPlaces = 2;
            this.txtISVTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISVTotal.Location = new System.Drawing.Point(463, 46);
            this.txtISVTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtISVTotal.Name = "txtISVTotal";
            this.txtISVTotal.Size = new System.Drawing.Size(127, 22);
            this.txtISVTotal.TabIndex = 72;
            this.txtISVTotal.ValueChanged += new System.EventHandler(this.txtISVTotal_ValueChanged);
            // 
            // txtIsv
            // 
            this.txtIsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIsv.DecimalPlaces = 2;
            this.txtIsv.Enabled = false;
            this.txtIsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsv.Location = new System.Drawing.Point(325, 116);
            this.txtIsv.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtIsv.Name = "txtIsv";
            this.txtIsv.Size = new System.Drawing.Size(147, 26);
            this.txtIsv.TabIndex = 76;
            this.txtIsv.ValueChanged += new System.EventHandler(this.txtIsv_ValueChanged);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(487, 118);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(36, 22);
            this.txtIdCliente.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 57;
            this.label12.Text = "ISV (%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 56;
            this.label11.Text = "Fecha:";
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(325, 44);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(147, 26);
            this.dtpFechaVenta.TabIndex = 55;
            // 
            // groupProducto
            // 
            this.groupProducto.Controls.Add(this.label13);
            this.groupProducto.Controls.Add(this.maskedDescuento);
            this.groupProducto.Controls.Add(this.txtDescuento);
            this.groupProducto.Controls.Add(this.label14);
            this.groupProducto.Controls.Add(this.label10);
            this.groupProducto.Controls.Add(this.dtpVencimiento);
            this.groupProducto.Controls.Add(this.txtPrecioVenta);
            this.groupProducto.Controls.Add(this.label9);
            this.groupProducto.Controls.Add(this.txtPrecioCompra);
            this.groupProducto.Controls.Add(this.label7);
            this.groupProducto.Controls.Add(this.txtCantidad);
            this.groupProducto.Controls.Add(this.txtStockActual);
            this.groupProducto.Controls.Add(this.txtIdDetalle);
            this.groupProducto.Controls.Add(this.btnQuitar);
            this.groupProducto.Controls.Add(this.btnAgregar);
            this.groupProducto.Controls.Add(this.label8);
            this.groupProducto.Controls.Add(this.label6);
            this.groupProducto.Controls.Add(this.btnCargarProducto);
            this.groupProducto.Controls.Add(this.txtNombreProducto);
            this.groupProducto.Controls.Add(this.label5);
            this.groupProducto.Location = new System.Drawing.Point(15, 155);
            this.groupProducto.Name = "groupProducto";
            this.groupProducto.Size = new System.Drawing.Size(508, 278);
            this.groupProducto.TabIndex = 41;
            this.groupProducto.TabStop = false;
            this.groupProducto.Text = "Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 16);
            this.label13.TabIndex = 73;
            this.label13.Text = "# Compra:";
            // 
            // maskedDescuento
            // 
            this.maskedDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedDescuento.Location = new System.Drawing.Point(406, 93);
            this.maskedDescuento.Mask = "000";
            this.maskedDescuento.Name = "maskedDescuento";
            this.maskedDescuento.PromptChar = '%';
            this.maskedDescuento.Size = new System.Drawing.Size(46, 26);
            this.maskedDescuento.TabIndex = 72;
            this.maskedDescuento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedDescuento_MaskInputRejected);
            this.maskedDescuento.TextChanged += new System.EventHandler(this.maskedDescuento_TextChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.DecimalPlaces = 2;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(329, 94);
            this.txtDescuento.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(69, 26);
            this.txtDescuento.TabIndex = 70;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 69;
            this.label14.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Vencimiento:";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(91, 168);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(123, 26);
            this.dtpVencimiento.TabIndex = 61;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.DecimalPlaces = 2;
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(350, 166);
            this.txtPrecioVenta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(102, 26);
            this.txtPrecioVenta.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Precio Venta:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.DecimalPlaces = 2;
            this.txtPrecioCompra.Enabled = false;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(350, 130);
            this.txtPrecioCompra.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(102, 26);
            this.txtPrecioCompra.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 64;
            this.label7.Text = "Precio Compra:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(91, 93);
            this.txtCantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 26);
            this.txtCantidad.TabIndex = 63;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockActual.Location = new System.Drawing.Point(92, 131);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(122, 26);
            this.txtStockActual.TabIndex = 62;
            this.txtStockActual.TextChanged += new System.EventHandler(this.txtStockActual_TextChanged);
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDetalle.Location = new System.Drawing.Point(91, 21);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.ReadOnly = true;
            this.txtIdDetalle.Size = new System.Drawing.Size(123, 26);
            this.txtIdDetalle.TabIndex = 60;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Image = global::capaPresentacion.Properties.Resources.del;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(377, 234);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 33);
            this.btnQuitar.TabIndex = 57;
            this.btnQuitar.Text = "&Quitar";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::capaPresentacion.Properties.Resources.add;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(296, 234);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 33);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Stock actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cantidad:";
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarProducto.Image = global::capaPresentacion.Properties.Resources.search;
            this.btnCargarProducto.Location = new System.Drawing.Point(416, 54);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(36, 26);
            this.btnCargarProducto.TabIndex = 44;
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(91, 58);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(296, 26);
            this.txtNombreProducto.TabIndex = 43;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Producto:";
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumComprobante.Location = new System.Drawing.Point(84, 113);
            this.txtNumComprobante.Mask = "009-009-09-00000009";
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(157, 26);
            this.txtNumComprobante.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Número:";
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Items.AddRange(new object[] {
            "FACTURA",
            "TICKET",
            "OTRO"});
            this.cmbComprobante.Location = new System.Drawing.Point(84, 76);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(157, 28);
            this.cmbComprobante.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cmpte: ";
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarCliente.Image = global::capaPresentacion.Properties.Resources.search;
            this.btnCargarCliente.Location = new System.Drawing.Point(487, 74);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(36, 33);
            this.btnCargarCliente.TabIndex = 34;
            this.btnCargarCliente.UseVisualStyleBackColor = false;
            this.btnCargarCliente.Click += new System.EventHandler(this.btnCargarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(325, 81);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(147, 26);
            this.txtNombreCliente.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cliente:";
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.Location = new System.Drawing.Point(84, 39);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(157, 26);
            this.txtIdVenta.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "ID Venta:";
            // 
            // dgvDetallesVenta
            // 
            this.dgvDetallesVenta.AllowUserToAddRows = false;
            this.dgvDetallesVenta.AllowUserToDeleteRows = false;
            this.dgvDetallesVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetallesVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetalleingreso,
            this.nombre_producto,
            this.precio_venta,
            this.cantidad,
            this.descuento,
            this.Subtotal});
            this.dgvDetallesVenta.Location = new System.Drawing.Point(545, 39);
            this.dgvDetallesVenta.Name = "dgvDetallesVenta";
            this.dgvDetallesVenta.Size = new System.Drawing.Size(565, 231);
            this.dgvDetallesVenta.TabIndex = 25;
            this.dgvDetallesVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesVenta_CellContentClick);
            // 
            // iddetalleingreso
            // 
            this.iddetalleingreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iddetalleingreso.DataPropertyName = "iddetalleingreso";
            this.iddetalleingreso.HeaderText = "# DETALLE";
            this.iddetalleingreso.Name = "iddetalleingreso";
            this.iddetalleingreso.ReadOnly = true;
            this.iddetalleingreso.Width = 95;
            // 
            // nombre_producto
            // 
            this.nombre_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "PRODUCTO";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            this.nombre_producto.Width = 110;
            // 
            // precio_venta
            // 
            this.precio_venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precio_venta.DataPropertyName = "precio_venta";
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.precio_venta.DefaultCellStyle = dataGridViewCellStyle13;
            this.precio_venta.HeaderText = "PRECIO UNIDAD";
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.ReadOnly = true;
            this.precio_venta.Width = 126;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.DataPropertyName = "cantidad";
            dataGridViewCellStyle14.NullValue = null;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 102;
            // 
            // descuento
            // 
            this.descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descuento.DataPropertyName = "descuento";
            dataGridViewCellStyle15.Format = "C2";
            this.descuento.DefaultCellStyle = dataGridViewCellStyle15;
            this.descuento.HeaderText = "DESCUENTO";
            this.descuento.Name = "descuento";
            this.descuento.ReadOnly = true;
            this.descuento.Width = 118;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.DataPropertyName = "Subtotal";
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle16;
            this.Subtotal.HeaderText = "SUBTOTAL";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 105;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(23, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "VENTAS";
            // 
            // ttMensaje
            // 
            this.ttMensaje.AutoPopDelay = 5000;
            this.ttMensaje.InitialDelay = 400;
            this.ttMensaje.IsBalloon = true;
            this.ttMensaje.ReshowDelay = 100;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmVentas";
            this.Text = "...:::Ventas:::....";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVentas_FormClosing);
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupVenta.ResumeLayout(false);
            this.groupVenta.PerformLayout();
            this.grupoBotones.ResumeLayout(false);
            this.grupoBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGranTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtISVTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsv)).EndInit();
            this.groupProducto.ResumeLayout(false);
            this.groupProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblNumElementos;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupVenta;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.GroupBox groupProducto;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtNumComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetallesVenta;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComprobante;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.NumericUpDown txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtPrecioCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown txtTotalAPagar;
        private System.Windows.Forms.NumericUpDown txtDescuento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.MaskedTextBox maskedDescuento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown txtGranTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown txtISVTotal;
        private System.Windows.Forms.NumericUpDown txtIsv;
        private System.Windows.Forms.GroupBox grupoBotones;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetalleingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_isv;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn isv;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}