using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibenhvien_Offical.Function;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical;
using System.Data.SqlClient;
namespace Quanlibenhvien_Offical
{
    public partial class Quanlybenhvien : Form
    {
        public Quanlybenhvien()
        {
            InitializeComponent();       
        }
        public Quanlybenhvien(NHANVIEN nv,TAIKHOAN TK)
        {
            nhanvien = nv;
            tk = TK;
            InitializeComponent();
           
        }
      
        public  NHANVIEN nhanvien
        {
            get;set;
        }
           public TAIKHOAN tk { get; set; }
        public  void load_usercontrol()
        {
           
            if (tk.IDquyen == "PQ001")
            {
                btn_BPquanly.Enabled = true;
                btn_BPquanly.PerformClick();
               
            }
            if (tk.IDquyen == "PQ002")
            {
                btn_quaythuoc.Enabled = true;
                btn_quaythuoc.PerformClick();
              
            }
            if (tk.IDquyen == "PQ003")
            {
                btn_bptiepdon.Enabled = true;
                btn_bptiepdon.PerformClick();
              
            }
            if (tk.IDquyen == "PQ004")
            {
                btn_BPKB.Enabled = true;
                btn_BPKB.PerformClick();
               
            }
            if (tk.IDquyen == "PQ005")
            {
                btn_BPthanhtoan.Enabled = true;
                btn_BPthanhtoan.PerformClick();
              
            }
            if (tk.IDquyen == "PQ006")
            {
                btn_bpxetnghiem.Enabled = true;
                btn_bpxetnghiem.PerformClick();
               
            }
            
        }
        private static Quanlybenhvien instance;
        public static Quanlybenhvien Instance
        {
            get
            {
                if (instance == null) instance = new Quanlybenhvien();
                return instance;
            }
        }
     
        public Panel Panel_Content
        {
            get
            {
              ;
                return pnl_content;
            }
            set
            {
                pnl_content = value;
            }
        }
        private void Btn_category_Click(object sender, EventArgs e)
        {
            pnl_slidebar.BringToFront();
            if (pnl_slidebar.Visible == true)
            {
                pnl_slidebar.Visible = false;
            }
            else
            {  
                pnl_slidebar.Visible = true;          
                logo_BV.Visible = false;
                transition_logo.ShowSync(logo_BV);   
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_usercontrol();
        }

     

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_BPKB_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            ctr = new Bophankhambenh(nhanvien);
            if(!pnl_content.Controls.Contains(ctr))
            {
                pnl_content.Controls.Add(ctr);
               
               ctr.Dock = DockStyle.Fill;
               ctr.BringToFront();
            }
            else
            {
               ctr.BringToFront();
            }
            
          
        }

     
        private Control ctr;
        public Control Ctr
        {
            get
            {
                return ctr;
            }
            set
            {
                value = ctr;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            Dangkykhambenh  ctr = new Dangkykhambenh();
            if (!pnl_content.Controls.Contains(ctr))
            {
                pnl_content.Controls.Add(ctr);

                ctr.Dock = DockStyle.Fill;
                ctr.BringToFront();
            }
            else
            {
                ctr.BringToFront();
              
                ctr.Dock = DockStyle.Fill;
            }
            ctr.nv = nhanvien;
          
        }
      

      

        private void Quanlybenhvien_FormClosing(object sender, FormClosingEventArgs e)
        {

            new Login().Show();
      
        }

        private void Btn_BPthanhtoan_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            bophanthanhtoanUC ttUC = new bophanthanhtoanUC(nhanvien);
            if (pnl_content.Controls.Contains(ttUC))
            {
                ttUC.BringToFront();

            }
            else
            {
                pnl_content.Controls.Add(ttUC);
                ttUC.Dock = DockStyle.Fill;
                ttUC.BringToFront();
            }
        }

        private void Btn_bpxetnghiem_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            bophanxetnghiemUC xnUC = new bophanxetnghiemUC(nhanvien);
            if (pnl_content.Controls.Contains(xnUC))
            {
                xnUC.BringToFront();

            }
            else
            {
                pnl_content.Controls.Add(xnUC);
                xnUC.Dock = DockStyle.Fill;
                xnUC.BringToFront();
            }
        }

      

        private void Btn_BPquanly_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            bophanquanlyUC bpql = new bophanquanlyUC();
            if (this.pnl_content.Controls.Contains(bpql))
            {
                bpql.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(bpql);
                bpql.Dock = DockStyle.Fill;
                bpql.BringToFront();
            }
        }

        private void Btn_quaythuoc_Click(object sender, EventArgs e)
        {
            pnl_slidebar.Visible = false;
            donthuocUC dt = new donthuocUC(nhanvien);
            if (this.pnl_content.Controls.Contains(dt))
            {
                dt.BringToFront();
            }
            else
            {
                this.pnl_content.Controls.Add(dt);
                dt.Dock = DockStyle.Fill;
                dt.BringToFront();
            }
        }
    }
}
