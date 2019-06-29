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
using System.Data.SqlClient;

namespace Quanlibenhvien_Offical
{
    public partial class nhanvienlamviecF : Form
    {
        public nhanvienlamviecF()
        {
            InitializeComponent();


           

        }
        public nhanvienlamviecF(NHANVIEN NV)
        {
            InitializeComponent();
            nv = NV;

           

            txt_idnv.Text = nv.IDnv;
            txt_tennv.Text = nv.Hodem + nv.Ten;
            load_data();
        }
        public NHANVIEN nv { get; set; }
        public void load_data()
        {
            data_nvlv.DataSource = new Model1().Database.SqlQuery<nhanviencongviecF>("nhanviencongviec @id", new SqlParameter("@id", nv.IDnv)).ToList();
            header_data();
        }
        public void header_data()
        {
            data_nvlv.Columns[0].HeaderText = "Mã nhân viên";
            data_nvlv.Columns[1].HeaderText = "Họ đệm";
            data_nvlv.Columns[2].HeaderText = "Tên";        
            data_nvlv.Columns[6].HeaderText = "Thời gian bắt đầu";
            data_nvlv.Columns[7].HeaderText = "Thời gian kết thúc";
        }

        private void Data_nvlv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idnv.Text = data_nvlv.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_tennv.Text = data_nvlv.Rows[e.RowIndex].Cells[1].Value.ToString() + data_nvlv.Rows[e.RowIndex].Cells[2].Value.ToString();
               
                date_bd.Value = DateTime.Parse(data_nvlv.Rows[e.RowIndex].Cells[6].Value.ToString());
                date_kt.Value = DateTime.Parse(data_nvlv.Rows[e.RowIndex].Cells[7].Value.ToString());
                tool_sua.Enabled = tool_xoa.Enabled = true;
            }
            catch (Exception)
            {
                tool_sua.Enabled = tool_xoa.Enabled = false ;
            }

        }
        public void reset_control()
        {
            data_nvlv.Enabled =tool_them.Enabled= date_kt.Enabled=true;
            tool_xoa.Enabled = tool_sua.Enabled = tool_luu.Enabled = tool_huy.Enabled = false;
          
        }
        string chucnang = null;
        private void Tool_them_Click(object sender, EventArgs e)
        {
            chucnang = "them";
            tool_sua.Enabled = tool_xoa.Enabled = data_nvlv.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = date_bd.Enabled=date_kt.Enabled= true;
          
           
        }

        private void Cb_bp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception)
            {

           
            }
          

        }

        private void Cb_pb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              
               
            }
            catch (Exception)
            {

            }
          
        }

        private void Cb_bp_Validating(object sender, CancelEventArgs e)
        {
        }

        private void Cb_pb_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void Cb_dd_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnang)
                {
                    case "them":
                        {
                            NHANVIENLAMVIEC nv = new NHANVIENLAMVIEC();
                            nv.IDnv = txt_idnv.Text;
                           // nv.IDdiadiem = cb_dd.SelectedValue.ToString();
                          
                            nv.Thoigianbatdau = date_bd.Value;
                            nv.Thoigianketthuc = date_kt.Value;
                            if(new nhanviencongviecF().insert_nvlv(nv))
                            {
                                new ketquathanhcongForm().Show();
                                load_data();
                                reset_control();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_nvlv.RowCount - 1);
                                Data_nvlv_CellClick(this, ee);
                                data_nvlv.Rows[ee.RowIndex].Selected = true;
                            }
                            else
                            {
                                MessageBox.Show("Phân công công việc đã tồn tại vui lòng chọn phân công khác ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        }
                    case "sua":
                        {
                            NHANVIENLAMVIEC nv = new NHANVIENLAMVIEC();
                            nv.IDnv = txt_idnv.Text;
                          
                          
                            nv.Thoigianbatdau = date_bd.Value;
                            nv.Thoigianketthuc = date_kt.Value;

                            if(new nhanviencongviecF().update_nvlv(nv))
                            {
                                new ketquathanhcongForm().Show();
                                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(0, data_nvlv.RowCount - 1);
                                load_data();
                                reset_control();
                                Data_nvlv_CellClick(this, ee);
                                data_nvlv.Rows[ee.RowIndex].Selected = true;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Tool_sua_Click(object sender, EventArgs e)
        {
            chucnang = "sua";
            tool_them.Enabled = tool_xoa.Enabled = tool_sua.Enabled= data_nvlv.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            date_bd.Enabled = date_kt.Enabled = true;
        }

        private void Cb_bp_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Cb_pb_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void Tool_xoa_Click(object sender, EventArgs e)
        {
          
        }

        private void Txt_idnv_OnValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
