using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh4
{
    public partial class BTTL_Form2 : Form
    {
        private int rgb1 = 0, rgb2 = 0, rgb3 = 0;
        private float newFontSize;
        private string newFontName;
        private FontStyle newFontStyle = FontStyle.Regular;

        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void BTTL_Form2_Load(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            
            listBox1.Items.Clear();
            for (int i = 0; i < fonts.Length; i++)
            {
                listBox1.Items.Add(fonts[i].Name);
            }
        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
            rgb1 = hScrollBar1.Value;
            rgb2 = hScrollBar2.Value;
            rgb3 = hScrollBar3.Value;
            lbReviewColor.BackColor = Color.FromArgb(rgb1, rgb2, rgb3);
            richTextBox1.SelectionColor = Color.FromArgb(255,rgb1, rgb2, rgb3);
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
            //ktra đã chọn văn bản hay ch
            Font currentFont = richTextBox1.SelectionFont;
            newFontSize = float.Parse(comboBox1.Text);
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

        

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
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

        private void BtnUnder_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
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
    }
}
