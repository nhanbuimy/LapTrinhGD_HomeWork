using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class TamGiac
    {
        private double canhA, canhB, canhC;

        public bool isTamGiac()
        {
            if ((canhA + canhB) <= canhC ||
                    (canhA + canhC) <= canhB ||
                    (canhB + canhC) <= canhA)
            {
                return false;
            }
            return true;
        }

        public double CanhA
        {
            get { return canhA; }
            set
            {
                if (value > 0)
                {
                    canhA = value;
                } else
                {
                    canhA = 0;
                }
            }
        }

        public double CanhB
        {
            get { return canhB; }
            set 
            {
                if (value > 0)
                {
                    canhB = value;
                }
                else
                {
                    canhB = 0;
                }
            }
        }

        public double CanhC
        {
            get { return canhC; }
            set 
            {
                if (value > 0)
                {
                    canhC = value;
                }
                else
                {
                    canhC = 0;
                }
            }
        }

        public double tinhDienTich()
        {
            double t = (canhA + canhB + canhC) / 2;
            return Math.Sqrt(t * (t - canhA) * (t - canhB) * (t - canhC));
        }

        public double tinhChuVi()
        {
            return canhA + canhB + canhC;
        }
    }
}
