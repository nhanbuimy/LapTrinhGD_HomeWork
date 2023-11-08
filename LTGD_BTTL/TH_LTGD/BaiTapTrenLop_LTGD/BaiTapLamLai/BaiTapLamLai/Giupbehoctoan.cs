using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLamLai
{
    public partial class Giupbehoctoan : Form
    {
        int so1, so2;
        int vitri;
        Random rand = new Random();
        string[] arr = { "+", "-", "*", "/" };
        public Giupbehoctoan()
        {
            InitializeComponent();
        }
        

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtNhap.Text += bt.Text;

        }
        private void init()
        {
            so1 = rand.Next(10);
            so2 = rand.Next(10);
            vitri = rand.Next(4);  
        }
        private void btXem_Click(object sender, EventArgs e)
        {

            try
            {
                int s = int.Parse(txtNhap.Text);

                string pt = arr[vitri];

                if (pt == "+")
                {
                    int kq = so1 + so2;
                    if (txtNhap.Text == kq.ToString())
                    {
                        lbKetqua.Text = "Đúng rồi!!!";
                    }
                    else
                        lbKetqua.Text = "Sai rồi!!! Kết quả là " + kq;
                }
                else if (pt == "-")
                {
                    int kq = so1 - so2;
                    if (txtNhap.Text == kq.ToString())
                    {
                        lbKetqua.Text = "Đúng rồi!!!";
                    }
                    else
                        lbKetqua.Text = "Sai rồi!!! Kết quả là " + kq;
                }
                else if (pt == "*")
                {
                    int kq = so1 * so2;
                    if (txtNhap.Text == kq.ToString())
                    {
                        lbKetqua.Text = "Đúng rồi!!!";
                    }
                    else
                        lbKetqua.Text = "Sai rồi!!! Kết quả là " + kq;
                }
                else
                {
                    double kq = (double)so1 / so2;
                    if (txtNhap.Text == kq.ToString())
                    {
                        lbKetqua.Text = "Đúng rồi!!!";
                    }
                    else
                        lbKetqua.Text = string.Format("Sai rồi!!! Kết quả là {0:0.##}", kq);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!");
            }
        }

        private void btAm_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
                txtNhap.Text = btAm.Text;
            else
                return;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text == "")
                {
                    throw new Exception("Bạn chưa nhập câu trả lời!");
                }
                else
                {
                    txtNhap.Text = txtNhap.Text.Substring(0, txtNhap.Text.Length - 1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btTieptuc_Click(object sender, EventArgs e)
        {
            init();
            if (so2 == 0 && arr[vitri] == "/")
            {
                so2 = rand.Next(10);
            }
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbPheptinh.Text = arr[vitri];
            txtNhap.Text = "";
            txtNhap.Focus();
        }
    }
}
