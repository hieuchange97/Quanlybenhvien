namespace Quanlibenhvien_Offical
{
    partial class quanlykhoaUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_bophan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.txt_searchkhoa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idbp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tenbp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tenTP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_tenTP = new System.Windows.Forms.ComboBox();
            this.date_ngayTL = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_bophan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // data_bophan
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_bophan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.data_bophan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_bophan.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_bophan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data_bophan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_bophan.DefaultCellStyle = dataGridViewCellStyle9;
            this.data_bophan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_bophan.Location = new System.Drawing.Point(0, 417);
            this.data_bophan.MultiSelect = false;
            this.data_bophan.Name = "data_bophan";
            this.data_bophan.ReadOnly = true;
            this.data_bophan.RowHeadersVisible = false;
            this.data_bophan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_bophan.Size = new System.Drawing.Size(1366, 231);
            this.data_bophan.TabIndex = 0;
            this.data_bophan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_bophan_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_search);
            this.panel1.Controls.Add(this.txt_searchkhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 39);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(430, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lọc theo :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cb_search
            // 
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Tên khoa",
            "Mã khoa"});
            this.cb_search.Location = new System.Drawing.Point(521, 12);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(151, 21);
            this.cb_search.TabIndex = 2;
            // 
            // txt_searchkhoa
            // 
            this.txt_searchkhoa.Depth = 0;
            this.txt_searchkhoa.Hint = "Tìm kiếm thông tin";
            this.txt_searchkhoa.Location = new System.Drawing.Point(696, 10);
            this.txt_searchkhoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchkhoa.Name = "txt_searchkhoa";
            this.txt_searchkhoa.PasswordChar = '\0';
            this.txt_searchkhoa.SelectedText = "";
            this.txt_searchkhoa.SelectionLength = 0;
            this.txt_searchkhoa.SelectionStart = 0;
            this.txt_searchkhoa.Size = new System.Drawing.Size(261, 23);
            this.txt_searchkhoa.TabIndex = 1;
            this.txt_searchkhoa.UseSystemPasswordChar = false;
            this.txt_searchkhoa.Click += new System.EventHandler(this.Txt_searchkhoa_Click);
            this.txt_searchkhoa.TextChanged += new System.EventHandler(this.Txt_searchkhoa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(556, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH CHUYÊN KHOA";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(547, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "THÔNG TIN CHUYÊN KHOA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(390, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã bộ phận :";
            // 
            // txt_idbp
            // 
            this.txt_idbp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idbp.Enabled = false;
            this.txt_idbp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_idbp.ForeColor = System.Drawing.Color.Black;
            this.txt_idbp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idbp.HintText = "Trống ";
            this.txt_idbp.isPassword = false;
            this.txt_idbp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idbp.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_idbp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idbp.LineThickness = 3;
            this.txt_idbp.Location = new System.Drawing.Point(508, 108);
            this.txt_idbp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idbp.Name = "txt_idbp";
            this.txt_idbp.Size = new System.Drawing.Size(372, 33);
            this.txt_idbp.TabIndex = 58;
            this.txt_idbp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idbp.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_idbp_Validating);
            // 
            // txt_tenbp
            // 
            this.txt_tenbp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenbp.Enabled = false;
            this.txt_tenbp.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenbp.ForeColor = System.Drawing.Color.Black;
            this.txt_tenbp.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tenbp.HintText = "Trống ";
            this.txt_tenbp.isPassword = false;
            this.txt_tenbp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenbp.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tenbp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenbp.LineThickness = 3;
            this.txt_tenbp.Location = new System.Drawing.Point(508, 166);
            this.txt_tenbp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenbp.Name = "txt_tenbp";
            this.txt_tenbp.Size = new System.Drawing.Size(372, 33);
            this.txt_tenbp.TabIndex = 60;
            this.txt_tenbp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenbp.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_tenbp_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(390, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tên bộ phận :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // lbl_tenTP
            // 
            this.lbl_tenTP.AutoSize = true;
            this.lbl_tenTP.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenTP.Location = new System.Drawing.Point(390, 294);
            this.lbl_tenTP.Name = "lbl_tenTP";
            this.lbl_tenTP.Size = new System.Drawing.Size(112, 15);
            this.lbl_tenTP.TabIndex = 61;
            this.lbl_tenTP.Text = "Tên trưởng phòng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(390, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Ngày thành lập :";
            // 
            // cb_tenTP
            // 
            this.cb_tenTP.Enabled = false;
            this.cb_tenTP.FormattingEnabled = true;
            this.cb_tenTP.Location = new System.Drawing.Point(508, 292);
            this.cb_tenTP.Name = "cb_tenTP";
            this.cb_tenTP.Size = new System.Drawing.Size(187, 21);
            this.cb_tenTP.TabIndex = 64;
            this.cb_tenTP.SelectedIndexChanged += new System.EventHandler(this.Cb_tenTP_SelectedIndexChanged);
            this.cb_tenTP.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_tenTP_Validating);
            // 
            // date_ngayTL
            // 
            this.date_ngayTL.Enabled = false;
            this.date_ngayTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngayTL.Location = new System.Drawing.Point(508, 242);
            this.date_ngayTL.Name = "date_ngayTL";
            this.date_ngayTL.Size = new System.Drawing.Size(187, 20);
            this.date_ngayTL.TabIndex = 65;
            this.date_ngayTL.Value = new System.DateTime(2019, 6, 1, 0, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 37);
            this.panel2.TabIndex = 66;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_them,
            this.toolStripSeparator1,
            this.tool_sua,
            this.toolStripSeparator2,
            this.tool_xoa,
            this.tool_luu,
            this.tool_huy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1366, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(61, 34);
            this.tool_them.Text = "Thêm ";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(46, 34);
            this.tool_sua.Text = "Sửa";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(47, 34);
            this.tool_xoa.Text = "Xóa";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(47, 34);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(49, 34);
            this.tool_huy.Text = "Hủy";
            this.tool_huy.Click += new System.EventHandler(this.Tool_huy_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // quanlykhoaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.date_ngayTL);
            this.Controls.Add(this.cb_tenTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tenTP);
            this.Controls.Add(this.txt_tenbp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idbp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_bophan);
            this.Name = "quanlykhoaUC";
            this.Size = new System.Drawing.Size(1366, 648);
            ((System.ComponentModel.ISupportInitialize)(this.data_bophan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_bophan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_search;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_idbp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tenbp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tenTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_tenTP;
        private System.Windows.Forms.DateTimePicker date_ngayTL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripButton tool_huy;
    }
}
