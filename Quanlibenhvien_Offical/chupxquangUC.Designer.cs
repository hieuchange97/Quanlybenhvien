namespace Quanlibenhvien_Offical
{
    partial class chupxquangUC
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ketluan = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_end = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(206, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "KẾT QUẢ CHỤP X-QUANG";
            // 
            // txt_ketluan
            // 
            this.txt_ketluan.Location = new System.Drawing.Point(169, 288);
            this.txt_ketluan.Name = "txt_ketluan";
            this.txt_ketluan.Size = new System.Drawing.Size(423, 87);
            this.txt_ketluan.TabIndex = 12;
            this.txt_ketluan.Text = "";
            this.txt_ketluan.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_ketluan_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(24, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kết luận :";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(169, 124);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(423, 84);
            this.txt_mota.TabIndex = 10;
            this.txt_mota.Text = "";
            this.txt_mota.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_mota_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mô tả :";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sua.Enabled = false;
            this.btn_sua.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(280, 432);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 57);
            this.btn_sua.TabIndex = 22;
            this.btn_sua.Text = "Sửa  phiếu ";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_in.Enabled = false;
            this.btn_in.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_in.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.ForeColor = System.Drawing.Color.White;
            this.btn_in.Location = new System.Drawing.Point(390, 432);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(100, 57);
            this.btn_in.TabIndex = 21;
            this.btn_in.Text = "In phiếu ";
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.Btn_in_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(169, 432);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 57);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Lưu phiếu ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_end
            // 
            this.btn_end.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_end.Enabled = false;
            this.btn_end.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_end.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_end.ForeColor = System.Drawing.Color.White;
            this.btn_end.Location = new System.Drawing.Point(496, 432);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(96, 57);
            this.btn_end.TabIndex = 23;
            this.btn_end.Text = "Kết thúc ";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chupxquangUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_ketluan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "chupxquangUC";
            this.Size = new System.Drawing.Size(687, 651);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_ketluan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_mota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
