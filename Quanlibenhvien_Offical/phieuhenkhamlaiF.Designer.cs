namespace Quanlibenhvien_Offical
{
    partial class phieuhenkhamlaiF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_luuthoat = new System.Windows.Forms.Button();
            this.date_hen = new System.Windows.Forms.DateTimePicker();
            this.rp_henkhamlai = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_luuthoat);
            this.panel1.Controls.Add(this.date_hen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Panel1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(86, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn ngày hẹn khám lại ";
            // 
            // btn_luuthoat
            // 
            this.btn_luuthoat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_luuthoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_luuthoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_luuthoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_luuthoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luuthoat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luuthoat.ForeColor = System.Drawing.Color.White;
            this.btn_luuthoat.Location = new System.Drawing.Point(304, 47);
            this.btn_luuthoat.Name = "btn_luuthoat";
            this.btn_luuthoat.Size = new System.Drawing.Size(218, 30);
            this.btn_luuthoat.TabIndex = 1;
            this.btn_luuthoat.Text = "Lưu và thoát";
            this.btn_luuthoat.UseVisualStyleBackColor = false;
            this.btn_luuthoat.Click += new System.EventHandler(this.Btn_luuthoat_Click);
            // 
            // date_hen
            // 
            this.date_hen.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_hen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date_hen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_hen.Location = new System.Drawing.Point(304, 12);
            this.date_hen.Name = "date_hen";
            this.date_hen.Size = new System.Drawing.Size(218, 22);
            this.date_hen.TabIndex = 0;
            this.date_hen.Value = new System.DateTime(2019, 5, 29, 1, 3, 19, 0);
            this.date_hen.Validated += new System.EventHandler(this.Date_hen_Validated);
            // 
            // rp_henkhamlai
            // 
            this.rp_henkhamlai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rp_henkhamlai.LocalReport.ReportEmbeddedResource = "Quanlibenhvien_Offical.phieuhenkhamlaiRP.rdlc";
            this.rp_henkhamlai.Location = new System.Drawing.Point(0, 94);
            this.rp_henkhamlai.Name = "rp_henkhamlai";
            this.rp_henkhamlai.ServerReport.BearerToken = null;
            this.rp_henkhamlai.Size = new System.Drawing.Size(800, 356);
            this.rp_henkhamlai.TabIndex = 1;
            this.rp_henkhamlai.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.Rp_henkhamlai_PrintingBegin);
            // 
            // phieuhenkhamlaiF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rp_henkhamlai);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "phieuhenkhamlaiF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "phieuhenkhamlaiF";
            this.Load += new System.EventHandler(this.PhieuhenkhamlaiF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rp_henkhamlai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_luuthoat;
        private System.Windows.Forms.DateTimePicker date_hen;
    }
}