using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        int dx;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Images\";
            pictureBox1.Image = Image.FromFile(path + "cat3.png");
            dx = 10;
        }
        Point p;
        //private void Pic_MouseDown(object sender, MouseEventArgs e)
        //{
        //    p = e.Location;
        //}

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;

                int dx, dy;
                dx = e.X - p.X;
                dy = e.Y - p.Y;
                pic.Left += dx;
                pic.Top += dy;

            }
        }

        //private void Pic_MouseUp(object sender, MouseEventArgs e)
        //{
        //    PictureBox pic = (PictureBox)sender;
        //    if (pnBound.Bounds.Contains(pic.Bounds))
        //    {
        //        pnBound.Controls.Add(pic);
        //        addNewpic();
        //    }
        //} 
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (lbThanhngang.Left > 0)
                    {
                        lbThanhngang.Left -= dx;
                    }

                    return true;
                case Keys.Right:
                    if (lbThanhngang.Right < ClientRectangle.Width)
                    {
                        lbThanhngang.Left += dx;
                    }

                    return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void lbThanhngang_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void lbThanhngang_MouseMove(object sender, MouseEventArgs e)
        {
            
                Label pic = (Label)sender;
                int dxThanhngang;
                dxThanhngang = e.X - p.X;
            if (e.Button == MouseButtons.Left
            && lbThanhngang.Left + dxThanhngang - 10 > 0
            && lbThanhngang.Right + dxThanhngang + 10 < ClientRectangle.Width)
            {
                //if (pic.Right > ClientRectangle.Width || pic.Left < 0)
                //    pic.Left -= dxThanhngang;
                pic.Left += dxThanhngang;
            }





//if (pic.Left > 0)
                //{
                //    lbThanhngang.Left -= dx;
                //}
                //else if (pic.Right < ClientRectangle.Width)
                //{
                //    //lbThanhngang.Left += dx;
                //    pic.Left += dx;
                //}
                //else
      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int n;
        Random rand = new Random();
        int[] arr;
        // int[] sont;
        int countcnt;
        private void btPlay_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(txtNhapspt.Text);
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, 100);
                bool snt = ktraSngto(arr[i]);
                if (snt == true)
                {
                    countcnt++;
                    lbSonguyento.Text += arr[i].ToString() + ",";

                }
            }
            lbSonguyento.Text = lbSonguyento.Text.TrimEnd(',');
            if (countcnt == 0)
                lbSonguyento.Text = "Khong co";
            lbtaoMang.Text = string.Join(",", arr);
            // lbSonguyento.Text = string.Join(", ", sont);
            //sont = new int[countcnt];
            //for (int k = 0; k < countcnt; k++)
            //{
            //    for(int m=0;m<n;m++)
            //    {
            //        if (ktraSngto(arr[m]) == true)
            //        {
            //            sont[k] = arr[m];
            //        }
            //    }
            //}
            //lbSonguyento.Text = countcnt.ToString() + "\n";
            //for(int f=0;f<countcnt;f++)
            //{
            //    lbSonguyento.Text = sont[f].ToString() + ", ";
            //}    


            //foreach(var element in sont)
            //{
            //    lbSonguyento.Text += e;
            //}

        }
        
        private bool ktraSngto(int k)
        {
            if (k < 2) return false;
            else
            { 
                for (int j = 2; j <= Math.Sqrt(k); j++) 
                {
                    if (k % j == 0)
                        return false;
                }
                return true;
            } 
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lbSonguyento.Text = lbtaoMang.Text = txtNhapspt.Text = "";
            txtNhapspt.Focus();
        }

        //private void lbThanhngang_MouseUp(object sender, MouseEventArgs e)
        //{

        //}
    }
   
}
