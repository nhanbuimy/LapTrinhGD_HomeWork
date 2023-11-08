using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC3_DiemVaHinhTron
{
    class Hinhtron
    {
        //double d1, d2;
        Diem dTam;
        private double bKinh;
        public Hinhtron()
        {
            
        }
        public Hinhtron(Diem tam,double bk)
        {
            this.dTam = tam;
            this.bKinh = bk;
        }
        public Diem DTam
        {
            get { return dTam; }
            set { this.dTam = value; }
        }
        public double BKinh
        {
            get { return bKinh; }
            set { this.bKinh = value; }
        }
        public double tinhChuVi()
        {
            return 2 * Math.PI * this.bKinh;
        }
        public double tinhDienTich()
        {
            return Math.PI * this.bKinh * this.bKinh;
        }
        public string KtraDiem(Diem dtam,Diem d)
        {
            double temp = Math.Sqrt(Math.Pow((dTam.X - d.X), 2) +
                Math.Pow((dTam.Y - d.Y), 2));
            if (temp == bKinh)
                return "Điểm nằm trên đường tròn";
            return "Điểm không nằm trên đường tròn";
        }
    }
    

}
