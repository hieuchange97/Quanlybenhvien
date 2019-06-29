using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical
{
    public partial class Phieuthanhtoanxetnghiem : Form
    {
        public Phieuthanhtoanxetnghiem()
        {
            InitializeComponent();
        }
        public Phieuthanhtoanxetnghiem(PHIEUTHANHTOANXNKT pttxn)
        {
            InitializeComponent();
            ptt = pttxn;
            ptt.phantramgiam = "0";
          
           
            para[0] = new ReportParameter("statusBHYT", "  ");
            para[1] = new ReportParameter("IDbhyt", " ");
            para[2] = new ReportParameter("NVthungan", "   ");
            para[4] = new ReportParameter("tinhtrangTT", "Chưa thanh toán ");
            para[5] = new ReportParameter("tenquaythungan", " ");
            trangthai = "0";
            cb_loaiDV.DataSource = new Model1().DICHVUs.ToList();
            cb_loaiDV.DisplayMember = "TenDV";
            cb_loaiDV.ValueMember = "IDdichvu";
        
            cb_loaiDV.Enabled = true ;
        }
        ReportParameter[] para = new ReportParameter[8];
        public Phieuthanhtoanxetnghiem (PHIEUTHANHTOANXNKT pttxt , NHANVIEN nv,string idbhyt,string status)
        {
            InitializeComponent();
            ptt = pttxt;
       
            ptt.phantramgiam = pttxt.phantramgiam;
          

            para[0] = new ReportParameter("statusBHYT",status);


            if (idbhyt != "")
            {
                para[1] = new ReportParameter("IDbhyt", idbhyt);
            }
            else
            {
                para[1] = new ReportParameter("IDbhyt"," ");
            }


        
          

           var ttnv = new dataquery2TableAdapters.THONGTINNHANVIENPHONGCHUCNAGTableAdapter().GetDatabyIDnvPhongchucnang(nv.IDnv).FirstOrDefault();

            para[2] = new ReportParameter("NVthungan",ttnv.Hodem+" "+ttnv.Ten);
            para[4] = new ReportParameter("tinhtrangTT", "Đã thanh toán");
            para[5] = new ReportParameter("tenquaythungan",ttnv.Tenpb );
            cb_loaiDV.DataSource = new Model1().DICHVUs.ToList();
            cb_loaiDV.DisplayMember = "TenDV";
            cb_loaiDV.ValueMember = "IDdichvu";
         
            cb_loaiDV.SelectedValue = ptt.IDdichvu;
            cb_loaiDV.Enabled = false;
            trangthai = "1";
            load_inBophanhanhtoan();
        }
        public PHIEUTHANHTOANXNKT ptt { get; set; }
        public string trangthai { get; set; }
 
        private void Phieuthanhtoanxetnghiem_Load(object sender, EventArgs e)
        {
         
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
      
    private void Cb_loaiDV_SelectionChangeCommitted(object sender, EventArgs e)
      {
            ptt.IDdichvu = cb_loaiDV.SelectedValue.ToString();
            new taothutuckhambenhF().update_phieutt(ptt);
            string tien = new Model1().DICHVUs.Find(ptt.IDdichvu).Giatien.ToString();
            tien = (int.Parse(tien) - int.Parse(tien) * int.Parse(ptt.phantramgiam) / 100).ToString();
            para[3] = new ReportParameter("sotientra", tien);
            para[6]= new ReportParameter("diadiem", " ");
            para[7]= new ReportParameter("stt", " ");

            DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter adapterPTT = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter();
            dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();

            Dataquery.PHIEUTHANHTOANXNKTDataTable tablePTT = new Dataquery.PHIEUTHANHTOANXNKTDataTable();
            dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();

            adapterPTT.FillbyIDptt(tablePTT, ptt.IDpttxn);
            adapterNV.FillbyIDnv(tableNV, ptt.IDnv);

            ReportDataSource rpdsBN = new ReportDataSource("phieuthanhtoan", (DataTable)tablePTT);
            ReportDataSource rpdsNV = new ReportDataSource("nhanvien", (DataTable)tableNV);

            rp_phieuthanhtoan.LocalReport.DataSources.Clear();
            rp_phieuthanhtoan.LocalReport.SetParameters(para);
            rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsBN);
            rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsNV);
            this.rp_phieuthanhtoan.RefreshReport();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(new taothutuckhambenhF().update_phieutt(ptt))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa thể lưu lại phiếu thanh toán này ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Cb_loaiDV_SelectedValueChanged(object sender, EventArgs e)
        {
            //try
            //{            
            //    string tien = new Model1().DICHVUs.Find(ptt.IDdichvu).Giatien.ToString();
            //    tien = (int.Parse(tien) - int.Parse(tien) * int.Parse(ptt.phantramgiam) / 100).ToString();
            //    para[3] = new ReportParameter("sotientra", tien);


            //    DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter adapterPTT = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter();
            //    DataqueryTableAdapters.infoNVlamviecTableAdapter adapterNV = new DataqueryTableAdapters.infoNVlamviecTableAdapter();

            //    Dataquery.PHIEUTHANHTOANXNKTDataTable tablePTT = new Dataquery.PHIEUTHANHTOANXNKTDataTable();
            //    Dataquery.infoNVlamviecDataTable tableNV = new Dataquery.infoNVlamviecDataTable();

            //    adapterPTT.FillbyIDptt(tablePTT, ptt.IDpttxn);
            //    adapterNV.Fill(tableNV, ptt.IDnv);

            //    ReportDataSource rpdsBN = new ReportDataSource("phieuthanhtoan", (DataTable)tablePTT);
            //    ReportDataSource rpdsNV = new ReportDataSource("nhanvien", (DataTable)tableNV);

            //    rp_phieuthanhtoan.LocalReport.DataSources.Clear();
            //    rp_phieuthanhtoan.LocalReport.SetParameters(para);
            //    rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsBN);
            //    rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsNV);
            //    this.rp_phieuthanhtoan.RefreshReport();
            //}
            //catch (Exception)
            //{

               
            //}  
           
        }
        public void load_inBophanhanhtoan()
        {
          
                string tien = new Model1().DICHVUs.Find(ptt.IDdichvu).Giatien.ToString();
                tien = (int.Parse(tien) - int.Parse(tien) * int.Parse(ptt.phantramgiam) / 100).ToString();
                para[3] = new ReportParameter("sotientra", tien);

            var bnlv = new Model1().BENHNHANLAMVIECs.Find(ptt.IDbnlv);
            var PB = new Model1().PHONGBANs.Find(bnlv.IDpb);
            
            para[6] = new ReportParameter("diadiem",PB.Tenpb +" "+ PB.Diachi);
            para[7] = new ReportParameter("stt",bnlv.STT.ToString());

            DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter adapterPTT = new DataqueryTableAdapters.PHIEUTHANHTOANXNKTTableAdapter();
                dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();

                Dataquery.PHIEUTHANHTOANXNKTDataTable tablePTT = new Dataquery.PHIEUTHANHTOANXNKTDataTable();
                dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();

                adapterPTT.FillbyIDptt(tablePTT, ptt.IDpttxn);
                adapterNV.FillbyIDnv(tableNV, ptt.IDnv); 

                ReportDataSource rpdsBN = new ReportDataSource("phieuthanhtoan", (DataTable)tablePTT);
                ReportDataSource rpdsNV = new ReportDataSource("nhanvien", (DataTable)tableNV);

                rp_phieuthanhtoan.LocalReport.DataSources.Clear();
                rp_phieuthanhtoan.LocalReport.SetParameters(para);
                rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsBN);
                rp_phieuthanhtoan.LocalReport.DataSources.Add(rpdsNV);
                this.rp_phieuthanhtoan.RefreshReport();
           
        }
    }
}
