using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;//Namespace này chứa các lớp liên quan đến
//quản lý các tiến trình (process) trên hệ thống
using System.Reflection;//Namespace này chứa các lớp liên quan đến quản lý metadata
//của các thành phần trong ứng dụng

namespace BTTLC7_ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            switch (rd.Text)
            {
                case "Details":
                    {
                        listView1.View = View.Details;
                        break;
                    }
                case "LargeIcon":
                    {
                        listView1.View = View.LargeIcon;
                        break;
                    }
                case "SmallIcon":
                    {
                        listView1.View = View.SmallIcon;
                        break;
                    }
                case "List":
                    {
                        listView1.View = View.List;
                        break;
                    }
                case "Tile":
                    {
                        listView1.View = View.Tile;
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ds các ổ đĩa đc liệt kê trong hệ thống
            string[] dd = Directory.GetLogicalDrives();
            foreach(string d in dd)
            {
                comboBox2.Items.Add(d);//thêm vào combobox
            }
            comboBox2.SelectedIndex = 0;//chon vi tri mac dinh khi form load
        }
        
        private void showlist(string path)
        {
            listView1.Items.Clear();
            DirectoryInfo inf = new DirectoryInfo(path);
            //path đg dẫn thư mục, đi ts thư mục ở đg dẫn đó
            foreach (DirectoryInfo fo in inf.GetDirectories())//lấy thư mục con
            {
                ListViewItem item = new ListViewItem(fo.Name);
                item.Tag = fo;//chi co item biet them thong tin ve fo
                item.ImageIndex = 0;

                item.SubItems.Add("");
                item.SubItems.Add(Directory.GetLastAccessTime(fo.FullName).ToString());
                listView1.Items.Add(item);
            }

            foreach(FileInfo fi in inf.GetFiles())
            {
                ListViewItem itemf = new ListViewItem(fi.Name);
                itemf.Tag = fi;
                itemf.ImageIndex = 1;
                long size = fi.Length;
                string kq;
                if (size < 1024)
                {
                    kq = string.Format("{0}  Byte", size);
                }
                else if ((double)size / 1024 < 1024)
                {
                    kq = string.Format("{0:0.00}  KB", (double)size / 1024);
                }
                else if (((double)size / (1024 * 1024)) < 1024)
                {
                    kq = string.Format("{0:0.00}  MB", (double)size / (1024 * 1024));
                }
                else
                {
                    kq = string.Format("{0:0.00}  GB", (double)size / (1024 * 1024 * 1024));
                } 
                itemf.SubItems.Add(kq);
                itemf.SubItems.Add(Directory.GetLastAccessTime(fi.FullName).ToString());
                listView1.Items.Add(itemf);

            }
            
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {


                var selectedItem = listView1.SelectedItems[0].Tag;
                if (selectedItem is DirectoryInfo folder)
                {
                    showlist(folder.FullName);
                }
                else if (selectedItem is FileInfo file)
                {
                    Process.Start(file.FullName);
                }
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showlist(comboBox2.SelectedItem.ToString());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                var selectitem = listView1.SelectedItems[0].Tag;
                if (selectitem is DirectoryInfo folder)
                {
                    lbDuongDan.Text = folder.FullName;
                }
                else if (selectitem is FileInfo file)
                {
                    lbDuongDan.Text = file.FullName;
                }
            }
        }
    }
}
