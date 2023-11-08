using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacPhepTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btCong_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //lbKetqua.Text = string.Format("{0}", a + b);
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //lbKetqua.Text = string.Format("{0}", a - b);
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //lbKetqua.Text = string.Format("{0}", a * b);
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
            //int b = int.Parse(textBox2.Text);
            //if (b == 0)
            //    lbKetqua.Text = "Số chia phải khác 0";
            //else
            //    lbKetqua.Text = string.Format("{0}", (double)a / b);
        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox1.Text == "" || textBox2.Text == "")
            //    {
            //        throw new Exception("Ban phai nhap gia tri");

            //    }
            //    int a = int.Parse(textBox1.Text);
            //    int b = int.Parse(textBox2.Text);
            //}
            //catch (FormatException)
            //{
            //    lbKetqua.Text = "Ban phai nhap so";
            //}
            //catch (Exception ex)
            //{
            //    lbKetqua.Text = ex.Message;
            //}

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                if (rdCong.Checked)
                    lbKetqua.Text = string.Format("{0}", a + b);
                else if (rdTru.Checked)
                    lbKetqua.Text = string.Format("{0}", a - b);
                else if (rdNhan.Checked)
                {
                    
                    lbKetqua.Text = string.Format("{0}", a * b);
                }
                else if (rdChia.Checked)
                {
                    if (b == 0)
                        throw new Exception("Loi chia cho 0");//lm cho ca 2
                    else
                        lbKetqua.Text = string.Format("{0}", (double)a / b);
                }

                else
                {
                    lbKetqua.Text = string.Format("{0}", a % b);
                }
                
            }
            catch(FormatException)
            {
                lbKetqua.Text = "Ban phai nhap so";
            }
            
            catch (OverflowException)
            {
                lbKetqua.Text = "Loi tran so";
            }
            catch (DivideByZeroException ex)
            {
                lbKetqua.Text =ex.Message;
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
