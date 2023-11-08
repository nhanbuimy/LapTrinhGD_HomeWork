using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Collections;//làm việc vs ArrayList
//using System.Collections.Generic;
//using System.IO;//làm việc vs FileStream
//using System.Runtime.Serialization;//giải mã phục hồi code trong file
//using System.Runtime.Serialization.Formatters.Binary;//y trên

namespace BTTLC6_QLSinhVien
{
    public partial class Form1 : Form
    {
        private List<SinhVien> arrsv = new List<SinhVien>();
       // ArrayList arrsv = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHo.Text == "" || txtten.Text == "" || txtmssv.Text == "")
                {
                    throw new Exception("Bạn cần nhập hết dữ liệu!!!");
                }    
                listView1.Items.Clear();
                ListViewItem listitem = null;
                foreach (SinhVien student in arrsv)
                {
                    listitem = new ListViewItem(student.Mssv);//tao doi tuong, them vao mssv do no la 0
                    listitem.SubItems.Add(student.Ho);//them vao thuoc tinh ho,ten
                    listitem.SubItems.Add(student.Ten);
                    listView1.Items.Add(listitem); //hien thi danh sach cac sinh vien
                }
                //Đối tượng listitem được tạo ra để thêm thông tin về sinh viên vào listView1.
                //Mỗi đối tượng listitem sẽ chứa thông tin về một sinh viên.
               
                SinhVien sv = new SinhVien(txtmssv.Text, txtHo.Text, txtten.Text);
                arrsv.Add(sv);
                txtten.Text = txtHo.Text = txtmssv.Text = "";
                txtmssv.Focus();
                //hien thi 1 sinh vien vs thong tin day du
                listitem = new ListViewItem(sv.Mssv);
                listitem.SubItems.Add(sv.Ho);
                listitem.SubItems.Add(sv.Ten);
                listView1.Items.Add(listitem);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        //private bool timMSSV(int maso, int timmssv)
        //{
        //    if (timmssv == maso)
        //        return true;
        //    return false;
        //}
        //private bool timMSSV(string maso, string timten)
        //{
        //    if (timten==maso)
        //        return true;
        //    return false;
        //}
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(txttim.Text=="")
                {
                    throw new Exception("Bạn chưa nhập dữ liệu cần tìm!!!");
                }
                string key = txttim.Text.ToLower();
                listView1.Items.Clear();
                foreach (SinhVien sv in arrsv)
                {
                    //duyet qua moi doi tuong SinhVien luu trong mang
                    //hien thi 1 sinh vien vs thong tin day du
                    if (sv.Mssv.ToLower().Contains(key) || sv.Ten.ToLower().Contains(key))
                    {
                        ListViewItem list = new ListViewItem(sv.Mssv);
                        list.SubItems.Add(sv.Ho);
                        list.SubItems.Add(sv.Ten);
                        listView1.Items.Add(list);
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            }

        }

        private void btsapxep_Click(object sender, EventArgs e)
        {

            arrsv.Sort((sv1, sv2) => sv1.Ten.CompareTo(sv2.Ten));
            listView1.Items.Clear();
            foreach (SinhVien sv in arrsv)
            {
                ListViewItem list = new ListViewItem(sv.Mssv);//tạo listview vs sv[0]
                list.SubItems.Add(sv.Ho);//thêm họ
                list.SubItems.Add(sv.Ten);//thêm tên
                listView1.Items.Add(list);//thêm thông tin sv vào dòng trên listview
            }
        }
    }
}
