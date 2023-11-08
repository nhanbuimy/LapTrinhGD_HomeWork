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
namespace MoveObject
{
    public partial class Form1 : Form
    {
        int count = 0;
        Point p;
        Random rand = new Random();
        string[] arr;
        int imgwidth = 90;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Dùng chuột hoặc các phím mũi tên để di chuyển ảnh vào panel bên phải";
            arr = Directory.GetFiles(Application.StartupPath + @"\Imagejpg\");
            addNewpic();
        }
        private void addNewpic()
        {
            count++;
            string file = arr[rand.Next(arr.Length)];
            Image img = Image.FromFile(file);
            PictureBox pic = new PictureBox();
            pic.Name = count.ToString();
            pic.Image = img;
            pic.Location = new Point(0, 0);
            pic.Width = pic.Height = imgwidth;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.MouseDown += Pic_MouseDown;
            pic.MouseMove += Pic_MouseMove;
            pic.MouseUp += Pic_MouseUp;
            this.Controls.Add(pic);
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                int dx, dy;
                dx = e.X - p.X;
                dy = e.Y - p.Y;
                pic.Left += dx;
                pic.Top += dy;

            }
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if(pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewpic();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arrcontrol = this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)arrcontrol[0];
            switch(e.KeyCode)
            {
                case Keys.Left:
                    if ((pic.Left)> 0) pic.Left-=5;
                    break;
                case Keys.Right:
                    if ((pic.Right) < ClientRectangle.Width) pic.Left += 5;
                    break;
                case Keys.Up:
                    if ((pic.Top) > 0) pic.Top -= 5;
                    break;
                case Keys.Down:
                    if ((pic.Bottom) < ClientRectangle.Height) pic.Top += 5;
                    break;
            }
            if(pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                addNewpic();
            }

        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnBound.Left += (e.X - p.X);
                pnBound.Top += (e.Y - p.Y);
            }
        }
    }
}
