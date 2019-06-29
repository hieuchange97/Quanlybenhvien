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
    public partial class quanlyquyentruycapUC : UserControl
    {
        public quanlyquyentruycapUC()
        {
            InitializeComponent();
            load_data();
        }
        public void load_data()
        {
            data_quyen.DataSource = new Model1().PHANQUYENs.ToList();
            header_data();
        }
        public void header_data()
        {
            data_quyen.Columns[0].HeaderText = "Mã quyền";
            data_quyen.Columns[1].HeaderText = "Tên quyền";
            data_quyen.Columns[2].Visible = false;
        }

        private void Data_quyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idquyen.Text = data_quyen.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tenquyen.Text = data_quyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                tool_sua.Enabled = tool_xoa.Enabled = true;
            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled = false;

            }
        }

        private void Tool_them_Click(object sender, EventArgs e)
        {
            data_quyen.Enabled = false;
             txt_tenquyen.Enabled = true;
            txt_idquyen.Text = "PQ" + stt_PQ();
            txt_tenquyen.Text = null;
            tool_luu.Enabled = tool_huy.Enabled = true;
            chucnang = "them";
            tool_sua.Enabled = false;
        }
        public void reset_control()
        {
            txt_tenquyen.Enabled = txt_idquyen.Enabled = tool_sua.Enabled = tool_xoa.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;
            tool_them.Enabled = data_quyen.Enabled = true;
        }
        public string stt_PQ()
        {
            var pb = new Model1().PHANQUYENs.ToList();
            string stt = pb[pb.Count - 1].IDquyen;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) > 9) stt = "0" + stt;

            return stt;
        }

        private void Tool_huy_Click(object sender, EventArgs e)
        {
            reset_control();
        }
        string chucnang = null;
        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnang)
                {
                    case "them":
                        {
                            PHANQUYEN pq = new PHANQUYEN();
                            pq.IDquyen = txt_idquyen.Text;
                            pq.Tenquyen = txt_tenquyen.Text;
                            if (new quyentruycapF().insert_quyen(pq))
                            {
                                new ketquathanhcongForm().Show();
                                load_data();
                                reset_control();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_quyen.Rows.Count - 1);
                                Data_quyen_CellClick(this, ee);
                                data_quyen.Rows[ee.RowIndex].Selected = true;

                            }

                            break;
                        }
                    case "sua":
                        {
                            PHANQUYEN pq = new PHANQUYEN();
                            pq.IDquyen = txt_idquyen.Text;
                            pq.Tenquyen = txt_tenquyen.Text;
                            if (new quyentruycapF().update_quyen(pq))
                            {
                                new ketquathanhcongForm().Show();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_quyen.CurrentRow.Index);
                                load_data();
                                reset_control();

                                Data_quyen_CellClick(this, ee);
                                data_quyen.Rows[ee.RowIndex].Selected = true;

                            }
                            break;
                        }
                }

            }
        }
        private void Txt_tenquyen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenquyen.Text))
            {
                e.Cancel = true;
                txt_tenquyen.Focus();
                errorProvider.SetError(txt_tenquyen, "Vui lòng nhập đủ thông tin !");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txt_tenquyen, null);
            }
        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            data_quyen.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            tool_them.Enabled = false;
            txt_tenquyen.Enabled = true;
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
            tool_them.Enabled=tool_luu.Enabled = tool_sua.Enabled = data_quyen.Enabled = false;
            tool_huy.Enabled = true;
            string txt = "Bạn có muốn xóa phân quyền " + txt_tenquyen.Text + " ra khỏi hệ thống >";
            DialogResult dr = MessageBox.Show(txt, "Xóa phân quyền", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(new quyentruycapF().delete_quyen(txt_idquyen.Text))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    reset_control();
                }
                else
                {
                    MessageBox.Show("Phân quyền này đang được sử dụng không thể xóa ", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    load_data();
                    reset_control();
                }
            }
        }

        private void QuanlyquyentruycapUC_Click(object sender, EventArgs e)
        {
            label1.Select();
        }
    }
}
