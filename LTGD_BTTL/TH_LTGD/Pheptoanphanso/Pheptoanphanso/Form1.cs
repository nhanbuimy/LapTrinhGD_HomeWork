using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pheptoanphanso
{
    public partial class Form1 : Form
    {
        Phanso p1 = new Phanso();
        Phanso p2 = new Phanso();
        Phanso kq;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(txtTuso1.Text);
            p1.Mauso = int.Parse(txtMauso1.Text);
            p2.Tuso = int.Parse(txtTuso2.Text);
            p2.Mauso = int.Parse(txtMauso2.Text);
            kq = p1.Cong(p2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
            lbPheptoan.Text = btCong.Text;
        }

        private void lbPheptoan_Click(object sender, EventArgs e)
        {
            
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            p1.Tuso = int.Parse(txtTuso1.Text);
            p1.Mauso = int.Parse(txtMauso1.Text);
            p2.Tuso = int.Parse(txtTuso2.Text);
            p2.Mauso = int.Parse(txtMauso2.Text);
            kq = p1.Tru(p2);
            txtTuso3.Text = kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
            lbPheptoan.Text = btTru.Text;
        }
    }
}
