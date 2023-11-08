using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace _2151050290_BuiMyNhan_May12
{
    public partial class Form1_InTro : Form
    {
        int imgWidth = 100;
        int padding = 40;
        Rectangle rec1;
        Rectangle rec2;
        int step = 10;
        Image img1;
        Image img2;

        public Form1_InTro()
        {
            InitializeComponent();
        }
        private void DrawImage(Graphics g)
        {
            g.DrawImage(img1, rec1);
            g.DrawImage(img2, rec2);
        }

        private void Form1_InTro_Load(object sender, EventArgs e)
        {
            rec1 = new Rectangle(padding, (ClientRectangle.Height - imgWidth) / 2, imgWidth, imgWidth);
            rec2 = new Rectangle(ClientRectangle.Width - imgWidth - padding, (ClientRectangle.Height - imgWidth) / 2, imgWidth, imgWidth);
            img1 = Image.FromFile(@"Hinh\bau.jpg");
            img2 = Image.FromFile(@"Hinh\cua.jpg");

        }

        private void Form1_InTro_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rec1.X += step;
            rec2.X -= step;
           DrawImage(this.CreateGraphics());
            Invalidate();
            if (rec1.IntersectsWith(rec2))
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
