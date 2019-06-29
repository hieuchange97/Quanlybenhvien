namespace Quanlibenhvien_Offical
{
    partial class kedonthuoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstbox_searchTH = new System.Windows.Forms.ListBox();
            this.btn_themthuoc = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_capnhat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Cb_searchthuoc = new System.Windows.Forms.ComboBox();
            this.tHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlibenhvien_officalDataSet = new Quanlibenhvien_Offical.Quanlibenhvien_officalDataSet();
            this.data_kedonthuoc = new System.Windows.Forms.DataGridView();
            this.STT_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDthuoc_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc_dt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DVT_dt = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lieudung_dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHUOCTableAdapter = new Quanlibenhvien_Offical.Quanlibenhvien_officalDataSetTableAdapters.THUOCTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlibenhvien_officalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_kedonthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 36);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP ĐƠN THUỐC CHO BỆNH NHÂN";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lstbox_searchTH);
            this.panel2.Controls.Add(this.btn_themthuoc);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Cb_searchthuoc);
            this.panel2.Controls.Add(this.data_kedonthuoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 557);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lstbox_searchTH
            // 
            this.lstbox_searchTH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbox_searchTH.FormattingEnabled = true;
            this.lstbox_searchTH.ItemHeight = 14;
            this.lstbox_searchTH.Location = new System.Drawing.Point(279, 230);
            this.lstbox_searchTH.Name = "lstbox_searchTH";
            this.lstbox_searchTH.Size = new System.Drawing.Size(188, 84);
            this.lstbox_searchTH.TabIndex = 10;
            this.lstbox_searchTH.Visible = false;
            this.lstbox_searchTH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lstbox_searchTH_KeyDown);
            // 
            // btn_themthuoc
            // 
            this.btn_themthuoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_themthuoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_themthuoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_themthuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_themthuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themthuoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themthuoc.ForeColor = System.Drawing.Color.White;
            this.btn_themthuoc.Location = new System.Drawing.Point(501, 196);
            this.btn_themthuoc.Name = "btn_themthuoc";
            this.btn_themthuoc.Size = new System.Drawing.Size(257, 28);
            this.btn_themthuoc.TabIndex = 8;
            this.btn_themthuoc.Text = "Thêm vào đơn thuốc ";
            this.btn_themthuoc.UseVisualStyleBackColor = false;
            this.btn_themthuoc.Click += new System.EventHandler(this.Btn_themthuoc_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1033, 37);
            this.panel3.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_capnhat,
            this.toolStripSeparator2,
            this.btn_xoa,
            this.toolStripSeparator1,
            this.btn_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1033, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_capnhat.Enabled = false;
            this.btn_capnhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Image = global::Quanlibenhvien_Offical.Properties.Resources.refresh_30px;
            this.btn_capnhat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_capnhat.ImageTransparentColor = System.Drawing.Color.SlateGray;
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(102, 34);
            this.btn_capnhat.Text = "Cập nhập ";
            this.btn_capnhat.Click += new System.EventHandler(this.Btn_capnhat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = false;
            this.btn_xoa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Image = global::Quanlibenhvien_Offical.Properties.Resources.cancel_30pppx;
            this.btn_xoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.SlateGray;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 34);
            this.btn_xoa.Text = "  Xóa ";
            this.btn_xoa.Click += new System.EventHandler(this.Btn_xoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = false;
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_as_30px;
            this.btn_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.SlateGray;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 34);
            this.btn_save.Text = "Lưu ";
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(87, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm tên thuốc :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Cb_searchthuoc
            // 
            this.Cb_searchthuoc.DataSource = this.tHUOCBindingSource;
            this.Cb_searchthuoc.DisplayMember = "Tenthuoc";
            this.Cb_searchthuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_searchthuoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Cb_searchthuoc.FormattingEnabled = true;
            this.Cb_searchthuoc.ItemHeight = 18;
            this.Cb_searchthuoc.Location = new System.Drawing.Point(279, 198);
            this.Cb_searchthuoc.Name = "Cb_searchthuoc";
            this.Cb_searchthuoc.Size = new System.Drawing.Size(188, 26);
            this.Cb_searchthuoc.TabIndex = 3;
            this.Cb_searchthuoc.ValueMember = "IDthuoc";
            this.Cb_searchthuoc.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.Cb_searchthuoc.TextUpdate += new System.EventHandler(this.Cb_searchthuoc_TextUpdate);
            this.Cb_searchthuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_searchthuoc_KeyDown);
            // 
            // tHUOCBindingSource
            // 
            this.tHUOCBindingSource.DataMember = "THUOC";
            this.tHUOCBindingSource.DataSource = this.quanlibenhvien_officalDataSet;
            // 
            // quanlibenhvien_officalDataSet
            // 
            this.quanlibenhvien_officalDataSet.DataSetName = "Quanlibenhvien_officalDataSet";
            this.quanlibenhvien_officalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_kedonthuoc
            // 
            this.data_kedonthuoc.BackgroundColor = System.Drawing.Color.White;
            this.data_kedonthuoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_kedonthuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_kedonthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_kedonthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_dt,
            this.IDthuoc_dt,
            this.tenthuoc_dt,
            this.DVT_dt,
            this.soluong,
            this.lieudung_dt});
            this.data_kedonthuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_kedonthuoc.Location = new System.Drawing.Point(0, 246);
            this.data_kedonthuoc.Name = "data_kedonthuoc";
            this.data_kedonthuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_kedonthuoc.Size = new System.Drawing.Size(1033, 311);
            this.data_kedonthuoc.TabIndex = 2;
            this.data_kedonthuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_kedonthuoc_CellClick);
            this.data_kedonthuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_kedonthuoc_CellContentClick);
            this.data_kedonthuoc.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellValidated);
            this.data_kedonthuoc.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellValueChanged);
            this.data_kedonthuoc.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Data_kedonthuoc_DataError);
            this.data_kedonthuoc.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Data_kedonthuoc_EditingControlShowing);
            // 
            // STT_dt
            // 
            this.STT_dt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.STT_dt.HeaderText = "STT";
            this.STT_dt.Name = "STT_dt";
            this.STT_dt.ReadOnly = true;
            this.STT_dt.ToolTipText = "Số thứ tự";
            this.STT_dt.Width = 51;
            // 
            // IDthuoc_dt
            // 
            this.IDthuoc_dt.HeaderText = "Mã thuốc";
            this.IDthuoc_dt.Name = "IDthuoc_dt";
            this.IDthuoc_dt.ReadOnly = true;
            this.IDthuoc_dt.Width = 188;
            // 
            // tenthuoc_dt
            // 
            this.tenthuoc_dt.DataSource = this.tHUOCBindingSource;
            this.tenthuoc_dt.DisplayMember = "Tenthuoc";
            this.tenthuoc_dt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tenthuoc_dt.HeaderText = "Tên thuốc";
            this.tenthuoc_dt.Name = "tenthuoc_dt";
            this.tenthuoc_dt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenthuoc_dt.ValueMember = "IDthuoc";
            this.tenthuoc_dt.Width = 188;
            // 
            // DVT_dt
            // 
            this.DVT_dt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DVT_dt.HeaderText = "Đơn vị tính";
            this.DVT_dt.Items.AddRange(new object[] {
            "Viên",
            "Chai",
            "Hộp",
            "Lọ",
            "Bìa",
            "Vỉ"});
            this.DVT_dt.Name = "DVT_dt";
            this.DVT_dt.Width = 187;
            // 
            // soluong
            // 
            this.soluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MaxDropDownItems = 5;
            this.soluong.Name = "soluong";
            this.soluong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.soluong.Width = 188;
            // 
            // lieudung_dt
            // 
            this.lieudung_dt.HeaderText = "Liều dùng";
            this.lieudung_dt.Name = "lieudung_dt";
            this.lieudung_dt.Width = 188;
            // 
            // tHUOCTableAdapter
            // 
            this.tHUOCTableAdapter.ClearBeforeFill = true;
            // 
            // kedonthuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "kedonthuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Kedonthuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlibenhvien_officalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_kedonthuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_kedonthuoc;
        private Quanlibenhvien_officalDataSet quanlibenhvien_officalDataSet;
        private System.Windows.Forms.BindingSource tHUOCBindingSource;
        private Quanlibenhvien_officalDataSetTableAdapters.THUOCTableAdapter tHUOCTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cb_searchthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDthuoc_dt;
        private System.Windows.Forms.DataGridViewComboBoxColumn tenthuoc_dt;
        private System.Windows.Forms.DataGridViewComboBoxColumn DVT_dt;
        private System.Windows.Forms.DataGridViewComboBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieudung_dt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_capnhat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.Button btn_themthuoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ListBox lstbox_searchTH;
    }
}