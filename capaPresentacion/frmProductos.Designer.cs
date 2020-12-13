namespace capaPresentacion
{
    partial class frmProductos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblNumElementos = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen_producto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_imagen = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoCategoria = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel_imagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 375);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblNumElementos);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.dgvProducto);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registros";
            // 
            // lblNumElementos
            // 
            this.lblNumElementos.AutoSize = true;
            this.lblNumElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumElementos.Location = new System.Drawing.Point(711, 69);
            this.lblNumElementos.Name = "lblNumElementos";
            this.lblNumElementos.Size = new System.Drawing.Size(85, 17);
            this.lblNumElementos.TabIndex = 7;
            this.lblNumElementos.Text = "# elementos";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(9, 70);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 105;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = global::capaPresentacion.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(802, 15);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 104;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::capaPresentacion.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(721, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AllowUserToOrderColumns = true;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.codigo_producto,
            this.nombre_producto,
            this.imagen_producto,
            this.Categoria,
            this.Unidad});
            this.dgvProducto.Location = new System.Drawing.Point(9, 93);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(878, 241);
            this.dgvProducto.TabIndex = 106;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            this.dgvProducto.DoubleClick += new System.EventHandler(this.dgvProducto_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // codigo_producto
            // 
            this.codigo_producto.DataPropertyName = "codigo_producto";
            this.codigo_producto.HeaderText = "CODIGO VENTA";
            this.codigo_producto.Name = "codigo_producto";
            this.codigo_producto.ReadOnly = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.DataPropertyName = "nombre_producto";
            this.nombre_producto.HeaderText = "NOMBRE PRODUCTO";
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.ReadOnly = true;
            // 
            // imagen_producto
            // 
            this.imagen_producto.DataPropertyName = "imagen_producto";
            this.imagen_producto.HeaderText = "IMAGEN";
            this.imagen_producto.Name = "imagen_producto";
            this.imagen_producto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "CATEGORIA";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "Unidad";
            this.Unidad.HeaderText = "UNIDAD";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::capaPresentacion.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(640, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 102;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(56, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(565, 26);
            this.txtBuscar.TabIndex = 101;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel_imagen);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblCodigoCategoria);
            this.tabPage2.Controls.Add(this.btnSeleccionar);
            this.tabPage2.Controls.Add(this.txtCodigoCategoria);
            this.tabPage2.Controls.Add(this.txtNombreCategoria);
            this.tabPage2.Controls.Add(this.lblUnidad);
            this.tabPage2.Controls.Add(this.cmbUnidad);
            this.tabPage2.Controls.Add(this.txtBusqueda);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.lblCodigo);
            this.tabPage2.Controls.Add(this.txtIDProducto);
            this.tabPage2.Controls.Add(this.lblIDProducto);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.chkActiva);
            this.tabPage2.Controls.Add(this.lblActivo);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.lblDescripcion);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualización";
            // 
            // panel_imagen
            // 
            this.panel_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_imagen.Controls.Add(this.btnCargar);
            this.panel_imagen.Controls.Add(this.pxImagen);
            this.panel_imagen.Controls.Add(this.btnDescartar);
            this.panel_imagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_imagen.Location = new System.Drawing.Point(598, 38);
            this.panel_imagen.Name = "panel_imagen";
            this.panel_imagen.Size = new System.Drawing.Size(285, 202);
            this.panel_imagen.TabIndex = 26;
            // 
            // btnCargar
            // 
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.Image = global::capaPresentacion.Properties.Resources.add;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.Location = new System.Drawing.Point(215, 6);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 84);
            this.btnCargar.TabIndex = 209;
            this.btnCargar.Text = "Buscar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // pxImagen
            // 
            this.pxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxImagen.Location = new System.Drawing.Point(14, 6);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(188, 184);
            this.pxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxImagen.TabIndex = 15;
            this.pxImagen.TabStop = false;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescartar.Image = global::capaPresentacion.Properties.Resources.del;
            this.btnDescartar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDescartar.Location = new System.Drawing.Point(215, 106);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(62, 84);
            this.btnDescartar.TabIndex = 210;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Busqueda:";
            // 
            // lblCodigoCategoria
            // 
            this.lblCodigoCategoria.AutoSize = true;
            this.lblCodigoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCategoria.Location = new System.Drawing.Point(375, 133);
            this.lblCodigoCategoria.Name = "lblCodigoCategoria";
            this.lblCodigoCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCodigoCategoria.TabIndex = 23;
            this.lblCodigoCategoria.Text = "Categoría:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = global::capaPresentacion.Properties.Resources.add;
            this.btnSeleccionar.Location = new System.Drawing.Point(552, 134);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(40, 43);
            this.btnSeleccionar.TabIndex = 206;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigoCategoria.Location = new System.Drawing.Point(510, 102);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(81, 26);
            this.txtCodigoCategoria.TabIndex = 300;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombreCategoria.Location = new System.Drawing.Point(378, 150);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(172, 26);
            this.txtNombreCategoria.TabIndex = 207;
            this.txtNombreCategoria.TextChanged += new System.EventHandler(this.txtNombreCategoria_TextChanged);
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(375, 183);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblUnidad.TabIndex = 19;
            this.lblUnidad.Text = "Unidad:";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(378, 208);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(213, 28);
            this.cmbUnidad.TabIndex = 208;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(98, 8);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ReadOnly = true;
            this.txtBusqueda.Size = new System.Drawing.Size(785, 26);
            this.txtBusqueda.TabIndex = 200;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(98, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(247, 26);
            this.txtCodigo.TabIndex = 202;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(25, 74);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDProducto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIDProducto.Location = new System.Drawing.Point(98, 41);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(83, 26);
            this.txtIDProducto.TabIndex = 201;
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProducto.Location = new System.Drawing.Point(25, 48);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(67, 13);
            this.lblIDProducto.TabIndex = 10;
            this.lblIDProducto.Text = "ID Producto:";
            this.lblIDProducto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::capaPresentacion.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(516, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 233;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::capaPresentacion.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(418, 289);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 232;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::capaPresentacion.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(323, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 231;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::capaPresentacion.Properties.Resources.add;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(227, 289);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 230;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Checked = true;
            this.chkActiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiva.Location = new System.Drawing.Point(444, 96);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(39, 20);
            this.chkActiva.TabIndex = 205;
            this.chkActiva.Text = "SI";
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(376, 97);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(43, 13);
            this.lblActivo.TabIndex = 4;
            this.lblActivo.Text = "Activo: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDescripcion.Location = new System.Drawing.Point(98, 145);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 84);
            this.txtDescripcion.TabIndex = 204;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 148);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(98, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 26);
            this.txtNombre.TabIndex = 203;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(24, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "PRODUCTOS";
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(964, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmProductos";
            this.Text = "..:::Productos:::..";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProductos_FormClosed);
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel_imagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNumElementos;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkActiva;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblCodigoCategoria;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_imagen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_producto;
        private System.Windows.Forms.DataGridViewImageColumn imagen_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
    }
}