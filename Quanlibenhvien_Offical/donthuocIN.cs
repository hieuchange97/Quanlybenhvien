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
using Microsoft.Reporting.WinForms;

namespace Quanlibenhvien_Offical
{
    public partial class donthuocIN : Form
    {
        public donthuocIN()
        {
            InitializeComponent();
        }

        private void DonthuocIN_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'Dataquery.CHITIETDONTHUOC' table. You can move, or remove it, as needed.
            this.CHITIETDONTHUOCTableAdapter.Fill(this.Dataquery.CHITIETDONTHUOC,ba.IDba);
            // TODO: This line of code loads data into the 'Dataquery.BENHNHANBENHAN' table. You can move, or remove it, as needed.
            this.BENHNHANBENHANTableAdapter.Fill(this.Dataquery.BENHNHANBENHAN,ba.IDba);
            // TODO: This line of code loads data into the 'dataquery2.THONGTINNVLAMVIEC' table. You can move, or remove it, as needed.
            this.THONGTINNHANVIENPHONGCHUCNAGTableAdapter.FillbyIDnvPhongchucnang(this.dataquery2.THONGTINNHANVIENPHONGCHUCNAG,nv.IDnv);
            var tt = new DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter().GetData(ba.IDba);
            int tien = 0;
            foreach (var item in tt)
            {
                tien = tien + item.Dongia * item.Soluong;
            }
          
            ReportParameter pr = new ReportParameter("thanhtien",tien.ToString());
            rp_donthuoc.LocalReport.SetParameters(pr);
            rp_donthuoc.RefreshReport();
        }
        public NHANVIEN nv { get; set; }
        public BENHAN ba { get; set; }
        public donthuocIN(NHANVIEN Nv , BENHAN BA)
        {
            InitializeComponent();
            nv = Nv;
            ba = BA;
           
        }

        public void load()
        {
            dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();
            DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter adapterCT = new DataqueryTableAdapters.CHITIETDONTHUOCTableAdapter();
            DataqueryTableAdapters.BENHNHANBENHANTableAdapter adapterBN = new DataqueryTableAdapters.BENHNHANBENHANTableAdapter();

            dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();
            Dataquery.CHITIETDONTHUOCDataTable tableCT = new Dataquery.CHITIETDONTHUOCDataTable();
            Dataquery.BENHNHANBENHANDataTable tableBN = new Dataquery.BENHNHANBENHANDataTable();

          

            adapterNV.FillbyIDnv(tableNV,nv.IDnv);
            adapterCT.Fill(tableCT,ba.IDba);
            adapterBN.Fill(tableBN,ba.IDba);

            ReportDataSource rps1 = new ReportDataSource("nhanvien", (DataTable)tableNV);
            ReportDataSource rps2 = new ReportDataSource("chitietdonthuoc", (DataTable)tableCT);
            ReportDataSource rps3 = new ReportDataSource("benhnhan", (DataTable)tableBN);
         //   rp_donthuoc.LocalReport.ReportPath = @"C:\Users\Hieu Programmer\source\repos\Quanlibenhvien_Offical\donthuocRP.rdlc";
            rp_donthuoc.LocalReport.DataSources.Add(rps2);
            rp_donthuoc.LocalReport.DataSources.Add(rps1);
            rp_donthuoc.LocalReport.DataSources.Add(rps3);

            rp_donthuoc.RefreshReport();

        }

        private void Rp_donthuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
