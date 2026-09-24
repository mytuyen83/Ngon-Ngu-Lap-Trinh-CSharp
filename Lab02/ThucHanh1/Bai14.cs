using System;

namespace Lab02.ThucHanh1
{
    class NhanVien
    {
        public string HoTen;
        public double MucLuong;
        public int SoNgayVang;

        // Nhập thông tin nhân viên
        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap muc luong: ");
            MucLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }

        // Tính lương
        public double TinhLuong()
        {
            return MucLuong - SoNgayVang * 100000;
        }

        // Xuất thông tin và lương
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Muc luong: " + MucLuong);
            Console.WriteLine("So ngay vang: " + SoNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }

        public static void Bai14()
        {
            NhanVien Nv = new NhanVien();

            // Nhập và xuất thông tin
            Nv.Nhap();
            Console.WriteLine();
            Nv.Xuat();
        }
    }
}