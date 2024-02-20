using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOntap
{
    class QuanLyGV
    {
        private List<GiangVien> dsGV;
        public QuanLyGV() {
            dsGV = new List<GiangVien>();
        }

        //phuong thuc nhap danh sach giang vien
        public void NhapDS() {
            string tieptuc = "y";
            int chon;
            GiangVien gv;
            do
            {
                Console.Write("Chon loai giang vien [1:Co Huu, 2:Thinh giang]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1: 
                          gv = new GiangVienCH(); //tạo đối tượng gv cơ hữu
                          gv.Nhap(); //gọi phương thức nhập thông tin cho gv co huu
                          dsGV.Add(gv); //thêm gv vào danh sách
                          break;
                    case 2:
                          gv = new GiangVienTG(); //tạo đối tượng gv thỉnh giảng
                          gv.Nhap(); //gọi phương thức nhập thông tin cho gv thinh giang
                          dsGV.Add(gv); //thêm gv vào danh sách
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }

                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }

        //phương thức xuất thông tin danh sách giảng viên
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20}  {"Nam Sinh",10}  {"Luong",20}");            
            foreach (GiangVien x in dsGV) {
                Console.WriteLine($"{x.MaSo,-10}  {x.HoTen,20}  {x.NamSinh,10}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }

        //phương thức tính tổng lương nhà trường phải trả cho các giảng viên
        public int tinhTongLuong()
        {
            int sum = 0;
            foreach(GiangVien gv in dsGV)
            {
                sum += gv.tinhLuong();
            }

            return sum;
        }
    }
}
