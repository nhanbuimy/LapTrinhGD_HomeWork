using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TroChoiXucXac
{
    public partial class Form1 : Form
    {
        string path;
        int songuoichon;
        int countdoan, countthang, countthua;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
        int xchon;
        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
             xchon = Convert.ToInt32(bt.Text);
            pictureBox1.Image = Image.FromFile(path + xchon + ".jpg");
            countdoan++;
            
        }
        private void khoitao(int x)
        {
            songuoichon = 1;
            pictureBox1.Image = Image.FromFile(path + songuoichon+ ".jpg");

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            path = Application.StartupPath + @"\hinhxucxac\";
            khoitao(songuoichon);
            countdoan = countthang = countthua = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label2.Text = label3.Text = "";
            pictureBox2.Image = null;
            listBox1.Items.Clear();
        }

        Random ran = new Random();
        string kq;
        private void button7_Click(object sender, EventArgs e)
        {
            int a = ran.Next(1, 7);
            pictureBox2.Image = Image.FromFile(path + a + ".jpg");
            if (xchon == a)
            {
                countthang++;
                kq = "Dung";
                listBox1.Items.Add(
                                    string.Format("{0} (Doan {1} ra {2})", kq, xchon, a)
                                  );
            }
            else
            {
                countthua++;
                kq = "Sai";
                listBox1.Items.Add(
                                        string.Format("{0} (Doan {1} ra {2})", kq, xchon, a)
                                   );
            }
                double tongthang = ((double)countthang * 100 / countdoan);
            label2.Text = string.Format("Lan thang: {0} ({1:0.##}%)", countthang,tongthang);
            label1.Text = string.Format("Lan doan: {0}", countdoan);
            double tongthang1 = ((double)countthua * 100 / countdoan);
            label3.Text = string.Format("Lan thua: {0} ({1:0.00}%)", countthua, tongthang1);
        }

    }
}
