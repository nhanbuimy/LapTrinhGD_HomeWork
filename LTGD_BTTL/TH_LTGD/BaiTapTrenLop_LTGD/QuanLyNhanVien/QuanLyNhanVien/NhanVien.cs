using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace QuanLyNhanVien
{
    [Serializable]
    class NhanVien
    {
        
        string name, address;
        int age;
        public NhanVien() { }
        public NhanVien(string n, int age, string dc)
        {
            this.name = n;
            this.age = age;
            this.address = dc;
        }
        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                this.address = value;
            }
        }
    }
}
