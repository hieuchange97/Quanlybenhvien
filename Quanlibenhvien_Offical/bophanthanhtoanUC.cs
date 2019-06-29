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
    public partial class bophanthanhtoanUC : UserControl
    {
        public bophanthanhtoanUC()
        {
            InitializeComponent();
           
        }
        public NHANVIEN nv { get; set; }
        public bophanthanhtoanUC(NHANVIEN Nv)
        {
            InitializeComponent();
            nv = Nv;
        }
        public void load_benhnhan()
        {
            data_benhnhan.DataSource = new benhnhanF().show_bn();
            headerTextcell();
        }
        public void headerTextcell()
        {
            data_benhnhan.Columns[1].HeaderText = "Mã bệnh nhân";
            data_benhnhan.Columns[2].HeaderText = "Họ và tên đệm";
            data_benhnhan.Columns[3].HeaderText = "Tên bệnh nhân";
            data_benhnhan.Columns[4].HeaderText = "Giới tính";
            data_benhnhan.Columns[5].HeaderText = "Ngày Sinh";
            data_benhnhan.Columns[6].HeaderText = "Số điện thoại";
            data_benhnhan.Columns[7].HeaderText = "Xã/Phường";
            data_benhnhan.Columns[8].HeaderText = "Quận/huyện";
            data_benhnhan.Columns[9].HeaderText = "Tỉnh/Thành phố";
            data_benhnhan.Columns[10].HeaderText = "Nghề nghiệp";
            data_benhnhan.Columns[11].HeaderText = "Số CMTND";
            data_benhnhan.Columns[12].HeaderText = "Mã khai sinh";

        }

        private void BophanthanhtoanUC_Load(object sender, EventArgs e)
        {
            load_benhnhan();
        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void BunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void Txt_searchBN_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBN.Text != "")
            {
                if (cb_locBN.SelectedIndex == 0)
                {
                    data_benhnhan.DataSource = new benhnhanF().search_hotenBN(txt_searchBN.Text);
                    headerTextcell();
                }
                if (cb_locBN.SelectedIndex == 1)
                {
                    data_benhnhan.DataSource = new benhnhanF().search_idBN(txt_searchBN.Text);
                    headerTextcell();
                }
                if (cb_locBN.SelectedIndex == 2)
                {
                    data_benhnhan.DataSource = new benhnhanF().search_cmndBN(txt_searchBN.Text);
                    headerTextcell();
                }
              
            }
            else
            {
                load_benhnhan();
            }
        }

        private void Data_benhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tooltrp_save.Enabled = false;
                txt_IDbn.Text = data_benhnhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_hotenBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[2].Value.ToString() + data_benhnhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_gioitinhBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_tuoiBN.Text = (DateTime.Now.Year - DateTime.Parse(data_benhnhan.Rows[e.RowIndex].Cells[5].Value.ToString()).Year).ToString();
                txt_nghenghiepBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[10].Value.ToString();
                txt_quequanBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[7].Value.ToString()+" - " + data_benhnhan.Rows[e.RowIndex].Cells[8].Value.ToString()+" - " + data_benhnhan.Rows[e.RowIndex].Cells[9].Value.ToString();



                var bhyt = new bhytF().filter_BHYT(txt_IDbn.Text);
                if (bhyt == null)
                {
                    chck_BHYT.Checked = false;
                    txt_idBHYT.Text = null;
                    txt_tuyenBHYT.Text = null;
                    txt_dtutBHYT.Text = null;
                    chck_giaychuyen.Checked = false;
                    txt_idgiaychuyen.Text = null;
                }
                else
                {
                    chck_BHYT.Checked = true;
                    txt_idBHYT.Text = bhyt.IDbhyt;
                    txt_tuyenBHYT.Text = new Model1().TUYENBHYTs.Find(bhyt.IDtuyen).Tentuyen;
                    txt_dtutBHYT.Text = new Model1().DTUTs.Find(bhyt.IDdt).TenDT;
                    var gcv = new giaychuyenvienF().searchGCV_idBHYT(bhyt.IDbhyt);
                    if (gcv != null)
                    {
                        chck_giaychuyen.Checked = true;
                        txt_idgiaychuyen.Text = gcv.IDgcv;
                    }
                    else
                    {
                        chck_giaychuyen.Checked = false;
                        txt_idgiaychuyen.Text = null;
                    }
                }

                if (txt_idBHYT.Text != "" )
                {
                    if (txt_idgiaychuyen.Text != null)
                    {
                        if (bhyt.IDdt != 4)
                        {
                            txt_phantramUD.Text = "100";
                        }
                        else
                        {
                            txt_phantramUD.Text = "80";
                        }
                    }
                    else
                    {
                        if (bhyt.IDtuyen == "T003")
                        {
                            if (bhyt.IDdt != 4)
                            {
                                txt_phantramUD.Text = "100";
                            }
                            else
                            {
                                txt_phantramUD.Text = "80";
                            }
                        }
                        else
                        {
                            txt_phantramUD.Text = "0";
                        }
                    }
                  
                }
                else
                {
                    txt_phantramUD.Text = "0";
                }

            }
            catch (Exception)
            {

               
            }
        }

        private void Tooltrp_ttXNKT_Click(object sender, EventArgs e)
        {
            txt_loaihinhTT.Text = "Thanh toán dịch vụ xét nghiệm , kiểm tra ";
            data_thanhtoan.DataSource = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter().GetDataByIDbn(txt_IDbn.Text);
            header_data_thanhtoan();
        }
        public void header_data_thanhtoan()
        {
            data_thanhtoan.Columns[0].HeaderText = "Mã phiếu TT";
            data_thanhtoan.Columns[1].HeaderText = "Mã dịch vụ";
            data_thanhtoan.Columns[2].HeaderText = "Ngày lập";
            data_thanhtoan.Columns[3].HeaderText = "Giờ lập";
            data_thanhtoan.Columns[4].HeaderText = "Mã nhân viên";
            data_thanhtoan.Columns[5].HeaderText = "Mã bệnh án";
            data_thanhtoan.Columns[6].HeaderText = "Tên dịch vụ";
            data_thanhtoan.Columns[7].HeaderText = "Trạng thái thanh toán";
            data_thanhtoan.Columns[8].HeaderText = "Phần trăm giảm";
            data_thanhtoan.Columns[9].Visible = data_thanhtoan.Columns[10].Visible = data_thanhtoan.Columns[11].Visible = data_thanhtoan.Columns[12].Visible = data_thanhtoan.Columns[13].Visible = data_thanhtoan.Columns[14].Visible = data_thanhtoan.Columns[15].Visible = data_thanhtoan.Columns[16].Visible = data_thanhtoan.Columns[17].Visible= data_thanhtoan.Columns[18].Visible = false;

        }

        private void Chck_locChuaTT_CheckedChanged(object sender, EventArgs e)
        {
          
        }


        private void Txt_searchTT_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchTT.Text != "")
            {
                switch (cb_thanhtoan.SelectedIndex)
                {
                    case 0:
                        {
                            data_thanhtoan.DataSource= new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter().GetDataBySearchIDptt(txt_IDbn.Text, txt_searchTT.Text);
                            header_data_thanhtoan();
                            break;
                        }
                    case 1:
                        {
                            data_thanhtoan.DataSource = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter().GetDataByIDba(txt_searchTT.Text,txt_IDbn.Text);
                            header_data_thanhtoan();
                            break;
                        }
                  
                }
                
            }
            else
            {
                data_thanhtoan.DataSource = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter().GetDataByIDbn(txt_IDbn.Text);
                header_data_thanhtoan();
            }
        }

        private void Chck_locDaTT_CheckedChanged(object sender, EventArgs e)
        {
           
          
        }

        private void Data_thanhtoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idBA.Text = data_thanhtoan.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_idPTT.Text = data_thanhtoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tiencanTT.Text = data_thanhtoan.Rows[e.RowIndex].Cells[17].Value.ToString();            
                txt_sotienPT.Text = (int.Parse(data_thanhtoan.Rows[e.RowIndex].Cells[17].Value.ToString()) - (int.Parse(data_thanhtoan.Rows[e.RowIndex].Cells[17].Value.ToString()) * int.Parse(txt_phantramUD.Text)) / 100).ToString();
                chck_thanhtoan.Checked = bool.Parse(data_thanhtoan.Rows[e.RowIndex].Cells[7].Value.ToString());
                if (chck_thanhtoan.Checked == true) toolmn_thongtinphongCN.Enabled = true; else toolmn_thongtinphongCN.Enabled = false;
                Model1 md = new Model1();
                var ptt = md.PHIEUTHANHTOANXNKTs.Find(txt_idPTT.Text);
                ptt.phantramgiam = txt_phantramUD.Text;
                md.SaveChanges();
                tooltrp_save.Enabled = true;
            }
            catch (Exception)
            {
                tooltrp_save.Enabled = false;
            }
           
        }

        private void Tooltrp_phieuttxnkt_Click(object sender, EventArgs e)
        {
           
            if (txt_idBHYT.Text != "")
            {

                new Phieuthanhtoanxetnghiem(new Model1().PHIEUTHANHTOANXNKTs.Find(txt_idPTT.Text), nv, txt_idBHYT.Text, "Có").Show();
            }
            else
            {
                new Phieuthanhtoanxetnghiem(new Model1().PHIEUTHANHTOANXNKTs.Find(txt_idPTT.Text), nv, "    ", "Không").Show();
            }
            
        }


        Dataquery.PHIEUTHANHTOANXNKTDataTable tableTT = new Dataquery.PHIEUTHANHTOANXNKTDataTable();
       

        List<Dataquery.PHIEUTHANHTOANXNKTRow> lit = new List<Dataquery.PHIEUTHANHTOANXNKTRow>();
        
        private void Chck_locDaTT_Click(object sender, EventArgs e)
        {



            if (chck_locDaTT.Checked == true)
            {
                chck_locChuaTT.Enabled = false;
                lit = new List<Dataquery.PHIEUTHANHTOANXNKTRow>(); 
                tableTT = (Dataquery.PHIEUTHANHTOANXNKTDataTable)data_thanhtoan.DataSource;
                foreach (Dataquery.PHIEUTHANHTOANXNKTRow item in tableTT)
                {
                    if (item.trangthaitt == true)
                    {
                        lit.Add(item);
                    }
                }
                data_thanhtoan.DataSource = null;
                data_thanhtoan.DataSource = lit;
                data_thanhtoan.Columns[19].Visible = data_thanhtoan.Columns[18].Visible = data_thanhtoan.Columns[20].Visible= data_thanhtoan.Columns[21].Visible = false;
                header_data_thanhtoan();
            }
            else
            {
                if (chck_locChuaTT.Checked == false)
                {
                    data_thanhtoan.DataSource = null;
                    data_thanhtoan.DataSource = tableTT;
                    header_data_thanhtoan();
                    chck_locChuaTT.Enabled = true;
                }
            }
        }

        private void Chck_locChuaTT_Click(object sender, EventArgs e)
        {       
            
           
            if (chck_locChuaTT.Checked == true)
            {
                chck_locDaTT.Enabled = false;
                lit = new List<Dataquery.PHIEUTHANHTOANXNKTRow>();
                tableTT =(Dataquery.PHIEUTHANHTOANXNKTDataTable) data_thanhtoan.DataSource;
                foreach (Dataquery.PHIEUTHANHTOANXNKTRow item in tableTT)
                {
                    if (item.trangthaitt == false)
                    {
                        lit.Add(item);
                    }
                }
                data_thanhtoan.DataSource = null;
                data_thanhtoan.DataSource = lit;
                data_thanhtoan.Columns[19].Visible = data_thanhtoan.Columns[18].Visible = data_thanhtoan.Columns[21].Visible = data_thanhtoan.Columns[20].Visible = false;
                header_data_thanhtoan();
            }
            else
            {
                if (chck_locChuaTT.Checked == false)
                {
                    data_thanhtoan.DataSource = null;
                    data_thanhtoan.DataSource = tableTT;
                    header_data_thanhtoan();
                    chck_locDaTT.Enabled = true;
                }
            }
        }

        private void Chck_thanhtoan_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_thanhtoan.Checked == true)
            {
                tooltrp_save.PerformClick();
            }
        }

        private void Tooltrp_save_Click(object sender, EventArgs e)
        {
            tootrp_inHD.Enabled = true;
            Model1 md = new Model1();
            var ptt = md.PHIEUTHANHTOANXNKTs.Find(txt_idPTT.Text);
            ptt.phantramgiam = txt_phantramUD.Text;
            ptt.trangthaitt = true;
            ptt.trangthaiXN = false;
            ptt.IDnvthungan = nv.IDnv;
            md.SaveChanges();
            tooltrp_ttXNKT.PerformClick();
            new ketquathanhcongForm().Show();
            toolmn_thongtinphongCN.Enabled = true;
            foreach (DataGridViewRow item in data_thanhtoan.Rows)
            {
                if (!item.IsNewRow)
                {
                    if (item.Cells[0].Value.ToString() == ptt.IDpttxn)
                    {
                        item.Selected = true;
                        Data_thanhtoan_CellClick(this, new DataGridViewCellEventArgs(0, item.Index));
                    }
                }
            }
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
            label10.Select();
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            label10.Select();
        }

        private void Tootrp_inHD_Click(object sender, EventArgs e)
        {

        }

        private void Toolmn_thongtinphongCN_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is thongtinphongchucnangForm);
            if (formToShow != null)
            {
                formToShow.BringToFront();
            }
            else
                new thongtinphongchucnangForm(data_thanhtoan.CurrentRow.Cells[1].Value.ToString(), data_thanhtoan.CurrentRow.Cells[0].Value.ToString(),txt_IDbn.Text,nv.IDnv,txt_idBHYT.Text,txt_idBA.Text).Show();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
