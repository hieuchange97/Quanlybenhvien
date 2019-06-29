using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibenhvien_Offical.Function;
using Quanlibenhvien_Offical.Object;
using System.Data.SqlClient;
namespace Quanlibenhvien_Offical
{
    public partial class Batdaukhambenh : UserControl
    {
        public Batdaukhambenh()
        {
            InitializeComponent();
        }
        private static Batdaukhambenh instance;
        public static Batdaukhambenh Instance
        {
            get
            {
                if (instance == null) instance = new Batdaukhambenh();
                return instance;
            }
        }

        public NHANVIEN nv { get; set; }

        public BENHNHAN bn { get; set; }
        public BENHAN BA { get; set; }
        public PHIEUKHAMBENH PKB { get; set; }
        public DONTHUOC donthuoc { get; set; }
        public string IDpdK { get; set; }
        public Batdaukhambenh(BENHNHAN BN, NHANVIEN NV,string idpdk)
        {
            InitializeComponent();
            bn = BN;
            nv = NV;
           
            lbl_Idbn.Text += bn.IDbn.ToString();
            lbl_tenbn.Text += bn.hodem.ToString() + bn.Ten.ToString();
            IDpdK = idpdk;
            Taobenhan_phieukham();
        }
        public Batdaukhambenh(BENHNHAN Bn, NHANVIEN Nv, BENHAN Ba, string IDpkb,string IDpdangky)
        {
            InitializeComponent();
            bn = Bn;
            nv = Nv;
            BA = Ba;
            IDpdK = IDpdangky;
            PKB = new Model1().PHIEUKHAMBENHs.Find(IDpkb);
           lbl_Idbn.Text += bn.IDbn.ToString();
            lbl_tenbn.Text += bn.hodem.ToString() + bn.Ten.ToString();
            txt_chuandoanCLS.Enabled = true;
            //IDpdK = new Model1().BENHANs.Find(Ba.IDba).IDpdk;
            //txt_chuandoanCLS.Enabled = true;
            loadPKB_bnCLS(PKB); tooltrp_luukpCLS.Enabled = true;
            tooltrp_luukpCLS.Enabled = true;
            tooltrp_BNxn.Enabled = false;
        }
        public void loadPKB_bnCLS(PHIEUKHAMBENH pk)
        {
            txt_tieusubenh.Text = pk.Tieusubenh;
            txt_cacbophan.Text = pk.Cacbophan;
            txt_nhietdo.Text = pk.Nhietdo;
            txt_nhiptho.Text = pk.Nhiptho;
            txt_huyetap.Text = pk.Huyetap;
            txt_nhiptim.Text = pk.Nhiptim;
            txt_chuandoanCLS.Text = pk.ChuandoanCLS;
            txt_ketluan.Text = pk.Ketluan;
            txt_xuly.Text = pk.Xuly;
            chck_CLS.Checked = bool.Parse(pk.CLS.ToString());
        }
        private void Batdaukhambenh_Load(object sender, EventArgs e)
        {
            load_DSbenhan();
        }
        public void Taobenhan_phieukham()
        {

            BENHAN ba = new BENHAN();
            ba.IDba = "BA" + DateTime.Now.ToString("ddMMyyyy") + stt();
            ba.IDbn = bn.IDbn;
            ba.Ngaylap = DateTime.Now;
            
            BA = ba;


            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH();
            pkb.IDpk="PKB"+ DateTime.Now.ToString("ddMMyyyy") + stt();
            pkb.Ngaylap = DateTime.Now.Date;
            pkb.giolap = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            pkb.IDba = ba.IDba;
            pkb.IDnv = nv.IDnv;
            PKB = pkb;

            taothutuckhambenhF bn_pk = new taothutuckhambenhF();
            if(bn_pk.insert_ba(ba))
            {
                if (bn_pk.insert_phieukham(pkb))
                {
                    Model1 md = new Model1();
                    var bnlv = md.BENHNHANLAMVIECs.Find(IDpdK);
                    bnlv.IDba = ba.IDba;
                    bnlv.IDtrangthai = "2";
                    md.SaveChanges();
                    MessageBox.Show("Bệnh án điện tử và phiếu khám bệnh cho bệnh nhân vừa được tạo thành công", "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }
        public string stt()
        {
            string i  = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().BENHANs.ToList();
            foreach (var item in ba)
            {
                if (item.IDba.Contains(dt))
                {
                    i =(int.Parse( item.IDba.Substring(10))+1).ToString();
                }
            }
            if (int.Parse( i) <= 9) i= "00" + i;
            if (int.Parse(i) >= 10) i= "0" + i;
            return i;

        }
        private void Ttrmn_back_Click(object sender, EventArgs e)
        {
            if(new taothutuckhambenhF().huythongtinKB(BA, PKB))
            {
                MessageBox.Show("Hủy thành công");
                Model1 md = new Model1();
                var pdk = md.BENHNHANLAMVIECs.Find(IDpdK);
                pdk.IDtrangthai = "1";
                md.SaveChanges();
                Bophankhambenh bp = new Bophankhambenh(nv);


                if(this.Parent.Controls.Contains(bp))
                {
                    bp.BringToFront();
                }
                else
                {
                    this.Parent.Controls.Add(bp);
                    bp.Dock = DockStyle.Fill;
                    bp.BringToFront();
                }
            }
        }

        private void Chck_CLS_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_CLS.Checked == true)
            {
                tooltrp_luukpLS.Enabled = false;

                tooltrp_chuandoanLS.Enabled = false;
                tooltrp_chuandoanCLS.Enabled = true;
                tooltrp_duaBNdscho.Enabled = true;
            }
            else
            {
                tooltrp_luukpLS.Enabled = true;
          
                tooltrp_chuandoanLS.Enabled = true;
                tooltrp_chuandoanCLS.Enabled = false;
            }
        }

        private void Tooltrp_luukpLS_Click(object sender, EventArgs e)
        {
            if(txt_ketluan.Text!=""&& txt_xuly.Text != "")
            {
                PKB.Cacbophan = txt_cacbophan.Text;
                PKB.Tieusubenh = txt_tieusubenh.Text;
                PKB.Nhietdo = txt_nhietdo.Text;
                PKB.Nhiptho = txt_nhiptho.Text;
                PKB.Nhiptim = txt_nhiptim.Text;
                PKB.Huyetap = txt_huyetap.Text;
                PKB.Ketluan = txt_ketluan.Text;
                PKB.Xuly = txt_xuly.Text;
                if(new taothutuckhambenhF().update_phieukhambenh(PKB))
                {
                    new ketquathanhcongForm().Show();
                    tooltrp_donthuoc.Enabled = true;
                    tooltrp_inhoadon.Enabled = true;
                    Tooltrp_back.Enabled = false;
                    tooltrp_hoatatBA.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ vào trường kết quả và xử lý !", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Tooltrp_taoDT_Click(object sender, EventArgs e)
        {
            tooltrp_xemDT.Enabled = true;
            DONTHUOC DT = new DONTHUOC();
            DT.IDdonthuoc = "DT" + DateTime.Now.ToString("ddMMyyyy") + sttDT();
            DT.IDba = BA.IDba;
            DT.IDnv = nv.IDnv;
            DT.Ngaylap = DateTime.Now;
            if(new taothutuckhambenhF().insert_donthuoc(DT))
            {
                donthuoc = DT;
                new kedonthuoc(DT).Show();
            }
        }
        public string sttDT()
        {
            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().DONTHUOCs.ToList();
            foreach (var item in ba)
            {
                if (item.IDba.Contains(dt))
                {
                    i = (int.Parse(item.IDdonthuoc.Substring(10)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;
        }

        private void Tooltrp_xemDT_Click(object sender, EventArgs e)
        {
            kedonthuoc xemdon = new kedonthuoc(donthuoc, "a");
            xemdon.Show();
        }

        private void Tooltrp_hoatatBA_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Hoàn tất bệnh án và bàn giao cho bệnh nhân ?", "Hoàn tất bệnh án ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                BA.Ngaybangiao = DateTime.Now;
                if(new taothutuckhambenhF().update_ba(BA))
                {
                    new ketquathanhcongForm().Show();
                    tooltrp_ketthucKB.Enabled = true;
                    tooltrp_inhoadon.Enabled = true;
                }
            }
        }

        private void PhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inphieukhambenhF ip = new inphieukhambenhF(PKB, BA);
          
            ip.BringToFront();
            ip.Show();
        }

     

        private void LậpPhiếuThanhToánXNKTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PHIEUTHANHTOANXNKT ptt = new PHIEUTHANHTOANXNKT();
            ptt.IDpttxn = "PTT" + DateTime.Now.ToString("ddMMyyyy") + stt_ptt();
            ptt.IDba = BA.IDba;
            ptt.IDnv = nv.IDnv;
            ptt.phantramgiam = "0";
            ptt.trangthaitt = false;
            ptt.ngaylap = DateTime.Parse( DateTime.Now.ToShortDateString());
            ptt.giolap= new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            if(new taothutuckhambenhF().insert_phieutt(ptt))
            {
                new Phieuthanhtoanxetnghiem(ptt).Show();
            }

        }
        public string stt_ptt()
        {
            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().PHIEUTHANHTOANXNKTs.ToList();
            foreach (var item in ba)
            {
                if (item.IDpttxn.Contains(dt))
                {
                    i = (int.Parse(item.IDpttxn.Substring(11)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void Tooltrp_ketthucKB_Click(object sender, EventArgs e)
        {
          
                Model1 md = new Model1();
            var ba = md.BENHANs.Find(BA.IDba);
            ba.IDloaihinh = "2";
            md.SaveChanges();

                var pdk = md.BENHNHANLAMVIECs.Find(IDpdK);
                pdk.IDtrangthai = "4";
                md.SaveChanges();

            Bophankhambenh bpkb = new Bophankhambenh(nv);
            if (this.Parent.Controls.Contains(bpkb))
            {
                this.Dispose();
                bpkb.BringToFront();
            }
            else
            {
                this.Parent.Controls.Add(bpkb);
                bpkb.Dock = DockStyle.Fill;
                bpkb.BringToFront();
            }
        }

        private void Tooltrp_BNxn_Click(object sender, EventArgs e)
        {

        }

        private void Tooltrp_luukpCLS_Click(object sender, EventArgs e)
        {
            if (txt_ketluan.Text != "" && txt_xuly.Text != "" && txt_chuandoanCLS.Text != "")
            {
                PKB.Cacbophan = txt_cacbophan.Text;
                PKB.Tieusubenh = txt_tieusubenh.Text;
                PKB.Nhietdo = txt_nhietdo.Text;
                PKB.Nhiptho = txt_nhiptho.Text;
                PKB.Nhiptim = txt_nhiptim.Text;
                PKB.Huyetap = txt_huyetap.Text;
                PKB.Ketluan = txt_ketluan.Text;
                PKB.ChuandoanCLS = txt_chuandoanCLS.Text;
                PKB.Xuly = txt_xuly.Text;
                if (new taothutuckhambenhF().update_phieukhambenh(PKB))
                {
                    new ketquathanhcongForm().Show();
                    tooltrp_donthuoc.Enabled = true;
                    tooltrp_inhoadon.Enabled = true;
                    
                    tooltrp_hoatatBA.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ vào trường chuẩn đoán cận lâm sàng , kết quả và xử lý !", "Cảnh báo ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public void load_DSbenhan()
         {
            var a = new Model1().BENHANs.Where(x => x.IDbn == bn.IDbn).ToList();
            if (a != null)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    string idBenhan = a[i].IDba.ToString(); 
                    var pkb = new Model1().PHIEUKHAMBENHs.Where(x => x.IDba == idBenhan).FirstOrDefault();
                    if (pkb != null)
                    {
                        TreeNode benhan = new TreeNode("Bệnh án ngày "+a[i].Ngaylap);
                        benhan.Name = a[i].IDba;
                        TreeNode phieukhambenh = new TreeNode("Phiếu khám bệnh " + pkb.Ngaylap);
                        phieukhambenh.Nodes.Add(pkb.IDpk);
                        benhan.Nodes.Add(phieukhambenh);
                        treeView_benhan.Nodes.Add(benhan);
                    }
                }
            }
          
        }

        private void TreeView_benhan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Contains("PKB"))
            {
                var pk = new Model1().PHIEUKHAMBENHs.Find(e.Node.Text);
                var ba = new Model1().BENHANs.Find(e.Node.Parent.Parent.Name);
                inphieukhambenhF p = new inphieukhambenhF(pk, ba);
                p.BringToFront();
                p.ShowDialog();
               
            }
        }

        private void tooltrp_phieuhenKL_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tạo phiếu hẹn khám lại cho bệnh nhân ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                PHIEUHENKHAMLAI phkl = new PHIEUHENKHAMLAI();
                phkl.IDphieuhen = "PH" +DateTime.Now.ToString("ddMMyyyy")+ stt_phieuhen();
                phkl.IDba = BA.IDba;
                phkl.IDnv = nv.IDnv;
                phkl.ngaylap = DateTime.Parse(DateTime.Now.ToShortDateString());
                if(new taothutuckhambenhF().insert_phieuhenKL(phkl))
                {
                    new phieuhenkhamlaiF(phkl).Show();
                }
            }
        }
        public string stt_phieuhen()
        {
            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ph = new Model1().PHIEUHENKHAMLAIs.ToList();
            foreach (var item in ph)
            {
                if (item.IDphieuhen.Contains(dt))
                {
                    i = (int.Parse(item.IDphieuhen.Substring(10)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;
        }

        private void tooltrp_duaBNdscho_Click(object sender, EventArgs e)
        {
            try
            {
                PKB.Cacbophan = txt_cacbophan.Text;
                PKB.Tieusubenh = txt_tieusubenh.Text;
                PKB.Nhietdo = txt_nhietdo.Text;
                PKB.Nhiptho = txt_nhiptho.Text;
                PKB.Nhiptim = txt_nhiptim.Text;
                PKB.Huyetap = txt_huyetap.Text;
                PKB.Ketluan = txt_ketluan.Text;
                PKB.ChuandoanCLS = txt_chuandoanCLS.Text;
                PKB.Xuly = txt_xuly.Text;
                if (new taothutuckhambenhF().update_phieukhambenh(PKB))
                {
                    Model1 md = new Model1();
                    DateTime date = DateTime.Parse(DateTime.Now.ToShortDateString());
                    var bnlv = md.BENHNHANLAMVIECs.Find(IDpdK);
                    bnlv.IDtrangthai = "3";
                    md.SaveChanges();
                    PKB.CLS = true;
                    new taothutuckhambenhF().update_phieukhambenh(PKB);
                  
                    tool_lapPTT.Enabled = true;
                    tool_tieptuckham.Enabled = true;
                }


                   
            }
            catch (Exception)
            {
                MessageBox.Show("Thất bại "); tool_tieptuckham.Enabled = false;
            }
        }

        private void Tool_tieptuckham_Click(object sender, EventArgs e)
        {
           DialogResult dr =  MessageBox.Show("Tiếp tục khám bệnh cho bệnh nhân tiếp theo "," Thông báo ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Bophankhambenh bpkb = new Bophankhambenh(nv);
                if (this.Parent.Controls.Contains(bpkb))
                {
                    this.Dispose();
                    bpkb.BringToFront();
                }
                else
                {
                    this.Parent.Controls.Add(bpkb);
                    bpkb.Dock = DockStyle.Fill;
                    bpkb.BringToFront();
                }
            }
           
        }

        private void Pnl_phieukham_Click(object sender, EventArgs e)
        {
            label10.Select();
        }

        private void Pnl_phieukham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tooltrp_back.Enabled = false;
        }
    }
}
