namespace Quanlibenhvien_Offical
{
    partial class donthuocIN
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rp_donthuoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Dataquery = new Quanlibenhvien_Offical.Dataquery();
            this.CHITIETDONTHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CHITIETDONTHUOCTableAdapter = new Quanlibenhvien_Offical.DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter();
            this.BENHNHANBENHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BENHNHANBENHANTableAdapter = new Quanlibenhvien_Offical.DataqueryTableAdapters.BENHNHANBENHANTableAdapter();
            this.dataquery2 = new Quanlibenhvien_Offical.dataquery2();
            this.THONGTINNHANVIENPHONGCHUCNAGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THONGTINNHANVIENPHONGCHUCNAGTableAdapter = new Quanlibenhvien_Offical.dataquery2TableAdapters.THONGTINNHANVIENPHONGCHUCNAGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Dataquery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETDONTHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BENHNHANBENHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataquery2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINNHANVIENPHONGCHUCNAGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rp_donthuoc
            // 
            this.rp_donthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_donthuoc.IsDocumentMapWidthFixed = true;
            reportDataSource1.Name = "chitietdonthuoc";
            reportDataSource1.Value = this.CHITIETDONTHUOCBindingSource;
            reportDataSource2.Name = "benhnhan";
            reportDataSource2.Value = this.BENHNHANBENHANBindingSource;
            reportDataSource3.Name = "nhanvien";
            reportDataSource3.Value = this.THONGTINNHANVIENPHONGCHUCNAGBindingSource;
            this.rp_donthuoc.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_donthuoc.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_donthuoc.LocalReport.DataSources.Add(reportDataSource3);
            this.rp_donthuoc.LocalReport.ReportEmbeddedResource = "Quanlibenhvien_Offical.donthuocRP.rdlc";
            this.rp_donthuoc.Location = new System.Drawing.Point(0, 0);
            this.rp_donthuoc.Name = "rp_donthuoc";
            this.rp_donthuoc.ServerReport.BearerToken = null;
            this.rp_donthuoc.Size = new System.Drawing.Size(800, 450);
            this.rp_donthuoc.TabIndex = 0;
            this.rp_donthuoc.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.rp_donthuoc.Load += new System.EventHandler(this.Rp_donthuoc_Load);
            // 
            // Dataquery
            // 
            this.Dataquery.DataSetName = "Dataquery";
            this.Dataquery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CHITIETDONTHUOCBindingSource
            // 
            this.CHITIETDONTHUOCBindingSource.DataMember = "CHITIETDONTHUOC";
            this.CHITIETDONTHUOCBindingSource.DataSource = this.Dataquery;
            // 
            // CHITIETDONTHUOCTableAdapter
            // 
            this.CHITIETDONTHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // BENHNHANBENHANBindingSource
            // 
            this.BENHNHANBENHANBindingSource.DataMember = "BENHNHANBENHAN";
            this.BENHNHANBENHANBindingSource.DataSource = this.Dataquery;
            // 
            // BENHNHANBENHANTableAdapter
            // 
            this.BENHNHANBENHANTableAdapter.ClearBeforeFill = true;
            // 
            // dataquery2
            // 
            this.dataquery2.DataSetName = "dataquery2";
            this.dataquery2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THONGTINNHANVIENPHONGCHUCNAGBindingSource
            // 
            this.THONGTINNHANVIENPHONGCHUCNAGBindingSource.DataMember = "THONGTINNHANVIENPHONGCHUCNAG";
            this.THONGTINNHANVIENPHONGCHUCNAGBindingSource.DataSource = this.dataquery2;
            // 
            // THONGTINNHANVIENPHONGCHUCNAGTableAdapter
            // 
            this.THONGTINNHANVIENPHONGCHUCNAGTableAdapter.ClearBeforeFill = true;
            // 
            // donthuocIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rp_donthuoc);
            this.Name = "donthuocIN";
            this.Text = "Đơn thuốc";
            this.Load += new System.EventHandler(this.DonthuocIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dataquery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETDONTHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BENHNHANBENHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataquery2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGTINNHANVIENPHONGCHUCNAGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_donthuoc;
        private System.Windows.Forms.BindingSource CHITIETDONTHUOCBindingSource;
        private Dataquery Dataquery;
        private System.Windows.Forms.BindingSource BENHNHANBENHANBindingSource;
        private System.Windows.Forms.BindingSource THONGTINNHANVIENPHONGCHUCNAGBindingSource;
        private dataquery2 dataquery2;
        private DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter CHITIETDONTHUOCTableAdapter;
        private DataqueryTableAdapters.BENHNHANBENHANTableAdapter BENHNHANBENHANTableAdapter;
        private dataquery2TableAdapters.THONGTINNHANVIENPHONGCHUCNAGTableAdapter THONGTINNHANVIENPHONGCHUCNAGTableAdapter;
    }
}