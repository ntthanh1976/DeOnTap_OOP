using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOntap
{
    class GiangVienTG: GiangVien
    {
        private int sotietday;

        public GiangVienTG() : base()
        {
        }
        public GiangVienTG(string maso, string hoten, int namsinh, int sotietday) : base(maso, hoten, namsinh)
        {
            this.sotietday = sotietday;
        }

        public int SoTietDay
        {
            set { sotietday = value; }
            get { return sotietday; }
        }

        //ghi đè phương thức Nhap() của lớp cha
        public override void Nhap()
        {
            base.Nhap(); //gọi phương thức Nhap() của lớp cha
            Console.Write("Nhap so tiet day:");
            this.sotietday = int.Parse(Console.ReadLine());
        }

        //ghi đè phương thức tinhLuong() của lớp cha
        public override int tinhLuong()
        {
            return sotietday * 80000;
        }
    }
}
