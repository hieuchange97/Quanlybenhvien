namespace Quanlibenhvien_Offical
{
    partial class ketquathanhcongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ketquathanhcongForm));
            this.time_load = new System.Windows.Forms.Timer(this.components);
            this.btn_thanhcong = new System.Windows.Forms.Button();
            this.progressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.transition_logo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // time_load
            // 
            this.time_load.Interval = 10;
            this.time_load.Tick += new System.EventHandler(this.Time_load_Tick);
            // 
            // btn_thanhcong
            // 
            this.btn_thanhcong.BackColor = System.Drawing.SystemColors.HotTrack;
            this.transition_logo.SetDecoration(this.btn_thanhcong, BunifuAnimatorNS.DecorationType.None);
            this.btn_thanhcong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_thanhcong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thanhcong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhcong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thanhcong.Image = global::Quanlibenhvien_Offical.Properties.Resources.ok_32px;
            this.btn_thanhcong.Location = new System.Drawing.Point(162, 78);
            this.btn_thanhcong.Name = "btn_thanhcong";
            this.btn_thanhcong.Size = new System.Drawing.Size(221, 83);
            this.btn_thanhcong.TabIndex = 1;
            this.btn_thanhcong.Text = "      Thành công ";
            this.btn_thanhcong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thanhcong.UseVisualStyleBackColor = false;
            this.btn_thanhcong.Visible = false;
            this.btn_thanhcong.Click += new System.EventHandler(this.Btn_thanhcong_Click);
            // 
            // progressbar
            // 
            this.progressbar.animated = false;
            this.progressbar.animationIterval = 10;
            this.progressbar.animationSpeed = 30;
            this.progressbar.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.progressbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar.BackgroundImage")));
            this.transition_logo.SetDecoration(this.progressbar, BunifuAnimatorNS.DecorationType.None);
            this.progressbar.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressbar.LabelVisible = false;
            this.progressbar.LineProgressThickness = 8;
            this.progressbar.LineThickness = 5;
            this.progressbar.Location = new System.Drawing.Point(214, 52);
            this.progressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressbar.MaxValue = 100;
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressBackColor = System.Drawing.Color.White;
            this.progressbar.ProgressColor = System.Drawing.SystemColors.HotTrack;
            this.progressbar.Size = new System.Drawing.Size(139, 139);
            this.progressbar.TabIndex = 0;
            this.progressbar.Value = 0;
            // 
            // transition_logo
            // 
            this.transition_logo.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.transition_logo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition_logo.DefaultAnimation = animation1;
            // 
            // ketquathanhcongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(546, 257);
            this.Controls.Add(this.btn_thanhcong);
            this.Controls.Add(this.progressbar);
            this.transition_logo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ketquathanhcongForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ketquathanhcongForm";
            this.Load += new System.EventHandler(this.KetquathanhcongForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar progressbar;
        private System.Windows.Forms.Timer time_load;
        private System.Windows.Forms.Button btn_thanhcong;
        private BunifuAnimatorNS.BunifuTransition transition_logo;
    }
}