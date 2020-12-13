namespace capaPresentacion
{
    partial class frmReporteIngresosByFechas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsPrincipal = new capaPresentacion.dsPrincipal();
            this.spbuscar_ingreso_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spbuscar_ingreso_fechaTableAdapter = new capaPresentacion.dsPrincipalTableAdapters.spbuscar_ingreso_fechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_ingreso_fechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReporteIngresosPorFechas";
            reportDataSource1.Value = this.spbuscar_ingreso_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Informes.rptIngresosByFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(944, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spbuscar_ingreso_fechaBindingSource
            // 
            this.spbuscar_ingreso_fechaBindingSource.DataMember = "spbuscar_ingreso_fecha";
            this.spbuscar_ingreso_fechaBindingSource.DataSource = this.dsPrincipal;
            // 
            // spbuscar_ingreso_fechaTableAdapter
            // 
            this.spbuscar_ingreso_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteIngresosByFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteIngresosByFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ...:::Reporte de Compras:::... - Por Fechas";
            this.Load += new System.EventHandler(this.frmReporteIngresosByFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_ingreso_fechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscar_ingreso_fechaBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.spbuscar_ingreso_fechaTableAdapter spbuscar_ingreso_fechaTableAdapter;
    }
}