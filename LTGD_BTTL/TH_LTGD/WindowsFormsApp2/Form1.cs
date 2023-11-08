using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private TamGiac tamGiac = new TamGiac();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tamGiac.CanhA = Convert.ToDouble(txtCanha.Text);
                tamGiac.CanhB = Convert.ToDouble(txtCanhb.Text);
                tamGiac.CanhC = Convert.ToDouble(txtCanhc.Text);
                if(!tamGiac.isTamGiac())
                {
                    throw new Exception("Ba cạnh không phải một tam giác");
                }
                lbKetQua.Text = String.Format("{0:0.##}", tamGiac.tinhDienTich());
            }
            catch(FormatException)
            {
                MessageBox.Show("Sai định dạng. Nhập lại!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tamGiac.CanhA = Convert.ToDouble(txtCanha.Text);
                tamGiac.CanhB = Convert.ToDouble(txtCanhb.Text);
                tamGiac.CanhC = Convert.ToDouble(txtCanhc.Text);
                if (!tamGiac.isTamGiac())
                {
                    throw new Exception("Ba cạnh không phải một tam giác");
                }
                lbKetQua.Text = String.Format("{0:0.##}", tamGiac.tinhChuVi());
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai định dạng. Nhập lại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
