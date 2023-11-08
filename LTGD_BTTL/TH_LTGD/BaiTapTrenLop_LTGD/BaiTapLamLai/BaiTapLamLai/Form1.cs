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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cacPhepTinhDonGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CacPhepTinhDonGian f1 = new CacPhepTinhDonGian();
            f1.MdiParent = this;
            f1.Show();
        }

        private void randomNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            RandomNumber f2 = new RandomNumber();
            f2.MdiParent = this;
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                DialogResult dialogResult = MessageBox.Show("Ban muon thoat???",
                  "Thoat chuong trinh", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giupbehoctoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giupbehoctoan f3 = new Giupbehoctoan();
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
