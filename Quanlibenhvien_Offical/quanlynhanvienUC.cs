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
    public partial class quanlynhanvienUC : UserControl
    {
        public quanlynhanvienUC()
        {
            InitializeComponent();
            load_data();
            cb_bophan.DataSource = new Model1().KHOAs.ToList();
            cb_bophan.DisplayMember = "Tenkhoa";
            cb_bophan.ValueMember = "IDkhoa";

            cb_quyen.DataSource = new Model1().PHANQUYENs.ToList();
            cb_quyen.DisplayMember = "Tenquyen";
            cb_quyen.ValueMember = "IDquyen";
            
            cb_chucvu.DataSource = new Model1().CHUCVUs.ToList();
            cb_chucvu.DisplayMember = "tenchucvu";
            cb_chucvu.ValueMember = "IDchucvu";
            
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
        public void load_data()
        {
            data_nhanvien.DataSource = new dataquery2TableAdapters.DANHSACHNHANVIENTableAdapter().GetData();

        }

        private void Data_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_tendn.Text = txt_matkhau.Text = cb_quyen.Text = null;

                txt_idnv.Text = data_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_hoten.Text= data_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (data_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString() == "Nam") chck_nam.Checked = true; else chck_nu.Checked = true;
               
                txt_sdt.Text= data_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_xaphuong.Text= data_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_quanhuyen.Text = data_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_tinhthanh.Text = data_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                cb_chucvu.Text= data_nhanvien.Rows[e.RowIndex].Cells[8].Value.ToString();
                cb_trinhdo.Text= data_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
                cb_bophan.Text = data_nhanvien.Rows[e.RowIndex].Cells[10].Value.ToString();

                tool_sua.Enabled = tool_xoa.Enabled = tool_ttlv.Enabled=true;
                    Model1 md = new Model1();
                    var tk = md.TAIKHOANs.Where(x => x.IDnv == txt_idnv.Text).FirstOrDefault();
                    if (tk != null)
                    {
                        chck_TK.Checked = true;
                        txt_tendn.Text = tk.Tendn;
                        txt_matkhau.Text = tk.Matkhau;
                        cb_quyen.Text = md.PHANQUYENs.Find(tk.IDquyen).Tenquyen;
                    tool_capTK.Enabled = false;
                    }
                    else
                    {
                        chck_TK.Checked = false;
                    tool_capTK.Enabled = true;
                    }
          
            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled =tool_ttlv.Enabled= false;

            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Chck_TK_OnChange(object sender, EventArgs e)
        {
           
        }

        private void Chck_TK_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_TK.Checked == true)
            {
                lbl_matkhau.Visible = lbl_tendn.Visible = lbl_tenquyen.Visible = txt_tendn.Visible = txt_matkhau.Visible = cb_quyen.Visible = true;
            }
            else
            {
                if (chck_TK.Checked == false) lbl_matkhau.Visible = lbl_tendn.Visible = lbl_tenquyen.Visible = txt_tendn.Visible = txt_matkhau.Visible = cb_quyen.Visible = false;
            }
        }

        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            tool_luu.Enabled =tool_huy.Enabled= true;
            tool_sua.Enabled = tool_xoa.Enabled = tool_capTK.Enabled = false;
            txt_idnv.Text = "NV" + stt_nv();
            txt_hoten.Enabled = txt_sdt.Enabled = txt_xaphuong.Enabled = chck_nam.Enabled = chck_nu.Enabled = txt_xaphuong.Enabled = cb_chucvu.Enabled = cb_trinhdo.Enabled = cb_bophan.Enabled = true;
            txt_hoten.Text = txt_sdt.Text = txt_xaphuong.Text = txt_xaphuong.Text = cb_chucvu.Text = cb_trinhdo.Text = cb_bophan.Text =txt_quanhuyen.Text=txt_tinhthanh.Text= null;
            txt_quanhuyen.Enabled = txt_tinhthanh.Enabled = true;
            chck_TK.Visible = false;
            data_nhanvien.Enabled = false;
          
        }
        public void reset_control()
        {
           tool_luu.Enabled=tool_huy.Enabled= tool_sua.Enabled = tool_xoa.Enabled = tool_capTK.Enabled = false;
            tool_them.Enabled = true;
            txt_hoten.Enabled = txt_sdt.Enabled = txt_xaphuong.Enabled = chck_nam.Enabled = chck_nu.Enabled = txt_xaphuong.Enabled = txt_quanhuyen.Enabled=txt_tinhthanh.Enabled= cb_chucvu.Enabled = cb_trinhdo.Enabled =cb_quyen.Enabled= cb_bophan.Enabled = false;
            txt_hoten.Text = txt_sdt.Text = txt_xaphuong.Text = txt_xaphuong.Text = cb_chucvu.Text = cb_trinhdo.Text = cb_bophan.Text =txt_idnv.Text= null;
            chck_nam.Checked = chck_nu.Checked = false;chck_nam.Enabled = chck_nu.Enabled = false; txt_quanhuyen.Text = txt_tinhthanh.Text= null;
            chck_TK.Visible = true;
            data_nhanvien.Enabled = true; txt_tendn.Enabled = txt_matkhau.Enabled = false;

        }
        public string stt_nv()
        {
            var nv = new Model1().NHANVIENs.ToList();
            string stt = nv[nv.Count - 1].IDnv;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) >  9) stt = "0" + stt;

            return stt;
        }
        string chucnang = null;
        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {

                switch (chucnang)
                {
                    case "them":

                        {
                            NHANVIEN nv = new NHANVIEN();
                            nv.IDnv = txt_idnv.Text;
                            string a, b;
                            getName_nv(txt_hoten.Text, out a, out b);
                            nv.Hodem = a.Trim();
                            nv.Ten = b.Trim();
                            nv.Sđt = txt_sdt.Text;
                            if (chck_nam.Checked == true) nv.Gioitinh = true; else nv.Gioitinh = false;
                            nv.Xaphuong = txt_xaphuong.Text;
                            nv.Quanhuyen = txt_quanhuyen.Text;
                            nv.Tinhthanhpho = txt_tinhthanh.Text;
                            nv.IDchucvu = cb_chucvu.SelectedValue.ToString();
                            nv.IDkhoa = cb_bophan.SelectedValue.ToString();
                            nv.Trinhdo = cb_trinhdo.Text;
                            if (new nhanvienF().insert_nv(nv))
                            {
                                new ketquathanhcongForm().Show();chucnang = null;
                                load_data();
                                reset_control();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_nhanvien.RowCount - 2);
                                Data_nhanvien_CellClick(this, ee);
                                data_nhanvien[0, ee.RowIndex].Selected = true;
                                chucnang = null;
                            }


                            break;
                        }
                    case "sua":

                        {
                            NHANVIEN nv = new NHANVIEN();
                            nv.IDnv = txt_idnv.Text;
                            string a, b;
                            getName_nv(txt_hoten.Text, out a, out b);
                            nv.Hodem = a.Trim();
                            nv.Ten = b.Trim();
                            nv.Sđt = txt_sdt.Text;
                            if (chck_nam.Checked == true) nv.Gioitinh = true; else nv.Gioitinh = false;
                            nv.Xaphuong = txt_xaphuong.Text;
                            nv.Quanhuyen = txt_quanhuyen.Text;
                            nv.Tinhthanhpho = txt_tinhthanh.Text;
                            nv.IDchucvu = cb_chucvu.SelectedValue.ToString();
                            nv.IDkhoa = cb_bophan.SelectedValue.ToString();
                            nv.Trinhdo = cb_trinhdo.Text;

                            var tk = new Model1().TAIKHOANs.Where(x => x.IDnv == txt_idnv.Text).FirstOrDefault();
                            if (tk != null)
                            {
                                tk.Tendn = txt_tendn.Text;
                                tk.Matkhau = txt_matkhau.Text;
                                tk.IDquyen = cb_quyen.SelectedValue.ToString();
                            }
                            if (new nhanvienF().update(nv, tk))
                            {
                                new ketquathanhcongForm().Show(); chucnang = null;
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_nhanvien.CurrentRow.Index);
                                load_data();
                                reset_control();

                                Data_nhanvien_CellClick(this, ee);
                                data_nhanvien[0, ee.RowIndex].Selected = true;
                                chucnang = null;

                            }


                            break;
                        }
                    case "capTK":
                        {
                            TAIKHOAN tk = new TAIKHOAN();
                            tk.IDtk = "TK" + stt_tk();
                            tk.Tendn = txt_tendn.Text;
                            tk.Matkhau = txt_matkhau.Text;
                            tk.IDnv = txt_idnv.Text;
                            tk.IDquyen = cb_quyen.SelectedValue.ToString();
                            if (new nhanvienF().captk(tk))
                            {
                                new ketquathanhcongForm().Show();chucnang = null;
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_nhanvien.CurrentRow.Index);
                                load_data();
                                reset_control();

                                Data_nhanvien_CellClick(this, ee);
                                data_nhanvien[0, ee.RowIndex].Selected = true;
                                chucnang = null;
                            }

                            break;
                        }
                }
            }
        }

        private void Txt_idnv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idnv.Text))
            {
                e.Cancel = true;
                txt_idnv.Focus();
                errorProvider.SetError(txt_idnv, "Vui lòng nhập đủ thông tin !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_idnv, null);
            }
        }

        private void Txt_hoten_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_hoten.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_hoten.Focus();
                    errorProvider.SetError(txt_hoten, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }

            }
            else
            {
                if (!txt_hoten.Text.Trim().Contains(" "))
                {
                 
                    e.Cancel = true;
                    txt_hoten.Focus();
                    errorProvider.SetError(txt_hoten, "Vui lòng ngăn cách tên bằng dầu cách");



                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
            }
        }

        private void Txt_sdt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_sdt.Focus();
                    errorProvider.SetError(txt_sdt, "Vui lòng nhập đủ thông tin !");
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

        private void Chck_nam_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_nam.Checked == true) chck_nu.Checked = false; else if(chck_nam.Checked==false) chck_nu.Checked = true;
        }



        private void Txt_chucvu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_chucvu.Text))
            {
                if(chucnang=="them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    cb_chucvu.Focus();
                    errorProvider.SetError(cb_chucvu, "Vui lòng nhập đủ thông tin !");
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

        private void Cb_trinhdo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_trinhdo.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    cb_trinhdo.Focus();
                    errorProvider.SetError(cb_trinhdo, "Vui lòng nhập đủ thông tin !");
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

        private void Cb_bophan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_bophan.Text))

            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    cb_bophan.Focus();
                    errorProvider.SetError(cb_bophan, "Vui lòng nhập đủ thông tin !");
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

        private void Txt_xaphuong_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_xaphuong.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_xaphuong.Focus();
                    errorProvider.SetError(txt_xaphuong, "Vui lòng nhập đủ thông tin !");
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

        private void Txt_quanhuyen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_quanhuyen.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_quanhuyen.Focus();
                    errorProvider.SetError(txt_quanhuyen, "Vui lòng nhập đủ thông tin !");
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

        private void Txt_tinhthanh_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tinhthanh.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_tinhthanh.Focus();
                    errorProvider.SetError(txt_tinhthanh, "Vui lòng nhập đủ thông tin !");
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
        public void getName_nv(string hoten, out string hodem, out string ten)
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
                    MessageBox.Show("Chú ý ngăn cách các chữ từ bằng dấu cách ");

                }
            
        }

        private void Tool_huy_Click(object sender, EventArgs e)
        {
            reset_control();
            if (data_nhanvien.CurrentRow!= null)
            {
                Data_nhanvien_CellClick(this, new DataGridViewCellEventArgs(0, data_nhanvien.CurrentRow.Index));
            }
            
        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            tool_them.Enabled = tool_xoa.Enabled = tool_capTK.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_hoten.Enabled = txt_sdt.Enabled = txt_xaphuong.Enabled = chck_nam.Enabled = chck_nu.Enabled = txt_xaphuong.Enabled = cb_chucvu.Enabled = cb_trinhdo.Enabled = cb_bophan.Enabled = true;
            txt_quanhuyen.Enabled = txt_tinhthanh.Enabled = true;
            data_nhanvien.Enabled = false; txt_tendn.Enabled = txt_matkhau.Enabled = true;
        }

        private void Tool_capTK_Click(object sender, EventArgs e)
        {
            chucnang = "capTK";
            tool_capTK.Enabled = false;
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
          
            chck_TK.Checked = true;
            txt_tendn.Enabled = txt_matkhau.Enabled = cb_quyen.Enabled = true;
            txt_tendn.Text = txt_matkhau.Text = cb_quyen.Text = null;

        }
        public string stt_tk()
        {
            var nv = new Model1().TAIKHOANs.ToList();
            string stt = nv[nv.Count - 1].IDtk;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) > 9) stt = "0" + stt;

            return stt;
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            tool_them.Enabled = tool_sua.Enabled = tool_capTK.Enabled = tool_xoa.Enabled = false;
            tool_huy.Enabled = true;
            string txt = "Bạn có muốn xóa nhân viên " + txt_hoten.Text + " ra khỏi hệ thống ?";
            DialogResult dr = MessageBox.Show(txt, "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new nhanvienF().delete_NV(txt_idnv.Text))
                {
                    new ketquathanhcongForm().Show();
                    reset_control();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Thất bại","Stop",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    reset_control();
                }
            }
        }

        private void Txt_seachNV_TextChanged(object sender, EventArgs e)
        {
            if (txt_seachNV.Text != null)
            {
                if (cb_loc.SelectedIndex == 0)
                {
                    data_nhanvien.DataSource = new dataquery2TableAdapters.SEARCHNHANVIENTableAdapter().GetDatabyName(txt_seachNV.Text);
                }
                if (cb_loc.SelectedIndex == 1)
                {
                    data_nhanvien.DataSource = new dataquery2TableAdapters.SEARCHNHANVIENTableAdapter().GetDataByID(txt_seachNV.Text);
                }
                if (cb_loc.SelectedIndex == 2)
                {
                    data_nhanvien.DataSource = new dataquery2TableAdapters.SEARCHNHANVIENTableAdapter().GetDataBychucvu(txt_seachNV.Text);
                }
            }
            else
            {
                data_nhanvien.DataSource = new DataqueryTableAdapters.DANHSACHNHANVIENTableAdapter().GetData();
            }
        }

        private void Tool_ttlv_Click(object sender, EventArgs e)
        {
            var a = new Model1().NHANVIENs.Find(txt_idnv.Text);
            nhanvienlamviecF nvF = new nhanvienlamviecF(a);
            nvF.Show();
        }

        private void QuanlynhanvienUC_Load(object sender, EventArgs e)
        {

        }

        private void Txt_tendn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tendn.Text))
            {
                if (chucnang == "capTK" )
                {
                    e.Cancel = true;
                    txt_tendn.Focus();
                    errorProvider.SetError(txt_tendn, "Vui lòng nhập đủ thông tin !");
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

        private void Txt_matkhau_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_matkhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matkhau.Text))
            {
                if (chucnang == "capTK" )
                {
                    e.Cancel = true;
                    txt_matkhau.Focus();
                    errorProvider.SetError(txt_matkhau, "Vui lòng nhập đủ thông tin !");
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

        private void Cb_quyen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_quyen.Text))
            {
                if (chucnang == "capTK")
                {
                    e.Cancel = true;
                    cb_quyen.Focus();
                    errorProvider.SetError(cb_quyen, "Vui lòng nhập đủ thông tin !");
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

        private void Chck_nu_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_nu.Checked == true) chck_nam.Checked = false; else if (chck_nu.Checked == false) chck_nam.Checked = true;
        }

        private void Txt_seachNV_Click(object sender, EventArgs e)
        {

        }
    }
}
