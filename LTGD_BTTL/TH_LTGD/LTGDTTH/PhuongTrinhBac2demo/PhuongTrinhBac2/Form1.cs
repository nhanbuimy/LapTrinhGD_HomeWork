using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
                {
                    throw new Exception("Ban chua nhap du lieu");
                }
                double soA = double.Parse(txtA.Text);
                double soB = double.Parse(txtB.Text);
                double soC = double.Parse(txtC.Text);
            }
            catch (FormatException)
            {
                lbKetqua.Text = "Ban nen nhap so";
            }
            catch(Exception ex)
            {
                lbKetqua.Text = ex.Message;
            }
        }

       
    }
}
