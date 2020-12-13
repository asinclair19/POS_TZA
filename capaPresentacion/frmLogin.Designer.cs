namespace capaPresentacion
{
    partial class frmLogin
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
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.ForeColor = System.Drawing.Color.White;
            this.lblTituloLogin.Location = new System.Drawing.Point(166, 9);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(240, 25);
            this.lblTituloLogin.TabIndex = 1;
            this.lblTituloLogin.Text = "Sistema de Inventario";
            this.lblTituloLogin.Click += new System.EventHandler(this.lblTituloLogin_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.lblHora);
            this.groupBoxLogin.Controls.Add(this.btnSalir);
            this.groupBoxLogin.Controls.Add(this.btnIngresar);
            this.groupBoxLogin.Controls.Add(this.chkVisible);
            this.groupBoxLogin.Controls.Add(this.txtPass);
            this.groupBoxLogin.Controls.Add(this.txtUser);
            this.groupBoxLogin.Controls.Add(this.lblPass);
            this.groupBoxLogin.Controls.Add(this.lblUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(132, 51);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(376, 187);
            this.groupBoxLogin.TabIndex = 2;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Inicio de sesión";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(110, 26);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 16);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "lblHora";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = global::capaPresentacion.Properties.Resources.cancel;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(240, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.TabIndex = 111;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Image = global::capaPresentacion.Properties.Resources.options;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(113, 141);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(105, 23);
            this.btnIngresar.TabIndex = 110;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Location = new System.Drawing.Point(289, 118);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(56, 17);
            this.chkVisible.TabIndex = 102;
            this.chkVisible.Text = "Visible";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(113, 88);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 26);
            this.txtPass.TabIndex = 101;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(113, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 26);
            this.txtUser.TabIndex = 100;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(24, 91);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = global::capaPresentacion.Properties.Resources.img_login;
            this.picUserIcon.Location = new System.Drawing.Point(15, 65);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(105, 107);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserIcon.TabIndex = 3;
            this.picUserIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 42);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(520, 250);
            this.Controls.Add(this.picUserIcon);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.lblTituloLogin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Inicio de Sesión:::...";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.PictureBox picUserIcon;
    }
}