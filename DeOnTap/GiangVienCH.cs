using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOntap
{
    class GiangVienCH : GiangVien
    {
        private double hesoluong;

        public GiangVienCH() : base() {            
        }
        public GiangVienCH(string maso, string hoten, int namsinh, double hesoluong) : base(maso,hoten,namsinh)
        {
            this.hesoluong = hesoluong;
        }

        public double HeSoLuong {
            set { hesoluong = value; }
            get { return hesoluong; }
        }

        //ghi đè phương thức Nhap() của lớp cha
        public override void Nhap()
        {
            base.Nhap(); //gọi phương thức Nhap() của lớp cha
            Console.Write("Nhap he so luong:");
            this.hesoluong = double.Parse(Console.ReadLine());
        }

        //ghi đè phương thức tinhLuong() của lớp cha
        public override int tinhLuong()
        {
            double luong = hesoluong * 1800000;
            return (int)luong;
        }
    }
}
