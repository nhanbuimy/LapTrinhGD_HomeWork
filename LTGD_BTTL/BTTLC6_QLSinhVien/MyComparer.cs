using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace BTTLC6_QLSinhVien
{
    class MyComparer:IComparer
    {
        public int Compare(object x,object y)
        {
            SinhVien sv1 = (SinhVien)x;
            SinhVien sv2 = (SinhVien)y;
            return sv1.Ten.CompareTo(sv2.Ten);
        }
    }

}
