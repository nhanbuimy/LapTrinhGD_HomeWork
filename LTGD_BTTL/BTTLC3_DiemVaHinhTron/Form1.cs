using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC3_DiemVaHinhTron
{
    public partial class Form1 : Form
    {
        bool bClose;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbtieude.Text = "     BÀI TOÁN ĐIỂM VÀ HÌNH TRÒN     ";
            bClose = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtieude.Text = lbtieude.Text.Substring(lbtieude.Text.Length - 1, 1)
                + lbtieude.Text.Substring(0, lbtieude.Text.Length - 1);
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                // diem tam i
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                
                Diem I = new Diem(a, b);
                //ban kinh
                
                double r = Convert.ToDouble(txtBK.Text);
                if (r <= 0)
                {
                    throw new Exception("Bán kính hình tròn phải > 0");
                }
                //diem A khac
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);
                Diem A = new Diem(x, y);
                Hinhtron ht = new Hinhtron(I, r);
                string ktraDiem = ht.KtraDiem(I, A);
                lbKetqua.Text = string.Format("{0}\nChu vi hình tròn: {1:0.##}\n" +
                    "Diện tích hình tròn: {2:0.##}", ktraDiem, ht.tinhChuVi(), ht.tinhDienTich());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btReset_Click(object sender, EventArgs e)
        {
            txtA.Text = txtB.Text = txtBK.Text = txtX.Text = txtY.Text = lbKetqua.Text = "";
            txtA.Focus();
        }

        
        // lam mo form truoc khi dong het
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bClose==false)
            {
                e.Cancel = true;
                Lammotruockhidong.Enabled = true;
            }    
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Lammotruockhidong_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.08;
            if (Opacity <= 0)
            {
                bClose = true;
                this.Close();
            }

        }

        
    }
}
