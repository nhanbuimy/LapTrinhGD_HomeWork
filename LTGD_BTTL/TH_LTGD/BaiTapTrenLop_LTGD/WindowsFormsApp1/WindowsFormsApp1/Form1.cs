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
    public partial class Form1 : Form
    {

        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("ban muon thoat?", "exit",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if(dialogResult==DialogResult.No)
            //{ 
            //    e.Cancel = true;
            //}
        }
        
        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f2.MdiParent = this;
            f3.Hide();
            f4.Hide();
            f5.Hide();
            f6.Hide();
            f2.Show();
            
        }
        
        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f3.MdiParent = this;
            f2.Hide();
            f4.Hide();
            f5.Hide();
            f6.Hide();
            f3.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.MdiParent = this;
            f2.Hide();
            f3.Hide();
            f5.Hide();
            f6.Hide();
            f4.Show();
        }
        
        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.MdiParent = this;
            f2.Hide();
            f3.Hide();
            f4.Hide();
            f6.Hide();
            f5.Show();
        }

        private void form6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.MdiParent = this;
            f2.Hide();
            f3.Hide();
            f4.Hide();
            f5.Hide();
            f6.Show();
        }


        //string path;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    path = Application.StartupPath + @"\Images\";
        //    randomImages();

        //}
        //private void randomImages()
        //{
        //    Random rand = new Random();
        //    int so;
        //    so = rand.Next(1, 7);
        //    pictureBox1.Image = Image.FromFile(path + so + ".jpg");
        //}
    }
}
