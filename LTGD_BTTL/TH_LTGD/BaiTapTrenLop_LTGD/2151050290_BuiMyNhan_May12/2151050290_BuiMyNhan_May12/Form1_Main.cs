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

namespace _2151050290_BuiMyNhan_May12
{
    public partial class Form1_Main : Form
    {
        Random rand = new Random();
        string[] dsBauCua;
        int tienconlai = 1000;
        public Form1_Main()
        {
            Form f = new Form1_InTro();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Bạn muốn đóng chương trình?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg==DialogResult.No)
            {
                e.Cancel = true;
            }    
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Main_Load(object sender, EventArgs e)
        {
            dsBauCua = Directory.GetFiles(Application.StartupPath + @"\Hinh");
            pictureBox1.Image = Image.FromFile(dsBauCua[4]);
            pictureBox2.Image = Image.FromFile(dsBauCua[0]);
            pictureBox3.Image = Image.FromFile(dsBauCua[3]);
            pictureBox4.Image = Image.FromFile(dsBauCua[1]);
            pictureBox5.Image = Image.FromFile(dsBauCua[2]);
            pictureBox6.Image = Image.FromFile(dsBauCua[5]);
            pictureBox1.SizeMode = pictureBox2.SizeMode = pictureBox3.SizeMode = pictureBox4.SizeMode = pictureBox5.SizeMode = pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            lbTienConLai.Text = tienconlai.ToString();
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            if (cbChon.SelectedIndex < 0) return;
            try
            {
                int tiencuoc = Convert.ToInt32(txtTienCuoc.Text);
                if (tiencuoc % 100 != 0 || tiencuoc > tienconlai)
                {
                    throw new Exception("Tiền cược phải là bội số của 100 và không lớn hơn tiền còn lại");
                }

                int vtImg1 = rand.Next(0, dsBauCua.Length);
                int vtImg2 = rand.Next(0, dsBauCua.Length);
                int vtImg3 = rand.Next(0, dsBauCua.Length);
                pickq1.SizeMode = pickq2.SizeMode = pickq3.SizeMode = PictureBoxSizeMode.StretchImage;
                pickq1.Image = Image.FromFile(dsBauCua[vtImg1]);
                pickq2.Image = Image.FromFile(dsBauCua[vtImg2]);
                pickq3.Image = Image.FromFile(dsBauCua[vtImg3]);

                int chon = cbChon.SelectedIndex, count = 0;
                if (chon == vtImg1) count++;
                if (chon == vtImg2) count++;
                if (chon == vtImg3) count++;
                tienconlai = ((count == 0) ? tienconlai -= tiencuoc : tienconlai += tiencuoc * count);

                lbTienConLai.Text = tienconlai.ToString();
                if (tienconlai <= 0)
                {
                    MessageBox.Show("Bạn không còn tiền để chơi!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
