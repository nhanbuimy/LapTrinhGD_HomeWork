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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        int imgwidth = 90;
        string [] arrFile;
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "     CHAO MUNG BAN DEN VOI FORM 3     ";
            arrFile = Directory.GetFiles(Application.StartupPath + @"\Images");
            addPic();
        }
        private void addPic()
        {
            string file = arrFile[rand.Next(arrFile.Length)];
            Image img = Image.FromFile(file);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            pic.Location = new Point(0, 0);
            pic.Width = pic.Height = imgwidth;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pic);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label1.Text = label1.Text.Substring(label1.Text.Length - 1, 1)
                + label1.Text.Substring(0, label1.Text.Length - 1);
        }
    }
}
