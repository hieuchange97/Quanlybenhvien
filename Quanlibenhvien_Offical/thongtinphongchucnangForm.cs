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
    public partial class thongtinphongchucnangForm : Form
    {
        public thongtinphongchucnangForm()
        {
            InitializeComponent();
        }
        List<PHONGBAN> pblist = new List<PHONGBAN>();
        public thongtinphongchucnangForm(string idDichvu,string idptt,string idbn,string idnv,string idbhyt,string idba)
        {
            InitializeComponent();
            load_dsphongban(idDichvu);
            load_index();
            IDptt = idptt;
            IDbn = idbn;
            IDnv = idnv;
            IDbhyt = idbhyt;
            IDba = idba;
        }
        int stt = 0;
        public string IDptt { get; set; }
        public string IDbn { get; set; }
        public string IDnv { get; set; }
        public string IDbhyt { get; set; }
        public string IDba { get; set; }
        public void load_dsphongban(string txt)
        {
            var pbdv = new Model1().PHONGBANDICHVUs.Where(x => x.IDdichvu == txt).ToList();
            foreach (var item in pbdv)
            {
                var pb = new Model1().PHONGBANs.Find(item.IDpb);
                pblist.Add(pb);
            }
            lbl_title.Text = new Model1().PHONGBANs.Find(pblist[stt].IDpbCha).Tenpb;
        }
        public void load_index()
        {
            lbl_tenPCN.Text = pblist[stt].Tenpb;
            string idpb = pblist[stt].IDpb;
            DateTime date = DateTime.Now.Date;
            lbl_soluongcho.Text ="Số bệnh nhân chờ : " + new Model1().BENHNHANLAMVIECs.Where(x => x.IDpb ==idpb  && x.IDtrangthai == "1" && x.ngaydk ==date ).ToList().Count;
        }

        private void Btn_next_Click(object sender, EventArgs e)
        {
            stt++;
            if (stt >= pblist.Count) stt = 0;
            load_index();
        }

        private void Btn_previous_Click(object sender, EventArgs e)
        {
            stt--;
            if (stt <0) stt = pblist.Count-1;
            load_index();
        }

        private void Btn_phongchucnang_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is Danhsachchokham);
            if (formToShow != null)
            {
                formToShow.BringToFront();
            }
            else
                new Danhsachchokham(pblist[stt]).Show();
        }

        private void Btn_dangkykham_Click(object sender, EventArgs e)
        {
            string txt = " Đăng ký làm xét nghiệm tại " + lbl_tenPCN.Text + " ?";
          DialogResult dr = MessageBox.Show(txt, "Đăng ký", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DateTime date = DateTime.Now.Date;
                BENHNHANLAMVIEC bnlv = new BENHNHANLAMVIEC();
                bnlv.IDbn = IDbn;
                bnlv.IDbnlv = "BNLV" + DateTime.Now.ToString("ddMMyyyy") + stt_BNLV();
                bnlv.IDpb = pblist[stt].IDpb;
                bnlv.ngaydk = DateTime.Parse(DateTime.Now.ToString("MM-dd-yyyy"));
                bnlv.giodk = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                bnlv.IDba = IDba;
                string idex = pblist[stt].IDpb;
                var lst = new Model1().BENHNHANLAMVIECs.Where(x => x.IDpb == idex && x.ngaydk == date).ToList();
                if (lst.Count == 0)
                {
                    bnlv.STT = 1;
                }
                else
                {
                    bnlv.STT = lst.Last().STT + 1;
                }
                bnlv.IDtrangthai = "1";
                bnlv.IDnv = IDnv;
                if (new taothutuckhambenhF().Insert_BNLV(bnlv))
                {
                    btn_dangkykham.Enabled = false;
                    Model1 md = new Model1();
                    var ptt = md.PHIEUTHANHTOANXNKTs.Find(IDptt);
                    ptt.IDbnlv = bnlv.IDbnlv;
                    md.SaveChanges();                  
                    load_index();
                    if (IDbhyt!="")
                    {

                        new Phieuthanhtoanxetnghiem(new Model1().PHIEUTHANHTOANXNKTs.Find(IDptt), new Model1().NHANVIENs.Find(IDnv), IDbhyt, "Có").Show();
                    }
                    else
                    {
                        new Phieuthanhtoanxetnghiem(new Model1().PHIEUTHANHTOANXNKTs.Find(IDptt), new Model1().NHANVIENs.Find(IDnv), "    ", "Không").Show();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Đăng ký khám bệnh thất bại ", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        public string stt_BNLV()
        {

            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().BENHNHANLAMVIECs.ToList();
            foreach (var item in ba)
            {
                if (item.IDbnlv.Contains(dt))
                {
                    i = (int.Parse(item.IDbnlv.Substring(12)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;

        }
      
  
    }
}
