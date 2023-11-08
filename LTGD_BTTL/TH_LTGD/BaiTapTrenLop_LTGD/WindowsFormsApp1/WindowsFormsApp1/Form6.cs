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

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        string path;
        int sondchon;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            sondchon = 1;
            path = Application.StartupPath + @"\hinhxucxac";
            pictureBox1.Image = Image.FromFile(path + sondchon + ".jpg");
        }

    }
}
