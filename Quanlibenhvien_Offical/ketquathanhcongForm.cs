using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlibenhvien_Offical
{
    public partial class ketquathanhcongForm : Form
    {
        public ketquathanhcongForm()
        {
            InitializeComponent();
        }

        private void KetquathanhcongForm_Load(object sender, EventArgs e)
        {
            time_load.Start();
        }
        
        private void Time_load_Tick(object sender, EventArgs e)
        {

            if (progressbar.Value == 100)
            {
                progressbar.Value = 0;
                time_load.Stop();
                transition_logo.HideSync(progressbar);
                transition_logo.ShowSync(btn_thanhcong);
            }
            progressbar.Value += 1;
        }

        private void Btn_thanhcong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
