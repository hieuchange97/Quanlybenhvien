using Quanlibenhvien_Offical.Function;
using Quanlibenhvien_Offical.Object;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Quanlibenhvien_Offical
{
    public partial class Lapphieudangkykhambenh : Form
    {
        public Lapphieudangkykhambenh()
        {
            InitializeComponent();
           
        }
        public Lapphieudangkykhambenh(string info,string idbn,NHANVIEN NV)
        {

            InitializeComponent();
            lbl_time.Text = DateTime.Now.ToString();
            soluongBN();
            lbl_infoBN.Text = info;
            Id_bn = idbn;
            nv = NV;
        }
        public void soluongBN()
        {
            DateTime date = DateTime.Parse( DateTime.Now.ToShortDateString());
            //var p1 = new Model1().PHIEUDANGKYKHAMs.Where(x => x.ngaydk == date && x.trangthaikham == false&&x.IDdiadiem=="DD001" && x.trangthaikham==false).ToList();
            //var p2 = new Model1().PHIEUDANGKYKHAMs.Where(x => x.ngaydk == date && x.trangthaikham == false && x.IDdiadiem == "DD002" && x.trangthaikham == false).ToList();
            //var p3 = new Model1().PHIEUDANGKYKHAMs.Where(x => x.ngaydk == date && x.trangthaikham == false && x.IDdiadiem == "DD003" && x.trangthaikham == false).ToList();
            //if (p1 == null) lbl_phong1.Text = "0"; else lbl_phong1.Text = p1.Count.ToString();
            //if (p2 == null) lbl_phong1.Text = "0"; else lbl_phong2.Text = p2.Count.ToString();
            //if (p3 == null) lbl_phong1.Text = "0"; else lbl_phong3.Text = p3.Count.ToString();
          
        }
            
        public NHANVIEN nv
        {
            get;set;
        }
        public string Id_bn { get; set; }
        public string hoten { get; set; }
        private void Btn_dkk1_Click(object sender, EventArgs e)
        {
            //PHIEUDANGKYKHAM pdk = new PHIEUDANGKYKHAM();
            //pdk.IDdiadiem = "DD001";
            //pdk.IDbn = Id_bn;
            //pdk.IDpdk = "PDK" + DateTime.Now.ToString("ddMMyyyy")+bornIDpdk();
            //pdk.ngaydk = DateTime.Parse(DateTime.Now.ToShortDateString());
            //pdk.giodk = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //pdk.STT = set_STT("DD001");
            //pdk.trangthaikham = false;
            //pdk.IDnv = nv.IDnv;
            //if( new phieudangkykhamF().insert_pdkk(pdk))
            //{
            //    MessageBox.Show("true");
            //    soluongBN();
            //}
            //load_phieuDK();
            //show_phieudangky(pdk.IDpdk);

            
        }
        public void show_phieudangky(string idPDK) // xuất phiếu đăng ký để in ra
        {
            
            //Phieudangkykhambenh Pdk = new Phieudangkykhambenh(idPDK,nv);
            //Pdk.Show();
        }
        public int set_STT(string IDdiadiem)// tạo số thứ tự cho bệnh nhân
        {
            int stt= 1;
            //DateTime date = DateTime.Parse(DateTime.Now.ToShortDateString());
            //try
            //{
            //    var pdk = new Model1().PHIEUDANGKYKHAMs.Where(x => x.ngaydk == date && x.IDdiadiem == IDdiadiem && x.trangthaikham==false).ToList();
            //    if (pdk.Count > 0)
            //    {
            //        stt = pdk[pdk.Count - 1].STT + 1;
            //    }
             
            //}
            //catch (Exception)
            //{

                
            //}
            return stt;
        }
        public string bornIDpdk()
        {
            string stt = null;
            DateTime date =DateTime.Parse( DateTime.Now.ToShortDateString());
            try
            {
            //    var listPK = new Model1().PHIEUDANGKYKHAMs.Where(x => x.ngaydk == date).ToList();
            //    if (listPK.Count>0)
            //    {
            //        stt=listPK[listPK.Count-1].IDpdk;
            //        stt = stt.Substring(11);
            //        if (int.Parse(stt) < 9) stt = "00" + (int.Parse(stt) + 1).ToString();
            //        if(int.Parse(stt)>=9) stt="0"+ (int.Parse(stt) + 1).ToString();
            //        if (int.Parse(stt) >= 99) stt = (int.Parse(stt) + 1).ToString();
            //    }
            //    else
            //    {
            //        stt = "001";
            //    }
            }
            catch (Exception)
            {
                stt = "001";
               
            }
            return stt;
        }
        private void Btn_dkk2_Click(object sender, EventArgs e)
        {
            BENHNHANLAMVIEC bnlv = new BENHNHANLAMVIEC();
          
            bnlv.IDbn = Id_bn;
            bnlv.IDbnlv = "BNLV" + DateTime.Now.ToString("ddMMyyyy") + bornIDpdk();
            bnlv.ngaydk = DateTime.Parse(DateTime.Now.ToShortDateString());
            bnlv.giodk = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            bnlv.STT = set_STT("DD002");
          //  bnlv.TRANGTHAILAMVIEC = 1;
            //if (new phieudangkykhamF().insert_pdkk(pdk))
            //{
            //    MessageBox.Show("true");
            //    soluongBN();
            //}
            load_phieuDK();
            show_phieudangky(bnlv.IDbnlv);
        }

        private void Lapphieukhambenh_Load(object sender, EventArgs e)
        {

            load_phieuDK();
            header_text_datagrip();
        }
        public void load_phieuDK()
        {
            
        }
        public void header_text_datagrip()
        {
            data_phieuDK.Columns[0].HeaderText = "STT";
            data_phieuDK.Columns[1].HeaderText = "Mã phiếu ";
            data_phieuDK.Columns[2].HeaderText = "Mã bệnh nhân";
            data_phieuDK.Columns[3].HeaderText = "Mã địa điểm";
            data_phieuDK.Columns[4].HeaderText = "Ngày đăng ký ";
            data_phieuDK.Columns[5].HeaderText = "Giờ đăng ký ";
            data_phieuDK.Columns[6].HeaderText = "STT khám";
            data_phieuDK.Columns[7].HeaderText = "Trạng thái khám";
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_searchPDK_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_phong1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_searchPDK_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Btn_phong1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Btn_phong2_Click(object sender, EventArgs e)
        {

           
        }

        private void Btn_phong3_Click(object sender, EventArgs e)
        {

          
        }

        private void Btn_dkk3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
