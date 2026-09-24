using System;
namespace Lab02.ThucHanh2
{
    // Lớp cha: lưu thông tin chung của nhân viên
    class NhanVien35
    {
        protected string MaSo;
        protected string HoTen;
        public NhanVien35()
        {
            MaSo = "";
            HoTen = "";
        }
        public NhanVien35(string MaSo, string HoTen)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
        }
        public virtual double TinhLuong()
        {
            return 0;
        }
        public virtual void Output()
        {
            Console.WriteLine("Ma nhan vien: " + MaSo);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Luong: " + TinhLuong());
        }
    }

    // Lớp con: nhân viên kinh doanh
    class NhanVienKinhDoanh : NhanVien35
    {
        private double LuongCoBan;
        private int SoHopDong;
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so hop dong: ");
            SoHopDong = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return LuongCoBan + SoHopDong * 500000;
        }
    }

    // Lớp con: nhân viên sản xuất
    class NhanVienSanXuat : NhanVien35
    {
        private int SoSanPham;
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so san pham: ");
            SoSanPham = int.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            double Luong = SoSanPham * 1000;
            if (SoSanPham > 3000)
                Luong = Luong * 1.05;
            return Luong;
        }
    }

    class QuanLyNhanVien
    {
        public static void Bai3_5()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien35[] ds = new NhanVien35[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan vien thu " + (i + 1));
                Console.WriteLine("1. Nhan vien kinh doanh");
                Console.WriteLine("2. Nhan vien san xuat");
                Console.Write("Chon loai nhan vien: ");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                    ds[i] = new NhanVienKinhDoanh();
                else
                    ds[i] = new NhanVienSanXuat();
                ds[i].Input();
            }
            Console.WriteLine();
            Console.WriteLine("Thong tin nhan vien:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan vien thu " + (i + 1));
                ds[i].Output();
            }
        }
    }
}