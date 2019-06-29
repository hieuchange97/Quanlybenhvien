namespace Quanlibenhvien_Offical
{
    partial class bhytForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_tuyenBHYT = new System.Windows.Forms.ComboBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cbbdBHYT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_idBHYT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cb_dtutBHYT = new System.Windows.Forms.ComboBox();
            this.date_ngayhetBHYT = new System.Windows.Forms.DateTimePicker();
            this.date_ngaycap_bhyt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_back = new System.Windows.Forms.ToolStripButton();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.data_bhyt = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_searchbhyt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_infoBN = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_gcv = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bhyt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_tuyenBHYT
            // 
            this.cb_tuyenBHYT.DisplayMember = "TenDT";
            this.cb_tuyenBHYT.Enabled = false;
            this.cb_tuyenBHYT.FormattingEnabled = true;
            this.cb_tuyenBHYT.Location = new System.Drawing.Point(607, 277);
            this.cb_tuyenBHYT.Name = "cb_tuyenBHYT";
            this.cb_tuyenBHYT.Size = new System.Drawing.Size(194, 21);
            this.cb_tuyenBHYT.TabIndex = 123;
            this.cb_tuyenBHYT.ValueMember = "IDdt";
            this.cb_tuyenBHYT.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_tuyenBHYT_Validating);
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(502, 280);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(99, 19);
            this.materialLabel26.TabIndex = 122;
            this.materialLabel26.Text = "Tuyến BHYT :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(385, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 109;
            this.label4.Text = "BẢO HIỂM Y TẾ";
            // 
            // txt_cbbdBHYT
            // 
            this.txt_cbbdBHYT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cbbdBHYT.Enabled = false;
            this.txt_cbbdBHYT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_cbbdBHYT.ForeColor = System.Drawing.Color.Black;
            this.txt_cbbdBHYT.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cbbdBHYT.HintText = "Trống";
            this.txt_cbbdBHYT.isPassword = false;
            this.txt_cbbdBHYT.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txt_cbbdBHYT.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cbbdBHYT.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txt_cbbdBHYT.LineThickness = 3;
            this.txt_cbbdBHYT.Location = new System.Drawing.Point(277, 168);
            this.txt_cbbdBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cbbdBHYT.Name = "txt_cbbdBHYT";
            this.txt_cbbdBHYT.Size = new System.Drawing.Size(388, 33);
            this.txt_cbbdBHYT.TabIndex = 119;
            this.txt_cbbdBHYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cbbdBHYT.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_cbbdBHYT_Validating);
            // 
            // txt_idBHYT
            // 
            this.txt_idBHYT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idBHYT.Enabled = false;
            this.txt_idBHYT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_idBHYT.ForeColor = System.Drawing.Color.Black;
            this.txt_idBHYT.HintForeColor = System.Drawing.Color.Empty;
            this.txt_idBHYT.HintText = "Trống";
            this.txt_idBHYT.isPassword = false;
            this.txt_idBHYT.LineFocusedColor = System.Drawing.Color.Khaki;
            this.txt_idBHYT.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_idBHYT.LineMouseHoverColor = System.Drawing.Color.Khaki;
            this.txt_idBHYT.LineThickness = 3;
            this.txt_idBHYT.Location = new System.Drawing.Point(277, 126);
            this.txt_idBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idBHYT.Name = "txt_idBHYT";
            this.txt_idBHYT.Size = new System.Drawing.Size(388, 35);
            this.txt_idBHYT.TabIndex = 118;
            this.txt_idBHYT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idBHYT.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_idBHYT_Validating);
            // 
            // cb_dtutBHYT
            // 
            this.cb_dtutBHYT.DisplayMember = "TenDT";
            this.cb_dtutBHYT.Enabled = false;
            this.cb_dtutBHYT.FormattingEnabled = true;
            this.cb_dtutBHYT.Location = new System.Drawing.Point(277, 277);
            this.cb_dtutBHYT.Name = "cb_dtutBHYT";
            this.cb_dtutBHYT.Size = new System.Drawing.Size(204, 21);
            this.cb_dtutBHYT.TabIndex = 116;
            this.cb_dtutBHYT.ValueMember = "IDdt";
            this.cb_dtutBHYT.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_dtutBHYT_Validating);
            // 
            // date_ngayhetBHYT
            // 
            this.date_ngayhetBHYT.Enabled = false;
            this.date_ngayhetBHYT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayhetBHYT.Location = new System.Drawing.Point(548, 230);
            this.date_ngayhetBHYT.Name = "date_ngayhetBHYT";
            this.date_ngayhetBHYT.Size = new System.Drawing.Size(117, 20);
            this.date_ngayhetBHYT.TabIndex = 115;
            this.date_ngayhetBHYT.Validating += new System.ComponentModel.CancelEventHandler(this.Date_ngayhetBHYT_Validating);
            // 
            // date_ngaycap_bhyt
            // 
            this.date_ngaycap_bhyt.Enabled = false;
            this.date_ngaycap_bhyt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaycap_bhyt.Location = new System.Drawing.Point(277, 230);
            this.date_ngaycap_bhyt.Name = "date_ngaycap_bhyt";
            this.date_ngaycap_bhyt.Size = new System.Drawing.Size(117, 20);
            this.date_ngaycap_bhyt.TabIndex = 114;
            this.date_ngaycap_bhyt.Validating += new System.ComponentModel.CancelEventHandler(this.Date_ngaycap_bhyt_Validating);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(144, 280);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(133, 19);
            this.materialLabel14.TabIndex = 113;
            this.materialLabel14.Text = "Đối tượng ưu tiên :";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(425, 232);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(104, 19);
            this.materialLabel12.TabIndex = 112;
            this.materialLabel12.Text = "Ngày hết hạn :";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(144, 232);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(79, 19);
            this.materialLabel11.TabIndex = 111;
            this.materialLabel11.Text = "Ngày cấp :";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(144, 183);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(111, 19);
            this.materialLabel10.TabIndex = 110;
            this.materialLabel10.Text = "Nơi ĐKKCBBĐ :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(142, 143);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(80, 19);
            this.materialLabel8.TabIndex = 108;
            this.materialLabel8.Text = "Mã BHYT :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_back,
            this.tool_them,
            this.tool_sua,
            this.tool_xoa,
            this.tool_luu,
            this.tool_huy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 28);
            this.toolStrip1.TabIndex = 124;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip1_ItemClicked);
            // 
            // tool_back
            // 
            this.tool_back.Image = global::Quanlibenhvien_Offical.Properties.Resources.cancel_30px1;
            this.tool_back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_back.Name = "tool_back";
            this.tool_back.Size = new System.Drawing.Size(84, 25);
            this.tool_back.Text = "Quay lại";
            this.tool_back.Click += new System.EventHandler(this.Tool_back_Click);
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(67, 25);
            this.tool_them.Text = "Thêm";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(59, 25);
            this.tool_sua.Text = "Sửa";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(57, 25);
            this.tool_xoa.Text = "Xóa";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(56, 25);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(54, 25);
            this.tool_huy.Text = "Hủy";
            this.tool_huy.Click += new System.EventHandler(this.Tool_huy_Click);
            // 
            // data_bhyt
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_bhyt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_bhyt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bhyt.BackgroundColor = System.Drawing.Color.White;
            this.data_bhyt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_bhyt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_bhyt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_bhyt.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_bhyt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_bhyt.Location = new System.Drawing.Point(0, 450);
            this.data_bhyt.MultiSelect = false;
            this.data_bhyt.Name = "data_bhyt";
            this.data_bhyt.ReadOnly = true;
            this.data_bhyt.RowHeadersVisible = false;
            this.data_bhyt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_bhyt.Size = new System.Drawing.Size(888, 177);
            this.data_bhyt.TabIndex = 125;
            this.data_bhyt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_bhyt_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(323, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 126;
            this.label1.Text = "DANH SÁCH BẢO HIỂM Y TẾ ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txt_searchbhyt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 32);
            this.panel1.TabIndex = 127;
            // 
            // txt_searchbhyt
            // 
            this.txt_searchbhyt.Depth = 0;
            this.txt_searchbhyt.Hint = "Nhập vào mã bảo hiểm y tế";
            this.txt_searchbhyt.Location = new System.Drawing.Point(327, 3);
            this.txt_searchbhyt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchbhyt.Name = "txt_searchbhyt";
            this.txt_searchbhyt.PasswordChar = '\0';
            this.txt_searchbhyt.SelectedText = "";
            this.txt_searchbhyt.SelectionLength = 0;
            this.txt_searchbhyt.SelectionStart = 0;
            this.txt_searchbhyt.Size = new System.Drawing.Size(285, 23);
            this.txt_searchbhyt.TabIndex = 0;
            this.txt_searchbhyt.UseSystemPasswordChar = false;
            this.txt_searchbhyt.TextChanged += new System.EventHandler(this.Txt_searchbhyt_TextChanged);
            // 
            // lbl_infoBN
            // 
            this.lbl_infoBN.AutoSize = true;
            this.lbl_infoBN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_infoBN.Location = new System.Drawing.Point(12, 71);
            this.lbl_infoBN.Name = "lbl_infoBN";
            this.lbl_infoBN.Size = new System.Drawing.Size(47, 16);
            this.lbl_infoBN.TabIndex = 128;
            this.lbl_infoBN.Text = "label2";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 31);
            this.panel2.TabIndex = 129;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 28);
            this.panel3.TabIndex = 130;
            // 
            // btn_gcv
            // 
            this.btn_gcv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_gcv.Enabled = false;
            this.btn_gcv.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_gcv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_gcv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_gcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gcv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_gcv.ForeColor = System.Drawing.Color.White;
            this.btn_gcv.Location = new System.Drawing.Point(277, 322);
            this.btn_gcv.Name = "btn_gcv";
            this.btn_gcv.Size = new System.Drawing.Size(204, 31);
            this.btn_gcv.TabIndex = 131;
            this.btn_gcv.Text = "Xem thông tin giấy chuyển viện";
            this.btn_gcv.UseVisualStyleBackColor = false;
            this.btn_gcv.Click += new System.EventHandler(this.Btn_gcv_Click);
            // 
            // bhytForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 627);
            this.Controls.Add(this.btn_gcv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_infoBN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_bhyt);
            this.Controls.Add(this.cb_tuyenBHYT);
            this.Controls.Add(this.materialLabel26);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cbbdBHYT);
            this.Controls.Add(this.txt_idBHYT);
            this.Controls.Add(this.cb_dtutBHYT);
            this.Controls.Add(this.date_ngayhetBHYT);
            this.Controls.Add(this.date_ngaycap_bhyt);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bhytForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BhytForm_Load);
            this.Click += new System.EventHandler(this.BhytForm_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_bhyt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tuyenBHYT;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cbbdBHYT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_idBHYT;
        private System.Windows.Forms.ComboBox cb_dtutBHYT;
        private System.Windows.Forms.DateTimePicker date_ngayhetBHYT;
        private System.Windows.Forms.DateTimePicker date_ngaycap_bhyt;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripButton tool_back;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_huy;
        private System.Windows.Forms.DataGridView data_bhyt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchbhyt;
        private System.Windows.Forms.Label lbl_infoBN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_gcv;
    }
}