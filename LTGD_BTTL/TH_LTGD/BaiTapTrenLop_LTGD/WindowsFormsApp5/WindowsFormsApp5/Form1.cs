using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Đóng chương trình?", "Cảnh báo!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dlg==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuTroChoi_Click(object sender, EventArgs e)
        {
            FormTroChoi f = new FormTroChoi();
            f.MdiParent = this;
            f.Show();
        }

        private void MenuVe_Click(object sender, EventArgs e)
        {

            FormVe f = new FormVe();
            f.MdiParent = this;
            f.Show();
        }
    }
}
