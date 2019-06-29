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
    public partial class phieuchupxquangForm : Form
    {
        public phieuchupxquangForm()
        {
            InitializeComponent();
        }
        public phieuchupxquangForm(PHIEUXETNGHIEM pxn)
        {
            InitializeComponent();
            PXN = pxn;
        }
        public PHIEUXETNGHIEM PXN { get; set; }
        private void PhieuchupxquangForm_Load(object sender, EventArgs e)
        {
            dataquery2TableAdapters.PHIEUXQUANGTableAdapter adapterxquang = new dataquery2TableAdapters.PHIEUXQUANGTableAdapter();
            dataquery2.PHIEUXQUANGDataTable tablexquang = new dataquery2.PHIEUXQUANGDataTable();
            adapterxquang.Fill(tablexquang, PXN.IDpxn);


            dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter adapterNV = new dataquery2TableAdapters.THONGTINNVLAMVIECTableAdapter();
            dataquery2.THONGTINNVLAMVIECDataTable tablenv = new dataquery2.THONGTINNVLAMVIECDataTable();
            adapterNV.FillbyIDnv(tablenv, PXN.IDnv);

            ReportDataSource rpdt1 = new ReportDataSource("phieuxquang", (DataTable)tablexquang);
            ReportDataSource rpdt2 = new ReportDataSource("nhanvien", (DataTable)tablenv);

            reportViewer.LocalReport.DataSources.Add(rpdt1);
            reportViewer.LocalReport.DataSources.Add(rpdt2);
            this.reportViewer.RefreshReport();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
