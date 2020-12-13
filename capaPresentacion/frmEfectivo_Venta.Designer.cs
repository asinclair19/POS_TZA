namespace capaPresentacion
{
    partial class frmEfectivo_Venta
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
            this.label17 = new System.Windows.Forms.Label();
            this.txtAPagar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 25);
            this.label17.TabIndex = 77;
            this.label17.Text = "A PAGAR";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAPagar
            // 
            this.txtAPagar.DecimalPlaces = 2;
            this.txtAPagar.Enabled = false;
            this.txtAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPagar.Location = new System.Drawing.Point(161, 55);
            this.txtAPagar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtAPagar.Name = "txtAPagar";
            this.txtAPagar.Size = new System.Drawing.Size(155, 38);
            this.txtAPagar.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "EFECTIVO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "CAMBIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCambio
            // 
            this.txtCambio.DecimalPlaces = 2;
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(161, 143);
            this.txtCambio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(155, 38);
            this.txtCambio.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "SALDO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSaldo
            // 
            this.txtSaldo.DecimalPlaces = 2;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(161, 187);
            this.txtSaldo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(155, 38);
            this.txtSaldo.TabIndex = 103;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(170, 268);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 55);
            this.btnAceptar.TabIndex = 105;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(9, 268);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 55);
            this.btnCancelar.TabIndex = 104;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.Location = new System.Drawing.Point(161, 99);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(155, 38);
            this.txtEfectivo.TabIndex = 106;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            this.txtEfectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivo_KeyPress_1);
            // 
            // frmEfectivo_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(337, 335);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEfectivo_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Entrega de Efectivo:::...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEfectivo_Venta_FormClosed);
            this.Load += new System.EventHandler(this.frmEfectivo_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown txtAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtCambio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtSaldo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtEfectivo;
    }
}