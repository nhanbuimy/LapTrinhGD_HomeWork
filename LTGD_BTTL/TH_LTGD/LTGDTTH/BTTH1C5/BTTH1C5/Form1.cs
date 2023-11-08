using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //thư viện làm việc với file
using System.Windows.Forms;

namespace BTTH1C5
{
    public partial class Form1 : Form
    {
        Point pOld; //lưu vị trí nhấn chuột
        Random rand = new Random();
        String[] arFiles;
        int imgWidth = 90;//kích thước hình

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = " Dùng chuột hoặc các phím mũi tên di chuyển vào khung ";
            arFiles = Directory.GetFiles(Application.StartupPath + @"\Hinh\");
            AddNewPictures();
        }
        int count = 0;
        private void AddNewPictures()
        {
            count++;
            String file = arFiles[rand.Next(arFiles.Length)];
            Image img = Image.FromFile(file);
            PictureBox pic = new PictureBox();
            pic.Image = img;
            pic.Location = new Point(0, 0);
            pic.Width = pic.Height = imgWidth;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Name = count.ToString();
            pic.MouseDown += Pic_MouseDown; //cài sự kiện chuột trên pictureBox        
            this.Controls.Add(pic);//thêm picbox vào form
            pic.MouseMove += Pic_MouseMove_1;
            pic.MouseUp += Pic_MouseUp_1;
            this.Controls.SetChildIndex(pnBound, this.Controls.Count - 1);
        }

        //private void Pic_MouseUp(object sender, MouseEventArgs e)
        //{
        //    PictureBox pic = (PictureBox)sender;
        //    pnBound.Controls.Add(pic);
        //    AddNewPictures();
        //    if (pnBound.Bounds.Contains(pic.Bounds)) ;
        //    //throw new NotImplementedException();
        //}

        //private void Pic_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        PictureBox pic = (PictureBox)sender;
        //        int dx = e.X - pOld.X;
        //        int dy = e.Y - pOld.Y;
        //        pic.Left += dx;
        //        pic.Top += dy;
        //    }
        //    //throw new NotImplementedException();
        //}

        //private void Pic_MouseDown(object sender, MouseEventArgs e)
        //{
        //    pOld = e.Location;
        //    //throw new NotImplementedException();
        //}

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arrControls = this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)arrControls[0];
            switch (e.KeyData)
            {
                case Keys.Left:
                    {
                        if ((pic.Left - 5) > 0)
                            pic.Left -= 5;
                        break;
                    }

                case Keys.Right:
                    {
                        if ((pic.Right + 5) < ClientRectangle.Width)
                            pic.Left += 5;
                        break;
                    }
                case Keys.Up:
                    {
                        if ((pic.Top - 5) > 0)
                            pic.Top -= 5;
                        break;
                    }
                case Keys.Down:
                    {
                        if ((pic.Bottom + 5) < ClientRectangle.Height)
                            pic.Top += 5;
                        break;
                    }
            }
            if (pnBound.Bounds.Contains(pic.Bounds))
                pnBound.Controls.Add(pic);
            AddNewPictures();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnBound.Left += (e.X - pOld.X);
                pnBound.Top += (e.Y - pOld.Y);
            }
        }

        private void Pic_MouseUp_1(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
           
            if (pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewPictures();
            }
            
        }

        private void Pic_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }
    }
}
