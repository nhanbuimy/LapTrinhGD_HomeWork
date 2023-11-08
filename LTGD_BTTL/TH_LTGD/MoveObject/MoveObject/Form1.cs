using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MoveObject
{
    public partial class Form1 : Form
    {
        Point vtOld;
        string path;
        PictureBox picAnh;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Dùng chuột hoặc các phím mũi tên di chuyển " +
                "hình vào trong panel bên phải";
            path = Application.StartupPath + @"\Imagejpg\";
           randomPic();

        }
        private void randomPic()
        {
            Random rand = new Random();
            int so;
            //tao moi 1 cai pictiureBox
            picAnh = new PictureBox();
            //thiet lap cac thuoc tinh image, size
            so = rand.Next(1, 11);

            Pic.Image = Image.FromFile(path + so + ".jpg");
            Pic.Width = Pic.Height = 90;
           Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            //thiet lap cac su kien
            picAnh.MouseDown += Pic_MouseDown;
            picAnh.MouseMove += Pic_MouseMove;
            picAnh.MouseUp += Pic_MouseUp;
            //add 1 control(pictureBox) vao form
            this.Controls.Add(Pic);
            pnBound.SendToBack();
            picAnh.BringToFront();
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            if(pnBound.Bounds.Contains(Pic.Bounds))//pbnound co chua cai Pic hay khoong?
            {
                pnBound.Controls.Add(Pic);
                randomPic();
            }
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - vtOld.X;
                int dy = e.Y - vtOld.Y;
                Pic.Left += dx;
                Pic.Top += dy;

            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            vtOld = e.Location;
        }
    }
}
