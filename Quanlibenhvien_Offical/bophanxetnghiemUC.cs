using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical
{
    public partial class bophanxetnghiemUC : UserControl
    {
        public bophanxetnghiemUC()
        {
            InitializeComponent();
        }
        public NHANVIEN nhanvien { get; set; }
 
        public string idpbNV { get; set; }
        public bophanxetnghiemUC(NHANVIEN nv)
        {
            InitializeComponent();
            nhanvien = nv;
          
            dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();
            new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter().FillbyIDnv(tableNV,nhanvien.IDnv);
            idpbNV = tableNV.First().IDpb;
            load_data(idpbNV);
            if (tableNV.First().IDpb == "PB039"|| tableNV.First().IDpb == "PB040")
            {          
               tooltrp_xquang.Enabled = false;
                tooltrp_sieuam.Enabled = true;
            }
            if (tableNV.First().IDpb == "PB037" || tableNV.First().IDpb == "PB041")
            {
                tooltrp_xquang.Enabled = true;
                tooltrp_sieuam.Enabled = false;
            }

        }
        private void MaterialLabel1_Click(object sender, EventArgs e)
        {

        }
        public void load_data(string txt)
        {
            data_ptt.DataSource = new dataquery2TableAdapters.DANHSACHBENHNHANLAMXETNGHIEMTableAdapter().GetData(txt);
            header_datagrid();

        }
        public void header_datagrid()
        {
            data_ptt.Columns[0].HeaderText = "Mã bệnh nhân";
            data_ptt.Columns[1].HeaderText = "Họ đệm";
            data_ptt.Columns[2].HeaderText = "Tên";
            data_ptt.Columns[3].HeaderText = "Xã phường";
            data_ptt.Columns[4].HeaderText = "Quận huyện";
            data_ptt.Columns[5].HeaderText = "Tỉnh thành phố";
            data_ptt.Columns[6].HeaderText = "Mã bệnh án ";
            data_ptt.Columns[7].HeaderText = "Mã phiếu thanh toán";
            data_ptt.Columns[9].HeaderText = "Giờ lập";
            data_ptt.Columns[8].HeaderText = "Ngày lập";
            data_ptt.Columns[10].HeaderText = "Trạng thái TT";
            data_ptt.Columns[11].HeaderText = "Trạng thái XN";
            data_ptt.Columns[12].HeaderText = "Mã DV";
            data_ptt.Columns[13].HeaderText = "Tên DV";
            data_ptt.Columns[14].HeaderText = "Giá tiền";
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void MaterialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Data_ptt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idBN.Text = data_ptt.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenBN.Text = data_ptt.Rows[e.RowIndex].Cells[1].Value.ToString() + data_ptt.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Idba.Text= data_ptt.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_IDptt.Text= data_ptt.Rows[e.RowIndex].Cells[7].Value.ToString();
                chck_TT.Checked = bool.Parse(data_ptt.Rows[e.RowIndex].Cells[10].Value.ToString());
                chck_XN.Checked = bool.Parse(data_ptt.Rows[e.RowIndex].Cells[11].Value.ToString());
                txt_tendv.Text = data_ptt.Rows[e.RowIndex].Cells[13].Value.ToString();
                tooltrp_tienhanhSA.Enabled = true;
            }
            catch (Exception)
            {
                tooltrp_tienhanhSA.Enabled = false;
             
            }
        }

        private void Txt_searchPTT_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchPTT.Text != "")
            {
                data_ptt.DataSource = new dataquery2TableAdapters.DANHSACHBENHNHANLAMXETNGHIEMTableAdapter().GetDataByIDptt(idpbNV,txt_searchPTT.Text);
                header_datagrid();

            }
            else
            {
                load_data(idpbNV);
            }
        }

       

        private void Tooltrp_tienhanhSA_Click(object sender, EventArgs e)
        {
            sieuamUC sa = new sieuamUC(nhanvien,txt_IDptt.Text,this);
            if (pnl_xetnghiem.Controls.Contains(sa))
            {
                sa.BringToFront();
            }
            else
            {
                pnl_xetnghiem.Controls.Add(sa);
                sa.Dock = DockStyle.Fill;
                sa.BringToFront();
            }
        }

        private void Tooltrp_save_Click(object sender, EventArgs e)
        {
           
             
            
        }

        private void Tooltrp_lammoi_Click(object sender, EventArgs e)
        {
            load_data(idpbNV);
        }
        public void call_refresh()
        {
            tooltrp_lammoi.PerformClick();
        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void TiếnHànhChụpXquangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chupxquangUC sa = new chupxquangUC(nhanvien, txt_IDptt.Text, this);
            if (pnl_xetnghiem.Controls.Contains(sa))
            {
                sa.BringToFront();
            }
            else
            {
                pnl_xetnghiem.Controls.Add(sa);
                sa.Dock = DockStyle.Fill;
                sa.BringToFront();
            }
        }
    }
}
