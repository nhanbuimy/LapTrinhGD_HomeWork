using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawByMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw_By_Mouse f = new Draw_By_Mouse();
            f.MdiParent = this;
            f.Show();
        }

        private void drawTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw_Text f = new Draw_Text();
            f.MdiParent = this;
            f.Show();
        }

        private void drawImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw_Image f = new Draw_Image();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
