namespace Quanlibenhvien_Offical
{
    partial class quanlyphongbanUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuPhongban = new System.Windows.Forms.MenuStrip();
            this.toolmn_PB = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_themPB = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_suaPB = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_xoaPB = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_luu = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_huy = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cb_Khoa = new System.Windows.Forms.ComboBox();
            this.txt_searchTree = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lst_search = new System.Windows.Forms.ListBox();
            this.tree_sodo = new System.Windows.Forms.TreeView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_khoaPBcon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nhiemvu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_phongban = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_diadiem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_tenPB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cb_locDD = new System.Windows.Forms.ComboBox();
            this.txt_searchPbB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.data_phongban = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tool_themPCN = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuPhongban.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_phongban)).BeginInit();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.menuPhongban);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 32);
            this.panel2.TabIndex = 1;
            // 
            // menuPhongban
            // 
            this.menuPhongban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPhongban.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolmn_PB,
            this.tool_luu,
            this.tool_huy});
            this.menuPhongban.Location = new System.Drawing.Point(0, 0);
            this.menuPhongban.Name = "menuPhongban";
            this.menuPhongban.Size = new System.Drawing.Size(1366, 32);
            this.menuPhongban.TabIndex = 0;
            this.menuPhongban.Text = "menuStrip1";
            // 
            // toolmn_PB
            // 
            this.toolmn_PB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_themPB,
            this.tool_suaPB,
            this.tool_xoaPB,
            this.tool_themPCN});
            this.toolmn_PB.Name = "toolmn_PB";
            this.toolmn_PB.Size = new System.Drawing.Size(77, 28);
            this.toolmn_PB.Text = "Phòng ban";
            // 
            // tool_themPB
            // 
            this.tool_themPB.Enabled = false;
            this.tool_themPB.Name = "tool_themPB";
            this.tool_themPB.Size = new System.Drawing.Size(220, 22);
            this.tool_themPB.Text = "Thêm mới phòng ban";
            this.tool_themPB.Click += new System.EventHandler(this.Tool_themPB_Click);
            // 
            // tool_suaPB
            // 
            this.tool_suaPB.Enabled = false;
            this.tool_suaPB.Name = "tool_suaPB";
            this.tool_suaPB.Size = new System.Drawing.Size(220, 22);
            this.tool_suaPB.Text = "Sửa thông tin phòng ban";
            this.tool_suaPB.Click += new System.EventHandler(this.Tool_suaPB_Click);
            // 
            // tool_xoaPB
            // 
            this.tool_xoaPB.Enabled = false;
            this.tool_xoaPB.Name = "tool_xoaPB";
            this.tool_xoaPB.Size = new System.Drawing.Size(220, 22);
            this.tool_xoaPB.Text = "Xóa phòng ban";
            this.tool_xoaPB.Click += new System.EventHandler(this.Tool_xoaPB_Click);
            // 
            // tool_luu
            // 
            this.tool_luu.Enabled = false;
            this.tool_luu.Image = global::Quanlibenhvien_Offical.Properties.Resources.save_30px;
            this.tool_luu.Name = "tool_luu";
            this.tool_luu.Size = new System.Drawing.Size(110, 28);
            this.tool_luu.Text = "Lưu thông tin ";
            this.tool_luu.Click += new System.EventHandler(this.Tool_luu_Click);
            // 
            // tool_huy
            // 
            this.tool_huy.Enabled = false;
            this.tool_huy.Image = global::Quanlibenhvien_Offical.Properties.Resources.delete_database_30px;
            this.tool_huy.Name = "tool_huy";
            this.tool_huy.Size = new System.Drawing.Size(57, 28);
            this.tool_huy.Text = "Hủy";
            this.tool_huy.Click += new System.EventHandler(this.Tool_huy_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pic_logo);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 606);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.Panel3_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_logo.Image = global::Quanlibenhvien_Offical.Properties.Resources.pd_05_khong_co_khung_1_0830;
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(678, 287);
            this.pic_logo.TabIndex = 108;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.Pic_logo_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.cb_Khoa);
            this.panel5.Controls.Add(this.txt_searchTree);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(678, 36);
            this.panel5.TabIndex = 107;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.FormattingEnabled = true;
            this.cb_Khoa.Location = new System.Drawing.Point(129, 9);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(121, 21);
            this.cb_Khoa.TabIndex = 1;
            // 
            // txt_searchTree
            // 
            this.txt_searchTree.Depth = 0;
            this.txt_searchTree.Hint = "Tìm kiếm tên phòng ban ";
            this.txt_searchTree.Location = new System.Drawing.Point(268, 7);
            this.txt_searchTree.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchTree.Name = "txt_searchTree";
            this.txt_searchTree.PasswordChar = '\0';
            this.txt_searchTree.SelectedText = "";
            this.txt_searchTree.SelectionLength = 0;
            this.txt_searchTree.SelectionStart = 0;
            this.txt_searchTree.Size = new System.Drawing.Size(271, 23);
            this.txt_searchTree.TabIndex = 0;
            this.txt_searchTree.UseSystemPasswordChar = false;
            this.txt_searchTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_searchTree_KeyDown);
            this.txt_searchTree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_searchTree_KeyPress);
            this.txt_searchTree.TextChanged += new System.EventHandler(this.Txt_searchTree_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lst_search);
            this.panel7.Controls.Add(this.tree_sodo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 323);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(678, 279);
            this.panel7.TabIndex = 104;
            // 
            // lst_search
            // 
            this.lst_search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lst_search.FormattingEnabled = true;
            this.lst_search.Location = new System.Drawing.Point(268, 6);
            this.lst_search.Name = "lst_search";
            this.lst_search.Size = new System.Drawing.Size(271, 108);
            this.lst_search.TabIndex = 1;
            this.lst_search.Visible = false;
            this.lst_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Lst_search_KeyDown);
            this.lst_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lst_search_KeyPress);
            // 
            // tree_sodo
            // 
            this.tree_sodo.BackColor = System.Drawing.Color.White;
            this.tree_sodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_sodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tree_sodo.FullRowSelect = true;
            this.tree_sodo.HideSelection = false;
            this.tree_sodo.HotTracking = true;
            this.tree_sodo.ItemHeight = 30;
            this.tree_sodo.LineColor = System.Drawing.Color.DimGray;
            this.tree_sodo.Location = new System.Drawing.Point(0, 0);
            this.tree_sodo.Name = "tree_sodo";
            this.tree_sodo.Size = new System.Drawing.Size(678, 279);
            this.tree_sodo.TabIndex = 0;
            this.tree_sodo.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.Tree_sodo_DrawNode);
            this.tree_sodo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_sodo_AfterSelect);
            this.tree_sodo.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_sodo_NodeMouseClick);
            this.tree_sodo.Click += new System.EventHandler(this.Tree_sodo_Click);
            this.tree_sodo.Enter += new System.EventHandler(this.Tree_sodo_Enter);
            this.tree_sodo.Leave += new System.EventHandler(this.Tree_sodo_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.cb_khoaPBcon);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_nhiemvu);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cb_phongban);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_diadiem);
            this.panel4.Controls.Add(this.txt_tenPB);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.data_phongban);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(682, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 606);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.Panel4_Click);
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // cb_khoaPBcon
            // 
            this.cb_khoaPBcon.Enabled = false;
            this.cb_khoaPBcon.FormattingEnabled = true;
            this.cb_khoaPBcon.Location = new System.Drawing.Point(454, 190);
            this.cb_khoaPBcon.Name = "cb_khoaPBcon";
            this.cb_khoaPBcon.Size = new System.Drawing.Size(177, 21);
            this.cb_khoaPBcon.TabIndex = 89;
            this.cb_khoaPBcon.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_khoaPBcon_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(384, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Tên khoa :";
            // 
            // txt_nhiemvu
            // 
            this.txt_nhiemvu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nhiemvu.Enabled = false;
            this.txt_nhiemvu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_nhiemvu.ForeColor = System.Drawing.Color.Black;
            this.txt_nhiemvu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nhiemvu.HintText = "Trống ";
            this.txt_nhiemvu.isPassword = false;
            this.txt_nhiemvu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_nhiemvu.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nhiemvu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_nhiemvu.LineThickness = 3;
            this.txt_nhiemvu.Location = new System.Drawing.Point(220, 130);
            this.txt_nhiemvu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nhiemvu.Name = "txt_nhiemvu";
            this.txt_nhiemvu.Size = new System.Drawing.Size(411, 33);
            this.txt_nhiemvu.TabIndex = 87;
            this.txt_nhiemvu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nhiemvu.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_nhiemvu_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(93, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 86;
            this.label1.Text = "Nhiệm vụ :";
            // 
            // cb_phongban
            // 
            this.cb_phongban.Enabled = false;
            this.cb_phongban.FormattingEnabled = true;
            this.cb_phongban.Location = new System.Drawing.Point(220, 190);
            this.cb_phongban.Name = "cb_phongban";
            this.cb_phongban.Size = new System.Drawing.Size(158, 21);
            this.cb_phongban.TabIndex = 85;
            this.cb_phongban.Validating += new System.ComponentModel.CancelEventHandler(this.Cb_phongban_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(93, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 15);
            this.label12.TabIndex = 84;
            this.label12.Text = "Tên phòng ban cha :";
            // 
            // txt_diadiem
            // 
            this.txt_diadiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_diadiem.Enabled = false;
            this.txt_diadiem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diadiem.ForeColor = System.Drawing.Color.Black;
            this.txt_diadiem.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_diadiem.HintText = "Trống ";
            this.txt_diadiem.isPassword = false;
            this.txt_diadiem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_diadiem.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_diadiem.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_diadiem.LineThickness = 3;
            this.txt_diadiem.Location = new System.Drawing.Point(220, 84);
            this.txt_diadiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diadiem.Name = "txt_diadiem";
            this.txt_diadiem.Size = new System.Drawing.Size(411, 33);
            this.txt_diadiem.TabIndex = 83;
            this.txt_diadiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_diadiem.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_diadiem_Validating);
            // 
            // txt_tenPB
            // 
            this.txt_tenPB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenPB.Enabled = false;
            this.txt_tenPB.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tenPB.ForeColor = System.Drawing.Color.Black;
            this.txt_tenPB.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tenPB.HintText = "Trống ";
            this.txt_tenPB.isPassword = false;
            this.txt_tenPB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenPB.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_tenPB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_tenPB.LineThickness = 3;
            this.txt_tenPB.Location = new System.Drawing.Point(220, 39);
            this.txt_tenPB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenPB.Name = "txt_tenPB";
            this.txt_tenPB.Size = new System.Drawing.Size(411, 33);
            this.txt_tenPB.TabIndex = 82;
            this.txt_tenPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tenPB.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_tenPB_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(93, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 81;
            this.label10.Text = "Địa điểm :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(93, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 80;
            this.label11.Text = "Tên phòng ban :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.cb_locDD);
            this.panel6.Controls.Add(this.txt_searchPbB);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(680, 36);
            this.panel6.TabIndex = 5;
            // 
            // cb_locDD
            // 
            this.cb_locDD.FormattingEnabled = true;
            this.cb_locDD.Items.AddRange(new object[] {
            "Tên phòng ban",
            "Mã địa điểm"});
            this.cb_locDD.Location = new System.Drawing.Point(160, 9);
            this.cb_locDD.Name = "cb_locDD";
            this.cb_locDD.Size = new System.Drawing.Size(121, 21);
            this.cb_locDD.TabIndex = 1;
            // 
            // txt_searchPbB
            // 
            this.txt_searchPbB.Depth = 0;
            this.txt_searchPbB.Hint = "Nhập thông tin tìm kiếm ";
            this.txt_searchPbB.Location = new System.Drawing.Point(306, 7);
            this.txt_searchPbB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_searchPbB.Name = "txt_searchPbB";
            this.txt_searchPbB.PasswordChar = '\0';
            this.txt_searchPbB.SelectedText = "";
            this.txt_searchPbB.SelectionLength = 0;
            this.txt_searchPbB.SelectionStart = 0;
            this.txt_searchPbB.Size = new System.Drawing.Size(272, 23);
            this.txt_searchPbB.TabIndex = 0;
            this.txt_searchPbB.UseSystemPasswordChar = false;
            this.txt_searchPbB.TextChanged += new System.EventHandler(this.Txt_searchPbB_TextChanged);
            // 
            // data_phongban
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_phongban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_phongban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_phongban.BackgroundColor = System.Drawing.Color.White;
            this.data_phongban.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_phongban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_phongban.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_phongban.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_phongban.Location = new System.Drawing.Point(0, 323);
            this.data_phongban.MultiSelect = false;
            this.data_phongban.Name = "data_phongban";
            this.data_phongban.ReadOnly = true;
            this.data_phongban.RowHeadersVisible = false;
            this.data_phongban.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_phongban.Size = new System.Drawing.Size(680, 279);
            this.data_phongban.TabIndex = 4;
            this.data_phongban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_phongban_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(190, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "DANH SÁCH PHÒNG BAN CON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(181, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN PHÒNG BAN CON";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tool_themPCN
            // 
            this.tool_themPCN.Name = "tool_themPCN";
            this.tool_themPCN.Size = new System.Drawing.Size(220, 22);
            this.tool_themPCN.Text = "Mở thêm phòng chức năng";
            this.tool_themPCN.Click += new System.EventHandler(this.Tool_themPCN_Click);
            // 
            // quanlyphongbanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "quanlyphongbanUC";
            this.Size = new System.Drawing.Size(1366, 648);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuPhongban.ResumeLayout(false);
            this.menuPhongban.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_phongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuPhongban;
        private System.Windows.Forms.ToolStripMenuItem toolmn_PB;
        private System.Windows.Forms.ToolStripMenuItem tool_themPB;
        private System.Windows.Forms.ToolStripMenuItem tool_suaPB;
        private System.Windows.Forms.ToolStripMenuItem tool_xoaPB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView data_phongban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_phongban;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_diadiem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_tenPB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchPbB;
        private System.Windows.Forms.ComboBox cb_locDD;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripMenuItem tool_luu;
        private System.Windows.Forms.ToolStripMenuItem tool_huy;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TreeView tree_sodo;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_searchTree;
        private System.Windows.Forms.ListBox lst_search;
        private System.Windows.Forms.ComboBox cb_Khoa;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ComboBox cb_khoaPBcon;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nhiemvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tool_themPCN;
    }
}
