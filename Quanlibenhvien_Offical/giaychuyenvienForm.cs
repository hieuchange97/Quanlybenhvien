using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical
{
    public partial class giaychuyenvienForm : Form
    {
        public giaychuyenvienForm()
        {
            InitializeComponent();
        }
        public giaychuyenvienForm(BHYT bh, BENHNHAN bn)
        {
            InitializeComponent();
            BH = bh;
            BN = bn;
            lbl_infoBHYT.Text = "Mã bảo hiểm y tế : " + BH.IDbhyt +"\n"+ "Tên bệnh nhân : " + BN.hodem+" "+bn.Ten;
            load_data();
        }
        public BHYT BH { get; set; }
        public BENHNHAN BN {get;set;}
        private void GiaychuyenvienForm_Load(object sender, EventArgs e)
        {

        }

        private void GiaychuyenvienForm_Click(object sender, EventArgs e)
        {
            lbl_infoBHYT.Select();
        }
        public void load_data()
        {
            data_gcv.DataSource = new dataquery2TableAdapters.GIAYCHUYENVIENTableAdapter().GetData(BH.IDbhyt);
            data_gcv.Columns[1].Visible = false;
            header_datagrid();
        }
        public void header_datagrid()
        {
            data_gcv.Columns[0].HeaderText = "Mã GCV";
            data_gcv.Columns[2].HeaderText = "Ngày cấp";
            data_gcv.Columns[3].HeaderText = "Chuẩn đoán";
            data_gcv.Columns[4].HeaderText = "Lý do chuyển";
            data_gcv.Columns[5].HeaderText = "Nơi cấp";
            data_gcv.Columns[6].HeaderText = "Người cấp";
      

        }

        private void Tool_back_Click(object sender, EventArgs e)
        {
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is bhytForm);
            if (formToShow != null)
            {
                formToShow.Show();
            }
        }

        private void Data_gcv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idGCV.Text = data_gcv.Rows[e.RowIndex].Cells[0].Value.ToString();
                date_ngaycap.Value=DateTime.Parse(data_gcv.Rows[e.RowIndex].Cells[2].Value.ToString());
                txt_chuandoan.Text = data_gcv.Rows[e.RowIndex].Cells[3].Value.ToString();
               txt_lydo.Text= data_gcv.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_noicap.Text = data_gcv.Rows[e.RowIndex].Cells[5].Value.ToString();
              txt_nguoicap.Text=  data_gcv.Rows[e.RowIndex].Cells[6].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled = true;

            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_luu.Enabled = false;
            }
        }
        string chucnangGCV = null;
        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnangGCV = "them";
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled = tool_back.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_idGCV.Enabled = date_ngaycap.Enabled = txt_chuandoan.Enabled = txt_lydo.Enabled = txt_noicap.Enabled = txt_nguoicap.Enabled = true;
            txt_idGCV.Text  = txt_chuandoan.Text = txt_lydo.Text = txt_noicap.Text = txt_nguoicap.Text = null ;
            data_gcv.Enabled = false;
        }
        public void reset_control(int i )
        {
            chucnangGCV = null;
            tool_them.Enabled = tool_back.Enabled=data_gcv.Enabled = true;
            tool_sua.Enabled = tool_xoa.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;
            txt_idGCV.Enabled = date_ngaycap.Enabled = txt_chuandoan.Enabled = txt_lydo.Enabled = txt_noicap.Enabled = txt_nguoicap.Enabled = false;
            txt_idGCV.Text = txt_chuandoan.Text = txt_lydo.Text = txt_noicap.Text = txt_nguoicap.Text = null;
           
            Data_gcv_CellClick(this, new DataGridViewCellEventArgs(0, i));
            data_gcv.Rows[i].Selected = true;
        }

        private void Tool_huy_Click(object sender, EventArgs e)
        {
            reset_control(data_gcv.CurrentRow.Index);
        }

        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnangGCV)
                {
                    case "them":
                        {
                            GIAYCHUYENVIEN gcv = new GIAYCHUYENVIEN();
                            gcv.IDgcv = txt_idGCV.Text;
                            gcv.IDbhyt = BH.IDbhyt;
                            gcv.Ngaycap = date_ngaycap.Value;
                            gcv.Chuandoan = txt_chuandoan.Text;
                            gcv.lydochuyen = txt_lydo.Text;
                            gcv.Noicap = txt_noicap.Text;
                            gcv.Nguoicap = txt_nguoicap.Text;
                            if (new giaychuyenvienF().insert_GCV(gcv))
                            {
                                new ketquathanhcongForm().Show();

                            }
                            chucnangGCV = null;
                            load_data();
                            reset_control(data_gcv.Rows.Count-2);
                           
                            break;
                        }
                    case "sua":
                        {
                            GIAYCHUYENVIEN gcv = new GIAYCHUYENVIEN();
                            gcv.IDgcv = txt_idGCV.Text;
                            gcv.IDbhyt = BH.IDbhyt;
                            gcv.Ngaycap = date_ngaycap.Value;
                            gcv.Chuandoan = txt_chuandoan.Text;
                            gcv.lydochuyen = txt_lydo.Text;
                            gcv.Noicap = txt_noicap.Text;
                            gcv.Nguoicap = txt_nguoicap.Text;
                            if (new giaychuyenvienF().update_GCV(gcv))
                            {
                                new ketquathanhcongForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại");
                            }
                            chucnangGCV = null;
                            int i = data_gcv.CurrentRow.Index;
                          
                            load_data();
                            reset_control(i);
                            data_gcv.Rows[i].Selected = true;
                            break;
                        }

                }
            }
        }

        private void Txt_idGCV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idGCV.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    txt_idGCV.Focus();
                    errorProvider.SetError(txt_idGCV, "vui lòng điền đầy đủ thông tin ");

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

        private void Date_ngaycap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(date_ngaycap.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    date_ngaycap.Focus();
                    errorProvider.SetError(date_ngaycap, "vui lòng điền đầy đủ thông tin ");

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

        private void Txt_chuandoan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_chuandoan.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    txt_chuandoan.Focus();
                    errorProvider.SetError(txt_chuandoan, "vui lòng điền đầy đủ thông tin ");

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

        private void Txt_lydo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lydo.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    txt_lydo.Focus();
                    errorProvider.SetError(txt_lydo, "vui lòng điền đầy đủ thông tin ");

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

        private void Txt_noicap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noicap.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    txt_noicap.Focus();
                    errorProvider.SetError(txt_noicap, "vui lòng điền đầy đủ thông tin ");

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

        private void Txt_nguoicap_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nguoicap.Text))
            {
                if (chucnangGCV == "them" || chucnangGCV == "sua")
                {
                    e.Cancel = true;
                    txt_nguoicap.Focus();
                    errorProvider.SetError(txt_nguoicap, "vui lòng điền đầy đủ thông tin ");

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

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnangGCV = "sua";
            tool_them.Enabled = tool_sua.Enabled = tool_back.Enabled = tool_xoa.Enabled = data_gcv.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
           date_ngaycap.Enabled = txt_chuandoan.Enabled = txt_lydo.Enabled = txt_noicap.Enabled = txt_nguoicap.Enabled = true;

        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            tool_back.Enabled = tool_them.Enabled = tool_sua.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;data_gcv.Enabled = false;
            string txt = "Bạn có muốn xóa giấy chuyển viện " + txt_idGCV.Text + " ra khỏi hệ thống không ?";
            DialogResult dr = MessageBox.Show(txt, "Xóa giấy chuyển viện ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new giaychuyenvienF().delete_GCV(txt_idGCV.Text, BH.IDbhyt))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    reset_control(data_gcv.CurrentRow.Index);
                }
            }
            else
            {
                reset_control(data_gcv.CurrentRow.Index);
            }
        }

        private void Txt_searchgcv_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchgcv.Text != "")
            {
                data_gcv.DataSource = new dataquery2TableAdapters.GIAYCHUYENVIENTableAdapter().GetDataBySearchIDgcv(BH.IDbhyt, txt_searchgcv.Text);
            }
            else
            {
                data_gcv.DataSource = new dataquery2TableAdapters.GIAYCHUYENVIENTableAdapter().GetData(BH.IDbhyt);
            }
        }

        // Đăng ký khám bệnh 

 
    }
}
