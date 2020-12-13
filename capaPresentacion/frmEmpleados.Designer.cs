namespace capaPresentacion
{
    partial class frmEmpleados
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
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAnioNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnModificarPermisos = new System.Windows.Forms.Button();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.chkReportes = new System.Windows.Forms.CheckBox();
            this.chkVentas = new System.Windows.Forms.CheckBox();
            this.chkPlanilla = new System.Windows.Forms.CheckBox();
            this.chkEmpleados = new System.Windows.Forms.CheckBox();
            this.chkCompras = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkConfig = new System.Windows.Forms.CheckBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPassvisible = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtIdempleado = new System.Windows.Forms.TextBox();
            this.lblIDProducto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primer_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilegios_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(34, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 375);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblNumElementos);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.dgvEmpleado);
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
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::capaPresentacion.Properties.Resources.print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(799, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 104;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::capaPresentacion.Properties.Resources.delete;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(718, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.AllowUserToOrderColumns = true;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.identidad,
            this.primer_nombre,
            this.primer_apellido,
            this.celular,
            this.username,
            this.privilegios_user});
            this.dgvEmpleado.Location = new System.Drawing.Point(9, 93);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(878, 241);
            this.dgvEmpleado.TabIndex = 106;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            this.dgvEmpleado.DoubleClick += new System.EventHandler(this.dgvEmpleado_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::capaPresentacion.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(637, 12);
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
            this.txtBuscar.Location = new System.Drawing.Point(119, 14);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(502, 26);
            this.txtBuscar.TabIndex = 101;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 17);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(107, 13);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar (por Apellido):";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtAnioNacimiento);
            this.tabPage2.Controls.Add(this.txtIdentidad);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.chkActivo);
            this.tabPage2.Controls.Add(this.lblActivo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCelular);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblCodigo);
            this.tabPage2.Controls.Add(this.txtIdempleado);
            this.tabPage2.Controls.Add(this.lblIDProducto);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualización";
            // 
            // txtAnioNacimiento
            // 
            this.txtAnioNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioNacimiento.Location = new System.Drawing.Point(96, 151);
            this.txtAnioNacimiento.Mask = "0000";
            this.txtAnioNacimiento.Name = "txtAnioNacimiento";
            this.txtAnioNacimiento.PromptChar = 'a';
            this.txtAnioNacimiento.Size = new System.Drawing.Size(170, 26);
            this.txtAnioNacimiento.TabIndex = 205;
            this.txtAnioNacimiento.Text = "1993";
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.BackColor = System.Drawing.Color.White;
            this.txtIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdentidad.Location = new System.Drawing.Point(96, 42);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(170, 26);
            this.txtIdentidad.TabIndex = 202;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnModificarPermisos);
            this.panel2.Controls.Add(this.txtPermisos);
            this.panel2.Controls.Add(this.chkReportes);
            this.panel2.Controls.Add(this.chkVentas);
            this.panel2.Controls.Add(this.chkPlanilla);
            this.panel2.Controls.Add(this.chkEmpleados);
            this.panel2.Controls.Add(this.chkCompras);
            this.panel2.Controls.Add(this.chkInventario);
            this.panel2.Controls.Add(this.chkConfig);
            this.panel2.Controls.Add(this.lblPermisos);
            this.panel2.Location = new System.Drawing.Point(545, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 218);
            this.panel2.TabIndex = 23;
            // 
            // btnModificarPermisos
            // 
            this.btnModificarPermisos.Image = global::capaPresentacion.Properties.Resources.edit;
            this.btnModificarPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPermisos.Location = new System.Drawing.Point(218, 80);
            this.btnModificarPermisos.Name = "btnModificarPermisos";
            this.btnModificarPermisos.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPermisos.TabIndex = 221;
            this.btnModificarPermisos.Text = "Modificar";
            this.btnModificarPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarPermisos.UseVisualStyleBackColor = true;
            this.btnModificarPermisos.Click += new System.EventHandler(this.btnModificarPermisos_Click);
            // 
            // txtPermisos
            // 
            this.txtPermisos.BackColor = System.Drawing.Color.White;
            this.txtPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermisos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPermisos.Location = new System.Drawing.Point(75, 12);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.ReadOnly = true;
            this.txtPermisos.Size = new System.Drawing.Size(233, 26);
            this.txtPermisos.TabIndex = 213;
            // 
            // chkReportes
            // 
            this.chkReportes.AutoSize = true;
            this.chkReportes.Location = new System.Drawing.Point(20, 181);
            this.chkReportes.Name = "chkReportes";
            this.chkReportes.Size = new System.Drawing.Size(107, 17);
            this.chkReportes.TabIndex = 220;
            this.chkReportes.Tag = "reportes";
            this.chkReportes.Text = "Módulo Reportes";
            this.chkReportes.UseVisualStyleBackColor = true;
            this.chkReportes.CheckedChanged += new System.EventHandler(this.chkReportes_CheckedChanged);
            // 
            // chkVentas
            // 
            this.chkVentas.AutoSize = true;
            this.chkVentas.Location = new System.Drawing.Point(20, 158);
            this.chkVentas.Name = "chkVentas";
            this.chkVentas.Size = new System.Drawing.Size(97, 17);
            this.chkVentas.TabIndex = 219;
            this.chkVentas.Tag = "ventas";
            this.chkVentas.Text = "Módulo Ventas";
            this.chkVentas.UseVisualStyleBackColor = true;
            this.chkVentas.CheckedChanged += new System.EventHandler(this.chkVentas_CheckedChanged);
            // 
            // chkPlanilla
            // 
            this.chkPlanilla.AutoSize = true;
            this.chkPlanilla.Location = new System.Drawing.Point(20, 135);
            this.chkPlanilla.Name = "chkPlanilla";
            this.chkPlanilla.Size = new System.Drawing.Size(97, 17);
            this.chkPlanilla.TabIndex = 218;
            this.chkPlanilla.Tag = "planilla";
            this.chkPlanilla.Text = "Módulo Planilla";
            this.chkPlanilla.UseVisualStyleBackColor = true;
            this.chkPlanilla.CheckedChanged += new System.EventHandler(this.chkPlanilla_CheckedChanged);
            // 
            // chkEmpleados
            // 
            this.chkEmpleados.AutoSize = true;
            this.chkEmpleados.Location = new System.Drawing.Point(20, 115);
            this.chkEmpleados.Name = "chkEmpleados";
            this.chkEmpleados.Size = new System.Drawing.Size(116, 17);
            this.chkEmpleados.TabIndex = 217;
            this.chkEmpleados.Tag = "empleados";
            this.chkEmpleados.Text = "Módulo Empleados";
            this.chkEmpleados.UseVisualStyleBackColor = true;
            this.chkEmpleados.CheckedChanged += new System.EventHandler(this.chkEmpleados_CheckedChanged);
            // 
            // chkCompras
            // 
            this.chkCompras.AutoSize = true;
            this.chkCompras.Location = new System.Drawing.Point(20, 92);
            this.chkCompras.Name = "chkCompras";
            this.chkCompras.Size = new System.Drawing.Size(105, 17);
            this.chkCompras.TabIndex = 216;
            this.chkCompras.Tag = "compras";
            this.chkCompras.Text = "Módulo Compras";
            this.chkCompras.UseVisualStyleBackColor = true;
            this.chkCompras.CheckedChanged += new System.EventHandler(this.chkCompras_CheckedChanged);
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(20, 69);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(111, 17);
            this.chkInventario.TabIndex = 215;
            this.chkInventario.Tag = "inventario";
            this.chkInventario.Text = "Módulo Inventario";
            this.chkInventario.UseVisualStyleBackColor = true;
            this.chkInventario.CheckedChanged += new System.EventHandler(this.chkInventario_CheckedChanged);
            // 
            // chkConfig
            // 
            this.chkConfig.AutoSize = true;
            this.chkConfig.Location = new System.Drawing.Point(20, 46);
            this.chkConfig.Name = "chkConfig";
            this.chkConfig.Size = new System.Drawing.Size(129, 17);
            this.chkConfig.TabIndex = 214;
            this.chkConfig.Tag = "config";
            this.chkConfig.Text = "Módulo Configuración";
            this.chkConfig.UseVisualStyleBackColor = true;
            this.chkConfig.CheckedChanged += new System.EventHandler(this.chkConfig_CheckedChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(17, 15);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(52, 13);
            this.lblPermisos.TabIndex = 25;
            this.lblPermisos.Text = "Permisos:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkPassvisible);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Location = new System.Drawing.Point(296, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 218);
            this.panel1.TabIndex = 22;
            // 
            // chkPassvisible
            // 
            this.chkPassvisible.AutoSize = true;
            this.chkPassvisible.Checked = true;
            this.chkPassvisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPassvisible.Location = new System.Drawing.Point(140, 165);
            this.chkPassvisible.Name = "chkPassvisible";
            this.chkPassvisible.Size = new System.Drawing.Size(60, 17);
            this.chkPassvisible.TabIndex = 211;
            this.chkPassvisible.Text = "Ocultar";
            this.chkPassvisible.UseVisualStyleBackColor = true;
            this.chkPassvisible.CheckedChanged += new System.EventHandler(this.chkPassvisible_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.Location = new System.Drawing.Point(16, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(211, 26);
            this.txtPassword.TabIndex = 212;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(16, 132);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(211, 26);
            this.txtUsuario.TabIndex = 210;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(16, 32);
            this.txtSalario.Mask = "00,000.00";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.PromptChar = '$';
            this.txtSalario.Size = new System.Drawing.Size(211, 26);
            this.txtSalario.TabIndex = 208;
            this.txtSalario.Text = "1500000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Salario Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cargo Desempeña:";
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.White;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCargo.Location = new System.Drawing.Point(16, 80);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(211, 26);
            this.txtCargo.TabIndex = 209;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(96, 220);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(36, 17);
            this.chkActivo.TabIndex = 207;
            this.chkActivo.Text = "SI";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(11, 221);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(43, 13);
            this.lblActivo.TabIndex = 20;
            this.lblActivo.Text = "Activo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(96, 185);
            this.txtCelular.Mask = "000-0000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(170, 26);
            this.txtCelular.TabIndex = 206;
            this.txtCelular.Text = "504";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Año Nacimiento:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtApellido.Location = new System.Drawing.Point(96, 115);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(170, 26);
            this.txtApellido.TabIndex = 204;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Primer Apellido:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 45);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Identidad:";
            // 
            // txtIdempleado
            // 
            this.txtIdempleado.BackColor = System.Drawing.Color.White;
            this.txtIdempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdempleado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdempleado.Location = new System.Drawing.Point(96, 11);
            this.txtIdempleado.Name = "txtIdempleado";
            this.txtIdempleado.ReadOnly = true;
            this.txtIdempleado.Size = new System.Drawing.Size(103, 26);
            this.txtIdempleado.TabIndex = 201;
            // 
            // lblIDProducto
            // 
            this.lblIDProducto.AutoSize = true;
            this.lblIDProducto.Location = new System.Drawing.Point(11, 19);
            this.lblIDProducto.Name = "lblIDProducto";
            this.lblIDProducto.Size = new System.Drawing.Size(71, 13);
            this.lblIDProducto.TabIndex = 10;
            this.lblIDProducto.Text = "ID Empleado:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNombre.Location = new System.Drawing.Point(96, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 26);
            this.txtNombre.TabIndex = 203;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Primer Nombre:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(29, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "EMPLEADOS";
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // identidad
            // 
            this.identidad.DataPropertyName = "identidad";
            this.identidad.HeaderText = "IDENTIDAD";
            this.identidad.Name = "identidad";
            this.identidad.ReadOnly = true;
            // 
            // primer_nombre
            // 
            this.primer_nombre.DataPropertyName = "primer_nombre";
            this.primer_nombre.HeaderText = "NOMBRE";
            this.primer_nombre.Name = "primer_nombre";
            this.primer_nombre.ReadOnly = true;
            // 
            // primer_apellido
            // 
            this.primer_apellido.DataPropertyName = "primer_apellido";
            this.primer_apellido.HeaderText = "APELLIDO";
            this.primer_apellido.Name = "primer_apellido";
            this.primer_apellido.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "CELULAR";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "USUARIO";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // privilegios_user
            // 
            this.privilegios_user.DataPropertyName = "privilegios_user";
            this.privilegios_user.HeaderText = "PERMISOS";
            this.privilegios_user.Name = "privilegios_user";
            this.privilegios_user.ReadOnly = true;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(964, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmEmpleados";
            this.Text = "..:::Empleados:::...";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNumElementos;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtIdempleado;
        private System.Windows.Forms.Label lblIDProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.CheckBox chkPassvisible;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkConfig;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.CheckBox chkCompras;
        private System.Windows.Forms.CheckBox chkEmpleados;
        private System.Windows.Forms.CheckBox chkReportes;
        private System.Windows.Forms.CheckBox chkVentas;
        private System.Windows.Forms.CheckBox chkPlanilla;
        private System.Windows.Forms.TextBox txtPermisos;
        private System.Windows.Forms.MaskedTextBox txtAnioNacimiento;
        private System.Windows.Forms.Button btnModificarPermisos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn primer_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilegios_user;
    }
}