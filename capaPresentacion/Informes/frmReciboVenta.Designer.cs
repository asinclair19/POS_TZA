namespace capaPresentacion
{
    partial class frmReciboVenta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spinforme_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new capaPresentacion.dsPrincipal();
            this.rvReciboVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spinforme_facturaTableAdapter = new capaPresentacion.dsPrincipalTableAdapters.spinforme_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spinforme_facturaBindingSource
            // 
            this.spinforme_facturaBindingSource.DataMember = "spinforme_factura";
            this.spinforme_facturaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvReciboVenta
            // 
            this.rvReciboVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spinforme_facturaBindingSource;
            this.rvReciboVenta.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReciboVenta.LocalReport.ReportEmbeddedResource = "capaPresentacion.Informes.infReciboVenta.rdlc";
            this.rvReciboVenta.Location = new System.Drawing.Point(0, 0);
            this.rvReciboVenta.Name = "rvReciboVenta";
            this.rvReciboVenta.Size = new System.Drawing.Size(384, 661);
            this.rvReciboVenta.TabIndex = 0;
            this.rvReciboVenta.ZoomPercent = 90;
            // 
            // spinforme_facturaTableAdapter
            // 
            this.spinforme_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReciboVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.rvReciboVenta);
            this.Name = "frmReciboVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Recibo Venta:::...";
            this.Load += new System.EventHandler(this.frmReciboVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinforme_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReciboVenta;
        private System.Windows.Forms.BindingSource spinforme_facturaBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spinforme_facturaTableAdapter spinforme_facturaTableAdapter;
    }
}