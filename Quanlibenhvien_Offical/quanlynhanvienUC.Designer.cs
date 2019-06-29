namespace Quanlibenhvien_Offical
{
    partial class quanlynhanvienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlynhanvienUC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolmenu = new System.Windows.Forms.ToolStrip();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_capTK = new System.Windows.Forms.ToolStripButton();
            this.tool_ttlv = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.data_nhanvien = new System.Windows.Forms.DataGridView();
            this.txt_idnv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_xaphuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_trinhdo = new System.Windows.Forms.ComboBox();
            this.cb_bophan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_loc = new System.Windows.Forms.ComboBox();
            this.txt_seachNV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chck_nam = new System.Windows.Forms.CheckBox();
            this.chck_nu = new System.Windows.Forms.CheckBox();
            this.lbl_tendn = new System.Windows.Forms.Label();
            this.txt_tendn = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_matkhau = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.cb_quyen = new System.Windows.Forms.ComboBox();
            this.lbl_tenquyen = new System.Windows.Forms.Label();
            this.txt_sdt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.chck_TK = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_quanhuyen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tinhthanh = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.toolmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 40);
            this.panel1.TabIndex = 0;
            // 
            // toolmenu
            // 
            this.toolmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_them,
            this.tool_sua,
            this.tool_xoa,
            this.tool_capTK,
            this.tool_ttlv,
            this.tool_luu,
            this.tool_huy});
            this.toolmenu.Location = new System.Drawing.Point(0, 0);
            this.toolmenu.Name = "toolmenu";
            this.toolmenu.Size = new System.Drawing.Size(1366, 40);
            this.toolmenu.TabIndex = 0;
            this.toolmenu.Text = "toolStrip1";
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(58, 37);
            this.tool_them.Text = "Thêm";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(46, 37);
            this.tool_sua.Text = "Sửa";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(47, 37);
            this.tool_xoa.Text = "Xóa";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_capTK
            // 
            this.tool_capTK.Enabled = false;
            this.tool_capTK.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_capTK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_capTK.Name = "tool_capTK";
            this.tool_capTK.Size = new System.Drawing.Size(103, 37);
            this.tool_capTK.Text = "Cấp tài khoản ";
            this.tool_capTK.Click += new System.EventHandler(this.Tool_capTK_Click);
            // 
            // tool_ttlv
            // 
            this.tool_ttlv.Enabled = false;
            this.tool_ttlv.Image = global::Quanlibenhvien_Offical.Properties.Resources.foul_30px;
            this.tool_ttlv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_ttlv.Name = "tool_ttlv";
            this.tool_ttlv.Size = new System.Drawing.Size(129, 37);
            this.tool_ttlv.Text = "Thông tin làm việc ";
            this.tool_ttlv.Click += new System.EventHandler(this.Tool_ttlv_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(47, 37);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(49, 37);
            this.tool_huy.Text = "Hủy";
            this.tool_huy.Click += new System.EventHandler(this.Tool_huy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(570, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // data_nhanvien
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_nhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_nhanvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_nhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_nhanvien.Location = new System.Drawing.Point(0, 479);
            this.data_nhanvien.MultiSelect = false;
            this.data_nhanvien.Name = "data_nhanvien";
            this.data_nhanvien.ReadOnly = true;
            this.data_nhanvien.RowHeadersVisible = false;
            this.data_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_nhanvien.Size = new System.Drawing.Size(1366, 169);
            this.data_nhanvien.TabIndex = 4;
            this.data_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_nhanvien_CellClick);
            // 
            // txt_idnv
            // 
            this.txt_idnv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idnv.Enabled = false;
            this.txt_idnv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_idnv.ForeColor = System.Drawing.Color.Black;
            this.txt_idnv.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idnv.HintText = "Trống ";
            this.txt_idnv.isPassword = false;
            this.txt_idnv.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idnv.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_idnv.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idnv.LineThickness = 3;
            this.txt_idnv.Location = new System.Drawing.Point(299, 82);
            this.txt_idnv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idnv.Name = "txt_idnv";
            this.txt_idnv.Size = new System.Drawing.Size(204, 33);
            this.txt_idnv.TabIndex = 60;
            this.txt_idnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idnv.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_idnv_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(181, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Mã nhân viên :";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_hoten.ForeColor = System.Drawing.Color.Black;
            this.txt_hoten.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_hoten.HintText = "Trống ";
            this.txt_hoten.isPassword = false;
            this.txt_hoten.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_hoten.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_hoten.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_hoten.LineThickness = 3;
            this.txt_hoten.Location = new System.Drawing.Point(607, 82);
            this.txt_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(432, 33);
            this.txt_hoten.TabIndex = 62;
            this.txt_hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hoten.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_hoten_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(528, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 61;
            this.label1.Text = "Họ và tên :";
            // 
            // txt_xaphuong
            // 
            this.txt_xaphuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_xaphuong.Enabled = false;
            this.txt_xaphuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_xaphuong.ForeColor = System.Drawing.Color.Black;
            this.txt_xaphuong.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_xaphuong.HintText = "Trống ";
            this.txt_xaphuong.isPassword = false;
            this.txt_xaphuong.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_xaphuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_xaphuong.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_xaphuong.LineThickness = 3;
            this.txt_xaphuong.Location = new System.Drawing.Point(607, 129);
            this.txt_xaphuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xaphuong.Name = "txt_xaphuong";
            this.txt_xaphuong.Size = new System.Drawing.Size(173, 33);
            this.txt_xaphuong.TabIndex = 64;
            this.txt_xaphuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_xaphuong.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_xaphuong_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(528, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Xã phường :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(528, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Trình độ :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(181, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Chức vụ :";
            // 
            // cb_trinhdo
            // 
            this.cb_trinhdo.Enabled = false;
            this.cb_trinhdo.FormattingEnabled = true;
            this.cb_trinhdo.Items.AddRange(new object[] {
            "Trung cấp",
            "Cao đẳng ",
            "Đại học ",
            "Cao học ",
            "Thạc sỹ",
            "Tiến sỹ ",
            "Phó giáo sư",
            "Giáo sư "});
            this.cb_trinhdo.Location = new System.Drawing.Point(607, 197);
            this.cb_trinhdo.Name = "cb_trinhdo";
            this.cb_trinhdo.Size = new System.Drawing.Size(222, 21);
            this.cb_trinhdo.TabIndex = 68;
            this.cb_trinhdo.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_trinhdo_Validating);
            // 
            // cb_bophan
            // 
            this.cb_bophan.Enabled = false;
            this.cb_bophan.FormattingEnabled = true;
            this.cb_bophan.Location = new System.Drawing.Point(1001, 198);
            this.cb_bophan.Name = "cb_bophan";
            this.cb_bophan.Size = new System.Drawing.Size(222, 21);
            this.cb_bophan.TabIndex = 70;
            this.cb_bophan.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_bophan_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(877, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Bộ phận làm việc :";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cb_loc);
            this.panel2.Controls.Add(this.txt_seachNV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 46);
            this.panel2.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(392, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Lọc theo :";
            // 
            // cb_loc
            // 
            this.cb_loc.FormattingEnabled = true;
            this.cb_loc.Items.AddRange(new object[] {
            "Tên nhân viên",
            "Mã nhân viên",
            "Chức vụ "});
            this.cb_loc.Location = new System.Drawing.Point(489, 14);
            this.cb_loc.Name = "cb_loc";
            this.cb_loc.Size = new System.Drawing.Size(146, 21);
            this.cb_loc.TabIndex = 73;
            // 
            // txt_seachNV
            // 
            this.txt_seachNV.Depth = 0;
            this.txt_seachNV.Hint = "Nhập thông tin tìm kiếm nhân viên";
            this.txt_seachNV.Location = new System.Drawing.Point(659, 14);
            this.txt_seachNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_seachNV.Name = "txt_seachNV";
            this.txt_seachNV.PasswordChar = '\0';
            this.txt_seachNV.SelectedText = "";
            this.txt_seachNV.SelectionLength = 0;
            this.txt_seachNV.SelectionStart = 0;
            this.txt_seachNV.Size = new System.Drawing.Size(270, 23);
            this.txt_seachNV.TabIndex = 0;
            this.txt_seachNV.UseSystemPasswordChar = false;
            this.txt_seachNV.Click += new System.EventHandler(this.Txt_seachNV_Click);
            this.txt_seachNV.TextChanged += new System.EventHandler(this.Txt_seachNV_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(570, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 24);
            this.label8.TabIndex = 72;
            this.label8.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(1063, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "Giới tính :";
            // 
            // chck_nam
            // 
            this.chck_nam.AutoSize = true;
            this.chck_nam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chck_nam.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chck_nam.Location = new System.Drawing.Point(1164, 95);
            this.chck_nam.Name = "chck_nam";
            this.chck_nam.Size = new System.Drawing.Size(59, 20);
            this.chck_nam.TabIndex = 74;
            this.chck_nam.Text = "Nam";
            this.chck_nam.UseVisualStyleBackColor = true;
            this.chck_nam.CheckStateChanged += new System.EventHandler(this.Chck_nam_CheckStateChanged);
            // 
            // chck_nu
            // 
            this.chck_nu.AutoSize = true;
            this.chck_nu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chck_nu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chck_nu.Location = new System.Drawing.Point(1229, 96);
            this.chck_nu.Name = "chck_nu";
            this.chck_nu.Size = new System.Drawing.Size(49, 20);
            this.chck_nu.TabIndex = 75;
            this.chck_nu.Text = "Nữ";
            this.chck_nu.UseVisualStyleBackColor = true;
            this.chck_nu.CheckStateChanged += new System.EventHandler(this.Chck_nu_CheckStateChanged);
            // 
            // lbl_tendn
            // 
            this.lbl_tendn.AutoSize = true;
            this.lbl_tendn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tendn.Location = new System.Drawing.Point(181, 300);
            this.lbl_tendn.Name = "lbl_tendn";
            this.lbl_tendn.Size = new System.Drawing.Size(101, 16);
            this.lbl_tendn.TabIndex = 76;
            this.lbl_tendn.Text = "Tên đăng nhập :";
            this.lbl_tendn.Visible = false;
            // 
            // txt_tendn
            // 
            this.txt_tendn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tendn.Enabled = false;
            this.txt_tendn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tendn.ForeColor = System.Drawing.Color.Black;
            this.txt_tendn.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tendn.HintText = "Trống ";
            this.txt_tendn.isPassword = false;
            this.txt_tendn.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tendn.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tendn.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tendn.LineThickness = 3;
            this.txt_tendn.Location = new System.Drawing.Point(295, 283);
            this.txt_tendn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(222, 33);
            this.txt_tendn.TabIndex = 77;
            this.txt_tendn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tendn.Visible = false;
            this.txt_tendn.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_tendn_Validating);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.Enabled = false;
            this.txt_matkhau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.Black;
            this.txt_matkhau.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_matkhau.HintText = "Trống ";
            this.txt_matkhau.isPassword = false;
            this.txt_matkhau.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_matkhau.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_matkhau.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_matkhau.LineThickness = 3;
            this.txt_matkhau.Location = new System.Drawing.Point(607, 288);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(222, 33);
            this.txt_matkhau.TabIndex = 79;
            this.txt_matkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_matkhau.Visible = false;
            this.txt_matkhau.OnValueChanged += new System.EventHandler(this.Txt_matkhau_OnValueChanged);
            this.txt_matkhau.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_matkhau_Validating);
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_matkhau.Location = new System.Drawing.Point(528, 305);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(74, 16);
            this.lbl_matkhau.TabIndex = 78;
            this.lbl_matkhau.Text = "Mật khẩu  :";
            this.lbl_matkhau.Visible = false;
            // 
            // cb_quyen
            // 
            this.cb_quyen.Enabled = false;
            this.cb_quyen.FormattingEnabled = true;
            this.cb_quyen.Items.AddRange(new object[] {
            "Trung cấp",
            "Cao đẳng ",
            "Đại học ",
            "Cao học ",
            "Thạc sỹ",
            "Tiến sỹ ",
            "Phó giáo sư",
            "Giáo sư "});
            this.cb_quyen.Location = new System.Drawing.Point(1001, 300);
            this.cb_quyen.Name = "cb_quyen";
            this.cb_quyen.Size = new System.Drawing.Size(222, 21);
            this.cb_quyen.TabIndex = 81;
            this.cb_quyen.Visible = false;
            this.cb_quyen.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_quyen_Validating);
            // 
            // lbl_tenquyen
            // 
            this.lbl_tenquyen.AutoSize = true;
            this.lbl_tenquyen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenquyen.Location = new System.Drawing.Point(877, 305);
            this.lbl_tenquyen.Name = "lbl_tenquyen";
            this.lbl_tenquyen.Size = new System.Drawing.Size(80, 16);
            this.lbl_tenquyen.TabIndex = 80;
            this.lbl_tenquyen.Text = "Tên quyền  :";
            this.lbl_tenquyen.Visible = false;
            this.lbl_tenquyen.Click += new System.EventHandler(this.Label13_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sdt.ForeColor = System.Drawing.Color.Black;
            this.txt_sdt.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_sdt.HintText = "Trống ";
            this.txt_sdt.isPassword = false;
            this.txt_sdt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_sdt.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_sdt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_sdt.LineThickness = 3;
            this.txt_sdt.Location = new System.Drawing.Point(299, 129);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(204, 33);
            this.txt_sdt.TabIndex = 83;
            this.txt_sdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sdt.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_sdt_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(181, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Số điện thoại :";
            // 
            // chck_TK
            // 
            this.chck_TK.AutoSize = true;
            this.chck_TK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chck_TK.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.chck_TK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chck_TK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.chck_TK.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chck_TK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chck_TK.Location = new System.Drawing.Point(299, 245);
            this.chck_TK.Name = "chck_TK";
            this.chck_TK.Size = new System.Drawing.Size(208, 26);
            this.chck_TK.TabIndex = 86;
            this.chck_TK.Text = "Tài khoản hệ thống";
            this.chck_TK.UseVisualStyleBackColor = true;
            this.chck_TK.CheckedChanged += new System.EventHandler(this.Chck_TK_OnChange);
            this.chck_TK.CheckStateChanged += new System.EventHandler(this.Chck_TK_CheckStateChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // txt_quanhuyen
            // 
            this.txt_quanhuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quanhuyen.Enabled = false;
            this.txt_quanhuyen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_quanhuyen.ForeColor = System.Drawing.Color.Black;
            this.txt_quanhuyen.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_quanhuyen.HintText = "Trống ";
            this.txt_quanhuyen.isPassword = false;
            this.txt_quanhuyen.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_quanhuyen.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_quanhuyen.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_quanhuyen.LineThickness = 3;
            this.txt_quanhuyen.Location = new System.Drawing.Point(880, 129);
            this.txt_quanhuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_quanhuyen.Name = "txt_quanhuyen";
            this.txt_quanhuyen.Size = new System.Drawing.Size(161, 33);
            this.txt_quanhuyen.TabIndex = 88;
            this.txt_quanhuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quanhuyen.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_quanhuyen_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(787, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Quận huyện :";
            // 
            // txt_tinhthanh
            // 
            this.txt_tinhthanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tinhthanh.Enabled = false;
            this.txt_tinhthanh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tinhthanh.ForeColor = System.Drawing.Color.Black;
            this.txt_tinhthanh.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tinhthanh.HintText = "Trống ";
            this.txt_tinhthanh.isPassword = false;
            this.txt_tinhthanh.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tinhthanh.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tinhthanh.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tinhthanh.LineThickness = 3;
            this.txt_tinhthanh.Location = new System.Drawing.Point(1164, 129);
            this.txt_tinhthanh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tinhthanh.Name = "txt_tinhthanh";
            this.txt_tinhthanh.Size = new System.Drawing.Size(168, 33);
            this.txt_tinhthanh.TabIndex = 90;
            this.txt_tinhthanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tinhthanh.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_tinhthanh_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(1063, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "Tỉnh thành phố :";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.Enabled = false;
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.Location = new System.Drawing.Point(299, 196);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(173, 21);
            this.cb_chucvu.TabIndex = 91;
            // 
            // quanlynhanvienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_chucvu);
            this.Controls.Add(this.txt_tinhthanh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_quanhuyen);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chck_TK);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_quyen);
            this.Controls.Add(this.lbl_tenquyen);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.lbl_tendn);
            this.Controls.Add(this.chck_nu);
            this.Controls.Add(this.chck_nam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cb_bophan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_trinhdo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_xaphuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_nhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "quanlynhanvienUC";
            this.Size = new System.Drawing.Size(1366, 648);
            this.Load += new System.EventHandler(this.QuanlynhanvienUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolmenu.ResumeLayout(false);
            this.toolmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolmenu;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_huy;
        private System.Windows.Forms.DataGridView data_nhanvien;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_idnv;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_hoten;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_xaphuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_trinhdo;
        private System.Windows.Forms.ComboBox cb_bophan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_loc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_seachNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chck_nam;
        private System.Windows.Forms.CheckBox chck_nu;
        private System.Windows.Forms.Label lbl_tendn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tendn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_matkhau;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.ComboBox cb_quyen;
        private System.Windows.Forms.Label lbl_tenquyen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_sdt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chck_TK;
        private System.Windows.Forms.ToolStripButton tool_capTK;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tinhthanh;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_quanhuyen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton tool_ttlv;
        private System.Windows.Forms.ComboBox cb_chucvu;
    }
}
