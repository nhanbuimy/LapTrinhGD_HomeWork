using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC2_SimpleCalculator
{
    public partial class Form1 : Form
    {
        string pt = "";
        int soa, sob;
        public Form1()
        {
            InitializeComponent();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            lbPheptinh.Text = "";
        }

        private void btXoalui_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbPheptinh.Text == "")
                {
                    throw new Exception("Không có dữ liệu để xóa!");
                }
                lbPheptinh.Text = lbPheptinh.Text.Substring(0, lbPheptinh.Text.Length - 1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            
            Button bt = (Button)sender;

            lbPheptinh.Text += bt.Text;

            //if (lbPheptinh.Text.IndexOf('0') == 0)
            //    lbPheptinh.Text = "";
        }
        
   
        

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                soa = int.Parse(lbPheptinh.Text);
                Button bt1 = (Button)sender;
                if (lbPheptinh.Text != "")
                {
                    pt = bt1.Text;
                    
                }
                lbPheptinh.Text += pt;
            }
            catch(FormatException)
            {
                MessageBox.Show("Nhập không hợp lệ vì định dạng chỉ bao gồm 2 toán hạng và 1 toán tử");
            }
            

        }
        private void btBang_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbPheptinh.Text == "")
                {
                    throw new Exception("Bạn chưa nhập dữ liệu!");
                }
                int tam = lbPheptinh.Text.IndexOf(pt);
                sob = int.Parse(lbPheptinh.Text.Substring(tam + 1));
                lbPheptinh.Text += btBang.Text;
                switch (pt)
                {
                    case "+":
                        {
                            lbPheptinh.Text += (soa + sob).ToString();
                            break;
                        }
                    case "-":
                        {
                            lbPheptinh.Text += (soa - sob).ToString();
                            break;
                        }
                    case "*":
                        {
                            lbPheptinh.Text += (soa * sob).ToString();
                            break;
                        }
                    case "/":
                        {
                            if (soa % sob == 0)
                                lbPheptinh.Text += (soa / sob).ToString();
                            else
                                lbPheptinh.Text += string.Format("{0}", (double)soa / sob);
                            break;
                        }
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Nhập không hợp lệ vì định dạng chỉ bao gồm 2 toán hạng và 1 toán tử");
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }

        }
    }
}
