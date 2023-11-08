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
    public partial class RandomNumber : Form
    {
        int diem = 0;
        Random rand = new Random();
        public RandomNumber()
        {
            InitializeComponent();
            
            
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            
            int so1, so2, so3;
            //so1 = Convert.ToInt32(label1.Text);
            //so2 = Convert.ToInt32(label2.Text);
            //so3 = Convert.ToInt32(label3.Text);
            so1 = rand.Next(6);
            so2 = rand.Next(6);
            so3 = rand.Next(6);
            label1.Text = so1.ToString();
            label2.Text = so2.ToString();
            label3.Text = so3.ToString();
            int tong = so1 + so2 + so3;
            if(rd310.Checked)
            {
                rd310.BackColor = Color.Gray;
                rd1118.BackColor = Color.GreenYellow;
                if (tong >= 3 && tong <= 10)
                    diem += 10;
                else
                    diem -= 10;
            }
            else
            {
                rd1118.BackColor = Color.Gray;
                rd310.BackColor = Color.GreenYellow;
                if (tong >= 11 && tong <= 18)
                    diem += 10;
                else
                    diem -= 10;
            }
            lbDiem.Text = diem.ToString();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = label3.Text = lbDiem.Text ="0";
        }

        
    }
}
