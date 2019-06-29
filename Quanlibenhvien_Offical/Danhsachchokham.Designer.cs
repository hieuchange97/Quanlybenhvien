namespace Quanlibenhvien_Offical
{
    partial class Danhsachchokham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_dsbenhnhan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tenpk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_dsbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // data_dsbenhnhan
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_dsbenhnhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_dsbenhnhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_dsbenhnhan.BackgroundColor = System.Drawing.Color.White;
            this.data_dsbenhnhan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_dsbenhnhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_dsbenhnhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_dsbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dsbenhnhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.data_dsbenhnhan.GridColor = System.Drawing.Color.Gray;
            this.data_dsbenhnhan.Location = new System.Drawing.Point(0, 104);
            this.data_dsbenhnhan.MultiSelect = false;
            this.data_dsbenhnhan.Name = "data_dsbenhnhan";
            this.data_dsbenhnhan.ReadOnly = true;
            this.data_dsbenhnhan.RowHeadersVisible = false;
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.data_dsbenhnhan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data_dsbenhnhan.RowTemplate.ReadOnly = true;
            this.data_dsbenhnhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_dsbenhnhan.Size = new System.Drawing.Size(1068, 378);
            this.data_dsbenhnhan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(303, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "DANH SÁCH CÁC BỆNH NHÂN CHỜ LÀM VIỆC";
            // 
            // lbl_tenpk
            // 
            this.lbl_tenpk.AutoSize = true;
            this.lbl_tenpk.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tenpk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_tenpk.Location = new System.Drawing.Point(428, 66);
            this.lbl_tenpk.Name = "lbl_tenpk";
            this.lbl_tenpk.Size = new System.Drawing.Size(41, 15);
            this.lbl_tenpk.TabIndex = 4;
            this.lbl_tenpk.Text = "label2";
            // 
            // Danhsachchokham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 482);
            this.Controls.Add(this.lbl_tenpk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_dsbenhnhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Danhsachchokham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách các bệnh nhân chờ khám ";
            this.Load += new System.EventHandler(this.Danhsachchokham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dsbenhnhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_dsbenhnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tenpk;
    }
}