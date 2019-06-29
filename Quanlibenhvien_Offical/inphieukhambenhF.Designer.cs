namespace Quanlibenhvien_Offical
{
    partial class inphieukhambenhF
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
            this.rp_phieukhambenh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_phieukhambenh
            // 
            this.rp_phieukhambenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_phieukhambenh.LocalReport.ReportEmbeddedResource = "Quanlibenhvien_Offical.phieukhambenhIN.rdlc";
            this.rp_phieukhambenh.Location = new System.Drawing.Point(0, 0);
            this.rp_phieukhambenh.Name = "rp_phieukhambenh";
            this.rp_phieukhambenh.ServerReport.BearerToken = null;
            this.rp_phieukhambenh.Size = new System.Drawing.Size(800, 450);
            this.rp_phieukhambenh.TabIndex = 0;
            // 
            // inphieukhambenhF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rp_phieukhambenh);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inphieukhambenhF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu khám bệnh ";
            this.Load += new System.EventHandler(this.InphieukhambenhF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_phieukhambenh;
    }
}