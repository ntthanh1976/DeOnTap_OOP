using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOntap
{
    class GiangVien
    {
        private string maso;
        private string hoten;
        private int namsinh;

        public GiangVien()
        {
        }
        public GiangVien(string maso, string hoten, int namsinh) {
            this.maso = maso;
            this.hoten = hoten;
            this.namsinh = namsinh;
        }

        public string MaSo {
            set { this.maso = value; }
            get { return this.maso; }
        }
        public string HoTen
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public int NamSinh {
            set { this.namsinh = value; }
            get { return this.namsinh; }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma so:");
            this.maso = Console.ReadLine();
            Console.Write("Nhap ho ten:");
            this.hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh:");
            this.namsinh = int.Parse(Console.ReadLine());
        }
        public virtual int tinhLuong()
        {
            return 0;
        }
    }
}
