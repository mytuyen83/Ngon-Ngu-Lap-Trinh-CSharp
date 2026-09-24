using System;
namespace Lab02.ThucHanh2
{
    class SinhVien
    {
        public string HoTen;
        public int NamSinh;

        // Nhập thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
        }

        // Hàm tính tuổi sinh viên
        public int TinhTuoi()
        {
            return DateTime.Now.Year - NamSinh; //lấy năm hiện tại trừ cho năm sinh đã nhập
        }

        // Xuất thông tin sinh viên
        public void Xuat()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Tuoi: " + TinhTuoi());
        }

        public static void Bai1_1()
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
            Console.WriteLine();
            sv.Xuat();
        }
    }
}