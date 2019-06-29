using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlibenhvien_Offical.Object;
using Quanlibenhvien_Offical.Function;
namespace Quanlibenhvien_Offical
{
    public partial class quanlyphongbanUC : UserControl
    {
        public quanlyphongbanUC()
        {
            InitializeComponent();
            load_sodo();
           

            load_thonginPBcon();
        }

        public void header_dataPB()
        {
            data_phongban.Columns[0].HeaderText = "Mã phòng ban ";
            data_phongban.Columns[1].HeaderText = "Tên phòng ban ";
            data_phongban.Columns[2].HeaderText = "Địa điểm ";
            data_phongban.Columns[3].HeaderText = "Nhiệm vụ";
            data_phongban.Columns[4].HeaderText = "Mã phòng ban cha";
            data_phongban.Columns[5].HeaderText = "Mã khoa";

            data_phongban.Columns[6].Visible = false;
            data_phongban.Columns[7].Visible = false;
            data_phongban.Columns[8].Visible = false;
            data_phongban.Columns[9].Visible = false;
            data_phongban.Columns[10].Visible = false;

        }

  
      

        private void Txt_searchDD_TextChanged(object sender, EventArgs e)
        {
           
            
        }

     
 
     
        public void reset_control()
        {
            chucnangPB = null;
            txt_tenPB.Text = txt_nhiemvu.Text = txt_diadiem.Text = cb_khoaPBcon.Text = cb_phongban.Text = null;
            txt_tenPB.Enabled = txt_nhiemvu.Enabled = txt_diadiem.Enabled = cb_khoaPBcon.Enabled = cb_phongban.Enabled = false;
            data_phongban.Enabled = true; tool_huy.Enabled = tool_luu.Enabled = false;
            tool_xoaPB.Enabled = tool_suaPB.Enabled = false;
            tool_themPB.Enabled = true;
        }
   
        public string stt_PB()
        {
            var pb = new Model1().PHONGBANs.ToList();
            string stt = pb[pb.Count - 1].IDpb;
            stt = (int.Parse(stt.Substring(2)) + 1).ToString();
            if (int.Parse(stt) <= 9) stt = "00" + stt;
            if (int.Parse(stt) > 9) stt = "0" + stt;

            return stt;
        }
        string chucnangPB = null;
        private void Tool_themPB_Click(object sender, EventArgs e)
        {
            data_phongban.Enabled = false;

            tool_luu.Enabled = tool_huy.Enabled = true;
            chucnangPB = "them";
            if (id.Contains("PB"))
            {
                var checkpb = new Model1().PHONGBANs.Find(id);
                if (checkpb.IDkhoa == null)
                {
                    txt_tenPB.Text = txt_nhiemvu.Text = txt_diadiem.Text = null;
                    txt_tenPB.Enabled = txt_nhiemvu.Enabled = txt_diadiem.Enabled = true;
                    cb_khoaPBcon.Text = null;
                    cb_phongban.SelectedValue=id;
                }
                else
                {
                    txt_tenPB.Text = txt_nhiemvu.Text = txt_diadiem.Text = null;
                    txt_tenPB.Enabled = txt_nhiemvu.Enabled = txt_diadiem.Enabled = true;
                    cb_phongban.SelectedValue = id;
                    cb_khoaPBcon.SelectedValue = new Model1().PHONGBANs.Find(id).IDkhoa;
                }
               
                
            }
            if (id.Contains("KH") || id.Contains("BP"))
            {
                txt_tenPB.Text = txt_nhiemvu.Text = txt_diadiem.Text = null;
                txt_tenPB.Enabled = txt_nhiemvu.Enabled = txt_diadiem.Enabled = true;
                cb_khoaPBcon.SelectedValue = id;

            }
          
        }

        private void Tool_suaPB_Click(object sender, EventArgs e)
        {
            data_phongban.Enabled = false;
            chucnangPB = "sua";
            tool_luu.Enabled = tool_huy.Enabled = true;
            txt_diadiem.Enabled = txt_tenPB.Enabled = txt_nhiemvu.Enabled = true;
        }

     

     
        private void Tool_xoaPB_Click(object sender, EventArgs e)
        {
            data_phongban.Enabled = false;
          
                var pb = new Model1().PHONGBANs.Find(data_phongban.CurrentRow.Cells[0].Value.ToString());
            if (pb != null)
            {
                string txt = "Bạn có chắc chắn muốn xóa phòng ban này ra khỏi hệ thống " + txt_tenPB.Text + " ra khỏi hệ thống không ";
                DialogResult dr = MessageBox.Show(txt, "Xóa phòng ban", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (new phongbanF().delete_PB(pb.IDpb))
                    {
                        new ketquathanhcongForm().Show();
                        reset_control();
                        tree_sodo.Nodes.Clear();
                        load_sodo();
                        load_thonginPBcon();
                        tree_sodo.Select();
                        TreeNode treenode = tree_sodo.Nodes.Find(id, true).FirstOrDefault();
                        tree_sodo.SelectedNode = treenode;
                    }
                    else
                    {
                        reset_control();
                        MessageBox.Show("Phòng ban này không thể xóa vì lý do đang được sử dụng làm phòng ban tổng của nhiều phòng ban trong bệnh viện .Để xóa phòng ban này vui lòng xóa các phòng ban con trong hệ thống !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                }
                else
                {
                    reset_control();
                }
              


            }
        }
       


   

   

    

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private List<string> sodo = new List<string>();
        public void addItem_sodo()
        {
            sodo = new List<string>();
            foreach (TreeNode item in tree_sodo.Nodes as TreeNodeCollection)
            {
                sodo.Add(item.Text);
                child_nodeLoad(item);
            }
        }
        public void child_nodeLoad(TreeNode nd)
        {
            foreach (TreeNode item in nd.Nodes)
            {
                sodo.Add(item.Text);
                child_nodeLoad(item);
            }
        }
        public void load_sodo()
        {
            var khoa = new Model1().KHOAs.ToList();
            for (int i = 0; i < khoa.Count; i++)
            {
                
                TreeNode mainNode = new TreeNode();
                mainNode.Text = khoa[i].Tenkhoa;
                mainNode.Name = khoa[i].IDkhoa;
              
                string id = khoa[i].IDkhoa;
                var pb = new Model1().PHONGBANs.Where(x => x.IDkhoa ==id && x.IDpbCha==null).ToList();
                for (int j = 0; j < pb.Count; j++)
                {
                    TreeNode nodePR = new TreeNode();
                    nodePR.Text = pb[j].Tenpb;
                    nodePR.Name = pb[j].IDpb;
                    mainNode.Nodes.Add(nodePR);
                    add_childNode(nodePR, pb[j].IDpb);
                }
                tree_sodo.Nodes.Add(mainNode);
            }
            addItem_sodo();
            load_phongchucnang();
        }
        public void add_childNode(TreeNode node ,string id)
        {
            var pb = new Model1().PHONGBANs.Where(x => x.IDpbCha == id).ToList();
            if (pb != null)
            {
                for (int i = 0; i < pb.Count; i++)
                {
                    TreeNode nodechild = new TreeNode();
                    nodechild.Name = pb[i].IDpb;
                    nodechild.Text = pb[i].Tenpb;
                    node.Nodes.Add(nodechild);
                    string idd = pb[i].IDpb;
                    add_childNode(nodechild, idd);
                }
            }
        }

        private void Tree_sodo_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
          
           
        }
        public string id { get; set; }
      
        private void Tree_sodo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            reset_control();
            try
            {
               
                if (e.Node.Name.Contains("PB"))
                {
                    var PBcha = new Model1().PHONGBANs.Find(e.Node.Name);
                    var Pbcon = new Model1().PHONGBANs.Where(x => x.IDpbCha == PBcha.IDpb).ToList();
                    data_phongban.DataSource = Pbcon;
                    header_dataPB();
                    id = e.Node.Name;
                    return;
                }
                if (e.Node.Name.Contains("KH")|| e.Node.Name.Contains("BP"))
                {
                    var khoa = new Model1().KHOAs.Find(e.Node.Name);
                    var Pbcon = new Model1().PHONGBANs.Where(x => x.IDkhoa == khoa.IDkhoa && x.IDpbCha==null).ToList();
                    data_phongban.DataSource = Pbcon;
                    header_dataPB();
                    id = e.Node.Name;
                    return;
                }

              
                

            }
            catch (Exception)
            {
                data_phongban.DataSource = null;
            }
        }
        
        private void Tree_sodo_Enter(object sender, EventArgs e)
        {
            
          
        }

        private void Tree_sodo_Leave(object sender, EventArgs e)
        {
           
        }

        private void Tree_sodo_Click(object sender, EventArgs e)
        {
            
        }

        private void Tree_sodo_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
           
        }
        public List<string> searchResult = new List<string>();
        private void Txt_searchTree_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchTree.Text != "" && cb_Khoa.Text!="")
            {


                search_nodebyKhoa();
                lst_search.DataSource = searchResult;
                lst_search.Visible = true;

               
                
                
            }
            else
            {
                if(txt_searchTree.Text!="" && cb_Khoa.Text == "")
                {
                    searchResult = new List<string>();
                    lst_search.Visible = true;

                    for (int i = 0; i < sodo.Count; i++)
                    {
                        if (sodo[i].Contains(txt_searchTree.Text.Trim()))
                        {
                            searchResult.Add(sodo[i]);
                        }
                    }
                    lst_search.DataSource = null;
                    lst_search.DataSource = searchResult;
                }
                else
                {
                    lst_search.DataSource = null;
                    lst_search.Visible = false;
                }
               
            }
        }

        private void Panel3_Click(object sender, EventArgs e)
        {
               
            
   
        }

        private void Txt_searchTree_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Txt_searchTree_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData== Keys.Down)
            {
                lst_search.Select();
            }
        }

        private void Lst_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Lst_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                select_nodeinTree();
                lst_search.DataSource = null;
                lst_search.Visible = false;
            }
        }
        public void search_nodebyKhoa()
        {
            searchResult = new List<string>();
            foreach (TreeNode item in tree_sodo.Nodes)
            {
                if (item.Name == cb_Khoa.SelectedValue.ToString())
                {
                    search_childnodebyKhoa(item);
                }
            }
        }
        public void search_childnodebyKhoa(TreeNode node) // tìm kiếm các phòng ban theo tên khoa của phòng ban đó đổ kết quả vào list searchresult
        {
            foreach (TreeNode item in node.Nodes)
            {
                if (item.Text.Contains(txt_searchTree.Text))
                {
                    searchResult.Add(item.Text);
                }
                search_childnodebyKhoa(item);
            }
        }
        public void select_nodeinTree()  // tìm kiếm node trong treeview sau đó select node đó 
        {
            foreach (TreeNode item in tree_sodo.Nodes)
            {
                if (item.Text == lst_search.SelectedValue.ToString())
                {
                    tree_sodo.Select();
                    tree_sodo.SelectedNode = item;

                    return;
                }
                load_childNode(item);
            }
        }
        public void load_childNode(TreeNode Tn) // dùng để đệ quy trong hàm select_nodeinTree()
        {
            foreach (TreeNode item in Tn.Nodes)
            {
                if (item.Text == lst_search.SelectedItem.ToString())
                {
                    tree_sodo.Select();
                    tree_sodo.SelectedNode = item;
                    return;
                }
                load_childNode(item);
            }
        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {
            label2.Select();
            lst_search.DataSource = null;
            lst_search.Visible = false;
            txt_searchTree.Text = null;
        }
        public void load_thonginPBcon()
        {
            cb_phongban.DataSource = new Model1().PHONGBANs.ToList();
            cb_phongban.DisplayMember = "Tenpb";
            cb_phongban.ValueMember = "IDpb";

            cb_khoaPBcon.DataSource = new Model1().KHOAs.ToList();
            cb_khoaPBcon.DisplayMember = "Tenkhoa";
           cb_khoaPBcon.ValueMember = "IDkhoa";

            cb_Khoa.DataSource = new Model1().KHOAs.ToList();
            cb_Khoa.DisplayMember = "Tenkhoa";
            cb_Khoa.ValueMember = "IDkhoa";

            cb_Khoa.Text = null;

            cb_khoaPBcon.Text = cb_phongban.Text = null;

        }

        private void Data_phongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_tenPB.Text = data_phongban.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_diadiem.Text = data_phongban.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_nhiemvu.Text = data_phongban.Rows[e.RowIndex].Cells[3].Value.ToString();
                try
                {
                   
                    cb_phongban.SelectedValue = data_phongban.Rows[e.RowIndex].Cells[4].Value.ToString();
                   
                }
                catch (Exception)
                {

               
                }
                try
                {
                    cb_khoaPBcon.SelectedValue = data_phongban.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                catch (Exception)
                {

                }
                tool_suaPB.Enabled = tool_xoaPB.Enabled = true;
              
            }
            catch (Exception)
            {
                tool_suaPB.Enabled = tool_xoaPB.Enabled = false;

            }
        }

        private void Tool_luu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                switch (chucnangPB)
                {
                    case "them":
                        {
                            PHONGBAN pb = new PHONGBAN();
                            
                                pb.IDpb = "PB" + stt_PB();
                                pb.Tenpb = txt_tenPB.Text;
                                pb.Diachi = txt_diadiem.Text;
                                pb.Nhiemvu = txt_nhiemvu.Text;
                            if (cb_phongban.Text != "")
                            {
                                pb.IDpbCha = cb_phongban.SelectedValue.ToString();
                            }
                            if (cb_khoaPBcon.Text != "")
                            {
                                pb.IDkhoa = cb_khoaPBcon.SelectedValue.ToString();
                            } 
                            if (new phongbanF().insert_PB(pb))
                            {
                                new ketquathanhcongForm().Show(); chucnangPB = null;
                                reset_control();
                                tree_sodo.Nodes.Clear();
                                load_sodo();
                                load_thonginPBcon();

                                tree_sodo.Select();
                                TreeNode treenode = tree_sodo.Nodes.Find(id, true).FirstOrDefault();

                                tree_sodo.SelectedNode = treenode; tree_sodo.Select();
                                data_phongban.Rows[data_phongban.RowCount - 1].Selected = true;
                                tree_sodo.Select();
                            }
                            else
                            {
                                MessageBox.Show("Thất bại ");
                                reset_control();
                            }

                            tool_luu.Enabled = tool_huy.Enabled = false ;
                            break;
                        }
                    case "sua":
                        {
                            PHONGBAN pb = new PHONGBAN();
                            pb.IDpb = data_phongban.CurrentRow.Cells[0].Value.ToString();
                            pb.Tenpb = txt_tenPB.Text;
                            pb.Diachi = txt_diadiem.Text;
                            pb.Nhiemvu = txt_nhiemvu.Text;
                            if(new phongbanF().update_PB(pb))
                            {
                                new ketquathanhcongForm().Show();chucnangPB = null;
                                int indexx = data_phongban.CurrentRow.Index;
                                reset_control();
                                tree_sodo.Nodes.Clear();
                                load_sodo();
                                load_thonginPBcon();
                                tree_sodo.Select();
                                TreeNode treenode = tree_sodo.Nodes.Find(id, true).FirstOrDefault();
                                tree_sodo.SelectedNode = treenode;
                                Data_phongban_CellClick(this, new DataGridViewCellEventArgs(0, indexx));
                                data_phongban.Rows[indexx].Selected = true; tree_sodo.Select();
                            }
                            break;
                        }
                    case "thempcn":
                        {
                            PHONGBAN pb = new PHONGBAN();
                            pb.IDpb = "PB" + stt_PB();
                            pb.Tenpb = txt_tenPB.Text;
                            pb.Diachi = txt_diadiem.Text;
                            pb.Nhiemvu = txt_nhiemvu.Text;
                            if(new phongbanF().insert_PB(pb))
                            {
                                new ketquathanhcongForm().Show();
                                load_sodo();
                            }
                            chucnangPB = null;
                            reset_control();
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void Txt_tenPB_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenPB.Text))
            {
                if (chucnangPB == "them" || chucnangPB == "sua")
                {
                    e.Cancel = true;
                    txt_tenPB.Focus();
                    errorProvider.SetError(txt_tenPB, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
               
            }
            else
            {

                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_diadiem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_diadiem.Text))
            {
                if (chucnangPB == "them" || chucnangPB == "sua")
                {
                    e.Cancel = true;
                    txt_diadiem.Focus();
                    errorProvider.SetError(txt_diadiem, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Txt_nhiemvu_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txt_nhiemvu.Text))
            {
                if (chucnangPB == "them" || chucnangPB == "sua")
                {
                    e.Cancel = true;
                    txt_nhiemvu.Focus();
                    errorProvider.SetError(txt_nhiemvu, "Vui lòng điền đầy đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Cb_phongban_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_phongban.Text))
            {
                if (chucnangPB == "them" || chucnangPB == "sua")
                {
                    e.Cancel = true;
                    cb_phongban.Focus();
                    errorProvider.SetError(cb_phongban, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Cb_khoaPBcon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cb_khoaPBcon.Text))
            {
                if (chucnangPB == "them" || chucnangPB == "sua")
                {
                    e.Cancel = true;
                    cb_khoaPBcon.Focus();
                    errorProvider.SetError(cb_khoaPBcon, "Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.Clear();
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider.Clear();
            }
        }

        private void Tool_huy_Click(object sender, EventArgs e)
        {
            chucnangPB = null;
          
            reset_control();
            tree_sodo.Select();
            TreeNode treenode = tree_sodo.Nodes.Find(id, true).FirstOrDefault();

            tree_sodo.SelectedNode = treenode;
        }

        private void Txt_searchPbB_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchPbB.Text != "")
            {
                switch (cb_locDD.SelectedIndex)
                {
                    case 0:
                        {
                            if (id.Contains("PB"))
                            {
                                data_phongban.DataSource = null;
                                data_phongban.DataSource = new dataquery2TableAdapters.PHONGBANTableAdapter().GetDataByPBchild(txt_searchPbB.Text, id);
                                data_phongban.Columns[0].HeaderText = "Mã phòng ban ";
                                data_phongban.Columns[1].HeaderText = "Tên phòng ban ";
                                data_phongban.Columns[2].HeaderText = "Địa điểm ";
                                data_phongban.Columns[3].HeaderText = "Nhiệm vụ";
                                data_phongban.Columns[4].HeaderText = "Mã phòng ban cha";
                                data_phongban.Columns[5].HeaderText = "Mã khoa";
                            }
                            if(id.Contains("BP")|| id.Contains("KH"))
                            {
                                data_phongban.DataSource = null;
                                data_phongban.DataSource = new dataquery2TableAdapters.PHONGBANTableAdapter().GetDataPBparent(txt_searchPbB.Text, id);
                                data_phongban.Columns[0].HeaderText = "Mã phòng ban ";
                                data_phongban.Columns[1].HeaderText = "Tên phòng ban ";
                                data_phongban.Columns[2].HeaderText = "Địa điểm ";
                                data_phongban.Columns[3].HeaderText = "Nhiệm vụ";
                                data_phongban.Columns[4].HeaderText = "Mã phòng ban cha";
                                data_phongban.Columns[5].HeaderText = "Mã khoa";
                            }
                           
                            break;
                        }
                    case 1:
                        {
                            if (id.Contains("PB"))
                            {
                                data_phongban.DataSource = null;
                                data_phongban.DataSource = new dataquery2TableAdapters.PHONGBANTableAdapter().GetDataByIDpbPBchild(txt_searchPbB.Text, id);
                                data_phongban.Columns[0].HeaderText = "Mã phòng ban ";
                                data_phongban.Columns[1].HeaderText = "Tên phòng ban ";
                                data_phongban.Columns[2].HeaderText = "Địa điểm ";
                                data_phongban.Columns[3].HeaderText = "Nhiệm vụ";
                                data_phongban.Columns[4].HeaderText = "Mã phòng ban cha";
                                data_phongban.Columns[5].HeaderText = "Mã khoa";
                            }
                            if (id.Contains("BP") || id.Contains("KH"))
                            {
                                //data_phongban.DataSource = null;
                                data_phongban.DataSource = new dataquery2TableAdapters.PHONGBANTableAdapter().GetDataByIDpbKhoa(txt_searchPbB.Text, id);
                                data_phongban.Columns[0].HeaderText = "Mã phòng ban ";
                                data_phongban.Columns[1].HeaderText = "Tên phòng ban ";
                                data_phongban.Columns[2].HeaderText = "Địa điểm ";
                                data_phongban.Columns[3].HeaderText = "Nhiệm vụ";
                                data_phongban.Columns[4].HeaderText = "Mã phòng ban cha";
                                data_phongban.Columns[5].HeaderText = "Mã khoa";
                            }
                           
                            break;
                        }
                }
            }
            else
            {
                tree_sodo.Select();
                TreeNode treenode = tree_sodo.Nodes.Find(id, true).FirstOrDefault();
                Tree_sodo_AfterSelect(this, new TreeViewEventArgs(treenode));
               
            }
        }
        public void load_phongchucnang()
        {
            var pb = new Model1().PHONGBANs.Where(x => x.IDpbCha == null && x.IDkhoa == null).ToList();
            foreach (var item in pb)
            {
                TreeNode node = new TreeNode();
                node.Text = item.Tenpb;
                node.Name = item.IDpb;
                add_childNode(node,item.IDpb);
                tree_sodo.Nodes.Add(node);
            }
        }

        private void Tool_themPCN_Click(object sender, EventArgs e)
        {
            txt_tenPB.Text = txt_nhiemvu.Text = txt_diadiem.Text = cb_khoaPBcon.Text = cb_phongban.Text = null;
            txt_tenPB.Enabled = txt_nhiemvu.Enabled = txt_diadiem.Enabled = true;
            tool_themPB.Enabled = tool_suaPB.Enabled = tool_xoaPB.Enabled = false;
            tool_luu.Enabled = tool_huy.Enabled = true;
            data_phongban.DataSource = null;
            chucnangPB = "thempcn";
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            label2.Select();
        }
    }
}
