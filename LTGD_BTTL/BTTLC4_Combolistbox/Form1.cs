using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTTLC4_Combolistbox
{
    public partial class Form1 : Form
    {

        string[] strmau = { "Red", "Blue", "Cyan", "DarkGreen", 
            "OliveDrab", "LightBlue"};
        int[] n = {1,2,3,4,5};
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đóng ứng dụng?", 
                "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) 
            {
                Application.Exit();
            }       
            
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            listBox1.Items.Clear();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "") return;
            listBox.Items.Add(txtNhap.Text);
            txtNhap.Text = "";
            txtNhap.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cbChonmau.Items.Add(Color.Green);
            cbChonmau.Items.AddRange(n);//theem phan tu vao(chu)
        }

        private void cbChonmau_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbChonmau.SelectedItem.ToString())
            {
                case "Red":
                    listBox1.BackColor = Color.Red;
                   
                    break;
                case "Blue":
                    listBox1.BackColor = Color.Blue;
                    listBox1.ForeColor = Color.White;
                    break;
                case "Cyan":
                    listBox1.BackColor = Color.Cyan;
                    break;
                case "DarkGreen":
                    listBox1.BackColor = Color.DarkGreen;
                    listBox1.ForeColor = Color.White;
                    break;
                case "OliveDrab":
                    listBox1.BackColor = Color.OliveDrab;
                    listBox1.ForeColor = Color.White;
                    break;
                case "LightBlue":
                    listBox1.BackColor = Color.LightBlue;
                    
                    break;
            }
        }

       

       

        private void btPhai_Click(object sender, EventArgs e)
        {
            for (int i = listBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox.SelectedItems[listBox.SelectedItems.Count-1-i]);
                listBox.Items.Remove(listBox.SelectedItems[listBox.SelectedItems.Count - 1 - i]);
            }
            
        }

        private void btTrai_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }


        private void btRemove_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItems.Count > 0)
            {
                for (int i = listBox.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox.Items.Remove(listBox.SelectedItems[i]);
                    // xóa ở vị trí các phần tử được chọn
                }
            }
            if (listBox1.SelectedItems.Count > 0)
            {
                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                //vì listbox 1 chỉ chọn được 1 cái nên pt được xóa luôn ở vị trí 0
            }
            //xoa duoc 1 phan tu
            //listBox.Items.Remove(listBox.SelectedItem);    
        }
    }
}
