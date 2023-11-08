using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Random rand = new Random();
        string[] arr = { "+", "-", "x", "/" };
        public Form4()
        {
            InitializeComponent();
        }
        int a, b, vitri;
        private void randomBT()
        {
             a = rand.Next(10);
             b = rand.Next(10);
            vitri = rand.Next(4);
            lbso1.Text = a.ToString();
            lbpt.Text = arr[vitri];
            while (lbpt.Text == "/" && b == 0)
            {
                b = rand.Next(10);
            }
            lbso2.Text = b.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtnhap.Text == "")
                txtnhap.Text = "-";
            else return;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtnhap.Text += bt.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtnhap.Text != "")
                txtnhap.Text = txtnhap.Text.Substring(0, txtnhap.Text.Length - 1);
        }

        private void btTieptuc_Click(object sender, EventArgs e)
        {
            randomBT();
            txtnhap.Text = lbKetqua.Text = "";
            txtnhap.Focus();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                int s = checked(Convert.ToInt32(txtnhap.Text));
                int kq = 0;
                switch (arr[vitri])
                {
                    case "+":
                        {
                            kq = a + b;
                            if (s == kq)
                                lbKetqua.Text = "Dung roi!!!";
                            else
                                lbKetqua.Text = "Sai roi, ket qua = " + kq.ToString();
                            break;
                        }
                    case "x":
                        {
                            kq = a * b;
                            if (s == kq)
                                lbKetqua.Text = "Dung roi!!!";
                            else
                                lbKetqua.Text = "Sai roi, ket qua = " + kq.ToString();
                            break;
                        }
                    case "-":
                        {
                            kq = a - b;
                            if (s == kq)
                                lbKetqua.Text = "Dung roi!!!";
                            else
                                lbKetqua.Text = "Sai roi, ket qua = " + kq.ToString();
                            break;
                        }
                    case "/":
                        {
                            kq = a / b;
                            if (s == kq)
                                lbKetqua.Text = "Dung roi!!!";
                            else
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}", kq);
                            break;
                        }
                }
            }
            catch(FormatException)
            {
                lbKetqua.Text = "Ban phai nhap so";
            }

            catch(OverflowException)
            {
                lbKetqua.Text = "Loi tran so!!!";
            }
        }
    }
}
