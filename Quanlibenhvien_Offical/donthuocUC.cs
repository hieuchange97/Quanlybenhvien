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
    public partial class donthuocUC : UserControl
    {
        public donthuocUC()
        {
            InitializeComponent();
        }
        public donthuocUC(NHANVIEN NV)
        {
            InitializeComponent();
            nv = NV;
            load_data();
        }
        public NHANVIEN nv { get; set; }
        public void load_data()
        {
            data_ba.DataSource = new DataqueryTableAdapters.DONTHUOCTableAdapter().GetData();
            header_databa();

        }
        public void header_databa()
        {
            data_ba.Columns[0].HeaderText = "Mã bệnh nhân ";
            data_ba.Columns[1].HeaderText = "Họ đệm";
            data_ba.Columns[2].HeaderText = "Tên";
            data_ba.Columns[3].HeaderText = "Mã bệnh án";
            data_ba.Columns[4].HeaderText = "Mã đơn thuốc";
            data_ba.Columns[5].HeaderText = "Ngày lập";
        }
        private void Txt_search_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Data_donthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_idbn.Text = data_ba.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_hovaten.Text= data_ba.Rows[e.RowIndex].Cells[1].Value.ToString()+ data_ba.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_idba.Text= data_ba.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_iddt.Text= data_ba.Rows[e.RowIndex].Cells[4].Value.ToString();
                date_ngaylap.Value=DateTime.Parse( data_ba.Rows[e.RowIndex].Cells[5].Value.ToString());

                data_dt.DataSource = new DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter().GetData(txt_idba.Text);
                header_dt();
                double tien = 0;
                foreach (DataGridViewRow item in data_dt.Rows)
                {
                    if (!item.IsNewRow)
                    {

                        tien += int.Parse(item.Cells[4].Value.ToString()) * int.Parse(item.Cells[2].Value.ToString());
                        lbl_tien.Text = "Tổng tiền " + tien + " VNĐ";
                        lbl_tien.Visible = true;
                        btn_in.Visible = true;
                    }
                   
                }
               
            }
            catch (Exception)
            {
                lbl_tien.Visible = false;
                btn_in.Visible = false;
            }
        }
        public void header_dt()
        {
            data_dt.Columns[0].HeaderText = "Tên thuốc ";
            data_dt.Columns[2].HeaderText = "Sô lượng mua ";
            data_dt.Columns[1].HeaderText = "Đơn vị mua";
            data_dt.Columns[3].HeaderText = "Liều dùng ";
            data_dt.Columns[3].HeaderText = "Đơn giá ";
        }
        private void Txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                data_ba.DataSource = null;
                data_ba.DataSource = new DataqueryTableAdapters.DONTHUOCTableAdapter().GetDataByIDba(txt_search.Text);
                header_databa();
            }
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            var ba = new Model1().BENHANs.Find(txt_idba.Text);
            new donthuocIN(nv, ba).Show();
        }
    }
}
