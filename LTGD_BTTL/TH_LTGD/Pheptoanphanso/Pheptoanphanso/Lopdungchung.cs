﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheptoanphanso
{
    class Lopdungchung
    {
        public static int Ucln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            return Ucln(b, a % b);
        }
    }
}
