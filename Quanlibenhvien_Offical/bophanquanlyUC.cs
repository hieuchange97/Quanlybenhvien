using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibenhvien_Offical
{
    public partial class bophanquanlyUC : UserControl
    {
        public bophanquanlyUC()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Tooltrp_QLbophan_Click(object sender, EventArgs e)
        {
            quanlykhoaUC qlbp = new quanlykhoaUC();
            if (this.pnl_content.Controls.Contains(qlbp))
            {
                qlbp.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(qlbp);
                qlbp.Dock = DockStyle.Fill;
                qlbp.BringToFront();
            }
        }

        private void Tooltrp_nhansu_Click(object sender, EventArgs e)
        {
            quanlynhanvienUC qlbp = new quanlynhanvienUC();
            if (this.pnl_content.Controls.Contains(qlbp))
            {
                qlbp.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(qlbp);
                qlbp.Dock = DockStyle.Fill;
                qlbp.BringToFront();
            }
        }

        private void Tool_phongban_Click(object sender, EventArgs e)
        {
            quanlyphongbanUC pb = new quanlyphongbanUC();
            if (this.pnl_content.Controls.Contains(pb))
            {
                pb.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(pb);
                pb.Dock = DockStyle.Fill;
                pb.BringToFront();
            }
        }

        private void Tooltrp_quanlydichvu_Click(object sender, EventArgs e)
        {
            dichvuUC pb = new dichvuUC();
            if (this.pnl_content.Controls.Contains(pb))
            {
                pb.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(pb);
                pb.Dock = DockStyle.Fill;
                pb.BringToFront();
            }
        }

        private void Tool_qlquyen_Click(object sender, EventArgs e)
        {
            quanlyquyentruycapUC pb = new quanlyquyentruycapUC();
            if (this.pnl_content.Controls.Contains(pb))
            {
                pb.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(pb);
                pb.Dock = DockStyle.Fill;
                pb.BringToFront();
            }
        }

        private void Toolmn_chucvu_Click(object sender, EventArgs e)
        {
            chucvuUC pb = new chucvuUC();
            if (this.pnl_content.Controls.Contains(pb))
            {
                pb.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(pb);
                pb.Dock = DockStyle.Fill;
                pb.BringToFront();
            }
        }
    }
}
