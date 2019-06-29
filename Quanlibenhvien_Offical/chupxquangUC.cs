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
    public partial class chupxquangUC : UserControl
    {
        public chupxquangUC()
        {
            InitializeComponent();
        }
        public NHANVIEN nv { get; set; }
        public bophanxetnghiemUC bp { get; set; }
        public string idpttxn { get; set; }
        public string IDPB { get; set; }
        public PHIEUXETNGHIEM pxn { get; set; }
        public chupxquangUC(NHANVIEN NV, string pttxnID, bophanxetnghiemUC xnF)
        {
            InitializeComponent();
            nv = NV;
            idpttxn = pttxnID;
            IDPB = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter().GetDatabyIDnv(nv.IDnv).FirstOrDefault().IDpb;
            bp = xnF;

        }
        public string sttPXQ()
        {
            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().PHIEUXETNGHIEMs.Where(x => x.IDloai == "LH002").ToList();
            foreach (var item in ba)
            {
                if (item.IDpxn.Contains(dt))
                {
                    i = (int.Parse(item.IDpxn.Substring(11)) + 1).ToString();
                }
            }
            if (int.Parse(i) <= 9) i = "00" + i;
            if (int.Parse(i) >= 10) i = "0" + i;
            return i;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PHIEUXETNGHIEM sa = new PHIEUXETNGHIEM();
                sa.IDpxn = "PXQ" + DateTime.Now.ToString("ddMMyyyy") + sttPXQ();

                sa.IDnv = nv.IDnv;
                sa.IDpttxn = idpttxn;
                sa.IDpb = IDPB;
                sa.IDloai = "LH002";
                sa.mota = txt_mota.Text;
                sa.ketluan = txt_ketluan.Text;
                sa.thoigianlap = DateTime.Now;
                if (new phieuxetnghiemF().them(sa))
                {
                    pxn = sa;
                    try
                    {
                        Model1 md = new Model1();
                        var ptt = md.PHIEUTHANHTOANXNKTs.Find(idpttxn);
                        ptt.trangthaiXN = true;
                        md.SaveChanges();
                        new ketquathanhcongForm().Show();
                        btn_in.Enabled = true;
                        btn_save.Enabled = false;
                        btn_sua.Enabled = true;


                    }
                    catch (Exception)
                    {


                    }

                }
            }
          
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            new phieuchupxquangForm(pxn).Show();
            btn_end.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bp.call_refresh();
            this.Dispose();
        }

        private void Txt_mota_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mota.Text))
            {
                e.Cancel = true;
                txt_mota.Focus();
                errorProvider.SetError(txt_mota, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_ketluan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ketluan.Text))
            {
                e.Cancel = true;
                txt_ketluan.Focus();
                errorProvider.SetError(txt_ketluan, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }
    }
}
