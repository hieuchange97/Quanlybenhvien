namespace Quanlibenhvien_Offical
{
    partial class Phieuthanhtoanxetnghiem
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
            this.PHIEUTHANHTOANXNKTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dataquery = new Quanlibenhvien_Offical.Dataquery();
            this.infoNVlamviecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rp_phieuthanhtoan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PHIEUTHANHTOANXNKTTableAdapter = new Quanlibenhvien_Offical.DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter();
            this.infoNVlamviecTableAdapter = new Quanlibenhvien_Offical.DataqueryTableAdapters.infoNVlamviecTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_loaiDV = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUTHANHTOANXNKTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataquery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNVlamviecBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PHIEUTHANHTOANXNKTBindingSource
            // 
            this.PHIEUTHANHTOANXNKTBindingSource.DataMember = "PHIEUTHANHTOANXNKT";
            this.PHIEUTHANHTOANXNKTBindingSource.DataSource = this.Dataquery;
            // 
            // Dataquery
            // 
            this.Dataquery.DataSetName = "Dataquery";
            this.Dataquery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoNVlamviecBindingSource
            // 
            this.infoNVlamviecBindingSource.DataMember = "infoNVlamviec";
            this.infoNVlamviecBindingSource.DataSource = this.Dataquery;
            // 
            // rp_phieuthanhtoan
            // 
            this.rp_phieuthanhtoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "phieuthanhtoan";
            reportDataSource1.Value = this.PHIEUTHANHTOANXNKTBindingSource;
            reportDataSource2.Name = "nhanvien";
            reportDataSource2.Value = this.infoNVlamviecBindingSource;
            this.rp_phieuthanhtoan.LocalReport.DataSources.Add(reportDataSource1);
            this.rp_phieuthanhtoan.LocalReport.DataSources.Add(reportDataSource2);
            this.rp_phieuthanhtoan.LocalReport.ReportEmbeddedResource = "Quanlibenhvien_Offical.PhieuthanhtoanXNrp.rdlc";
            this.rp_phieuthanhtoan.Location = new System.Drawing.Point(0, 86);
            this.rp_phieuthanhtoan.Name = "rp_phieuthanhtoan";
            this.rp_phieuthanhtoan.ServerReport.BearerToken = null;
            this.rp_phieuthanhtoan.Size = new System.Drawing.Size(800, 364);
            this.rp_phieuthanhtoan.TabIndex = 0;
            // 
            // PHIEUTHANHTOANXNKTTableAdapter
            // 
            this.PHIEUTHANHTOANXNKTTableAdapter.ClearBeforeFill = true;
            // 
            // infoNVlamviecTableAdapter
            // 
            this.infoNVlamviecTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại dịch vụ xét nghiệm kiểm tra :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cb_loaiDV
            // 
            this.cb_loaiDV.FormattingEnabled = true;
            this.cb_loaiDV.Location = new System.Drawing.Point(412, 24);
            this.cb_loaiDV.Name = "cb_loaiDV";
            this.cb_loaiDV.Size = new System.Drawing.Size(188, 21);
            this.cb_loaiDV.TabIndex = 2;
            this.cb_loaiDV.SelectionChangeCommitted += new System.EventHandler(this.Cb_loaiDV_SelectionChangeCommitted);
            this.cb_loaiDV.SelectedValueChanged += new System.EventHandler(this.Cb_loaiDV_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(412, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lưu phiếu và thoát ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Phieuthanhtoanxetnghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_loaiDV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rp_phieuthanhtoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Phieuthanhtoanxetnghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phieuthanhtoanxetnghiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Phieuthanhtoanxetnghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUTHANHTOANXNKTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataquery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoNVlamviecBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_phieuthanhtoan;
        private System.Windows.Forms.BindingSource PHIEUTHANHTOANXNKTBindingSource;
        private Dataquery Dataquery;
        private System.Windows.Forms.BindingSource infoNVlamviecBindingSource;
        private DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter PHIEUTHANHTOANXNKTTableAdapter;
        private DataqueryTableAdapters.infoNVlamviecTableAdapter infoNVlamviecTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_loaiDV;
        private System.Windows.Forms.Button button1;
    }
}