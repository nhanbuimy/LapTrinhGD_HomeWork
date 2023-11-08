using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC3_DiemVaHinhTron
{
    class Diem
    {
        private double x,y;
        public Diem()
        {

        }
        public Diem(double td1,double td2)
        {
            this.x = td1;
            this.y = td2;
        }

        public double X
        {
            get { return x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return y; }
            set { this.y = value; }
        }

    }
}
