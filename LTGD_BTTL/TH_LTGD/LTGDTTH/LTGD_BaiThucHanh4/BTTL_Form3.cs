using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh4
{
    public partial class BTTL_Form3 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
        private readonly int fadeValue = 10;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private bool flag = false;

        public BTTL_Form3()
        {
            InitializeComponent();
        }

        private void FormLoad()
        {
            textBox1.ForeColor = Color.Blue;
            textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            //kiểu chữ thông thường, kích thước 16, tên font là Micro....
            textBox1.Text = "Chương trình demo sử dụng các hộp thoại thông dụng của Windows";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timerFadeIn.Start();
            FormLoad();
        }

        private void TimerFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.01 * fadeValue;
            if (Opacity >= 1)
            {
                timerFadeIn.Stop();
                Enabled = true;
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false && MessageBox.Show("Chắc chắn đóng form?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            flag = true;
            if (Opacity > 0)
            {
                e.Cancel = true;
                timerFadeOut.Start();
            }
        }

        private void TimerFadeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.01 * fadeValue;
            if (Opacity <= 0)
            {
                timerFadeOut.Stop();
                Close();
            }
        }

        private void BtnOneFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }   
        }

        private void BtnMultiFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            //tạo đối tượng mở file = cách OpenFileDialog
            {
                Multiselect = true
            };
            //cho phép chọn nhiều tập tin cùng lúc
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int totalFile = openFileDialog.FileNames.Length;
                //lấy tên file, số lượng tập tin được chọn
                textBox1.Text = string.Format("Có {0} file:\r\n", totalFile);
                for (int i = 0; i < totalFile; i++)
                {
                    textBox1.Text += openFileDialog.FileNames[i] + "\r\n";
                    //lấy tên file đó ra
                }
            }
        }

        private void BtnBrowserFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog //đối tượng chọn thư mục
            {
                Description = "Choose a folder", // tiêu đề trong hộp thoại
                ShowNewFolderButton = true
                //cho phép người dùng tạo một thư mục mới trên hệ
                //thống tệp tin trong hộp thoại chọn thư mục
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
                //hiển thị đường dẫn khi ng dùng chọn tập tin
            }
        }

        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();//tạo ms đt màu
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog.Color;//màu nền trong đt đó có sẵn
            }
        }

        private void BtnForeColor_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog
            {
                FullOpen = true
                //hiển thị tất cả các màu có sẵn trong hộp thoại chọn màu
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
                // màu chữ (ForeColor) của textbox
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog//tạo đt font
            {
                ShowEffects = true,//cho phép hiệu ứng
                ShowApply = true,//cho phép áp dụng
                ShowColor = true//cho phép chọn màu
            };
            fontDialog.Apply += new System.EventHandler(FontDialog_Apply);
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
                textBox1.ForeColor = fontDialog.Color;
            }
        }

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog.Font;
            textBox1.ForeColor = fontDialog.Color;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
