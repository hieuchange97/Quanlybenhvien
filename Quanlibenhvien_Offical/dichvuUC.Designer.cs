namespace Quanlibenhvien_Offical
{
    partial class dichvuUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.data_dichvu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_loc = new System.Windows.Forms.ComboBox();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_iddv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tendv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_maymoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_giatien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_dichvu)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 10);
            this.panel1.TabIndex = 0;
            // 
            // data_dichvu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.data_dichvu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_dichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.data_dichvu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_dichvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_dichvu.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_dichvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_dichvu.GridColor = System.Drawing.Color.Gray;
            this.data_dichvu.Location = new System.Drawing.Point(0, 394);
            this.data_dichvu.MultiSelect = false;
            this.data_dichvu.Name = "data_dichvu";
            this.data_dichvu.ReadOnly = true;
            this.data_dichvu.RowHeadersVisible = false;
            this.data_dichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dichvu.Size = new System.Drawing.Size(1366, 254);
            this.data_dichvu.TabIndex = 4;
            this.data_dichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_dichvu_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 39);
            this.panel2.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_them,
            this.tool_sua,
            this.tool_xoa,
            this.tool_luu,
            this.tool_huy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1366, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(103, 36);
            this.tool_them.Text = "Thêm dịch vụ ";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(91, 36);
            this.tool_sua.Text = "Sửa dịch vụ ";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(92, 36);
            this.tool_xoa.Text = "Xóa dịch vụ ";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(47, 36);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(49, 36);
            this.tool_huy.Text = "Hủy";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.cb_loc);
            this.panel3.Controls.Add(this.txt_search);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1366, 33);
            this.panel3.TabIndex = 6;
            // 
            // cb_loc
            // 
            this.cb_loc.FormattingEnabled = true;
            this.cb_loc.Items.AddRange(new object[] {
            "Tên dịch vụ ",
            "Mã dịch vụ"});
            this.cb_loc.Location = new System.Drawing.Point(457, 6);
            this.cb_loc.Name = "cb_loc";
            this.cb_loc.Size = new System.Drawing.Size(156, 21);
            this.cb_loc.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.Depth = 0;
            this.txt_search.Hint = "Nhập thông tin tìm kiếm dịch vụ";
            this.txt_search.Location = new System.Drawing.Point(619, 4);
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(293, 23);
            this.txt_search.TabIndex = 0;
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(539, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(539, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã dịch vụ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên dịch vụ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Máy móc :";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá tiền  :";
            // 
            // txt_iddv
            // 
            this.txt_iddv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_iddv.Enabled = false;
            this.txt_iddv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_iddv.ForeColor = System.Drawing.Color.Black;
            this.txt_iddv.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_iddv.HintText = "Trống ";
            this.txt_iddv.isPassword = false;
            this.txt_iddv.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_iddv.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_iddv.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_iddv.LineThickness = 3;
            this.txt_iddv.Location = new System.Drawing.Point(518, 97);
            this.txt_iddv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_iddv.Name = "txt_iddv";
            this.txt_iddv.Size = new System.Drawing.Size(301, 33);
            this.txt_iddv.TabIndex = 83;
            this.txt_iddv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_iddv.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_iddv_Validating);
            // 
            // txt_tendv
            // 
            this.txt_tendv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tendv.Enabled = false;
            this.txt_tendv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tendv.ForeColor = System.Drawing.Color.Black;
            this.txt_tendv.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tendv.HintText = "Trống ";
            this.txt_tendv.isPassword = false;
            this.txt_tendv.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tendv.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tendv.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tendv.LineThickness = 3;
            this.txt_tendv.Location = new System.Drawing.Point(518, 149);
            this.txt_tendv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(301, 33);
            this.txt_tendv.TabIndex = 84;
            this.txt_tendv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tendv.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_tendv_Validating);
            // 
            // txt_maymoc
            // 
            this.txt_maymoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maymoc.Enabled = false;
            this.txt_maymoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maymoc.ForeColor = System.Drawing.Color.Black;
            this.txt_maymoc.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_maymoc.HintText = "Trống ";
            this.txt_maymoc.isPassword = false;
            this.txt_maymoc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_maymoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_maymoc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_maymoc.LineThickness = 3;
            this.txt_maymoc.Location = new System.Drawing.Point(518, 198);
            this.txt_maymoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maymoc.Name = "txt_maymoc";
            this.txt_maymoc.Size = new System.Drawing.Size(301, 33);
            this.txt_maymoc.TabIndex = 85;
            this.txt_maymoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_maymoc.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_maymoc_Validating);
            // 
            // txt_giatien
            // 
            this.txt_giatien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giatien.Enabled = false;
            this.txt_giatien.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_giatien.ForeColor = System.Drawing.Color.Black;
            this.txt_giatien.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_giatien.HintText = "Trống ";
            this.txt_giatien.isPassword = false;
            this.txt_giatien.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_giatien.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_giatien.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_giatien.LineThickness = 3;
            this.txt_giatien.Location = new System.Drawing.Point(518, 248);
            this.txt_giatien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(301, 33);
            this.txt_giatien.TabIndex = 86;
            this.txt_giatien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_giatien.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_giatien_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dichvuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_giatien);
            this.Controls.Add(this.txt_maymoc);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.txt_iddv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.data_dichvu);
            this.Controls.Add(this.panel1);
            this.Name = "dichvuUC";
            this.Size = new System.Drawing.Size(1366, 648);
            this.Load += new System.EventHandler(this.DichvuUC_Load);
            this.Click += new System.EventHandler(this.DichvuUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.data_dichvu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_dichvu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_loc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_iddv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tendv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_maymoc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_giatien;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_huy;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
