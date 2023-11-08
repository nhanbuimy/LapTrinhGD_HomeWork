using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC3_HieuchinhlopPhanSo
{
    class PhanSo
    {
        private int tuso, mauso;
        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int t,int m)
        {
            this.tuso = t;
            this.mauso = ((m == 0) ? 1 : m);
        }
        public int Tuso
        {
            get { return tuso; }
            set { this.tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set { this.mauso = ((value == 0) ? 1 : value); }
        }

        
        public  void ToiGian()
        {
            int uc = LopDungChung.Ucln(tuso, mauso);
            if (uc > 0)
            {
                tuso /= uc;
                mauso /= uc;
            }
        }
        
        public static bool sosanhPhanSo(PhanSo p1,PhanSo p2)
        {
            double tam1 = (double)p1.tuso / p1.mauso;
            double tam2 = (double)p2.tuso / p2.mauso;
            if (((p1.tuso==p2.tuso)&&(p1.mauso==p2.mauso)) )//|| tam1==tam2)
                return true;
            return false;
        }

        //cong phan so
        public static PhanSo Congps(PhanSo p1,PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = p1.tuso * p2.mauso + p1.mauso * p2.tuso;
            kq.mauso = p1.mauso * p2.mauso;          
            kq.ToiGian();
            return kq;
        }
        public static PhanSo Trups(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = p1.tuso * p2.mauso - p1.mauso * p2.tuso;
            kq.mauso = p1.mauso * p2.mauso;
            kq.ToiGian();
            return kq;
        }
        public static PhanSo Nhanps(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = p1.tuso * p2.tuso;
            kq.mauso = p1.mauso * p2.mauso;
            kq.ToiGian();
            return kq;
        }
        public static PhanSo Chiaps(PhanSo p1, PhanSo p2)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = p1.tuso * p2.mauso;
            kq.mauso = p1.mauso * p2.tuso;
            kq.ToiGian();
            return kq;
        }
    }
}
