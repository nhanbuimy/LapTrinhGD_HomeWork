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
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        float x, y;
        int width, height;
        Color fillColor;
        Color borderColor;
        float borderWidth = 1;
        public Form1()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            //button3.Click += button3_Click;
            //button4.Click += button4_Click;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        }
        
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                btMaunen.BackColor = dlg.Color;
                fillColor = dlg.Color;
                panel1.Invalidate();
                return;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                FullOpen = true
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btMauvien.BackColor = dlg.Color;
            }
            borderColor = dlg.Color;
            panel1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btMaunen.BackColor = Color.White;
            btMauvien.BackColor = Color.White;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView1.SelectedItems[0];//dòng list view được chọn đầu tiên

                    int n = int.Parse(selectedItem.SubItems[0].Text);//giá trị X
                    int m = int.Parse(selectedItem.SubItems[1].Text);//Y
                    int width = int.Parse(selectedItem.SubItems[2].Text);//Width
                    int height = int.Parse(selectedItem.SubItems[3].Text);//Height
                    Graphics g = panel1.CreateGraphics();//Tạo ms 1 grap...
                    g.Clear(panel1.BackColor);//dọn màu cho panel
                    Pen borderPen = new Pen(borderColor, borderWidth);// tạo bút vẽ
                    Brush fillBrush = new SolidBrush(fillColor);//loại cọ tô đồng nhất, tô lên 1 đtượng
                    Rectangle rect = new Rectangle(n, m, width, height);
                    g.FillRectangle(fillBrush, rect);//tô nền
                    g.DrawRectangle(borderPen, rect);//tô viền
                }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            borderWidth = (float)numericUpDown1.Value;
            panel1.Invalidate();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Close Application?", "Waring",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (dlg == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            
               
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                || textBox4.Text == "")
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);
                width = int.Parse(textBox3.Text);
                height = int.Parse(textBox4.Text);
                //listView1.Items.Clear();
                ListViewItem item = null;
                item = new ListViewItem(textBox1.Text);
                item.SubItems.Add(textBox2.Text);
                item.SubItems.Add(textBox3.Text);
                item.SubItems.Add(textBox4.Text);
                listView1.Items.Add(item);
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                textBox1.Focus();
            }
            catch (FormatException)
                {
                    MessageBox.Show("Bạn phải nhập định dạng là số!!!");
                }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[i]);
                    }
                }
                else
                    throw new Exception("Ban nen chon 1 phan tu o listview");
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMaunen_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btMaunen.BackColor = dlg.Color;
                fillColor = dlg.Color;
                panel1.Invalidate();
                
            }
        }

        private void btMauvien_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                FullOpen = true
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                btMauvien.BackColor = dlg.Color;
            }
            borderColor = dlg.Color;
            panel1.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileStream stream = null;
            //BinaryFormatter bin = new BinaryFormatter();
            //try
            //{
            //    SaveFileDialog dlg = new SaveFileDialog();
            //    dlg.Filter = "Rectangle file (*.rect)|*.rect";
            //    if (dlg.ShowDialog() == DialogResult.OK)
            //    {
            //        stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
            //        panel1 = bin.Deserialize(stream);
            //    }
            //}
            //catch { }
            //finally
            //{
            //    stream.Close();
            //}
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            BinaryFormatter bin = new BinaryFormatter();
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rectangle file (*.rect)|*.rect";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
                    bin.Serialize(stream, panel1);
                }
            }
            catch { }
            finally
            {
                stream.Close();
            }
        }
    }
}
