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

namespace BTTLC8_DrawShapes
{
    public partial class Form1 : Form
    {
        bool ve;
        Point vitribd;
        Point vitriend;
        Pen butve;
        string luachonhinh;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butve = new Pen(Color.Red);
            ve = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure?", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dlg == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormOption f = new FormOption();
            //f.ShowDialog();
            Graphics g = CreateGraphics();
            if(f.ShowDialog()==DialogResult.OK)
            {
                switch(f.ChonHinh)//lay get set
                {
                    case "Rectangle":
                        {
                            luachonhinh = "Rectangle";
                            butve = new Pen(f.ChonMau);
                            break;
                        }
                    case "Ellipse":
                        {
                            luachonhinh = "Ellipse";
                            butve = new Pen(f.ChonMau);
                            break;
                        }
                    case "Triangle":
                        {
                            luachonhinh = "Triangle";
                            butve = new Pen(f.ChonMau);
                            break;
                        }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ve = true;
            vitribd = e.Location;//diem bd va kt dau tien o cung 1 cho
            vitriend = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ve)
                vitriend = e.Location;
            //diem dich, da di chuyen
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ve = false;//nghi ve, tha chuot
            Rectangle hcn = new Rectangle(vitribd, new Size(vitriend.X - vitribd.X, vitriend.Y - vitribd.Y));
            Graphics g1 = this.CreateGraphics();
            switch(luachonhinh)
            {
                case "Rectangle":
                    {
                        g1.FillRectangle(new SolidBrush(butve.Color), hcn);
                        break;

                    }
                case "Ellipse":
                    {
                        g1.FillEllipse(new SolidBrush(butve.Color), hcn);
                        break;

                    }
                case "Triangle":
                    {
                        Point[] ps = new Point[3];
                        ps[0] = new Point(vitribd.X, vitribd.Y);
                        ps[1] = new Point(vitriend.X, vitriend.Y);
                        ps[2] = new Point(vitriend.X, vitribd.Y);
                        g1.FillPolygon(new SolidBrush(butve.Color), ps);
                        break;

                    }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(ve)
            {
                switch (luachonhinh)
                {
                    case "Rectangle":
                        {
                            Rectangle hcn = new Rectangle(vitribd, new Size(vitriend.X - vitribd.X, vitriend.Y - vitribd.Y));
                            e.Graphics.FillRectangle(new SolidBrush(butve.Color), hcn);
                            break;
                        }
                    case "Ellipse":
                        {
                            //Rectangle hcn = new Rectangle(vitribd, new Size(vitriend.X - vitribd.X, vitriend.Y - vitribd.Y));
                            e.Graphics.DrawEllipse(butve,new Rectangle(vitribd,new Size(vitriend.X-vitribd.X,vitriend.Y-vitribd.Y)));
                            break;
                        }
                    case "Triangle":
                        {
                            Point[] ps = new Point[3];
                            ps[0] = new Point(vitribd.X, vitribd.Y);
                            ps[1] = new Point(vitriend.X, vitriend.Y);
                            ps[2] = new Point(vitriend.X, vitribd.Y);
                            e.Graphics.FillPolygon(new SolidBrush(butve.Color), ps);
                            break;
                        }
                }
                
            }
        }

       
    }
}
