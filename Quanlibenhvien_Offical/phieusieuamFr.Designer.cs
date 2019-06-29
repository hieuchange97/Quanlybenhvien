namespace Quanlibenhvien_Offical
{
    partial class phieusieuamFr
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
            this.rp_phieusieuam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rp_phieusieuam
            // 
            this.rp_phieusieuam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_phieusieuam.LocalReport.ReportEmbeddedResource = "Quanlibenhvien_Offical.phieusieuamRP.rdlc";
            this.rp_phieusieuam.Location = new System.Drawing.Point(0, 0);
            this.rp_phieusieuam.Name = "rp_phieusieuam";
            this.rp_phieusieuam.ServerReport.BearerToken = null;
            this.rp_phieusieuam.Size = new System.Drawing.Size(800, 450);
            this.rp_phieusieuam.TabIndex = 0;
            // 
            // phieusieuamFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rp_phieusieuam);
            this.Name = "phieusieuamFr";
            this.Text = "phieusieuamF";
            this.Load += new System.EventHandler(this.PhieusieuamFr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_phieusieuam;
    }
}