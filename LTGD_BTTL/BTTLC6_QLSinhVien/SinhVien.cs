using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTLC6_QLSinhVien
{
    class SinhVien
    {
        string mssv, ho, ten;
       public SinhVien()
        {

        }
       public SinhVien(string mssv, string ho, string ten)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
        }
        public static implicit operator string(SinhVien d) => d.mssv;
   
        public string Mssv
        {
            get
            {
                return mssv;
            }
            set
            {
                this.mssv = value;
            }

        }
        public string Ho
        {
            get
            {
                return ho;
            }
            set
            {
                this.ho = value;
            }
        }
        public string Ten
        {
            get
            {
                return ten;
            }
            set
            {
                this.ten = value;
            }
        }

    }
}
