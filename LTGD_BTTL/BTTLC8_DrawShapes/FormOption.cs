using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC8_DrawShapes
{
    public partial class FormOption : Form
    {
        private string chonHinh;
        Color chonMau;
        ColorDialog colors = new ColorDialog
        {
            FullOpen = true
        };
        public FormOption()
        {
            InitializeComponent();
        }
        public string ChonHinh
        {
            get { return chonHinh; }
            set { this.chonHinh = value; }
        }
        public Color ChonMau
        {
            get { return chonMau; }
            set { this.chonMau = value; }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (colors.ShowDialog() == DialogResult.OK)
                button1.BackColor = colors.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked)
            {
                chonHinh = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                chonHinh = radioButton2.Text;
            }
            else
            {
                chonHinh = radioButton3.Text;
            }
            chonMau = colors.Color;//chon mau cua hinh bang chon mau cua button1
            this.DialogResult = DialogResult.OK;//gui kqua ve Form chinh
        }
    }
}
