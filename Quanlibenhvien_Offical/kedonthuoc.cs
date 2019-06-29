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
    public partial class kedonthuoc : Form
    {
        public kedonthuoc()
        {
            InitializeComponent();
        }
        public kedonthuoc(DONTHUOC DT)
        {
            InitializeComponent();
            dt = DT;
        }
        public kedonthuoc(DONTHUOC DT , string txt)
        {
            InitializeComponent();
            dt = DT;
            load_data();
            btn_capnhat.Enabled = btn_xoa.Enabled = true;
            btn_save.Enabled = false;
        }
       
        public DONTHUOC dt { get; set; }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Kedonthuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlibenhvien_officalDataSet.THUOC' table. You can move, or remove it, as needed.
            this.tHUOCTableAdapter.Fill(this.quanlibenhvien_officalDataSet.THUOC);

            for (int i = 1; i <= 100; i++)
            {
                soluong.Items.Add(i);
            }

  

        }
        public void load_data()
        {
            int xx = data_kedonthuoc.RowCount;
            for (int i = xx - 1; i >= 0; i--)   // xóa các cột trong datagrid
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = data_kedonthuoc.Rows[i];
                if (!dr.IsNewRow) data_kedonthuoc.Rows.Remove(dr);
            }                                                        
            var chitietdon = new Model1().CHITIETDONTHUOCs.Where(x => x.IDdonthuoc == dt.IDdonthuoc).ToList();
          
            foreach (var item in chitietdon)
            {
                data_kedonthuoc.Rows.Add();
                data_kedonthuoc[0, data_kedonthuoc.Rows.Count - 2].Value = data_kedonthuoc.Rows.Count-1;
                data_kedonthuoc[1, data_kedonthuoc.Rows.Count - 2].Value = item.IDthuoc;
                data_kedonthuoc[2, data_kedonthuoc.Rows.Count - 2].Value = item.IDthuoc;
                data_kedonthuoc[3, data_kedonthuoc.Rows.Count - 2].Value = item.DVM;
                data_kedonthuoc[4, data_kedonthuoc.Rows.Count - 2].Value = item.Soluong;
                data_kedonthuoc[5, data_kedonthuoc.Rows.Count - 2].Value = item.Lieudung;
                //int index = DVT_dt.Items.IndexOf(item.DVM.Trim());
                //data_kedonthuoc[3, data_kedonthuoc.Rows.Count - 2].Value = DVT_dt.Items[index];
                //int indexSL = soluong.Items.IndexOf(item.Soluong);
                //data_kedonthuoc[4, data_kedonthuoc.Rows.Count - 2].Value = item.Soluong;

            }

        }


        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 2)
            //{
            //    MessageBox.Show("change");

            //}
        }

        private void DataGridView2_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
               
            }
        }

        private void Data_kedonthuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     
        private void Btn_themthuoc_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            data_kedonthuoc.ReadOnly = false;
            for (int i = 0; i < data_kedonthuoc.Rows.Count; i++)
            {
                if (data_kedonthuoc.Rows[i].Cells[2].Value == Cb_searchthuoc.SelectedValue)
                {
                    return;
                }
            }

            data_kedonthuoc.Rows.Add();
            data_kedonthuoc[0,data_kedonthuoc.Rows.Count-2].Value = data_kedonthuoc.Rows.Count -1 ;
            data_kedonthuoc[1,data_kedonthuoc.Rows.Count - 2].Value = Cb_searchthuoc.SelectedValue;
            data_kedonthuoc[2,data_kedonthuoc.Rows.Count - 2].Value = Cb_searchthuoc.SelectedValue;
           


        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < data_kedonthuoc.RowCount-1; i++)
            {
                if(data_kedonthuoc[3,i].Value==null || data_kedonthuoc[4, i].Value == null || data_kedonthuoc[5, i].Value == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào đơn thuốc !");return;
                }
            }
            if (data_kedonthuoc.Rows.Count > 1)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("Lưu lại đơn thuốc cho bệnh nhân ?", "Lưu ý ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        for (int i = 0; i < data_kedonthuoc.Rows.Count - 1;)
                        {
                            CHITIETDONTHUOC ctdt = new CHITIETDONTHUOC();
                            ctdt.IDdonthuoc = dt.IDdonthuoc;
                            ctdt.IDthuoc = data_kedonthuoc.Rows[i].Cells[1].Value.ToString();
                            ctdt.DVM = data_kedonthuoc.Rows[i].Cells[3].Value.ToString();
                            ctdt.Soluong = int.Parse(data_kedonthuoc.Rows[i].Cells[4].Value.ToString());
                            ctdt.Lieudung = data_kedonthuoc.Rows[i].Cells[5].Value.ToString();
                            if (new taothutuckhambenhF().search_thuoc(ctdt))
                            {
                                new taothutuckhambenhF().update_chitietthuoc(ctdt);
                                data_kedonthuoc.ReadOnly = true;
                                i++;

                            }
                            else
                            {
                                if (new taothutuckhambenhF().insert_chitietdonthuoc(ctdt)) i++; else { MessageBox.Show("Thêm thất bại "); return; }
                            }

                        }
                        new ketquathanhcongForm().Show();
                        btn_save.Enabled = false;
                        data_kedonthuoc.ReadOnly = true;
                    }
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("thất bại ");
                }

                
            }
        
        }

      

        private void Data_kedonthuoc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Exception.Message== "DataGridViewComboBoxCell value is not valid.")
            {
                object value = data_kedonthuoc.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
               
                if(!((DataGridViewComboBoxColumn)data_kedonthuoc.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)data_kedonthuoc.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Data_kedonthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (data_kedonthuoc.Rows[e.RowIndex].Cells[0].Value != null && btn_save.Enabled==false )
                {
                    btn_xoa.Enabled = btn_capnhat.Enabled = true;
                }
            }
            catch (Exception)
            {

                btn_xoa.Enabled = btn_capnhat.Enabled = false;
            }
           
           
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            
            btn_save.Enabled = btn_capnhat.Enabled = btn_themthuoc.Enabled = false;
           DialogResult dr = MessageBox.Show("Bạn muốn xóa thuốc " +new Model1().THUOCs.Find(((DataGridViewComboBoxCell)data_kedonthuoc.CurrentRow.Cells[2]).Value.ToString()) + " ra khỏi đơn thuốc ?","Xóa thuốc ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr== DialogResult.Yes)
            {
                if(new taothutuckhambenhF().delete_thuoc(data_kedonthuoc.CurrentRow.Cells[2].Value.ToString(), dt.IDdonthuoc))
                {
                    new ketquathanhcongForm().Show();
                    load_data();
                    btn_xoa.Enabled = false;
                    btn_themthuoc.Enabled = true;
                }
            }
            else
            {
                btn_save.Enabled =btn_xoa.Enabled= false; btn_capnhat.Enabled = btn_themthuoc.Enabled = true;
            }
        }

        private void Lst_searchTH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_searchthuoc_TextUpdate(object sender, EventArgs e)
        {
            if (Cb_searchthuoc.Text != "")
            {
                lstbox_searchTH.Visible = true;
                lstbox_searchTH.DataSource = new DataqueryTableAdapters.THUOCTableAdapter().GetData(Cb_searchthuoc.Text);
                lstbox_searchTH.DisplayMember = "Tenthuoc";
                lstbox_searchTH.ValueMember = "IDthuoc";
            }
            else
            {
                lstbox_searchTH.Visible = false;
            }
        }

        private void Cb_searchthuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                lstbox_searchTH.Select();
            }
        }

        private void Lstbox_searchTH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Cb_searchthuoc.SelectedValue = lstbox_searchTH.SelectedValue;
                lstbox_searchTH.Visible = false;
            }
        }
        ComboBox cb;
        private void Data_kedonthuoc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
            cb = e.Control as ComboBox;
           
            if(cb!=null )
            {
                
                    cb.SelectionChangeCommitted -= new EventHandler(cb_SelectionChangeCommitted);
                    cb.SelectionChangeCommitted += cb_SelectionChangeCommitted;
                
               
            }
        }
        private void cb_SelectionChangeCommitted(object sender,EventArgs e)
        {
            if (cb.ValueMember == "IDthuoc")
            {
                int i = 0;
                foreach (DataGridViewRow item in data_kedonthuoc.Rows)
                {

                    if (item.Cells[2].Value == cb.SelectedValue)
                    {
                        i++;
                    }

                }
                if (i == 1)
                {

                    MessageBox.Show("Thuốc "+ cb.Text+" đã có trong đơn thuốc , Vui lòng chọn thuốc khác !");
                    cb.Text = null;
                }
                else
                {
                    data_kedonthuoc.CurrentRow.Cells[0].Value = data_kedonthuoc.RowCount;
                    data_kedonthuoc.CurrentRow.Cells[1].Value = cb.SelectedValue;
                }
            }
         
        }

        private void Btn_capnhat_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_xoa.Enabled = btn_themthuoc.Enabled = false;
            data_kedonthuoc.ReadOnly = false;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
