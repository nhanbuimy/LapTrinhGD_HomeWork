using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string path;
        int nchon;
        int ndoan, nthang, nthua;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }
        private void init()
        {
            path = Application.StartupPath + @"\hinhxucxac\";
            nchon = 1;
            picChon.Image = Image.FromFile(path + nchon.ToString() + ".jpg");
            picRandom.Image = null;
            listBox1.Items.Clear();
            label1.Text = label2.Text = label3.Text = "";
            nthang = nthua = ndoan = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            nchon = int.Parse(bt.Text);
            picChon.Image = Image.FromFile(path + nchon.ToString() + ".jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Play();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Enter: Play(); break;
                case Keys.Escape: init(); break;

            }    
            return true;
        }
        private void Play()
        {
            int a = rand.Next(1, 7);
            string kq;
            picRandom.Image = Image.FromFile(path + a.ToString() + ".jpg");
            ndoan++;
            if (a == nchon)
            {
                kq = "Thắng";
                nthang++;
            } 
            else
            {
                kq = "Thua";
                nthua++;
            }
            label1.Text = "Lần đoán: " + ndoan.ToString();
            double tbthang = (double)nthang*100 / ndoan;
            label2.Text = string.Format("Lần thắng: {0} ({1:0.00}%)", nthang, tbthang);
            double tbthua = (double)nthua*100 / ndoan;
            label3.Text = string.Format("Lần thua: {0} ({1:0.00}%)", nthua, tbthua);
            
            listBox1.Items.Add(String.Format("{0}.{1} (Đoán {2} ra {3})",
                ndoan,kq, nchon, a));
                
        }
    }
}
