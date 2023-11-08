using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BTTLC4_MyPhotoMDI
{
    public partial class FormChild : Form
    {
        Image image;
        public FormChild()
        {
            InitializeComponent();
        }

        private void FormChild_Load(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\dog.jpg");
        }
        private void LoadImage(String filename)
        {
            image = Image.FromFile(filename);
            picImage.Image = image;
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\dog.jpg");
        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Image file (jepg,gif,bmp,...)|*.jpg;*.gif;*.bmp;*.png|" +
                "jpeg file(*.jpg)|*.jpg|" +
                "gif file(*.gif)|*.gif|" +
                "bmp file(*.bmp)|*.bmp|" +
                "png file(*.png)|*.png";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                LoadImage(dlg.FileName);
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Image file (jepg,gif,bmp,...)|*.jpg;*.gif;*.bmp;*.png|" +
                "jpeg file(*.jpg)|*.jpg|" +
                "gif file(*.gif)|*.gif|" +
                "bmp file(*.bmp)|*.bmp|" +
                "png file(*.png)|*.png";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                if(dlg.FileName.ToLower().EndsWith(".jpg"))
                {
                    image.Save(dlg.FileName, ImageFormat.Jpeg);
                }
                else if(dlg.FileName.ToLower().EndsWith(".bmp"))
                {
                    image.Save(dlg.FileName, ImageFormat.Bmp);
                }
                else if(dlg.FileName.ToLower().EndsWith(".png"))
                {
                    image.Save(dlg.FileName, ImageFormat.Png);
                }
                else if(dlg.FileName.ToLower().EndsWith(".gif"))
                {
                    image.Save(dlg.FileName, ImageFormat.Gif);
                }
            }
        }
    }
}
