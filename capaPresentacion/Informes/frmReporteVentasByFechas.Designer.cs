namespace capaPresentacion
{
    partial class frmReporteVentasByFechas
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
            this.spbuscar_venta_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new capaPresentacion.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spbuscar_venta_fechaTableAdapter = new capaPresentacion.dsPrincipalTableAdapters.spbuscar_venta_fechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_venta_fechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // spbuscar_venta_fechaBindingSource
            // 
            this.spbuscar_venta_fechaBindingSource.DataMember = "spbuscar_venta_fecha";
            this.spbuscar_venta_fechaBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsventasbyfechas";
            reportDataSource1.Value = this.spbuscar_venta_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Informes.rptVentasByFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(944, 551);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomPercent = 90;
            // 
            // spbuscar_venta_fechaTableAdapter
            // 
            this.spbuscar_venta_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteVentasByFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteVentasByFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ...:::Reporte de Ventas:::... - Por Fechas";
            this.Load += new System.EventHandler(this.frmReporteVentasByFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_venta_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscar_venta_fechaBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spbuscar_venta_fechaTableAdapter spbuscar_venta_fechaTableAdapter;
    }
}