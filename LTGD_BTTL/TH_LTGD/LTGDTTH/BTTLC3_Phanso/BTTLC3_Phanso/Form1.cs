using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC3_Phanso
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        char[] arr = { '+', '-', 'x', '/' };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTieude.Text = "   CÁC PHÉP TOÁN TRÊN PHÂN SỐ   ";
            randomPhanSo();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTieude.Text = lbTieude.Text.Substring(lbTieude.Text.Length - 1, 1)
                + lbTieude.Text.Substring(0, lbTieude.Text.Length - 1);
        }
        private void randomPhanSo()
        {
            int vitri;
            int t1, m1, t2, m2;
            t1 = rand.Next(10);
            m1 = rand.Next(10);
            t2 = rand.Next(10);
            m2 = rand.Next(10);
            vitri = rand.Next(4);
            lbtu1.Text = t1.ToString();
            while (m1 == 0)
            {
                m1 = rand.Next(10);
            }
            lbmau1.Text = m1.ToString();
            while (t2 == 0 && arr[vitri] == '/')
            {
                t2 = rand.Next(10);
            }
            lbtu2.Text = t2.ToString();
            while (m2 == 0)
            {
                m2 = rand.Next(10);
            }
            lbmau2.Text = m2.ToString();
            lbPheptinh.Text = arr[vitri].ToString();
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            randomPhanSo();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            int tuso = int.Parse(txtTu.Text);
            int mauso = int.Parse(txtMau.Text);








          //  lbKetqua.Text = "DUNG ROI!!!";
            
        }
    }
}
