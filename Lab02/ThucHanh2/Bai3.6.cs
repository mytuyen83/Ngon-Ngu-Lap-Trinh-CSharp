using System;
namespace Lab02.ThucHanh2
{
    // Lớp cha: lưu thông tin chung của thí sinh
    class ThiSinh
    {
        protected string sbd;
        protected string hoten;
        protected double bai1;
        protected double bai2;
        protected double bai3;
        public ThiSinh()
        {
            sbd = "";
            hoten = "";
            bai1 = 0;
            bai2 = 0;
            bai3 = 0;
        }
        public virtual void Input()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap diem bai 1: ");
            bai1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 2: ");
            bai2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem bai 3: ");
            bai3 = double.Parse(Console.ReadLine());
        }
        public virtual double TinhTongDiem()
        {
            return bai1 + bai2 + bai3;
        }
        public virtual void Output()
        {
            Console.WriteLine("So bao danh: " + sbd);
            Console.WriteLine("Ho ten: " + hoten);
            Console.WriteLine("Tong diem: " + TinhTongDiem());
        }
    }

    // Lớp con: thí sinh Chuyên
    class ThiSinhChuyen : ThiSinh
    {
        private double tiengAnh;
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem tieng Anh: ");
            tiengAnh = double.Parse(Console.ReadLine());
        }
        public override double TinhTongDiem()
        {
            double tong = bai1 + bai2 + bai3;
            if (tiengAnh >= 7 && tiengAnh <= 8)
                tong = tong + 1;
            else if (tiengAnh >= 9 && tiengAnh <= 10)
                tong = tong + 2;
            return tong;
        }
    }

    // Lớp con: thí sinh Siêu cúp
    class ThiSinhSieuCup : ThiSinh
    {
        private double csdl;
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem CSDL: ");
            csdl = double.Parse(Console.ReadLine());
        }
        public override double TinhTongDiem()
        {
            return bai1 + bai2 + bai3 + csdl;
        }
    }

    class QuanLyThiSinh
    {
        public static void Bai3_6()
        {
            Console.Write("Nhap so luong thi sinh: ");
            int n = int.Parse(Console.ReadLine());
            ThiSinh[] ds = new ThiSinh[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Thi sinh thu " + (i + 1));
                Console.WriteLine("1. Thi sinh Chuyen");
                Console.WriteLine("2. Thi sinh Sieu cup");
                Console.Write("Chon loai thi sinh: ");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                    ds[i] = new ThiSinhChuyen();
                else
                    ds[i] = new ThiSinhSieuCup();
                ds[i].Input();
            }
            Console.WriteLine();
            Console.WriteLine("Tong diem cua cac thi sinh:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Thi sinh thu " + (i + 1));
                ds[i].Output();
            }
        }
    }
}