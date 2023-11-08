using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        public void swap(ref int a,ref int b)
        {
            int tm = a;
            a = b;
            b = tm;

        }
        public void Print()
        {
            int a = 3, b = 5;
            swap(ref a, ref b);
            label1.Text = a.ToString() + ", " + b.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = 50;
            p.Y = 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Red, new Rectangle(50,
           20, 30, 30));


        }
        string fun1( ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i += 2)
                arr[i] = arr[i] + 10;
            return String.Join(", ", arr);
        }
        void Test()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            string result = fun1(ref arr);
            label1.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
