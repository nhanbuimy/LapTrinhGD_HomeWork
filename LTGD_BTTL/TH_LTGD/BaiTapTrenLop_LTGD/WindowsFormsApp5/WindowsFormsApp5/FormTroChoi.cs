using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FormTroChoi : Form
    {
        string path;
        Random rand = new Random();
        int countquay;// count1, count2, count3;
        public FormTroChoi()
        {
            InitializeComponent();
        }

        private void FormTroChoi_Load(object sender, EventArgs e)
        {
            countquay = 0;/*= count1 = count2 = count3 = 0;*/
            lbTieuDe.Text = "     TRÒ CHƠI QUAY SỐ     ";
            path = Application.StartupPath + @"\hinhxucxac\";
            load();
        }
        private void load()
        {
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile(path + "6.jpg");
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTieuDe.Text = lbTieuDe.Text.Substring(lbTieuDe.Text.Length - 1, 1)
                + lbTieuDe.Text.Substring(0, lbTieuDe.Text.Length - 1);
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            countquay++;
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            pictureBox1.Image = Image.FromFile(path + so1.ToString() + ".jpg");
            pictureBox2.Image = Image.FromFile(path + so2.ToString() + ".jpg");
            pictureBox3.Image = Image.FromFile(path + so3.ToString() + ".jpg");
            listBox1.Items.Add(string.Format("Lần {0}: Số {1}: 1 lần. " +
                "Số {2}: 1 lần. Số {3}: 1 lần.",countquay,so1,so2,so3));
            int kq = listBox1.Items.Count - 1;
            listBox1.SelectedIndex = kq;
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            load();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
