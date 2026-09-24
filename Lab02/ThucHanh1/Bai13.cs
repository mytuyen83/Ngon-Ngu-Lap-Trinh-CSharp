using System;

namespace Lab02.ThucHanh1
{
    class SinhVien
    {
        public string MaSinhVien;
        public string HoTen;
        public string DiaChi;
        public int NamThu;

        // Nhập thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSinhVien = Console.ReadLine();

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();

            Console.Write("Nhap sinh vien nam thu: ");
            NamThu = int.Parse(Console.ReadLine());
        }

        // Xuất thông tin sinh viên
        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien: " + MaSinhVien);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Sinh vien nam thu: " + NamThu);
        }

        public static void Bai13()
        {
            SinhVien Sv = new SinhVien();

            // Nhập và xuất thông tin
            Sv.Nhap();
            Console.WriteLine();
            Sv.Xuat();
        }
    }
}