namespace Quanlibenhvien_Offical
{
    partial class nhanvienlamviecF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_nvlv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_idnv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tennv = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.date_bd = new System.Windows.Forms.DateTimePicker();
            this.date_kt = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_nvlv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // data_nvlv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_nvlv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_nvlv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_nvlv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_nvlv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_nvlv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_nvlv.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_nvlv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_nvlv.Location = new System.Drawing.Point(0, 295);
            this.data_nvlv.MultiSelect = false;
            this.data_nvlv.Name = "data_nvlv";
            this.data_nvlv.ReadOnly = true;
            this.data_nvlv.RowHeadersVisible = false;
            this.data_nvlv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_nvlv.Size = new System.Drawing.Size(897, 195);
            this.data_nvlv.TabIndex = 0;
            this.data_nvlv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_nvlv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(341, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(117, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(471, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(117, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày bắt đầu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(471, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày kết thúc :";
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
            this.txt_idnv.Location = new System.Drawing.Point(239, 95);
            this.txt_idnv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idnv.Name = "txt_idnv";
            this.txt_idnv.Size = new System.Drawing.Size(216, 33);
            this.txt_idnv.TabIndex = 61;
            this.txt_idnv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idnv.OnValueChanged += new System.EventHandler(this.Txt_idnv_OnValueChanged);
            // 
            // txt_tennv
            // 
            this.txt_tennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tennv.Enabled = false;
            this.txt_tennv.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tennv.ForeColor = System.Drawing.Color.Black;
            this.txt_tennv.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tennv.HintText = "Trống ";
            this.txt_tennv.isPassword = false;
            this.txt_tennv.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tennv.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tennv.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tennv.LineThickness = 3;
            this.txt_tennv.Location = new System.Drawing.Point(602, 93);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(204, 33);
            this.txt_tennv.TabIndex = 62;
            this.txt_tennv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_bd
            // 
            this.date_bd.Enabled = false;
            this.date_bd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_bd.Location = new System.Drawing.Point(239, 196);
            this.date_bd.Name = "date_bd";
            this.date_bd.Size = new System.Drawing.Size(216, 20);
            this.date_bd.TabIndex = 71;
            // 
            // date_kt
            // 
            this.date_kt.Enabled = false;
            this.date_kt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_kt.Location = new System.Drawing.Point(602, 196);
            this.date_kt.Name = "date_kt";
            this.date_kt.Size = new System.Drawing.Size(204, 20);
            this.date_kt.TabIndex = 72;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_them,
            this.tool_sua,
            this.tool_xoa,
            this.tool_luu,
            this.tool_huy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(897, 25);
            this.toolStrip1.TabIndex = 73;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(61, 22);
            this.tool_them.Text = "Thêm ";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(46, 22);
            this.tool_sua.Text = "Sửa";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(47, 22);
            this.tool_xoa.Text = "Xóa";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(47, 22);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(49, 22);
            this.tool_huy.Text = "Hủy";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // nhanvienlamviecF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 490);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.date_kt);
            this.Controls.Add(this.date_bd);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.txt_idnv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_nvlv);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nhanvienlamviecF";
            this.Text = "Thông tin làm việc nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.data_nvlv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_nvlv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_idnv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tennv;
        private System.Windows.Forms.DateTimePicker date_bd;
        private System.Windows.Forms.DateTimePicker date_kt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_huy;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}