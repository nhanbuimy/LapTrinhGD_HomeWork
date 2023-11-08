using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC5_QuaBong
{
    public partial class Form1 : Form
    {
        int dx, dy, dxThanhngang;
        bool trangthaiball;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void dichuyenBanh()
        {
            if (picBall.Left < 0 || picBall.Right > ClientRectangle.Width)
            {
                dx = -dx;              
            }
            if (picBall.Top < 0 || lbthanhngang.Bounds.IntersectsWith(picBall.Bounds))//thanh ngang và trái ball đụng nhau
            {
                dy = -dy;           
            }
            picBall.Left += dx;
            picBall.Top += dy;
            if (picBall.Bottom > lbthanhngang.Bottom)
                timer1.Stop(); 
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            dichuyenBanh();   
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dx = 5;
            dy = 10;
            trangthaiball = false;
            dxThanhngang = 5;

        }
        Point p;
        private void lbthanhngang_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void lbthanhngang_MouseMove(object sender, MouseEventArgs e)
        {
            Label pic = (Label)sender;
            int dxThanhngang;
            dxThanhngang = e.X - p.X;
            if (e.Button == MouseButtons.Left
            && lbthanhngang.Left + dxThanhngang - 10 > 0
            && lbthanhngang.Right + dxThanhngang + 10 < ClientRectangle.Width)
            {
                pic.Left += dxThanhngang;
            }
        }

        //private void dichuyenThanhNgang(int dodai)
        //{
        //    if(lbthanhngang.Left>0 && lbthanhngang.Right<ClientRectangle.Width)
        //    {
        //        lbthanhngang.Left += dodai;
        //    }
        //}
        
       
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.S:// phim s
                    trangthaiball = !trangthaiball;
                    if(trangthaiball)
                    {
                        timer1.Enabled = trangthaiball;
                        timer1.Start();
                    }
                    else
                    {
                        timer1.Stop();
                        timer1.Enabled = trangthaiball;
                    }
                    timer1.Enabled = trangthaiball;
                    return true;
                case Keys.Left:
                    if (lbthanhngang.Left > 0)
                    {
                        lbthanhngang.Left -= dxThanhngang;
                    }

                    return true;
                case Keys.Right:
                    if (lbthanhngang.Right < ClientRectangle.Width)
                    {
                        lbthanhngang.Left += dxThanhngang;
                    }

                    return true;

            }    
            return base.ProcessDialogKey(keyData);
        }

    }
}
