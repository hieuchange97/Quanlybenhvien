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
    public partial class Bophankhambenh : UserControl
    {
        public Bophankhambenh()
        {
            InitializeComponent();
           
        }
       
        public Bophankhambenh(NHANVIEN NV)
        {
            InitializeComponent();
            nv = NV;

        }
        public string IDdiadiem { get; set; }
        public NHANVIEN nv { get; set; }
        public BENHNHAN bn { get; set; }
        public string IDpdk { get; set; }
        public void Searchphong_theoNV()
        {
            var a = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter().GetDatabyIDnv(nv.IDnv).First();
            IDdiadiem = a.IDpb;
            lbl_tenbophan.Text = a.Tenkhoa;
            lbl_tenphong.Text = a.Tenpb;
          
        }
        public void load_dsbenhnhanCho( string iddd)
        {

            dataquery2TableAdapters.DANHSACHBENHNHANCHOTableAdapter adapterBN = new dataquery2TableAdapters.DANHSACHBENHNHANCHOTableAdapter();
            dataquery2.DANHSACHBENHNHANCHODataTable tableBN = new dataquery2.DANHSACHBENHNHANCHODataTable();
            adapterBN.Fill(tableBN, iddd);
            data_dsBNcho.DataSource = tableBN;
        }
      
       
        
        private void Bophankhambenh_Load(object sender, EventArgs e)
        {
            lbl_timenow.Text = DateTime.Now.ToString();
            Searchphong_theoNV();
            load_dsbenhnhanCho(IDdiadiem);
            load_DSbn_lamXN(IDdiadiem);
            header_dataBNcho();
            header_data_BNxetnghiem();
            timer_realtime.Start();
        }
        
        private void Btn_khamBPKB_Click(object sender, EventArgs e)
        {

            if (!this.Parent.Controls.Contains(Batdaukhambenh.Instance))
            {
                Batdaukhambenh.Instance.Dock = DockStyle.Fill;
                this.Parent.Controls.Add(Batdaukhambenh.Instance);
            }
            this.Parent.Controls["Batdaukhambenh"].BringToFront();
        }

        private void BắtĐầuKhámBệnhChoBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Batdaukhambenh bd = new Batdaukhambenh(bn,nv,IDpdk);
           
            if(this.Parent.Controls.Contains(bd))
            {

                bd.BringToFront();
            }
            else
            {
                this.Parent.Controls.Add(bd);
                bd.Dock = DockStyle.Fill;
                bd.BringToFront();
            }
         
           
        }

        private void BệnhNhânChờKhámBệnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_timenow_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Data_dsBNcho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btn_khambenhBNcho.Enabled = true;
                tooltrp_BNcho.Enabled = true;
                tooltrp_BNdoi.Enabled = false;
                txt_IDba.Text = null;  
                txt_idBN.Text=  data_dsBNcho.Rows[e.RowIndex].Cells[0].Value.ToString();
                bn = new Model1().BENHNHANs.Find(txt_idBN.Text);
                txt_hotenBN.Text = data_dsBNcho.Rows[e.RowIndex].Cells[1].Value.ToString() +" "+ data_dsBNcho.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_tuoiBN.Text = (DateTime.Now.Year - DateTime.Parse(data_dsBNcho.Rows[e.RowIndex].Cells[7].Value.ToString()).Year).ToString();
                txt_idPDK.Text = data_dsBNcho.Rows[e.RowIndex].Cells[9].Value.ToString();
                txt_sttkham.Text = data_dsBNcho.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_quequanBN.Text = data_dsBNcho.Rows[e.RowIndex].Cells[3].Value.ToString() +" - "+ data_dsBNcho.Rows[e.RowIndex].Cells[4].Value.ToString() + " - "+data_dsBNcho.Rows[e.RowIndex].Cells[5].Value.ToString();
                IDpdk = data_dsBNcho.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch (Exception)
            {
                btn_khambenhBNcho.Enabled = false;

            }
        }
        public void header_dataBNcho()
        {
            data_dsBNcho.Columns[0].HeaderText = "Mã bệnh nhân";
            data_dsBNcho.Columns[1].HeaderText = "Họ đệm";
            data_dsBNcho.Columns[2].HeaderText = "Tên";
            data_dsBNcho.Columns[6].HeaderText = "Giới tính";
            data_dsBNcho.Columns[7].HeaderText = "Ngày sinh";
            data_dsBNcho.Columns[3].HeaderText = "Xã phường";
            data_dsBNcho.Columns[4].HeaderText = "Quận huyện";
            data_dsBNcho.Columns[5].HeaderText = "Tỉnh thành phố";

            data_dsBNcho.Columns[8].HeaderText = "STT";
            data_dsBNcho.Columns[9].HeaderText = "Số phiếu đăng ký ";
        }
        private void Pnl_bndoi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_buttonKB_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Data_dsBNcho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Data_BNhangdoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_searchbn_cho_Click(object sender, EventArgs e)
        {
           
        }

        private void Txt_searchbn_cho_TextChanged(object sender, EventArgs e)
        {
            dataquery2TableAdapters.DANHSACHBENHNHANCHOTableAdapter adapterBN = new dataquery2TableAdapters.DANHSACHBENHNHANCHOTableAdapter();

            if (txt_searchbn_cho.Text != "")
            {
                if (cb_searchBN_cho.SelectedIndex == 0)
                {
                    data_dsBNcho.DataSource = null;
                    data_dsBNcho.DataSource = adapterBN.GetDataByIDbn(IDdiadiem,txt_searchbn_cho.Text);
                    header_dataBNcho();
                }
                if (cb_searchBN_cho.SelectedIndex == 1)
                {
                    data_dsBNcho.DataSource =adapterBN.GetDataByName(IDdiadiem, txt_searchbn_cho.Text );
                    header_dataBNcho();
                }
                if (cb_searchBN_cho.SelectedIndex == 2)
                {
                    data_dsBNcho.DataSource = adapterBN.GetDataBySTT(IDdiadiem,int.Parse( txt_searchbn_cho.Text));
                    header_dataBNcho();
                }
            }
            else
            {
                load_dsbenhnhanCho(IDdiadiem);
                header_dataBNcho();
            }
        }

        private void Timer_realtime_Tick(object sender, EventArgs e)
        {
            lbl_timenow.Text = DateTime.Now.ToString();
            
        }

        private void Tooltrp_lamtuoi_Click(object sender, EventArgs e)
        {
            load_dsbenhnhanCho(IDdiadiem);
            load_DSbn_lamXN(IDdiadiem);
        }
        public void load_DSbn_lamXN(string dd)
        {
            data_BNhangdoi.DataSource = new dataquery2TableAdapters.DANHSACHBNCHUANDOANCLSTableAdapter().GetDatabyIDpb(IDdiadiem);
           
        }
        public void header_data_BNxetnghiem()
        {
            data_BNhangdoi.Columns[0].HeaderText = "Mã bệnh nhân";
            data_BNhangdoi.Columns[1].HeaderText = "Họ đệm";
            data_BNhangdoi.Columns[2].HeaderText = "Tên";
            data_BNhangdoi.Columns[7].HeaderText = "Ngày Sinh";
            data_BNhangdoi.Columns[6].HeaderText = "Giới tính";
            data_BNhangdoi.Columns[3].HeaderText = "Xã phường";
            data_BNhangdoi.Columns[4].HeaderText = "Quận huyện";
            data_BNhangdoi.Columns[5].HeaderText = "Tỉnh thành phố";
           
            data_BNhangdoi.Columns[8].HeaderText = "STT";
            data_BNhangdoi.Columns[9].HeaderText = "Số phiếu đăng ký ";
        }

        private void Data_BNhangdoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tooltrp_BNcho.Enabled = false;
                tooltrp_BNdoi.Enabled = true;

               
               
                txt_idBN.Text = data_BNhangdoi.Rows[e.RowIndex].Cells[0].Value.ToString();
                bn = new Model1().BENHNHANs.Find(txt_idBN.Text);
                txt_hotenBN.Text= data_BNhangdoi.Rows[e.RowIndex].Cells[1].Value.ToString()+ data_BNhangdoi.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_tuoiBN.Text= (DateTime.Now.Year - DateTime.Parse(data_BNhangdoi.Rows[e.RowIndex].Cells[7].Value.ToString()).Year).ToString();
                txt_quequanBN.Text = data_BNhangdoi.Rows[e.RowIndex].Cells[3].Value.ToString()+" - " + data_BNhangdoi.Rows[e.RowIndex].Cells[4].Value.ToString() +" - "+ data_BNhangdoi.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_idPDK.Text = data_BNhangdoi.Rows[e.RowIndex].Cells[9].Value.ToString();
            
                txt_sttkham.Text =data_BNhangdoi.Rows[e.RowIndex].Cells[8].Value.ToString();
                txt_IDba.Text = new Model1().BENHNHANLAMVIECs.Find(txt_idPDK.Text).IDba;
                tool_chuandoanCLS.Enabled = true;


            }
            catch (Exception)
            {
                tool_chuandoanCLS.Enabled = false;
             
            }
        }

        private void Cb_searchBN_cho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_searchBN_cho_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_searchbn_cho.Focus();
        }

        private void Cb_searchBN_doi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_searchBNdoi.Focus();
        }

        
        private void Txt_searchBNdoi_TextChanged(object sender, EventArgs e)
       {
            if (txt_searchBNdoi.Text != "")
            {
                switch (cb_searchBN_doi.SelectedIndex)
                {
                    case 0:
                        {
                            data_BNhangdoi.DataSource = new DataqueryTableAdapters.DanhsachbenhnhandixetnghiemTableAdapter().GetDataByIDbn(IDdiadiem, txt_searchBNdoi.Text);
                            break;
                        }
                    case 1:
                        {
                            data_BNhangdoi.DataSource = new DataqueryTableAdapters.DanhsachbenhnhandixetnghiemTableAdapter().GetDataByIDba(IDdiadiem, txt_searchBNdoi.Text);
                            break;
                        }
                    case 2:
                        {
                            data_BNhangdoi.DataSource = new DataqueryTableAdapters.DanhsachbenhnhandixetnghiemTableAdapter().GetDataByIDpk(IDdiadiem, txt_searchBNdoi.Text);
                            break;
                        }
                    default:
                        {
                            
                            break;
                        }
                }
            }
            else
            {
                data_BNhangdoi.DataSource = new DataqueryTableAdapters.DanhsachbenhnhandixetnghiemTableAdapter().GetData(IDdiadiem);
            }
        }

        private void tooltrp_chuandoanCLS_Click(object sender, EventArgs e)
        {
            var Ba = new Model1().BENHANs.Find(txt_IDba.Text);

            string idpk = new Model1().PHIEUKHAMBENHs.Where(x => x.IDba == Ba.IDba).FirstOrDefault().IDpk;

           
            Batdaukhambenh db = new Batdaukhambenh(bn, nv, Ba, idpk,txt_idPDK.Text);
          
            if (this.Parent.Controls.Contains(db))
            {
                db.BringToFront();
            }
            else
            {
                this.Parent.Controls.Add(db);
                db.Dock = DockStyle.Fill;
                db.BringToFront();
            }
        }

        private void Tooltrp_dangxuat_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
          

        }
    }
}
