using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC3_BaiToanTamGiac
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "     BÀI TOÁN TAM GIÁC     ";
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(label1.Text.Length - 1, 1)
                + label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = lbKetqua.Text = "";
            textBox1.Focus();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                TamGiac tg = new TamGiac(a, b, c);
                bool ktCanh = tg.ktCanhTamGiac();
                if (ktCanh)
                {
                    lbKetqua.Text = string.Format("{0}\nChu vi: {1}\nDiện tích: {2:0.##}",
                        tg.ktLoaiTamGiac(), tg.tinhChuVi(), tg.tinhDienTich());
                }
                else
                    lbKetqua.Text = "Đầy không phải là ba cạnh của tam giác\nKhông tính được chu vi và diện tích";
            }
            catch(FormatException)
            {
                MessageBox.Show("Input with number!!!");
            }
        }
    }
}
