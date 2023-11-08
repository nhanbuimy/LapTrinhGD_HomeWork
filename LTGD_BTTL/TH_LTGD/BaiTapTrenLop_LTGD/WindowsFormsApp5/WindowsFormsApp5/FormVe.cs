using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp5
{
    public partial class FormVe : Form
    {
        public FormVe()
        {
            InitializeComponent();
        }

        private void FormVe_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc3 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width, ClientRectangle.Height / 2);
            Rectangle rc1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            DrawImage(rc1, e.Graphics);
            DrawImage(rc2, e.Graphics);
           // DrawImage(rc3, e.Graphics);
        }
        private void DrawImage(Rectangle rc,Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath+@"\babi.jpg");
            g.DrawImage(img, rc);
            img.RotateFlip(RotateFlipType.Rotate180FlipY);

        }

        private void FormVe_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
