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
    public partial class inphieukhambenhF : Form
    {
        public inphieukhambenhF()
        {
            InitializeComponent();
        }
        public inphieukhambenhF( PHIEUKHAMBENH Pk , BENHAN Ba)
        {
            InitializeComponent();
            pkb = Pk;
            ba = Ba;
        }
        public PHIEUKHAMBENH pkb { get; set; }
        public BENHAN ba { get; set; }
        
        private void InphieukhambenhF_Load(object sender, EventArgs e)
        {
            dataquery2TableAdapters.PHIEUKHAMBENHTableAdapter adapterPKB= new dataquery2TableAdapters.PHIEUKHAMBENHTableAdapter();
            dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();

          //  dataquery2.PHIEUKHAMBENHDataTable tablePKB = new dataquery2.PHIEUKHAMBENHDataTable();
            dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();

          //  adapterPKB.Fill(tablePKB, pkb.IDpk);
            adapterNV.FillbyIDnv(tableNV, pkb.IDnv);

            ReportDataSource rpdsBN = new ReportDataSource("phieukhambenh",(DataTable) new dataquery2TableAdapters.PKB2TableAdapter().GetData(pkb.IDpk));
            ReportDataSource rpdsNV = new ReportDataSource("nhanvien", (DataTable)tableNV);
            rp_phieukhambenh.LocalReport.DataSources.Clear();
            rp_phieukhambenh.LocalReport.DataSources.Add(rpdsBN);
            rp_phieukhambenh.LocalReport.DataSources.Add(rpdsNV);
            rp_phieukhambenh.Refresh();
            this.rp_phieukhambenh.RefreshReport();
       
        }
    }
}
