using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC2_RandomNumber
{
    public partial class Form1 : Form
    {
        int diem = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            so1 = rand.Next(9);
            so2 = rand.Next(9);
            so3 = rand.Next(9);
            label1.Text = so1.ToString();
            label2.Text = so2.ToString();
            label3.Text = so3.ToString();
            if ((so1 == so2) && (so2 == so3) && (so3 == so1))
            {
                diem += 100;
            }
            else
            {
                diem -= 10;
            }
            lbDiem.Text = diem.ToString();
        }
        
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
