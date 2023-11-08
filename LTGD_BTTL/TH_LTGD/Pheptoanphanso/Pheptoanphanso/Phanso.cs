using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheptoanphanso
{
    class Phanso
    {
        int tuso, mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 1;

        }
        public Phanso(int ts,int ms)
        {
            tuso = ts;
            mauso = ms == 0 ? 1 : ms;
        }
        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mauso; }
            set 
            {
                mauso = value;
                if (mauso == 0)
                    mauso = 1;
            }
        }
        public Phanso Cong(Phanso p)
        {
            Phanso kq = new Pheptoanphanso.Phanso();
            kq.tuso = tuso * p.mauso + mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.UCLN();
            return kq;
        }
        public Phanso Tru(Phanso p)
        {
            Phanso kq = new Pheptoanphanso.Phanso();
            kq.tuso = tuso * p.mauso - mauso * p.tuso;
            kq.mauso = mauso * p.mauso;
            kq.UCLN();
            return kq;
        }
        public void UCLN()
        {
            int ucln = Pheptoanphanso.Lopdungchung.Ucln(tuso, mauso);
            if(ucln>0)
            {
                tuso /= ucln;
                mauso /= ucln;
            }
        }
    }
}
