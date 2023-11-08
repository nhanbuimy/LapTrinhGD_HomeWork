using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC3_Phanso
{
    class PhanSo
    {
        private int tuso,mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int a, int b)
        {
            this.tuso = a;
            this.mauso = ((b == 0) ? 1 : b);
        }
        public static int Ucln(int x,int y)
        {
            int a = Math.Abs(x);
            int b = Math.Abs(y);
            if (a < b) return a;
            return Ucln(b, a % b);
            
        }
        public void ToiGian()
        {
            int uc = Ucln(tuso, mauso);
            if (uc > 0)
            {
                tuso /= uc;
                mauso /= uc;
            }
        }
        public int Tuso
        {
            get
            {
                return tuso;
            }
            set
            {
                this.tuso = value;
            }
        }
        public int Mauso
        {
            get 
            { 
                return mauso;
            }
            set
            {
                this.mauso = ((value == 0) ? 1 : value);
            }
        }
    }
}
