using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC3_BaiToanTamGiac
{
    class TamGiac
    {
        private double canh1, canh2, canh3;
        // ptkt
        public TamGiac()
        {

        }
        public TamGiac(double a, double b, double c)
        {
            this.canh1 = a;
            this.canh2 = b;
            this.canh3 = c;
        }
        public double tinhChuVi()
        {
            return this.canh1 + this.canh2 + this.canh3;
        }
        public double tinhDienTich()
        {
            double p = tinhChuVi() / 2;

            return Math.Sqrt(p * (p - this.canh1) * (p - this.canh2) * (p - this.canh3));
        }
        public bool ktCanhTamGiac()
        {
            if (this.canh1 > 0 && this.canh2 > 0 && this.canh3 > 0)
            {
                if (((this.canh1 + this.canh2) > this.canh3) &&
                   ((this.canh3 + this.canh2) > this.canh1) &&
                   ((this.canh3 + this.canh1) > this.canh2))
                {
                    return true;
                }
            }
            return false;
        }
            
        public string ktLoaiTamGiac()
        {
           
            if ((this.canh1 == this.canh2) && (this.canh2 == this.canh3))
            {
                return "Đây là tam giác đều";
            }
            else if ((this.canh1 == this.canh2) ||
                (this.canh2 == this.canh3) ||
                (this.canh3 == this.canh1))
            {
                return "Đây là tam giác cân";

            } 

            return "Đây là tam giác";
        }
        













    //get set
    public double Canh1
        {
            get { return canh1; }
            set { this.canh1 = value; }
        }
        public double Canh2
        {
            get { return canh2; }
            set { this.canh2 = value; }
        }
        public double Canh3
        {
            get {return canh3; }
            set { this.canh3 = value; }
        }

    }
}
