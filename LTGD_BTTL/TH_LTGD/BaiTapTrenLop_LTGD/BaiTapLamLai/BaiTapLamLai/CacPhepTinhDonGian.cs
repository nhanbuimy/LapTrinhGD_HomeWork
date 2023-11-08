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
    public partial class CacPhepTinhDonGian : Form
    {
        public CacPhepTinhDonGian()
        {
            InitializeComponent();
        }

        private void CacPhepTinhDonGian_Load(object sender, EventArgs e)
        {
            
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int so1, so2;
            try
            {
                if (txt1.Text == "" || txt2.Text == "")
                {
                    throw new Exception("Bạn chưa nhập đủ hai số!");
                }
                so1 = int.Parse(txt1.Text);
                so2 = int.Parse(txt2.Text);
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
                    if (so2 == 0)
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
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số!");
            }
            catch (OverflowException)
            {
                lbKetqua.Text = "Lỗi tràn số";
            }

            catch (DivideByZeroException)
            {
                lbKetqua.Text = "Lỗi chia cho 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void CacPhepTinhDonGian_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dialogResult = MessageBox.Show("Ban muon thoat???",
        //       "Thoat chuong trinh", MessageBoxButtons.YesNo,
        //       MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt2.Text = lbKetqua.Text = "";
            txt1.Focus();
        }
    }
}
