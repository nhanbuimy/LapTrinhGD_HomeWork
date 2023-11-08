using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        ArrayList arrnv = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")

                {
                    throw new Exception("Bạn nên nhập đầy dử dữ liệu");
                }
                NhanVien nv = new NhanVien(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);
                arrnv.Add(nv);
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void show()//hien thi ds NhanVien ben listview
        {
            listView1.Items.Clear();
            ListViewItem item = null;
            foreach(NhanVien n in arrnv)
            {
                item = new ListViewItem(n.Name);
                item.SubItems.Add(n.Age.ToString());
                item.SubItems.Add(n.Address);
                listView1.Items.Add(item);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                show();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            BinaryFormatter bin = new BinaryFormatter();
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Employee File |*.emp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
                    foreach(NhanVien nv in arrnv)
                    {
                        bin.Serialize(stream, nv);

                    }
                }
            }
            catch { }
            finally
            {
                stream.Close();
            }

        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            FileStream stream = null;
            BinaryFormatter bin = new BinaryFormatter();
            arrnv.Clear();
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Employee File |*.emp";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    while(true)
                    {
                        NhanVien nv = new NhanVien();
                        nv = (NhanVien)bin.Deserialize(stream);
                        arrnv.Add(nv);

                    }

                }
            }
            catch { }
            finally
            {
                stream.Close();
                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
