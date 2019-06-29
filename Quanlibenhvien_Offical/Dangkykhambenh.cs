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
using System.Data.SqlClient;
using System.Data.Sql;

namespace Quanlibenhvien_Offical
{
    public partial class Dangkykhambenh : UserControl
    {
        public Dangkykhambenh()
        {
            InitializeComponent();
        }

        public NHANVIEN nv { get; set; }
        private void Dangkykhambenh_Load(object sender, EventArgs e)
        {
            Load_Data();
            headerTextcell();
            phongKB = new Model1().PHONGBANs.Where(x => x.IDpbCha == "PB021").ToList();
            load_phongkhambenh(phongKB[0]);
        }
        public List<PHONGBAN> phongKB { get; set; }

        private void Load_Data()
        {
            benhnhanF bnf = new benhnhanF();
            data_benhnhan.DataSource = bnf.show_bn();
            null_text_BN();
            enable_control_BN(false);
        }




        // nhập liệu bệnh nhân 
        public void null_text_BN()
        {
            txt_quanhuyenBN.Text = txt_hotenbn.Text = txt_xaphuongBN.Text = txt_cmndBN.Text = txt_gkhaisinhBN.Text = txt_nghenghiep.Text = txt_tinhthanhBN.Text =
               txt_tuoiBN.Text = txt_sdtBN.Text = null; chck_namBN.Checked = chck_nuBN.Checked = false;
        }
        public void enable_control_BN(bool bl)
        {
            txt_quanhuyenBN.Enabled = txt_hotenbn.Enabled = txt_xaphuongBN.Enabled = txt_cmndBN.Enabled = txt_gkhaisinhBN.Enabled = txt_nghenghiep.Enabled = txt_tinhthanhBN.Enabled =
              txt_sdtBN.Enabled = bl; chck_namBN.Enabled = chck_nuBN.Enabled = date_ngaysinhBN.Enabled = bl;
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

        string idbn = null; int index = 0;
        private void Data_benhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idbn = null;
                null_text_BN();


                index = e.RowIndex;
                idbn = data_benhnhan.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (idbn != null)
                {
                    Btn_CCsuaBN.Enabled = btn_CCxoaBN.Enabled = true;
                }
                txt_hotenbn.Text = data_benhnhan.Rows[e.RowIndex].Cells[2].Value.ToString() + data_benhnhan.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (data_benhnhan.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
                {
                    chck_namBN.Checked = true;
                    chck_nuBN.Checked = false;
                }
                else
                {
                    chck_nuBN.Checked = true;
                    chck_namBN.Checked = false;
                }


                date_ngaysinhBN.Value = DateTime.Parse(data_benhnhan.Rows[e.RowIndex].Cells[5].Value.ToString());
                txt_sdtBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[6].Value.ToString();
                int tuoi = int.Parse(DateTime.Now.Year.ToString()) - int.Parse(date_ngaysinhBN.Value.Year.ToString());
                txt_tuoiBN.Text = tuoi.ToString();
                txt_xaphuongBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_quanhuyenBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_tinhthanhBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_nghenghiep.Text = data_benhnhan.Rows[e.RowIndex].Cells[10].Value.ToString();
                try
                {
                    txt_cmndBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[11].Value.ToString();
                }
                catch (Exception)
                {


                }

                txt_gkhaisinhBN.Text = data_benhnhan.Rows[e.RowIndex].Cells[12].Value.ToString();
                btn_bhyt.Enabled = true;

            }
            catch (Exception)
            {
                Btn_CCsuaBN.Enabled = btn_CCxoaBN.Enabled = btn_bhyt.Enabled = false;

            }

        }









        //bệnh nhân 
        private string bornAutoID() // sinh id theo ngày
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            if (int.Parse(day) < 10) day = "0" + day;
            if (int.Parse(month) < 10) month = "0" + month;
            string txt = day + month + DateTime.Now.Year.ToString();
            var bn = new Model1().BENHNHANs.ToList();
            string stt = "0";
            foreach (var item in bn)
            {
                if (item.IDbn.Contains(txt))
                {
                    stt = item.IDbn.Substring(10).ToString();
                    stt = (int.Parse(stt) + 1).ToString();
                }
            }

            if (int.Parse(stt) < 9) txt += "00" + stt.ToString();
            else
                if (int.Parse(stt) < 100) txt += "0" + stt.ToString();
            else txt += stt.ToString();
            return txt;

        }
        public void getName_bn(string hoten, out string hodem, out string ten)
        {
            hodem = ten = null;
            try
            {
                int index = 0;
                for (int i = 0; i < hoten.Length; i++)
                {

                    if (hoten[i] != ' ' && hoten[i + 1] == ' ')
                    {
                        index++;
                        if (index == 2)
                        {
                            index = i;
                            break;
                        }
                    }
                }
                hodem = hoten.Remove(index + 1);
                ten = hoten.Substring(index + 1);
            }
            catch (Exception)
            {


            }

        }
        private void Btn_CCsuaBN_Click(object sender, EventArgs e)
        {
            chucnangBN = "update";
            enable_control_BN(true);
            btn_CCthemBN.Enabled = btn_CCxoaBN.Enabled = data_benhnhan.Enabled = false;
            toolmn_luu.Enabled = toolmn_huy.Enabled = true;

        }

        private void Btn_CCxoaBN_Click(object sender, EventArgs e)
        {
            string txt = "Bạn có muốn xóa bệnh nhân " + txt_hotenbn.Text + " ra khỏi hệ thống ? ";
            DialogResult dr = MessageBox.Show(txt, "Xóa bệnh nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (new benhnhanF().delete_bn(idbn))
                {
                    new ketquathanhcongForm().Show();
                    reset_control();
                    Load_Data();
                }
                else
                {
                    MessageBox.Show("Chưa thể xóa bệnh nhân ra khỏi hệ thống ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    reset_control();
                }
            }

        }
        private void Btn_themBN_Click(object sender, EventArgs e)
        {
            toolmn_luu.Enabled = toolmn_huy.Enabled = true;
            idbn = null;
            chucnangBN = "insert";
            data_benhnhan.Enabled = false;
            toolmn_luu.Enabled = toolmn_huy.Enabled = true;
            enable_control_BN(true);
            null_text_BN();
        }
        string chucnangBN = null;

        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                try
                {
                    switch (cb_loc.SelectedIndex)
                    {
                        case 0:
                            {
                                data_benhnhan.DataSource = new benhnhanF().search_hotenBN(txt_search.Text);
                                headerTextcell();
                                return;
                            }
                        case 1:
                            {
                                data_benhnhan.DataSource = new benhnhanF().search_cmndBN(txt_search.Text);
                                headerTextcell();
                                return;
                            }
                        case 2:
                            {
                                data_benhnhan.DataSource = new benhnhanF().search_gksBN(txt_search.Text);
                                headerTextcell();
                                return;
                            }
                        case 3:
                            {
                                data_benhnhan.DataSource = new benhnhanF().search_bhytBN(txt_search.Text);
                                headerTextcell();
                                return;
                            }
                    }
                }
                catch (Exception)
                {


                }
            }
            else
            {
                Load_Data();
                headerTextcell();
            }
        }

        private void Txt_search_Click(object sender, EventArgs e)
        {

        }


        //end bệnh nhân



        // Start giấy chuyển viện 




        private void ĐăngKýKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        public void load_current_index(string id)
        {


            foreach (DataGridViewRow item in data_benhnhan.Rows)
            {
                if (item.Cells[1].Value.ToString() == id)
                {
                    data_benhnhan.Rows[item.Index].Selected = true;
                    Data_benhnhan_CellClick(this, new DataGridViewCellEventArgs(0, item.Index));
                    return;
                }
            }

        }

        private void Chck_namBN_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_namBN.Checked == true)
            {
                chck_nuBN.Checked = false;
            }
        }

        private void Chck_nuBN_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_nuBN.Checked == true)
            {
                chck_namBN.Checked = false;
            }
        }

        private void Btn_bhyt_Click(object sender, EventArgs e)
        {
            if (idbn == null)
            {
                MessageBox.Show("Mời bạn chọn một bệnh nhân "); return;
            }

            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Quanlybenhvien);

            if (formToShow != null)
            {
                formToShow.Hide();
            }

            var bn = new Model1().BENHNHANs.Find(idbn);
            bhytForm bhyt = new bhytForm(bn);
            bhyt.Show();
        }

        private void Date_ngaysinhBN_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_tuoiBN.Text = (DateTime.Now.Year - date_ngaysinhBN.Value.Year).ToString();
            }
            catch (Exception)
            {


            }
        }

        private void Txt_hotenbn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_hotenbn.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_hotenbn.Focus();
                    errorProvider.SetError(txt_hotenbn, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {

                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                if (!txt_hotenbn.Text.Contains(" "))
                {
                    e.Cancel = true;
                    errorProvider.SetError(txt_hotenbn, "Vui lòng ngăn cách tên bằng dấu cách");
                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }

            }
        }

        private void Date_ngaysinhBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(date_ngaysinhBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    date_ngaysinhBN.Focus();
                    errorProvider.SetError(date_ngaysinhBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_xaphuongBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_xaphuongBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_xaphuongBN.Focus();
                    errorProvider.SetError(txt_xaphuongBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_quanhuyenBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_quanhuyenBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_quanhuyenBN.Focus();
                    errorProvider.SetError(txt_quanhuyenBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_tinhthanhBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tinhthanhBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_tinhthanhBN.Focus();
                    errorProvider.SetError(txt_tinhthanhBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_nghenghiep_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nghenghiep.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_nghenghiep.Focus();
                    errorProvider.SetError(txt_nghenghiep, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_cmndBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cmndBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_cmndBN.Focus();
                    errorProvider.SetError(txt_cmndBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {

                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_gkhaisinhBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_gkhaisinhBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_gkhaisinhBN.Focus();
                    errorProvider.SetError(txt_gkhaisinhBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Txt_sdtBN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sdtBN.Text))
            {
                if (chucnangBN == "insert" || chucnangBN == "update")
                {
                    e.Cancel = true;
                    txt_sdtBN.Focus();
                    errorProvider.SetError(txt_sdtBN, "vui lòng điền đầy đủ thông tin ");

                }
                else
                {
                    e.Cancel = false;

                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;

                errorProvider.Clear();
            }
        }

        private void Toolmn_luu_Click(object sender, EventArgs e)
        {
            CancelEventArgs cl = new CancelEventArgs();

            if (chck_nuBN.Checked == true || chck_namBN.Checked == true)
            {
                cl.Cancel = false;
                errorProvider.Clear();
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    switch (chucnangBN)
                    {
                        case "insert":
                            {

                                BENHNHAN bn = new BENHNHAN();
                                bn.IDbn = "BN" + bornAutoID();
                                string a, b;
                                getName_bn(txt_hotenbn.Text, out a, out b);
                                bn.hodem = a.Trim(); bn.Ten = b.Trim();
                                bn.gioitinh = chck_namBN.Checked;

                                bn.ngaysinh = date_ngaysinhBN.Value;
                                bn.Xaphuong = txt_xaphuongBN.Text;
                                bn.Quanhuyen = txt_quanhuyenBN.Text;
                                bn.Tinhthanhpho = txt_tinhthanhBN.Text;
                                bn.Nghenghiep = txt_nghenghiep.Text;
                                bn.CMTND = txt_cmndBN.Text;
                                bn.Giaykhaisinh = txt_gkhaisinhBN.Text;
                                bn.Sdt = txt_sdtBN.Text;
                                benhnhanF bnF = new benhnhanF();
                                if (bnF.insert_bn(bn))
                                {
                                    new ketquathanhcongForm().Show();
                                }
                                chucnangBN = null;
                                Load_Data();
                                reset_control();

                                load_current_index(bn.IDbn);

                                break;
                            }
                        case "update":
                            {

                                BENHNHAN bn = new BENHNHAN();
                                bn.IDbn = idbn;
                                string a, b;
                                getName_bn(txt_hotenbn.Text, out a, out b);
                                bn.hodem = a; bn.Ten = b;
                                bn.gioitinh = chck_namBN.Checked;
                                bn.ngaysinh = date_ngaysinhBN.Value;
                                bn.Xaphuong = txt_xaphuongBN.Text;
                                bn.Quanhuyen = txt_quanhuyenBN.Text;
                                bn.Tinhthanhpho = txt_tinhthanhBN.Text;
                                bn.Nghenghiep = txt_nghenghiep.Text;
                                bn.CMTND = txt_cmndBN.Text;
                                bn.Giaykhaisinh = txt_gkhaisinhBN.Text;
                                bn.Sdt = txt_sdtBN.Text;
                                benhnhanF bnF = new benhnhanF();
                                if (bnF.update_bn(bn))
                                {
                                    new ketquathanhcongForm().Show();

                                }
                                else
                                {
                                    MessageBox.Show("thất bại ");
                                }
                                chucnangBN = null;
                                int i = data_benhnhan.CurrentRow.Index;
                                Load_Data();
                                reset_control();
                                load_current_index(bn.IDbn);
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            else
            {
                cl.Cancel = true;
                errorProvider.SetError(chck_namBN, "Vui lòng chọn giới tính");
                errorProvider.SetError(chck_nuBN, "Vui lòng chọn giới tính");
            }



        }

        private void Btn_huyBN_Click(object sender, EventArgs e)
        {

        }
        public void reset_control()
        {
            chucnangBN = null;
            null_text_BN();
            enable_control_BN(false);
            data_benhnhan.Enabled = true;
            toolmn_luu.Enabled = toolmn_huy.Enabled = false;
            btn_CCthemBN.Enabled = true;
            btn_CCxoaBN.Enabled = Btn_CCsuaBN.Enabled = false;

        }

        private void Toolmn_huy_Click(object sender, EventArgs e)
        {
            reset_control();
        }

        private void Pnl_BHYT_Click(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void Pnl_ttBN_Click(object sender, EventArgs e)
        {
            label1.Select();
        }

        private void Pnl_BHYT_Paint(object sender, PaintEventArgs e)
        {

        }
        public PHONGBAN pb { get; set; }
        public void load_phongkhambenh(PHONGBAN pban)
        {
            Model1 md = new Model1();

            pb = pban;
            lbl_tenPK.Text = pb.Tenpb;
            DateTime date = DateTime.Parse((DateTime.Now.ToString("MM-dd-yyyy")));
            var soluong = md.BENHNHANLAMVIECs.Where(x => x.ngaydk == date && x.IDpb == pb.IDpb && x.IDtrangthai == "1").ToList();
            lbl_soluongkham.Text = "Số bệnh nhân chờ khám : " + soluong.Count.ToString();
            sttLamviec = soluong.Count;
        }
        int stt = 0;
        int sttLamviec = 0;
        private void Btn_next_Click(object sender, EventArgs e)
        {
            bunifuTransition.HideSync(btn_dangkykham);
            bunifuTransition.HideSync(lbl_soluongkham);
            bunifuTransition.HideSync(lbl_tenPK);
            bunifuTransition.HideSync(btn_phongkham);

            stt++;
            if (stt >= phongKB.Count) stt = 0;
            load_phongkhambenh(phongKB[stt]);

            bunifuTransition.HideSync(btn_dangkykham);
            bunifuTransition.HideSync(lbl_soluongkham);
            bunifuTransition.HideSync(lbl_tenPK);
            bunifuTransition.HideSync(btn_phongkham);


            bunifuTransition.ShowSync(btn_phongkham);
            bunifuTransition.ShowSync(btn_dangkykham);
            bunifuTransition.ShowSync(lbl_soluongkham);
            bunifuTransition.ShowSync(lbl_tenPK);

        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            bunifuTransition.HideSync(btn_dangkykham);
            bunifuTransition.HideSync(lbl_soluongkham);
            bunifuTransition.HideSync(lbl_tenPK);
            bunifuTransition.HideSync(btn_phongkham);


            stt--;
            if (stt < 0) stt = phongKB.Count - 1;
            load_phongkhambenh(phongKB[stt]);





            bunifuTransition.ShowSync(btn_phongkham);
            bunifuTransition.ShowSync(btn_dangkykham);
            bunifuTransition.ShowSync(lbl_soluongkham);
            bunifuTransition.ShowSync(lbl_tenPK);
        }

        private void Btn_dangkykham_Click(object sender, EventArgs e)
        {
            if (idbn == null)
            {
                MessageBox.Show("Vui lòng chọn một bệnh nhân để đăng ký làm việc !", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string txt = "Đăng ký cho bệnh nhân khám bệnh tại " + pb.Tenpb + " ?";
            DialogResult dr = MessageBox.Show(txt, "Đăng ký khám bệnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DateTime date = DateTime.Now.Date;
                var a = new Model1().BENHNHANLAMVIECs.Where(x => x.IDbn == idbn && x.IDtrangthai != "4" && x.ngaydk == date).FirstOrDefault();
                if (a != null)
                {
                    MessageBox.Show("Bệnh nhân không thể đăng ký khám tiếp vì lý do quá trình khám chữa bệnh của bệnh nhân vẫn chưa hoàn thành ", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                BENHNHANLAMVIEC bnlv = new BENHNHANLAMVIEC();
                bnlv.IDbn = idbn;
                bnlv.IDbnlv = "BNLV" + DateTime.Now.ToString("ddMMyyyy") + stt_BNLV();
                bnlv.IDpb = pb.IDpb;
                bnlv.ngaydk = DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy"));
                bnlv.giodk = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                string idex = phongKB[stt].IDpb;
                var lst = new Model1().BENHNHANLAMVIECs.Where(x => x.IDpb == idex && x.ngaydk == date).ToList();
                if (lst.Count == 0)
                {
                    bnlv.STT = 1;
                }
                else
                {
                    bnlv.STT = lst.Last().STT + 1;
                }
                bnlv.IDtrangthai = "1";
                bnlv.IDnv = nv.IDnv;
                if (new taothutuckhambenhF().Insert_BNLV(bnlv))
                {
                 

                    load_phongkhambenh(phongKB[stt]);
                    new Phieudangkykhambenh(bnlv).Show();
                }
                else
                {
                    MessageBox.Show("Đăng ký khám bệnh thất bại ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        public string stt_BNLV()
        {

            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().BENHNHANLAMVIECs.ToList();
            foreach (var item in ba)
            {
                if (item.IDbnlv.Contains(dt))
                {
                    i = (int.Parse(item.IDbnlv.Substring(12)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;

        }

        private void Btn_phongkham_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Danhsachchokham);
            if (formToShow != null)
            {
                formToShow.BringToFront();
            }
            else
                new Danhsachchokham(phongKB[stt]).Show();
        }
        private void Txt_cmndBN_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            CancelEventArgs ee = new CancelEventArgs();
            if (txt_cmndBN.Text != "")
            {

                if (e.KeyChar < 48 && e.KeyChar != 8 && e.KeyChar != 127  || e.KeyChar > 57 && e.KeyChar != 8 && e.KeyChar != 127)
                {
                    ee.Cancel = true;
                    txt_cmndBN.Focus();
                    errorProvider.SetError(txt_cmndBN, "Chỉ  được nhập số !");
                    toolmn_luu.Enabled = false;
                }
                else
                {
                    toolmn_luu.Enabled = true;
                    ee.Cancel = true;
                    errorProvider.Clear();
                }
            }
            else
            {
                toolmn_luu.Enabled = true;
                ee.Cancel = true;
                errorProvider.Clear();
            }
        }
        private void Txt_gkhaisinhBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelEventArgs ee = new CancelEventArgs();
            if (txt_gkhaisinhBN.Text != "")
            {

                if (e.KeyChar < 48 || e.KeyChar > 57)
                {

                    ee.Cancel = true;
                    txt_gkhaisinhBN.Focus();
                    errorProvider.SetError(txt_gkhaisinhBN, "Chỉ  được nhập số !"); toolmn_luu.Enabled = false;
                }
                else
                {
                    toolmn_luu.Enabled = true;
                    ee.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                toolmn_luu.Enabled = true;
                ee.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_sdtBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            CancelEventArgs ee = new CancelEventArgs();
            if (txt_sdtBN.Text != "")
            {

                if (e.KeyChar < 48 || e.KeyChar > 57)
                {
                    toolmn_luu.Enabled = false;
                    ee.Cancel = true;
                    txt_sdtBN.Focus();
                    errorProvider.SetError(txt_sdtBN, "Chỉ  được nhập số !");
                }
                else
                {
                    toolmn_luu.Enabled = true;
                    ee.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                toolmn_luu.Enabled = true;
                ee.Cancel = false;
                errorProvider.Clear();
            }
        }
    }
}

      
