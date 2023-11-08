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
using System.Drawing.Drawing2D;

namespace BTTLC4_ComomDialog
{
    public partial class Form1 : Form
    {
        bool bClose;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity == 1)
            {
                Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            bClose = false;
            textBox1.Text = "Chương trình demo sử dụng các hộp thoại thông dụng của Windows";
        }

        


        private void timer1_Tick(object sender, EventArgs e)//time dong
        {
            this.Opacity -= 0.05;
            if (this.Opacity <= 0)
            {
                bClose = true;
                Close();
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bClose == false)
            {
                DialogResult dlg = MessageBox.Show("Bạn muốn thoát chương trình?",
                   "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.ForeColor = Color.Blue;
            textBox1.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            textBox1.Text = "Chương trình demo sử dụng các hộp thoại thông dụng của Windows";
        }

        private void btChon1_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            OpenFileDialog dlg = new OpenFileDialog();
            
            textBox1.Clear();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                textBox1.Text = dlg.FileName;
            }    

        }

        private void btChonnhieu_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            OpenFileDialog dlg = new OpenFileDialog
            {
                Multiselect = true
            };
            textBox1.Clear();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                int sltaptin = dlg.FileNames.Length;
                textBox1.Text = string.Format("Có {0} file:\r\n", sltaptin);
                for(int i=0;i<sltaptin;i++)
                {
                    textBox1.Text += dlg.FileNames[i] + "\r\n";//canh chinh column dong thoi xuong dong ms
                }
            }

        }

        private void btChonThuMuc_Click(object sender, EventArgs e)
        {
          
            textBox1.Clear();
            FolderBrowserDialog dlg = new FolderBrowserDialog
            {
                Description = "Choose a directory...", // tiêu đề trong hộp thoại
                ShowNewFolderButton = true
                //cho phép người dùng tạo một thư mục mới trên hệ
                //thống tệp tin trong hộp thoại chọn thư mục
            };
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                //hiển thị đường dẫn khi ng dùng chọn tập tin
                textBox1.Text = dlg.SelectedPath;
            }
        }

        private void btChonMaunen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = dlg.Color;
            }

        }

        private void btChonMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            { 
                FullOpen = true
            };
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                textBox1.ForeColor = dlg.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
            }
        }

    }
}
