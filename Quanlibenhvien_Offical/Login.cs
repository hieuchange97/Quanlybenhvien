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
namespace Quanlibenhvien_Offical
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 

        private void Btn_login_Click(object sender, EventArgs e)
        {

            timer_load.Start();
          
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void Timer_load_Tick(object sender, EventArgs e)
        {
            if (progress_login.Value < 100)
            {
                progress_login.Value += 1;
            }
            else
            {
                timer_load.Stop();
                try
                {
                    var a = new Model1().TAIKHOANs.Where(x => x.Tendn == txt_tendn.Text && x.Matkhau == txt_matkhau.Text).FirstOrDefault();
                    var nv = new Model1().NHANVIENs.Find(a.IDnv);
                    if (a != null)
                    {
                        Quanlybenhvien ql = new Quanlybenhvien(nv,a);
                        ql.Show();
                        this.Hide();
                    }


                }
                catch (Exception)
                {
                    lbl_error.Visible = true;
                    lbl_error.Text = "Sai tên đăng nhập hoặc mật khẩu";

                }
                    progress_login.Value = 0;

            }      
        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Select();
           
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
