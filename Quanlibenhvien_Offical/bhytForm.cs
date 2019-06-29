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
    public partial class bhytForm : Form
    {
        public bhytForm()
        {
            InitializeComponent();
        }
        public bhytForm(BENHNHAN bn)
        {
           
            InitializeComponent();
            BN = bn;
       
            lbl_infoBN.Text="Mã bệnh nhân : " + BN.IDbn.ToString() + "\n"+"Tên bệnh nhân : " + BN.hodem.ToString() + " " + BN.Ten.ToString();
            load_data();
        }

        public void load_data()
        {
            data_bhyt.DataSource = new dataquery2TableAdapters.BHYTTableAdapter().GetDataIDbn(BN.IDbn);

            cb_tuyenBHYT.DataSource = new Model1().TUYENBHYTs.ToList();
            cb_tuyenBHYT.DisplayMember = "Tentuyen";
            cb_tuyenBHYT.ValueMember = "IDtuyen";

            cb_dtutBHYT.DataSource = new Model1().DTUTs.ToList();
            cb_dtutBHYT.DisplayMember = "TenDT";
            cb_dtutBHYT.ValueMember = "IDdt";
            header_datagrid();

            cb_tuyenBHYT.Text = cb_dtutBHYT.Text = null;
        }
        public void header_datagrid()
        {
            data_bhyt.Columns[0].HeaderText = "Mã BHYT";
            data_bhyt.Columns[1].HeaderText = "Ngày cấp";
            data_bhyt.Columns[2].HeaderText = "Ngày hết hạn";
            data_bhyt.Columns[3].HeaderText = "Cơ sở ban đầu";
            data_bhyt.Columns[4].HeaderText = "Tên tuyến";
            data_bhyt.Columns[5].HeaderText = "Tên đối tượng";
   
        }

        public BENHNHAN BN { get; set; }
        Dangkykhambenh DK { get; set; }

        string chucnangBHYT = null;
        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnangBHYT)
                {
                    case "them":
                        {
                            BHYT bh = new BHYT();
                            bh.IDbn = BN.IDbn;
                            bh.IDbhyt = txt_idBHYT.Text;
                            bh.Csbd = txt_idBHYT.Text;
                            bh.Ngaycap = date_ngaycap_bhyt.Value;
                            bh.Ngayhethan = date_ngayhetBHYT.Value;
                            bh.IDtuyen = cb_tuyenBHYT.SelectedValue.ToString();
                            bh.IDdt = int.Parse(cb_dtutBHYT.SelectedValue.ToString());
                            bhytF bhf = new bhytF();
                            if (bhf.them(bh))
                            {
                                new ketquathanhcongForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("thất bại ");
                            }
                            chucnangBHYT = null;
                            reset_control();
                            load_data();
                            Data_bhyt_CellClick(this, new DataGridViewCellEventArgs(0, data_bhyt.Rows.Count - 2));
                            data_bhyt.Rows[data_bhyt.Rows.Count - 2].Selected = true;
                            break;
                        }
                   
                    case "sua":
                        {
                            BHYT bh = new BHYT();
                            bh.IDbhyt = txt_idBHYT.Text;
                            bh.Ngaycap = date_ngaycap_bhyt.Value;
                            bh.Ngayhethan = date_ngayhetBHYT.Value;
                            bh.Csbd = txt_cbbdBHYT.Text;
                            bh.IDdt = int.Parse(cb_dtutBHYT.SelectedValue.ToString());
                            bh.IDtuyen = cb_tuyenBHYT.SelectedValue.ToString();
                            if (new bhytF().update(bh))
                            {
                                new ketquathanhcongForm().Show();
                             
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ");
                            }
                            chucnangBHYT = null;
                            var index = data_bhyt.CurrentRow.Index;
                            reset_control();
                            load_data();
                            Data_bhyt_CellClick(this, new DataGridViewCellEventArgs(0, index));
                            data_bhyt.Rows[index].Selected = true;
                            return;
                        }
                }
            }
       
        }

        private void Data_bhyt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idBHYT.Text = data_bhyt.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_cbbdBHYT.Text= data_bhyt.Rows[e.RowIndex].Cells[3].Value.ToString();
                date_ngaycap_bhyt.Value = DateTime.Parse(data_bhyt.Rows[e.RowIndex].Cells[1].Value.ToString());
                date_ngayhetBHYT.Value = DateTime.Parse(data_bhyt.Rows[e.RowIndex].Cells[2].Value.ToString());
                cb_dtutBHYT.Text= data_bhyt.Rows[e.RowIndex].Cells[5].Value.ToString();
                cb_tuyenBHYT.Text= data_bhyt.Rows[e.RowIndex].Cells[4].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled =btn_gcv.Enabled= true;
            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled=btn_gcv.Enabled = false;

            }
        }

        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnangBHYT = "them";
           tool_them.Enabled= tool_sua.Enabled = tool_xoa.Enabled = tool_back.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_idBHYT.Enabled = txt_cbbdBHYT.Enabled = date_ngaycap_bhyt.Enabled = date_ngayhetBHYT.Enabled = cb_dtutBHYT.Enabled = cb_tuyenBHYT.Enabled = true;
            txt_idBHYT.Text = txt_cbbdBHYT.Text = date_ngaycap_bhyt.Text = date_ngayhetBHYT.Text = cb_dtutBHYT.Text = cb_tuyenBHYT.Text = null ;
            data_bhyt.Enabled = true;
            btn_gcv.Enabled = false;

        }
        public void reset_control()
        {
            txt_idBHYT.Enabled = txt_cbbdBHYT.Enabled = date_ngaycap_bhyt.Enabled = date_ngayhetBHYT.Enabled = cb_dtutBHYT.Enabled = cb_tuyenBHYT.Enabled = false;
            tool_sua.Enabled = tool_xoa.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;
            tool_back.Enabled = tool_them.Enabled = true;
            data_bhyt.Enabled = true;
            chucnangBHYT = null;
            btn_gcv.Enabled = true;
        }

        private void Tool_back_Click(object sender, EventArgs e)
        {
          
           
            this.Close();
            var formToShow = Application.OpenForms.Cast<Form>()
         .FirstOrDefault(c => c is Quanlybenhvien);
            if (formToShow != null)
            {
                formToShow.Show();
            }

        }

        private void Txt_idBHYT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_idBHYT.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    txt_idBHYT.Focus();
                    errorProvider.SetError(txt_idBHYT, "vui lòng điền đầy đủ thông tin ");

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

        private void Txt_cbbdBHYT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cbbdBHYT.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    txt_cbbdBHYT.Focus();
                    errorProvider.SetError(txt_cbbdBHYT, "vui lòng điền đầy đủ thông tin ");

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

        private void Date_ngaycap_bhyt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(date_ngaycap_bhyt.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    date_ngaycap_bhyt.Focus();
                    errorProvider.SetError(date_ngaycap_bhyt, "vui lòng điền đầy đủ thông tin ");

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

        private void Date_ngayhetBHYT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(date_ngayhetBHYT.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    date_ngayhetBHYT.Focus();
                    errorProvider.SetError(date_ngayhetBHYT, "vui lòng điền đầy đủ thông tin ");

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

        private void Cb_dtutBHYT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_dtutBHYT.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    cb_dtutBHYT.Focus();
                    errorProvider.SetError(cb_dtutBHYT, "vui lòng điền đầy đủ thông tin ");

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

        private void Cb_tuyenBHYT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_tuyenBHYT.Text))
            {
                if (chucnangBHYT == "them" || chucnangBHYT == "sua")
                {
                    e.Cancel = true;
                    cb_tuyenBHYT.Focus();
                    errorProvider.SetError(cb_tuyenBHYT, "vui lòng điền đầy đủ thông tin ");

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

        private void Tool_huy_Click(object sender, EventArgs e)
        {
           
            int i = data_bhyt.CurrentRow.Index;
            reset_control();
          
            Data_bhyt_CellClick(this, new DataGridViewCellEventArgs(0, i));
            data_bhyt.Rows[i].Selected = true;

        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BhytForm_Load(object sender, EventArgs e)
        {

        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnangBHYT = "sua";
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled = tool_back.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_idBHYT.Enabled = txt_cbbdBHYT.Enabled = date_ngaycap_bhyt.Enabled = date_ngayhetBHYT.Enabled = cb_dtutBHYT.Enabled = cb_tuyenBHYT.Enabled = true;
            data_bhyt.Enabled = false;
            btn_gcv.Enabled = false;
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            btn_gcv.Enabled = false;
            tool_them.Enabled = tool_sua.Enabled =tool_back.Enabled= tool_luu.Enabled = tool_xoa.Enabled = false;
            tool_huy.Enabled = true;
            string txt = " Bạn có muốn xóa BHYT " + txt_idBHYT.Text + " ra khỏi hệ thống không ? ";
            DialogResult dr = MessageBox.Show(txt, " Xóa BHYT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if( new bhytF().xoa(txt_idBHYT.Text))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    reset_control();
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa BHYT này ra khỏi hệ thống vui lòng kiếm tra lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    reset_control();
                }
            }
            else
            {
                reset_control();
            }
        }

        private void Txt_searchbhyt_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchbhyt.Text != "")
            {
                data_bhyt.DataSource = new dataquery2TableAdapters.BHYTTableAdapter().GetDataBySearchID(BN.IDbn, txt_searchbhyt.Text);
            }

            else {
                data_bhyt.DataSource = new dataquery2TableAdapters.BHYTTableAdapter().GetDataIDbn(BN.IDbn);
            }
        }

        private void BhytForm_Click(object sender, EventArgs e)
        {
            lbl_infoBN.Select();
        }

        private void Btn_gcv_Click(object sender, EventArgs e)
        {
            this.Hide();
            var bh = new Model1().BHYTs.Find(txt_idBHYT.Text);
            new giaychuyenvienForm(bh, BN).Show();
        }
    }
}
