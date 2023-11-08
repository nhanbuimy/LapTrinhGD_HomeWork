using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2151050290_BuiMyNhan_12
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string path;
        int tienconlai;
       //int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            path = Application.StartupPath + @"\XiNgau\";
            pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile(path + "dice6.png");
            tienconlai = Convert.ToInt32(lbTienConlai.Text);
            lb1.Text = lb2.Text = lb3.Text = "6";
            cbTiencuoc1.SelectedIndex = 0;
            cbTiencuoc2.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //pictureBox1.Image = pictureBox2.Image = pictureBox3.Image = Image.FromFile(path + "dice6.png");
            pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = checkBox1.Checked;


            lb1.Visible = lb2.Visible = lb3.Visible = !checkBox1.Checked;
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            try
            {
                int tiencuoc1 = Convert.ToInt32(cbTiencuoc1.SelectedItem.ToString());
                int tiencuoc2 = Convert.ToInt32(cbTiencuoc2.SelectedItem.ToString());
                if (tiencuoc1 + tiencuoc2 > tienconlai)
                {
                    throw new Exception("Tổng tiền cược không được lớn hơn tổng tiền còn lại");
                }
                int so1 = rand.Next(1, 7);
                int so2 = rand.Next(1, 7);
                int so3 = rand.Next(1, 7);
                lb1.Text = so1.ToString();
                lb2.Text = so2.ToString();
                lb3.Text = so3.ToString();
                pictureBox1.Image = Image.FromFile(path + "dice" + so1.ToString() + ".png");
                pictureBox2.Image = Image.FromFile(path + "dice" + so2.ToString() + ".png");
                pictureBox3.Image = Image.FromFile(path + "dice" + so3.ToString() + ".png");

                int tong = so1 + so2 + so3;
                if ((rdChan.Checked && (tong % 2 == 0)) || (rdLe.Checked && (tong % 2 != 0)))
                {
                    tienconlai += tiencuoc1;
                }
                else
                    tienconlai -= tiencuoc1;

                if ((rd310.Checked && (tong >= 3 && tong <= 10)) ||
                    (rd1118.Checked && (tong >= 11 && tong <= 18)))
                {
                    tienconlai += tiencuoc2;

                }
                else
                    tienconlai -= tiencuoc2;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lbTienConlai.Text = tienconlai.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
                e.Cancel = true;
        }
    }
}
