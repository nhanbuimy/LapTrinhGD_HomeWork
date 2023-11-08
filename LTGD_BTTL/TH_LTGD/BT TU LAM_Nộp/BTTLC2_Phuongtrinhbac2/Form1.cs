using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC2_Phuongtrinhbac2
{
    public partial class Form1 : Form
    {
        double soA, soB, soC;
        public Form1()
        {
            InitializeComponent();
        }
        private void GiaiPTB2()
        {
            double delta = soB * soB - 4 * soA * soC;
            if (delta == 0)
            {
                lbKetqua.Text = "Phương trình có nghiệm kép x = "
                    + (-soB) / (2 * soA);
            }
            else if (delta < 0)
            {
                lbKetqua.Text = "Phương trình vô nghiệm";
            }
            else
            {
                lbKetqua.Text = string.Format("Phương trình có hai nghiệm \nx1 = {0:0.##}\nx2 = {1:0.##} "
                    , (-soB + Math.Sqrt(delta)) / (2 * soA)
                    , (-soB - Math.Sqrt(delta)) / (2 * soA));
            }
        }
        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
                {
                    throw new Exception("Bạn chưa nhập dữ liệu!");
                }
                soA = double.Parse(txtA.Text);
                soB = double.Parse(txtB.Text);
                soC = double.Parse(txtC.Text);
                if (soA == 0)
                {
                    throw new Exception("Phương trình bậc 2 hệ số của a phải khác 0!");
                }
                GiaiPTB2();
            }
            catch (FormatException)
            {
                lbKetqua.Text = "Bạn nên nhập số!";
            }
            catch (Exception ex)
            {
                lbKetqua.Text = ex.Message;
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
