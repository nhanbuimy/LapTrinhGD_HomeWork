using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC6_ArrayRandom
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int[] arr;
        int spt, sumChan, sumLe, tbpt, countSnt;
        bool bClose;

        private void Form1_Load(object sender, EventArgs e)
        {
            bClose = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.08;
            if(this.Opacity<=0)
            {
                bClose = true;
                Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private bool Ktrasnt(int k)
        {
            if (k < 2) return false;
            else
            {
                for (int m = 2; m <= Math.Sqrt(k); m++)
                {
                    if (k % m == 0) return false;
                }
                return true;
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            lbChan.Text = lbLe.Text = lbSonguyento.Text = lbtaoMang.Text = lbTbCong.Text = txtSopt.Text = "";
            txtSopt.Focus();
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            lbSonguyento.Text = "";
            try
            {
                spt = int.Parse(txtSopt.Text);
                if (spt <= 0)
                {
                    throw new Exception("Bạn nên nhập số nguyên lớn hơn 0");
                }    
                arr = new int[spt];
                sumLe = sumChan = tbpt = countSnt = 0;
                bool sngto;
                for (int i = 0; i < spt; i++)
                {
                    //gan gia tri cho mang arr
                    arr[i] = rand.Next(0, 100);

                    //truyền vào mảng, join in ra các phần tử phân cách nhau dấu ','
                    //phần tử cuối không có dấu ','
                    lbtaoMang.Text = string.Join(",", arr);

                    // tong cac pt
                    tbpt += arr[i];

                    //tong so pt chan le
                    if (arr[i] % 2 == 0)
                    {
                        sumChan += arr[i];
                    }
                    else
                    {
                        sumLe += arr[i];
                    }    

                    //số nguyên tố
                    sngto = Ktrasnt(arr[i]);
                    if (sngto)
                    {
                        countSnt++;
                        lbSonguyento.Text += arr[i].ToString() + ",";
                    }
                }
                // in ra các label
                lbSonguyento.Text = lbSonguyento.Text.TrimEnd(',');
                //xóa dấu , cuối
                if (countSnt == 0)
                    lbSonguyento.Text = "Không có số nguyên tố trong mảng này!!!";
                lbChan.Text = sumChan.ToString();
                lbLe.Text = sumLe.ToString();
                double tbc = (double)tbpt / spt;
                lbTbCong.Text = string.Format("{0:0.##}", tbc);
            }
            catch (FormatException)
            { 
                MessageBox.Show("Bạn nên nhập số nguyên dương", "Lỗi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
    }
}
