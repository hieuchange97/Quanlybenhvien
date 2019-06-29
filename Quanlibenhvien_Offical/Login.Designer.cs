namespace Quanlibenhvien_Offical
{
    partial class Login
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
            this.txt_tendn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_matkhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.progress_login = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer_load = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tendn
            // 
            this.txt_tendn.Depth = 0;
            this.txt_tendn.Hint = "Nhập vào tên đăng nhập";
            this.txt_tendn.Location = new System.Drawing.Point(599, 202);
            this.txt_tendn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.PasswordChar = '\0';
            this.txt_tendn.SelectedText = "";
            this.txt_tendn.SelectionLength = 0;
            this.txt_tendn.SelectionStart = 0;
            this.txt_tendn.Size = new System.Drawing.Size(253, 23);
            this.txt_tendn.TabIndex = 2;
            this.txt_tendn.UseSystemPasswordChar = false;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Depth = 0;
            this.txt_matkhau.Hint = "Nhập vào mật khẩu ";
            this.txt_matkhau.Location = new System.Drawing.Point(599, 287);
            this.txt_matkhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.SelectionLength = 0;
            this.txt_matkhau.SelectionStart = 0;
            this.txt_matkhau.Size = new System.Drawing.Size(253, 23);
            this.txt_matkhau.TabIndex = 3;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Depth = 0;
            this.btn_login.Location = new System.Drawing.Point(599, 356);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(253, 37);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Đăng nhập ";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(630, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đăng nhập hệ thống";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(599, 416);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 9;
            this.lbl_error.Text = "label3";
            this.lbl_error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý bệnh viện đa khoa Hoa Sữa";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 77);
            this.panel1.TabIndex = 10;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_exit.Image = global::Quanlibenhvien_Offical.Properties.Resources.cancel_50px;
            this.btn_exit.ImageActive = null;
            this.btn_exit.Location = new System.Drawing.Point(833, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(48, 39);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_exit.TabIndex = 6;
            this.btn_exit.TabStop = false;
            this.btn_exit.Zoom = 5;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // progress_login
            // 
            this.progress_login.BackColor = System.Drawing.Color.White;
            this.progress_login.BorderRadius = 5;
            this.progress_login.Location = new System.Drawing.Point(602, 470);
            this.progress_login.MaximumValue = 100;
            this.progress_login.Name = "progress_login";
            this.progress_login.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progress_login.Size = new System.Drawing.Size(250, 10);
            this.progress_login.TabIndex = 12;
            this.progress_login.Value = 0;
            this.progress_login.progressChanged += new System.EventHandler(this.BunifuProgressBar1_progressChanged);
            // 
            // timer_load
            // 
            this.timer_load.Interval = 12;
            this.timer_load.Tick += new System.EventHandler(this.Timer_load_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Quanlibenhvien_Offical.Properties.Resources.pexels_photo_273756;
            this.pictureBox1.Location = new System.Drawing.Point(0, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 513);
            this.Controls.Add(this.progress_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Login_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tendn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_matkhau;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_error;
        private Bunifu.Framework.UI.BunifuImageButton btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuProgressBar progress_login;
        private System.Windows.Forms.Timer timer_load;
    }
}