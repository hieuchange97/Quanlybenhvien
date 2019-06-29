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
    public partial class phieusieuamFr : Form
    {
        public phieusieuamFr()
        {
            InitializeComponent();
        }
        public phieusieuamFr(PHIEUXETNGHIEM pxn)
        {
            InitializeComponent();
            PXN = pxn;
        }
        public PHIEUXETNGHIEM PXN { get; set; }
        private void PhieusieuamFr_Load(object sender, EventArgs e)
        {
            dataquery2.PHIEUXETNGHIEMDataTable tablePSA = new dataquery2.PHIEUXETNGHIEMDataTable();
            dataquery2TableAdapters.PHIEUXETNGHIEMTableAdapter adapterPSA = new dataquery2TableAdapters.PHIEUXETNGHIEMTableAdapter();
            adapterPSA.FillbyIDpxn(tablePSA, PXN.IDpxn);

            dataquery2.THONGTINNVLAMVIECDataTable tableNV = new dataquery2.THONGTINNVLAMVIECDataTable();
            dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();
            adapterNV.FillbyIDnv(tableNV, PXN.IDnv);
          

            ReportDataSource rpdt1 = new ReportDataSource("phieusieuam", (DataTable)tablePSA);
            ReportDataSource rpdt2 = new ReportDataSource("nhanvien", (DataTable)tableNV);

            rp_phieusieuam.LocalReport.DataSources.Add(rpdt1);
            rp_phieusieuam.LocalReport.DataSources.Add(rpdt2);
            this.rp_phieusieuam.RefreshReport();
        }
    }
}
