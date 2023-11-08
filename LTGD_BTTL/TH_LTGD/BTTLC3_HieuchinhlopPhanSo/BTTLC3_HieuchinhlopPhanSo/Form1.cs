using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTTLC3_HieuchinhlopPhanSo;
namespace BTTLC3_HieuchinhlopPhanSo
{
    public partial class Form1 : Form
    {
        
        PhanSo p1, p2;
        int vitri;
        int ts1, ts2, ms1, ms2;
        Random rand = new Random();
        string[] arr = { "+", "-", "*", "/" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "     CÁC PHÉP TOÁN TRÊN PHÂN SỐ     ";
            randomPhanSo();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(label1.Text.Length-1,1)
                 + label1.Text.Substring(0, label1.Text.Length-1);
        }
        private void randomPhanSo()
        {
            ts1 = rand.Next(10);
            ms1 = rand.Next(10);
            ts2 = rand.Next(10);
            ms2 = rand.Next(10);
            vitri = rand.Next(4);
            lbTu1.Text = ts1.ToString();
            while (ms1 == 0)
            {
                ms1 = rand.Next(10);
            }
            lbMau1.Text = ms1.ToString();
            while (ts2 == 0 && arr[vitri] == "/")
            {
                ts2 = rand.Next(10);
            }
            lbTu2.Text = ts2.ToString();
            while (ms2 == 0)
            {
                ms2 = rand.Next(10);
            }
            lbMau2.Text = ms2.ToString();
            lbPheptinh.Text = arr[vitri];
            p1 = new PhanSo(ts1, ms1);
            p2 = new PhanSo(ts2, ms2);
        }      
        
        //xem ket qua
        private void btXem_Click(object sender, EventArgs e)
        {
            PhanSo kq = new PhanSo();
            switch (lbPheptinh.Text)
            {
                case "+":
                    {
                        
                        kq = PhanSo.Congps(p1, p2);
                        //lbKetqua.Text = kq.Tuso.ToString()
                        //+ "/" + kq.Mauso.ToString();
                        int tsnhap = int.Parse(txtTu.Text);
                        int msnhap = int.Parse(txtMau.Text);
                        PhanSo p3 = new PhanSo(tsnhap, msnhap);
                        bool ktra = PhanSo.sosanhPhanSo(kq, p3);
                        if (ktra == true)
                            lbKetqua.Text = "Dung roi!!!";
                        else
                        {
                            if (kq.Mauso == 1)
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}",
                                kq.Tuso.ToString());
                            }
                            else
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}/{1}",
                                    kq.Tuso.ToString(), kq.Mauso.ToString());
                            }
                        }
                        break;
                    }
                case "-":
                    {
                        kq = BTTLC3_HieuchinhlopPhanSo.PhanSo.Trups(p1, p2);
                        int tsnhap = int.Parse(txtTu.Text);
                        int msnhap = int.Parse(txtMau.Text);
                        PhanSo p3 = new PhanSo(tsnhap, msnhap);
                        bool ktra = PhanSo.sosanhPhanSo(kq, p3);
                        if (ktra == true)
                            lbKetqua.Text = "Dung roi!!!";
                        else
                        {
                            if (kq.Mauso == 1)
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}",
                                kq.Tuso.ToString());
                            }
                            else
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}/{1}",
                                    kq.Tuso.ToString(), kq.Mauso.ToString());
                            }
                        }
                        break;
                    }
                case "*":
                    {
                        kq = BTTLC3_HieuchinhlopPhanSo.PhanSo.Nhanps(p1, p2);
                        int tsnhap = int.Parse(txtTu.Text);
                        int msnhap = int.Parse(txtMau.Text);
                        PhanSo p3 = new PhanSo(tsnhap, msnhap);
                        bool ktra = PhanSo.sosanhPhanSo(kq, p3);
                        if (ktra == true)
                            lbKetqua.Text = "Dung roi!!!";
                        else
                        {
                            if (kq.Mauso == 1)
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}",
                                kq.Tuso.ToString());
                            }
                            else
                            {
                                lbKetqua.Text = string.Format("Sai roi, ket qua = {0}/{1}",
                                    kq.Tuso.ToString(), kq.Mauso.ToString());
                            }
                        }
                        break;
                    }
                case "/":
                    {
                        kq = BTTLC3_HieuchinhlopPhanSo.PhanSo.Chiaps(p1, p2);
                        int tsnhap = int.Parse(txtTu.Text);
                        int msnhap = int.Parse(txtMau.Text);
                        PhanSo p3 = new PhanSo(tsnhap, msnhap);
                        bool ktra = PhanSo.sosanhPhanSo(kq, p3);
                        if (ktra == true)
                            lbKetqua.Text = "Đúng rồi!!!";
                        else
                        {
                            if (kq.Mauso == 1)
                            {
                                lbKetqua.Text = string.Format("Sai rồi, kết quả  = {0}",
                                kq.Tuso.ToString());
                            }
                            else
                            {
                                lbKetqua.Text = string.Format("Sai rồi, kết quả = {0}/{1}",
                                    kq.Tuso.ToString(), kq.Mauso.ToString());
                            }
                        }
                        break;
                    }
            }
        }




        //dong chuong trinh
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //quay so
        private void btQuay_Click(object sender, EventArgs e)
        {
            lbKetqua.Text = "";
            randomPhanSo();
        }
    }
}
