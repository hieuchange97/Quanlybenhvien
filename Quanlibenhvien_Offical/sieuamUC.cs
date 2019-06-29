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
    public partial class sieuamUC : UserControl
    {
        bophanxetnghiemUC bp;
        public sieuamUC()
        {
            InitializeComponent();

        }
        public NHANVIEN nv { get; set; }
        
        public string idpttxn { get; set; }
        public string IDPB { get; set; }
        public sieuamUC(NHANVIEN NV,string pttxnID,bophanxetnghiemUC xnF)
        {
            InitializeComponent();
            nv = NV;
            idpttxn = pttxnID;
            IDPB = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter().GetDatabyIDnv(nv.IDnv).FirstOrDefault().IDpb;
            bp = xnF;
           
        }


        public string sttPSA()
        {
            string i = "1";
            string dt = DateTime.Now.ToString("ddMMyyyy").ToString();
            var ba = new Model1().PHIEUXETNGHIEMs.Where(x => x.IDloai == " ").ToList();
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

        public PHIEUXETNGHIEM pxn { get; set; }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PHIEUXETNGHIEM sa = new PHIEUXETNGHIEM();
                sa.IDpxn = "PSA" + DateTime.Now.ToString("ddMMyyyy") + sttPSA();
                sa.gan = txt_gan.Text;
                sa.mat = txt_mat.Text;
                sa.lach = txt_Lach.Text;
                sa.tuy = txt_tuy.Text;
                sa.tuyentienliet = txt_tienliet.Text;
                sa.hethongtietlieu = txt_tienliet.Text;
                sa.IDnv = nv.IDnv;
                sa.IDpttxn = idpttxn;
                sa.IDpb = IDPB;
                sa.IDloai = "LH001";
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

        private void Btn_sua_Click(object sender, EventArgs e)
        {

            pxn.gan = txt_gan.Text;
            pxn.mat = txt_mat.Text;
            pxn.lach = txt_Lach.Text;
            pxn.tuy = txt_tuy.Text;
            pxn.tuyentienliet = txt_tienliet.Text;
            pxn.hethongtietlieu = txt_tietlieu.Text;
   
            if (new phieuxetnghiemF().update(pxn))
            {
                new ketquathanhcongForm().Show();
            }
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            new phieusieuamFr(pxn).Show();
            btn_end.Enabled = true;
        }

        private void Btn_end_Click(object sender, EventArgs e)
        {
            bp.call_refresh();
            this.Dispose();
        }

        private void Txt_gan_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_gan.Text))
            {
                e.Cancel = true;
                txt_gan.Focus();
                errorProvider.SetError(txt_gan, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_mat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mat.Text))
            {
                e.Cancel = true;
                txt_mat.Focus();
                errorProvider.SetError(txt_mat, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_tuy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tuy.Text))
            {
                e.Cancel = true;
                txt_tuy.Focus();
                errorProvider.SetError(txt_tuy, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_Lach_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Lach.Text))
            {
                e.Cancel = true;
                txt_Lach.Focus();
                errorProvider.SetError(txt_Lach, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_tietlieu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tietlieu.Text))
            {
                e.Cancel = true;
                txt_tietlieu.Focus();
                errorProvider.SetError(txt_tietlieu, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_tienliet_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienliet.Text))
            {
                e.Cancel = true;
                txt_tienliet.Focus();
                errorProvider.SetError(txt_tienliet, "Vui lòng điền đầy đủ thông tin ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }
    }
}
