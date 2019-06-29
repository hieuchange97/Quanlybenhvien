namespace Quanlibenhvien_Offical
{
    partial class chucvuUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolMenu = new System.Windows.Forms.ToolStrip();
            this.tool_them = new System.Windows.Forms.ToolStripButton();
            this.tool_sua = new System.Windows.Forms.ToolStripButton();
            this.tool_xoa = new System.Windows.Forms.ToolStripButton();
            this.tool_luu = new System.Windows.Forms.ToolStripButton();
            this.tool_huy = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.data_chucvu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tenchucvu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_idchucvu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.toolMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_chucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 32);
            this.panel2.TabIndex = 63;
            // 
            // toolMenu
            // 
            this.toolMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_them,
            this.tool_sua,
            this.tool_xoa,
            this.tool_luu,
            this.tool_huy});
            this.toolMenu.Location = new System.Drawing.Point(0, 0);
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(1366, 32);
            this.toolMenu.TabIndex = 0;
            this.toolMenu.Text = "toolStrip1";
            // 
            // tool_them
            // 
            this.tool_them.Image = global::Quanlibenhvien_Offical.Properties.Resources.insert_page_30px;
            this.tool_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_them.Name = "tool_them";
            this.tool_them.Size = new System.Drawing.Size(103, 29);
            this.tool_them.Text = "Thêm chức vụ";
            this.tool_them.Click += new System.EventHandler(this.Tool_them_Click);
            // 
            // tool_sua
            // 
            this.tool_sua.Enabled = false;
            this.tool_sua.Image = global::Quanlibenhvien_Offical.Properties.Resources.update_file_30px;
            this.tool_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_sua.Name = "tool_sua";
            this.tool_sua.Size = new System.Drawing.Size(91, 29);
            this.tool_sua.Text = "Sửa chức vụ";
            this.tool_sua.Click += new System.EventHandler(this.Tool_sua_Click);
            // 
            // tool_xoa
            // 
            this.tool_xoa.Enabled = false;
            this.tool_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_30px;
            this.tool_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_xoa.Name = "tool_xoa";
            this.tool_xoa.Size = new System.Drawing.Size(92, 29);
            this.tool_xoa.Text = "Xóa chức vụ";
            this.tool_xoa.Click += new System.EventHandler(this.Tool_xoa_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(47, 29);
            this.tool_luu.Text = "Lưu";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(49, 29);
            this.tool_huy.Text = "Hủy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(545, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "THÔNG TIN CHỨC VỤ ";
            // 
            // data_chucvu
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_chucvu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.data_chucvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_chucvu.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_chucvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.data_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_chucvu.DefaultCellStyle = dataGridViewCellStyle8;
            this.data_chucvu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_chucvu.Location = new System.Drawing.Point(0, 299);
            this.data_chucvu.MultiSelect = false;
            this.data_chucvu.Name = "data_chucvu";
            this.data_chucvu.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_chucvu.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_chucvu.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.data_chucvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_chucvu.Size = new System.Drawing.Size(1366, 349);
            this.data_chucvu.TabIndex = 61;
            this.data_chucvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_chucvu_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 10);
            this.panel1.TabIndex = 60;
            // 
            // txt_tenchucvu
            // 
            this.txt_tenchucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenchucvu.Enabled = false;
            this.txt_tenchucvu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenchucvu.ForeColor = System.Drawing.Color.Black;
            this.txt_tenchucvu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tenchucvu.HintText = "Trống ";
            this.txt_tenchucvu.isPassword = false;
            this.txt_tenchucvu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenchucvu.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tenchucvu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenchucvu.LineThickness = 3;
            this.txt_tenchucvu.Location = new System.Drawing.Point(801, 154);
            this.txt_tenchucvu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenchucvu.Name = "txt_tenchucvu";
            this.txt_tenchucvu.Size = new System.Drawing.Size(253, 33);
            this.txt_tenchucvu.TabIndex = 67;
            this.txt_tenchucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_idchucvu
            // 
            this.txt_idchucvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idchucvu.Enabled = false;
            this.txt_idchucvu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_idchucvu.ForeColor = System.Drawing.Color.Black;
            this.txt_idchucvu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idchucvu.HintText = "Trống ";
            this.txt_idchucvu.isPassword = false;
            this.txt_idchucvu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idchucvu.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_idchucvu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_idchucvu.LineThickness = 3;
            this.txt_idchucvu.Location = new System.Drawing.Point(384, 154);
            this.txt_idchucvu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idchucvu.Name = "txt_idchucvu";
            this.txt_idchucvu.Size = new System.Drawing.Size(251, 33);
            this.txt_idchucvu.TabIndex = 66;
            this.txt_idchucvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_idchucvu.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_idchucvu_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(690, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên chức vụ  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(265, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Mã chức vụ :";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chucvuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_chucvu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_tenchucvu);
            this.Controls.Add(this.txt_idchucvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "chucvuUC";
            this.Size = new System.Drawing.Size(1366, 648);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolMenu.ResumeLayout(false);
            this.toolMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_chucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolMenu;
        private System.Windows.Forms.ToolStripButton tool_them;
        private System.Windows.Forms.ToolStripButton tool_sua;
        private System.Windows.Forms.ToolStripButton tool_xoa;
        private System.Windows.Forms.ToolStripButton tool_luu;
        private System.Windows.Forms.ToolStripButton tool_huy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_chucvu;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tenchucvu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_idchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
