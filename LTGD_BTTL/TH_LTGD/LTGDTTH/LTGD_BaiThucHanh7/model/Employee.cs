using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh7.model
{
    [Serializable]
    internal class Employee
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }

        public Employee() { }

        public Employee(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
