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
using System.Data.SqlClient;
namespace Quanlibenhvien_Offical
{
    public partial class Danhsachchokham : Form
    {
        public Danhsachchokham()
        {
            InitializeComponent();
        }
        public  Danhsachchokham(PHONGBAN PB)
        {
            InitializeComponent();
            pb = PB;
        }
        public PHONGBAN pb { get; set; }
        public void load_datagrip()
        {
            data_dsbenhnhan.DataSource = new Model1().Database.SqlQuery<benhnhanlamviec>("danhsachbenhnhancho @idpb", new SqlParameter("@idpb", pb.IDpb)).ToList();
        }

        private void Danhsachchokham_Load(object sender, EventArgs e)
        {
            load_datagrip();
            header_text_datagrip();
            lbl_tenpk.Text = pb.Tenpb;
        }
        public void header_text_datagrip()
        {

            data_dsbenhnhan.Columns[0].HeaderText = "Mã bệnh nhân";
            data_dsbenhnhan.Columns[1].HeaderText = "Họ đệm";
            data_dsbenhnhan.Columns[2].HeaderText = "Tên BN";
            data_dsbenhnhan.Columns[3].HeaderText = "Giới tính";
            data_dsbenhnhan.Columns[4].HeaderText = "Ngày sinh";
            data_dsbenhnhan.Columns[5].HeaderText = "Xã phường";
            data_dsbenhnhan.Columns[6].HeaderText = "Quận huyện";
            data_dsbenhnhan.Columns[7].HeaderText = "Tỉnh thành phố";
            data_dsbenhnhan.Columns[8].HeaderText = "Số thứ tự";
            data_dsbenhnhan.Columns[9].Visible = false;
        }
    }
}
