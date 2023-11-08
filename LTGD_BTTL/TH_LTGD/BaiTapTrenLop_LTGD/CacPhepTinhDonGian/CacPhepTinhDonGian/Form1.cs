using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacPhepTinhDonGian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int so1, so2;
            try
            {
                if (txt1.Text == "" || txt2.Text == "")
                {
                    throw new Exception("Ban chua nhap hai so!");
                }
                so1 = checked(int.Parse(txt1.Text));
                so2 = checked(int.Parse(txt2.Text));
                if (rdCong.Checked)
                {
                    lbKetqua.Text = (so1 + so2).ToString();
                }
                else if (rdTru.Checked)
                {
                    lbKetqua.Text = (so1 - so2).ToString();
                }
                else if (rdNhan.Checked)
                {
                    lbKetqua.Text = (so1 * so2).ToString();
                }
                else if (rdChia.Checked)
                {
                    if(so2==0)
                    {
                        throw new DivideByZeroException();
                    }
                    lbKetqua.Text = string.Format("{0:0.##}", (double)so1 / so2);
                }
                else
                {
                    lbKetqua.Text = (so1 % so2).ToString();
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ban phai nhap so");
            }
            catch(OverflowException)
            {
                lbKetqua.Text = "Loi tran so";
            }
            catch(DivideByZeroException)
            {
                lbKetqua.Text = "Loi chia cho 0";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ban muon thoat???",
                "Thoat chuong trinh", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = lbKetqua.Text = "";
            rdCong.Checked = true;
            txt1.Focus();
        }
    }
}
