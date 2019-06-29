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
    public partial class quanlykhoaUC : UserControl
    {
        public quanlykhoaUC()
        {
            InitializeComponent();
            load_data();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
        public void load_data()
        {
            data_bophan.DataSource = new dataquery2TableAdapters.KHOATableAdapter().GetData();
            header_datagrid();
        }
        public void header_datagrid()
        {
            data_bophan.Columns[0].HeaderText = "Mã khoa";
            data_bophan.Columns[1].HeaderText = "Tên khoa";
            data_bophan.Columns[2].HeaderText = "Mã trưởng khoa ";
            data_bophan.Columns[3].HeaderText = "Ngày thành lập";
        }
        private void Data_bophan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               
                txt_idbp.Text = data_bophan[0, e.RowIndex].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled = true;
                txt_tenbp.Text= data_bophan[1, e.RowIndex].Value.ToString();
                date_ngayTL.Value = DateTime.Parse(data_bophan[3, e.RowIndex].Value.ToString());

                cb_tenTP.DataSource = new dataquery2TableAdapters.NHANVIEN_KHOATableAdapter().GetData(txt_idbp.Text);
                cb_tenTP.DisplayMember = "hoten";
                cb_tenTP.ValueMember = "IDnv";
                cb_tenTP.Text = null;
                if (data_bophan.Rows[e.RowIndex].Cells[2].Value.ToString() != "")  cb_tenTP.SelectedValue = data_bophan.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled = false;

            }   
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        string chucnang = null;
        private void Tool_them_Click(object sender, EventArgs e)
        {
            txt_idbp.Text = txt_tenbp.Text = null; date_ngayTL.Value = DateTime.Now;
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled =data_bophan.Enabled= false;
            tool_luu.Enabled = true;
            chucnang = "them";
            txt_idbp.Text ="KH"+ stt_bp();
            txt_tenbp.Enabled  = date_ngayTL.Enabled = true;
            data_bophan.Enabled = false;
            tool_huy.Enabled = true;
            lbl_tenTP.Visible = cb_tenTP.Visible = false;
        }
        public string stt_bp()
        {
            var kh = new Model1().KHOAs.ToList();
            string stt = kh[kh.Count-1].IDkhoa;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) > 9) stt = "0" + stt;
            return stt;
           
        }
        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnang)
                {
                    case "them":
                        {
                            KHOA kh = new KHOA();
                            kh.IDkhoa = txt_idbp.Text;
                            kh.Tenkhoa = txt_tenbp.Text;
                          
                            kh.Ngaythanhlap = date_ngayTL.Value;
                            if(new khoaF().insert_kh(kh))
                            {
                                new ketquathanhcongForm().Show();
                                chucnang = null;
                                load_data();
                                reset_control();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_bophan.RowCount - 1);
                                Data_bophan_CellClick(this, ee);
                                data_bophan.Rows[ee.RowIndex-1].Cells[0].Selected = true;
                            }
                            break;
                        }
                    case "sua":
                        {
                            KHOA kh = new KHOA();
                            kh.IDkhoa = txt_idbp.Text;
                            kh.Tenkhoa = txt_tenbp.Text;
                            if (cb_tenTP.DataSource != null)
                            {
                                kh.IDtruongkhoa = cb_tenTP.SelectedValue.ToString();
                            }
                            kh.Ngaythanhlap = date_ngayTL.Value;
                            if (new khoaF().update_kh(kh))
                            {
                                new ketquathanhcongForm().Show();
                                chucnang = null;
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_bophan.CurrentRow.Index );
                                load_data();
                                reset_control();
                                Data_bophan_CellClick(this, ee);
                                data_bophan.Rows[ee.RowIndex].Cells[0].Selected = true;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Txt_idbp_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void Txt_tenbp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenbp.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    e.Cancel = true;
                    txt_tenbp.Focus();
                    errorProvider.SetError(txt_tenbp, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(txt_tenbp, null);
                }
               
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_tenbp, null);
            }
         
        }

        private void Cb_tenTP_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void Tool_huy_Click(object sender, EventArgs e)
        {
            reset_control();
            Data_bophan_CellClick(this, new DataGridViewCellEventArgs(0, data_bophan.CurrentRow.Index));
        }
        public void reset_control()
        {
            chucnang = null;
            cb_tenTP.DataSource = null;
            txt_idbp.Text = txt_tenbp.Text = null; date_ngayTL.Value = DateTime.Now;
            txt_tenbp.Enabled = date_ngayTL.Enabled =cb_tenTP.Enabled= false;
            data_bophan.Enabled = true;
            lbl_tenTP.Visible = cb_tenTP.Visible = true;
            tool_sua.Enabled = tool_xoa.Enabled = tool_huy.Enabled = tool_luu.Enabled= false;tool_them.Enabled = true;
        }

        private void Cb_tenTP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
          tool_xoa.Enabled=  tool_them.Enabled = false;tool_huy.Enabled = tool_luu.Enabled= true;
            data_bophan.Enabled = false;
            date_ngayTL.Enabled = txt_tenbp.Enabled = cb_tenTP.Enabled = true;
        

        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            string txt = "Bạn có muốn xóa bộ phận "+ txt_tenbp.Text +" ?";
            DialogResult dr = MessageBox.Show(txt, "Xóa một bộ phận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new khoaF().delete_kh(txt_idbp.Text))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    reset_control();
                }
                else
                {
                    MessageBox.Show("Thất bại ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reset_control();
                }
            }
        }

        private void Txt_searchkhoa_Click(object sender, EventArgs e)
        {
          
        }

        private void Txt_searchkhoa_TextChanged(object sender, EventArgs e)
        {
            if (txt_idbp.Text != "")
            {
                if (txt_searchkhoa.Text != "")
                {
                    switch (cb_search.SelectedIndex)
                    {
                        case 0:
                            {
                                data_bophan.DataSource = new dataquery2TableAdapters.KHOATableAdapter().GetDataByTen(txt_searchkhoa.Text);
                                break;
                            }
                        case 1:
                            {
                                data_bophan.DataSource = new dataquery2TableAdapters.KHOATableAdapter().GetDataByID(txt_searchkhoa.Text);
                                break;
                            }
                       
                    }
                              
                }
                else
                {
                    data_bophan.DataSource = new dataquery2TableAdapters.KHOATableAdapter().GetData();

                }
            }
        }
    }
}
