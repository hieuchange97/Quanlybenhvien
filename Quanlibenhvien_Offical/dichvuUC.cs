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
    public partial class dichvuUC : UserControl
    {
        public dichvuUC()
        {
            InitializeComponent();
            load_dv();
        }

        private void DichvuUC_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
        public void load_dv()
        {
            data_dichvu.DataSource = new DataqueryTableAdapters.DICHVUTableAdapter().GetData();
            header_data();
        }
        public void header_data()
        {
            data_dichvu.Columns[0].HeaderText = "Mã dịch vụ";
            data_dichvu.Columns[1].HeaderText = "Tên dịch vụ";
            data_dichvu.Columns[2].HeaderText = "Máy móc ";
            data_dichvu.Columns[3].HeaderText = "Giá tiền";
        }
        private void Data_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_iddv.Text = data_dichvu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tendv.Text= data_dichvu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_maymoc.Text= data_dichvu.Rows[e.RowIndex].Cells[2].Value.ToString();
              txt_giatien.Text=  data_dichvu.Rows[e.RowIndex].Cells[3].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled = true;

            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled = false;

            }
        }
        string chucnang = null;
        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            data_dichvu.Enabled = false;
            tool_sua.Enabled = tool_xoa.Enabled = false;
            txt_tendv.Enabled = txt_maymoc.Enabled = txt_giatien.Enabled = true;
            txt_iddv.Text = "DV" + stt_DV();
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_tendv.Text = txt_maymoc.Text = txt_giatien.Text = null;

        }
        public string stt_DV()
        {
            var dd = new Model1().DICHVUs.ToList();
            string stt = dd[dd.Count - 1].IDdichvu;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) > 9) stt = "0" + stt;

            return stt;
        }
        public void reset_control()
        {
            tool_them.Enabled = true;
            tool_sua.Enabled = tool_xoa.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;
            txt_giatien.Enabled = txt_iddv.Enabled = txt_tendv.Enabled = txt_maymoc.Enabled = false;
            data_dichvu.Enabled = true ;
            txt_iddv.Text = txt_tendv.Text = txt_maymoc.Text = txt_giatien.Text = null;

        }
        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnang)
                {
                    case "them":
                        {
                            DICHVU dv = new DICHVU();
                            dv.IDdichvu = txt_iddv.Text;
                            dv.TenDV = txt_tendv.Text;
                            dv.Maymoc = txt_maymoc.Text;
                                dv.Giatien = int.Parse(txt_giatien.Text);
                            if(new dichvuF().insert_DV(dv))
                            {
                                new ketquathanhcongForm().Show();
                                load_dv();
                                reset_control();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_dichvu.Rows.Count - 2);
                                Data_dichvu_CellClick(this, ee);
                                data_dichvu.Rows[ee.RowIndex].Selected = true;
                            }
                            break;
                        }

                    case "sua":
                        {
                            DICHVU dv = new DICHVU();
                            dv.IDdichvu = txt_iddv.Text;
                            dv.TenDV = txt_tendv.Text;
                            dv.Maymoc = txt_maymoc.Text;
                            dv.Giatien = int.Parse(txt_giatien.Text);
                            if (new dichvuF().uodate_DV(dv))
                            {
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_dichvu.CurrentRow.Index);
                                new ketquathanhcongForm().Show();
                                load_dv();
                                reset_control();
                                Data_dichvu_CellClick(this, ee);
                                data_dichvu.Rows[ee.RowIndex].Selected = true;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Txt_iddv_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Txt_tendv_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_tendv.Text))
            {
                e.Cancel = true;
                txt_tendv.Focus();
                errorProvider.SetError(txt_tendv, "Vui lòng nhập đủ thông tin !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_tendv, null);
            }
        }

        private void Txt_maymoc_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_maymoc.Text))
            {
                e.Cancel = true;
                txt_maymoc.Focus();
                errorProvider.SetError(txt_maymoc, "Vui lòng nhập đủ thông tin !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_maymoc, null);
            }
        }

        private void Txt_giatien_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_giatien.Text))
            {
                e.Cancel = true;
                txt_giatien.Focus();
                errorProvider.SetError(txt_giatien, "Vui lòng nhập đủ thông tin !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_giatien, null);
            }
        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            tool_sua.Enabled=  tool_them.Enabled = tool_xoa.Enabled = data_dichvu.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_tendv.Enabled = txt_maymoc.Enabled = txt_giatien.Enabled = true;
         
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            string txt = "Bạn có muốn xóa dịch vụ " + txt_tendv.Text + " ra khỏi hệ thống ?";
            DialogResult dr = MessageBox.Show(txt, "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new dichvuF().delete_dv(txt_iddv.Text))
                {
                    new ketquathanhcongForm().Show();
                    load_dv();
                    reset_control();
                }
                else
                {
                    MessageBox.Show("Dịch vụ đang được sử dụng không thể xóa ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DichvuUC_Click(object sender, EventArgs e)
        {
            data_dichvu.Focus();
        }
    }
}
