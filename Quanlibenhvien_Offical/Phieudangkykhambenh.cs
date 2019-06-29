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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace Quanlibenhvien_Offical
{
    public partial class Phieudangkykhambenh : Form
    {
        public Phieudangkykhambenh()
        {
            InitializeComponent();
        }
        public Phieudangkykhambenh(BENHNHANLAMVIEC bnlv)
        {
            InitializeComponent();
            BENHNHANLAMVIEC = bnlv;
          
        }
 
        public BENHNHANLAMVIEC BENHNHANLAMVIEC { get; set; }
        private void Phieudangkykhambenh_Load(object sender, EventArgs e)
        {
            int sttdk = 0;
            var sttdangkham = new Model1().BENHNHANLAMVIECs.Where(x => x.IDpb == BENHNHANLAMVIEC.IDpb && x.ngaydk == BENHNHANLAMVIEC.ngaydk && x.IDtrangthai == "1").FirstOrDefault();
            if (sttdangkham != null) sttdk = sttdangkham.STT-1;

            ReportParameter para = new ReportParameter("sttdangkham", sttdk.ToString());


            dataquery2.PHIEUDANGKYKHAMBENHDataTable tableBN = new dataquery2.PHIEUDANGKYKHAMBENHDataTable();


            new dataquery2TableAdapters.PHIEUDANGKYKHAMBENHTableAdapter().FillbyID(tableBN,BENHNHANLAMVIEC.IDbnlv);
          
            ReportDataSource rpdsBN = new ReportDataSource("phieudangky",(DataTable) tableBN);
            reportViewer1.LocalReport.SetParameters(para);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpdsBN);
         
            reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();
          
        }
    }
}
