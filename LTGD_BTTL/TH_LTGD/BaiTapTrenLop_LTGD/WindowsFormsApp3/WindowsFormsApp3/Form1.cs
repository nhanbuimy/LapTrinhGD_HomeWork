using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int rgb1 = 0, rgb2 = 0, rgb3 = 0;
        private float newFontSize;
        private string newFontName;
        private FontStyle newFontStyle = FontStyle.Regular;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            rgb1 = hScrollBar1.Value;
            rgb2 = hScrollBar2.Value;
            rgb3 = hScrollBar3.Value;
            lbReviewColor.BackColor = Color.FromArgb(rgb1, rgb2, rgb3);
            richTextBox1.SelectionColor = Color.FromArgb(0, rgb1, rgb2, rgb3);
        }

        private void lbReviewColor_Click(object sender, EventArgs e)
        {

        }

        private void btBold_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectedText == "")//kyta văn bản đã đc chọn hay ch
                {
                    throw new Exception("Ban chua chon van ban");
                }
                    Font currentFont = richTextBox1.SelectionFont;//lấy font chữ của văn bản được chọn
                newFontSize = float.Parse(comboBox1.Text);//lấy kích thước size đc chọn từ combobox1
                if (!currentFont.Bold)
                {
                    newFontStyle |= FontStyle.Bold;
                }
                else
                {
                    newFontStyle &= ~FontStyle.Bold;
                }
                newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
                richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            try
            {

                if (richTextBox1.SelectedText == "")
                {
                    throw new Exception("Ban chua chon van ban");
                }
                Font currentFont = richTextBox1.SelectionFont;
                newFontSize = float.Parse(comboBox1.Text);
                if (!currentFont.Italic)
                {
                    newFontStyle |= FontStyle.Italic;
                }
                else
                {
                    newFontStyle &= ~FontStyle.Italic;
                }
                newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
                richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                if (richTextBox1.SelectedText == "")
                {
                    throw new Exception("Ban chua chon van ban");
                }
                Font currentFont = richTextBox1.SelectionFont;
                newFontSize = float.Parse(comboBox1.Text);
                if (!currentFont.Underline)
                {
                    newFontStyle |= FontStyle.Underline;
                }
                else
                {
                    newFontStyle &= ~FontStyle.Underline;
                }
                newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
                richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FontFamily[] fonts = FontFamily.Families;
            foreach(FontFamily i in fonts)
            {
                listBox1.Items.Add(i.Name);
            }    
        }
    }
}
