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
    public partial class chucvuUC : UserControl
    {
        public chucvuUC()
        {
            InitializeComponent();
            load_data();
        }
        string chucnang = null;
        private void Txt_idchucvu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenchucvu.Text))
            {
                if (chucnang == "them" || chucnang == "sua")
                {
                    errorProvider.SetError(txt_tenchucvu, "Vui lòng điền thông tin đầy đủ !");
                    e.Cancel = true;
                    txt_tenchucvu.Focus();
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

        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            txt_tenchucvu.Enabled = true;
            txt_idchucvu.Text = "CV" + bord_idchucvu();
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled = false; tool_luu.Enabled = tool_huy.Enabled = true;
            txt_tenchucvu.Text = null;
            data_chucvu.Enabled = false;
        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            txt_tenchucvu.Enabled = true;
            tool_them.Enabled = tool_sua.Enabled = tool_xoa.Enabled = false; tool_luu.Enabled = tool_huy.Enabled = true;
            data_chucvu.Enabled = false;
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            tool_them.Enabled =data_chucvu.Enabled= tool_sua.Enabled= tool_xoa.Enabled = false;
            string txt = "Bạn có muốn xóa chức vụ " + txt_tenchucvu.Text + " ra khỏi hệ thống ?";
            DialogResult dr = MessageBox.Show(txt, "Xóa chức vụ ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new chucvuF().delete_chucvu(txt_idchucvu.Text))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    reset_control();
                }
                else
                {
                    MessageBox.Show("Bạn chưa thể xóa chức vụ này , chức vụ này đang được sử dụng trong hệ thống vui lòng gỡ bỏ những nơi sử dụng chức vụ này sau đó thực hiện xóa lại ! ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    tool_them.Enabled = data_chucvu.Enabled = tool_sua.Enabled = tool_xoa.Enabled = true;
                }

                
            }
            else
            {
                tool_them.Enabled = data_chucvu.Enabled = tool_sua.Enabled = tool_xoa.Enabled = true;
            }
        }

        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnang)
                {
                    case "sua":
                        {
                            CHUCVU cv = new CHUCVU();
                            cv.IDchucvu = txt_idchucvu.Text;
                            cv.tenchucvu = txt_tenchucvu.Text;

                            if(new chucvuF().update_chucvu(cv))
                            {
                                new ketquathanhcongForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            reset_control();
                            load_data();
                            select_inDatagrid(cv.IDchucvu);
                            break;

                        }
                    case "them":
                        {
                            CHUCVU cv = new CHUCVU();
                            cv.IDchucvu = txt_idchucvu.Text;
                            cv.tenchucvu = txt_tenchucvu.Text;

                            if (new chucvuF().insert_chucvu(cv))
                            {
                                new ketquathanhcongForm().Show();
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            reset_control();
                            load_data();
                            select_inDatagrid(cv.IDchucvu);
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        public string bord_idchucvu()
        {
            string a = null;
           a  = new Model1().CHUCVUs.ToList().LastOrDefault().IDchucvu;
            if (a != null)
            {
                a = (int.Parse(a.Substring(2)) + 1).ToString();
                if (int.Parse(a) < 10) a = "00" + a;
                if (int.Parse(a) >= 10 && int.Parse(a)<100) a = "0" + a;

            }
            return a;
        }
        public void reset_control()
        {
            chucnang = null;
            txt_tenchucvu.Enabled = false;
            tool_them.Enabled = data_chucvu.Enabled = true;
            tool_sua.Enabled = tool_luu.Enabled = tool_xoa.Enabled = tool_huy.Enabled = false;
            txt_idchucvu.Text = txt_tenchucvu.Text = null;
            label1.Select();
        }
        public void select_inDatagrid(string txt)
        {
            foreach (DataGridViewRow item in data_chucvu.Rows)
            {
                if (!item.IsNewRow)
                {
                    if (item.Cells[0].Value.ToString() == txt)
                    {
                        item.Selected = true;
                        Data_chucvu_CellClick(this, new DataGridViewCellEventArgs(0, item.Index));
                    }
                }
            
            }
        }

        private void Data_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idchucvu.Text = data_chucvu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenchucvu.Text = data_chucvu.Rows[e.RowIndex].Cells[1].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled = true;

            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled = false;
            }
        }
        public void header_datagrid()
        {
            data_chucvu.Columns[0].HeaderText = "Mã chức vụ";
            data_chucvu.Columns[1].HeaderText = "Tên chức vụ";
        }
        public void load_data()
        {
            data_chucvu.DataSource = new dataquery2TableAdapters.CHUCVUTableAdapter().GetData();
            header_datagrid();
        }
    }
}
