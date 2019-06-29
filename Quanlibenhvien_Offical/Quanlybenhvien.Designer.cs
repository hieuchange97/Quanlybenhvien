namespace Quanlibenhvien_Offical
{
    partial class Quanlybenhvien
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlybenhvien));
            this.header_form = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_category = new System.Windows.Forms.Button();
            this.pnl_slidebar = new System.Windows.Forms.Panel();
            this.btn_BPquanly = new System.Windows.Forms.Button();
            this.btn_bpxetnghiem = new System.Windows.Forms.Button();
            this.btn_quaythuoc = new System.Windows.Forms.Button();
            this.btn_BPthanhtoan = new System.Windows.Forms.Button();
            this.btn_BPKB = new System.Windows.Forms.Button();
            this.btn_bptiepdon = new System.Windows.Forms.Button();
            this.logo_BV = new System.Windows.Forms.PictureBox();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.transition_logo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.header_form.SuspendLayout();
            this.pnl_slidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_BV)).BeginInit();
            this.pnl_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_form
            // 
            this.header_form.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header_form.Controls.Add(this.label1);
            this.header_form.Controls.Add(this.btn_minimize);
            this.header_form.Controls.Add(this.btn_exit);
            this.header_form.Controls.Add(this.btn_category);
            this.transition_logo.SetDecoration(this.header_form, BunifuAnimatorNS.DecorationType.None);
            this.header_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_form.Location = new System.Drawing.Point(0, 0);
            this.header_form.Name = "header_form";
            this.header_form.Size = new System.Drawing.Size(1366, 33);
            this.header_form.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition_logo.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(604, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(338, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bệnh viện đa khoa Hoa Sữa ";
            this.label1.Visible = false;
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_minimize.BackgroundImage = global::Quanlibenhvien_Offical.Properties.Resources.drop_down_100px;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition_logo.SetDecoration(this.btn_minimize, BunifuAnimatorNS.DecorationType.None);
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.Color.Beige;
            this.btn_minimize.Location = new System.Drawing.Point(1288, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(39, 33);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_exit.BackgroundImage = global::Quanlibenhvien_Offical.Properties.Resources.cancel_100pxfinal;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transition_logo.SetDecoration(this.btn_exit, BunifuAnimatorNS.DecorationType.None);
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.Color.Beige;
            this.btn_exit.Location = new System.Drawing.Point(1327, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(39, 33);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // btn_category
            // 
            this.btn_category.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_category.BackgroundImage = global::Quanlibenhvien_Offical.Properties.Resources.list_50px;
            this.btn_category.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.transition_logo.SetDecoration(this.btn_category, BunifuAnimatorNS.DecorationType.None);
            this.btn_category.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_category.FlatAppearance.BorderSize = 0;
            this.btn_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.ForeColor = System.Drawing.Color.Beige;
            this.btn_category.Location = new System.Drawing.Point(0, 0);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(66, 33);
            this.btn_category.TabIndex = 0;
            this.btn_category.UseVisualStyleBackColor = false;
            this.btn_category.Click += new System.EventHandler(this.Btn_category_Click);
            // 
            // pnl_slidebar
            // 
            this.pnl_slidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_slidebar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_slidebar.Controls.Add(this.btn_BPquanly);
            this.pnl_slidebar.Controls.Add(this.btn_bpxetnghiem);
            this.pnl_slidebar.Controls.Add(this.btn_quaythuoc);
            this.pnl_slidebar.Controls.Add(this.btn_BPthanhtoan);
            this.pnl_slidebar.Controls.Add(this.btn_BPKB);
            this.pnl_slidebar.Controls.Add(this.btn_bptiepdon);
            this.pnl_slidebar.Controls.Add(this.logo_BV);
            this.transition_logo.SetDecoration(this.pnl_slidebar, BunifuAnimatorNS.DecorationType.None);
            this.pnl_slidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_slidebar.Name = "pnl_slidebar";
            this.pnl_slidebar.Size = new System.Drawing.Size(214, 536);
            this.pnl_slidebar.TabIndex = 2;
            // 
            // btn_BPquanly
            // 
            this.transition_logo.SetDecoration(this.btn_BPquanly, BunifuAnimatorNS.DecorationType.None);
            this.btn_BPquanly.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BPquanly.Enabled = false;
            this.btn_BPquanly.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BPquanly.FlatAppearance.BorderSize = 0;
            this.btn_BPquanly.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_BPquanly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BPquanly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BPquanly.ForeColor = System.Drawing.Color.White;
            this.btn_BPquanly.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_BPquanly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BPquanly.Location = new System.Drawing.Point(0, 438);
            this.btn_BPquanly.Name = "btn_BPquanly";
            this.btn_BPquanly.Size = new System.Drawing.Size(214, 59);
            this.btn_BPquanly.TabIndex = 5;
            this.btn_BPquanly.Text = "Bộ phận quản lý";
            this.btn_BPquanly.UseVisualStyleBackColor = true;
            this.btn_BPquanly.Click += new System.EventHandler(this.Btn_BPquanly_Click);
            // 
            // btn_bpxetnghiem
            // 
            this.transition_logo.SetDecoration(this.btn_bpxetnghiem, BunifuAnimatorNS.DecorationType.None);
            this.btn_bpxetnghiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bpxetnghiem.Enabled = false;
            this.btn_bpxetnghiem.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_bpxetnghiem.FlatAppearance.BorderSize = 0;
            this.btn_bpxetnghiem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_bpxetnghiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bpxetnghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bpxetnghiem.ForeColor = System.Drawing.Color.White;
            this.btn_bpxetnghiem.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_bpxetnghiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bpxetnghiem.Location = new System.Drawing.Point(0, 379);
            this.btn_bpxetnghiem.Name = "btn_bpxetnghiem";
            this.btn_bpxetnghiem.Size = new System.Drawing.Size(214, 59);
            this.btn_bpxetnghiem.TabIndex = 4;
            this.btn_bpxetnghiem.Text = "Bộ phận xét nghiệm ";
            this.btn_bpxetnghiem.UseVisualStyleBackColor = true;
            this.btn_bpxetnghiem.Click += new System.EventHandler(this.Btn_bpxetnghiem_Click);
            // 
            // btn_quaythuoc
            // 
            this.transition_logo.SetDecoration(this.btn_quaythuoc, BunifuAnimatorNS.DecorationType.None);
            this.btn_quaythuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quaythuoc.Enabled = false;
            this.btn_quaythuoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_quaythuoc.FlatAppearance.BorderSize = 0;
            this.btn_quaythuoc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_quaythuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_quaythuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quaythuoc.ForeColor = System.Drawing.Color.White;
            this.btn_quaythuoc.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_quaythuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quaythuoc.Location = new System.Drawing.Point(0, 320);
            this.btn_quaythuoc.Name = "btn_quaythuoc";
            this.btn_quaythuoc.Size = new System.Drawing.Size(214, 59);
            this.btn_quaythuoc.TabIndex = 3;
            this.btn_quaythuoc.Text = " Bộ phận quầy thuốc";
            this.btn_quaythuoc.UseVisualStyleBackColor = true;
            this.btn_quaythuoc.Click += new System.EventHandler(this.Btn_quaythuoc_Click);
            // 
            // btn_BPthanhtoan
            // 
            this.transition_logo.SetDecoration(this.btn_BPthanhtoan, BunifuAnimatorNS.DecorationType.None);
            this.btn_BPthanhtoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BPthanhtoan.Enabled = false;
            this.btn_BPthanhtoan.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BPthanhtoan.FlatAppearance.BorderSize = 0;
            this.btn_BPthanhtoan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_BPthanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BPthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BPthanhtoan.ForeColor = System.Drawing.Color.White;
            this.btn_BPthanhtoan.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_BPthanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BPthanhtoan.Location = new System.Drawing.Point(0, 261);
            this.btn_BPthanhtoan.Name = "btn_BPthanhtoan";
            this.btn_BPthanhtoan.Size = new System.Drawing.Size(214, 59);
            this.btn_BPthanhtoan.TabIndex = 2;
            this.btn_BPthanhtoan.Text = "Bộ phận thu ngân";
            this.btn_BPthanhtoan.UseVisualStyleBackColor = true;
            this.btn_BPthanhtoan.Click += new System.EventHandler(this.Btn_BPthanhtoan_Click);
            // 
            // btn_BPKB
            // 
            this.transition_logo.SetDecoration(this.btn_BPKB, BunifuAnimatorNS.DecorationType.None);
            this.btn_BPKB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BPKB.Enabled = false;
            this.btn_BPKB.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_BPKB.FlatAppearance.BorderSize = 0;
            this.btn_BPKB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_BPKB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BPKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BPKB.ForeColor = System.Drawing.Color.White;
            this.btn_BPKB.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_BPKB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BPKB.Location = new System.Drawing.Point(0, 202);
            this.btn_BPKB.Name = "btn_BPKB";
            this.btn_BPKB.Size = new System.Drawing.Size(214, 59);
            this.btn_BPKB.TabIndex = 1;
            this.btn_BPKB.Text = "  Bộ phận khám bệnh ";
            this.btn_BPKB.UseVisualStyleBackColor = true;
            this.btn_BPKB.Click += new System.EventHandler(this.Btn_BPKB_Click);
            // 
            // btn_bptiepdon
            // 
            this.transition_logo.SetDecoration(this.btn_bptiepdon, BunifuAnimatorNS.DecorationType.None);
            this.btn_bptiepdon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_bptiepdon.Enabled = false;
            this.btn_bptiepdon.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_bptiepdon.FlatAppearance.BorderSize = 0;
            this.btn_bptiepdon.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_bptiepdon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_bptiepdon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bptiepdon.ForeColor = System.Drawing.Color.White;
            this.btn_bptiepdon.Image = global::Quanlibenhvien_Offical.Properties.Resources.about_us_filled_30px;
            this.btn_bptiepdon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bptiepdon.Location = new System.Drawing.Point(0, 143);
            this.btn_bptiepdon.Name = "btn_bptiepdon";
            this.btn_bptiepdon.Size = new System.Drawing.Size(214, 59);
            this.btn_bptiepdon.TabIndex = 0;
            this.btn_bptiepdon.Text = "Bộ phận tiếp đón";
            this.btn_bptiepdon.UseVisualStyleBackColor = true;
            this.btn_bptiepdon.Click += new System.EventHandler(this.Button1_Click);
            // 
            // logo_BV
            // 
            this.logo_BV.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.transition_logo.SetDecoration(this.logo_BV, BunifuAnimatorNS.DecorationType.None);
            this.logo_BV.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_BV.Image = global::Quanlibenhvien_Offical.Properties.Resources.Capture;
            this.logo_BV.Location = new System.Drawing.Point(0, 0);
            this.logo_BV.Name = "logo_BV";
            this.logo_BV.Size = new System.Drawing.Size(214, 143);
            this.logo_BV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo_BV.TabIndex = 0;
            this.logo_BV.TabStop = false;
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.pnl_slidebar);
            this.transition_logo.SetDecoration(this.pnl_content, BunifuAnimatorNS.DecorationType.None);
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 33);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1366, 536);
            this.pnl_content.TabIndex = 3;
            // 
            // transition_logo
            // 
            this.transition_logo.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.transition_logo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition_logo.DefaultAnimation = animation1;
            this.transition_logo.Interval = 5;
            this.transition_logo.TimeStep = 0.01F;
            // 
            // Quanlybenhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1366, 569);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.header_form);
            this.transition_logo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quanlybenhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                          Bệnh viện đa khoa Hoa Sữa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Quanlybenhvien_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header_form.ResumeLayout(false);
            this.header_form.PerformLayout();
            this.pnl_slidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_BV)).EndInit();
            this.pnl_content.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Panel header_form;
        private System.Windows.Forms.Panel pnl_slidebar;
        private System.Windows.Forms.PictureBox logo_BV;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_bptiepdon;
        private BunifuAnimatorNS.BunifuTransition transition_logo;
        private System.Windows.Forms.Button btn_BPKB;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btn_quaythuoc;
        private System.Windows.Forms.Button btn_BPthanhtoan;
        private System.Windows.Forms.Button btn_bpxetnghiem;
        private System.Windows.Forms.Button btn_BPquanly;
    }
}