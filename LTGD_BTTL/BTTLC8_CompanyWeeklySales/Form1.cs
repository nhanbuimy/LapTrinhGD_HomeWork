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

namespace BTTLC8_CompanyWeeklySales
{
    public partial class Form1 : Form
    {

        int[] data = new int[5];
        public Form1()
        {
            InitializeComponent();
        }
        private void VeBieuDo(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 2);
            //bút vẽ


            int columnCount = data.Length;//số cột = số phần tử của data
            int columnWidth = 30;//do rong cua cot
            int columnGap = 50;//khoang cach cac cot
            int chartWidth = columnCount * (columnWidth + columnGap) - columnGap;
            int chartHeight = 270;//chieu cao

           
            // Vẽ trục tọa độ x
            g.DrawLine(Pens.Black, 50, chartHeight + 80, chartWidth + 60, chartHeight +80);
            int y = chartHeight + 80;
            int max = data[0];
            int x = 55;
            Color[] color = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Aqua };
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                    max = data[i];
            }
            // Vẽ từng cột biểu đồ
            for (int i = 0; i < data.Length; i++)
            {
                int columnHeight = data[i] * (chartHeight - 100) / max;
                Rectangle columnRect = new Rectangle(x, y - columnHeight, columnWidth, columnHeight);
                g.FillRectangle(new SolidBrush(color[i]), columnRect);
                x += columnWidth + columnGap;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            data[0] = (int.Parse(textBox1.Text));
            data[1] = (int.Parse(textBox2.Text));
            data[2] = (int.Parse(textBox3.Text));
            data[3] = (int.Parse(textBox4.Text));
            data[4] = (int.Parse(textBox5.Text));
            
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {      
            VeBieuDo(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data[0] = (int.Parse(textBox1.Text));
            data[1] = (int.Parse(textBox2.Text));
            data[2] = (int.Parse(textBox3.Text));
            data[3] = (int.Parse(textBox4.Text));
            data[4] = (int.Parse(textBox5.Text));
        }
    }
}
