using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuLamC2//chuyển mã ascii
{
    public partial class ChuyenMaAscii : Form
    {
        public ChuyenMaAscii()
        {
            InitializeComponent();
        }

        private void btChuyen1_Click(object sender, EventArgs e)
        {
            try
            {

                int so = int.Parse(txt1.Text);
                if (so >= 0 && so <= 127)
                    lbKetqua1.Text = string.Format("{0}", (char)so);
                else
                {
                    throw new Exception("Mã ASCII có giá trị từ 0 đến 127");
                }    
                       
            }
            catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập số");
            }
            
        }

        private void btChuyen2_Click(object sender, EventArgs e)
        {
            try
            {
               
                char kt = char.Parse(txt2.Text);
                if ((int)kt >= 0 && (int)kt <= 127) 
                    lbKetqua2.Text = String.Format("{0}", (int)kt);
             
            }
            
            catch(FormatException)
            {
                MessageBox.Show("Bạn phải nhập 1 kí tự");
            }
          
        }
    }
}
