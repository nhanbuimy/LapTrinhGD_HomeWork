using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTLC4_Editor
{
    public partial class Form1 : Form
    {
        int m1, m2, m3 = 0;
        Font fontold;
        float sizen;
        string namen;
        FontStyle stylen = FontStyle.Regular;//k co dinh dang j ht
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btB_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectedText == "")
                {
                    throw new Exception("Ban chua chon van ban!!!");
                }
                fontold = richTextBox1.SelectionFont;//lay font chu ht
                sizen = float.Parse(comboBox1.Text);//laykthuoc duoc chon o comboBox
                //listbox co chon kieu font hay k
                if (listBox1.SelectedItem != null)
                    namen = listBox1.SelectedItem.ToString();//lay chuoi duoc chon ra
                else
                    namen = fontold.Name;//lay fontold

                if (!fontold.Bold)
                {
                    btB.BackColor = Color.Gray;
                    stylen |= FontStyle.Bold;//kieu chu
                    

                }
                else
                {
                    btB.BackColor = Color.White;
                    stylen &= ~FontStyle.Bold;
                   
                }
                

                richTextBox1.SelectionFont = new Font(namen, sizen, stylen);
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btInghieng_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectedText == "")
                {
                    throw new Exception("Ban chua chon van ban!!!");
                }
                fontold = richTextBox1.SelectionFont;//lay font chu ht
                sizen = float.Parse(comboBox1.Text);//laykthuoc duoc chon o comboBox
                //listbox co chon kieu font hay k
                if (listBox1.SelectedItem != null)
                    namen = listBox1.SelectedItem.ToString();//lay chuoi duoc chon ra
                else
                    namen = fontold.Name;//lay fontold

                if (!fontold.Italic)
                {
                    btInghieng.BackColor = Color.Gray;
                    stylen |= FontStyle.Italic;//kieu chu


                }
                else
                {
                    btInghieng.BackColor = Color.White;
                    stylen &= ~FontStyle.Italic;

                }


                richTextBox1.SelectionFont = new Font(namen, sizen, stylen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUgach_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.SelectedText == "")
                {
                    throw new Exception("Ban chua chon van ban!!!");
                }
                fontold = richTextBox1.SelectionFont;//lay font chu ht
                sizen = float.Parse(comboBox1.Text);//laykthuoc duoc chon o comboBox
                //listbox co chon kieu font hay k
                if (listBox1.SelectedItem != null)
                    namen = listBox1.SelectedItem.ToString();//lay chuoi duoc chon ra
                else
                    namen = fontold.Name;//lay fontold

                if (!fontold.Underline)
                {
                    btUgach.BackColor = Color.Gray;
                    stylen |= FontStyle.Underline;//kieu chu


                }
                else
                {
                    btUgach.BackColor = Color.White;
                    stylen &= ~FontStyle.Underline;

                }


                richTextBox1.SelectionFont = new Font(namen, sizen, stylen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            
            m1 = hScrollBar1.Value;
            m2 = hScrollBar2.Value;
            m3 = hScrollBar3.Value;
            lbColor.BackColor = Color.FromArgb(255,m1,m2,m3);
            richTextBox1.SelectionColor = Color.FromArgb(255, m1, m2, m3);
            
            //thiết lập màu sắc cho văn bản được chọn
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbColor.BackColor = Color.FromArgb(255,m1,m2,m3);
            listBox1.Items.Clear();
            FontFamily[] fs = FontFamily.Families;
            //lấy font có sẵn đưa vào mảng
            for(int i=0;i<fs.Length;i++)
            {
                listBox1.Items.Add(fs[i].Name.ToString());//thêm tên font đó vào listbox
                
            }
        }


    }
}
