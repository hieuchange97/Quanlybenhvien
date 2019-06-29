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
    public partial class phieuhenkhamlaiF : Form
    {
        public phieuhenkhamlaiF()
        {
            InitializeComponent();
        }
        public phieuhenkhamlaiF(PHIEUHENKHAMLAI phieuhen)
        {
            InitializeComponent();
            PH = phieuhen;
        }
        private void PhieuhenkhamlaiF_Load(object sender, EventArgs e)
        {

           
        }
        public PHIEUHENKHAMLAI PH { get; set; }

        private void Rp_henkhamlai_PrintingBegin(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            btn_luuthoat.PerformClick();
        }

        private void Date_hen_Validated(object sender, EventArgs e)
        {
            PH.ngayhen = date_hen.Value;
            if(new taothutuckhambenhF().update_phieuhenKL(PH))
            {
                DataqueryTableAdapters.PhieuhenkhamlaiTableAdapter adapterPH = new DataqueryTableAdapters.PhieuhenkhamlaiTableAdapter();
                dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();
                Dataquery.PhieuhenkhamlaiDataTable tablePH = new Dataquery.PhieuhenkhamlaiDataTable();
                dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();
                adapterPH.Fill(tablePH, PH.IDphieuhen);
                adapterNV.FillbyIDnv(tableNV, PH.IDnv);

                ReportDataSource rpdsPH = new ReportDataSource("phieuhen", (DataTable)tablePH);
                ReportDataSource rpdsNV = new ReportDataSource("nhanvien", (DataTable)tableNV);
                rp_henkhamlai.LocalReport.DataSources.Add(rpdsPH);
                rp_henkhamlai.LocalReport.DataSources.Add(rpdsNV);

                this.rp_henkhamlai.RefreshReport();
            }
           

        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            panel1.Select();
        }

        private void Btn_luuthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
