using System;
namespace Lab02.ThucHanh2
{
    class NhanVien
    {
        // Field: lưu họ tên, mức lương và số ngày vắng
        private string HoTen;
        private double Luong;
        private int SoNgayVang;
        // Default Constructor: tạo nhân viên ban đầu
        public NhanVien()
        {
            HoTen = "";
            Luong = 0;
            SoNgayVang = 0;
        }
        // Constructor có tham số
        public NhanVien(string HoTen, double Luong, int SoNgayVang)
        {
            this.HoTen = HoTen;
            this.Luong = Luong;
            this.SoNgayVang = SoNgayVang;
        }
        // Copy Constructor: sao chép một nhân viên
        public NhanVien(NhanVien nv)
        {
            HoTen = nv.HoTen;
            Luong = nv.Luong;
            SoNgayVang = nv.SoNgayVang;
        }
        // Nhập thông tin nhân viên
        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            Luong = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            SoNgayVang = int.Parse(Console.ReadLine());
        }
        // Xuất thông tin nhân viên
        public void Output()
        {
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Muc luong: " + Luong);
            Console.WriteLine("So ngay vang: " + SoNgayVang);
            Console.WriteLine("Luong thuc nhan: " + TinhLuong());
        }
        // Tính lương sau khi trừ tiền vắng
        public double TinhLuong()
        {
            return Luong - SoNgayVang * 100000;
        }
    }
    class PhongBan
    {
        // Field: lưu danh sách nhân viên
        private NhanVien[] a;
        // Default Constructor: tạo phòng ban rỗng
        public PhongBan()
        {
            a = new NhanVien[0];
        }
        // Constructor có tham số: tạo phòng ban có n nhân viên
        public PhongBan(int n)
        {
            a = new NhanVien[n];
            for (int i = 0; i < n; i++)
                a[i] = new NhanVien();
        }
        // Copy Constructor: sao chép một phòng ban
        public PhongBan(PhongBan p)
        {
            a = new NhanVien[p.a.Length];
            for (int i = 0; i < p.a.Length; i++)
                a[i] = new NhanVien(p.a[i]);
        }
        // Indexer: truy cập nhân viên thứ i
        public NhanVien this[int i]
        {
            get
            {
                return a[i];
            }
            set
            {
                a[i] = value;
            }
        }
        // Nhập danh sách nhân viên
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap nhan vien thu " + (i + 1) + ":");
                a[i].Input();
            }
        }
        // Xuất danh sách nhân viên
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan vien thu " + (i + 1) + ":");
                a[i].Output();
            }
        }
        // Tính tổng lương của phòng ban
        public double TinhTongLuong()
        {
            double tong = 0;
            for (int i = 0; i < a.Length; i++)
                tong += a[i].TinhLuong();
            return tong;
        }

        public static void Bai2_7()
        {
            Console.Write("Nhap so luong nhan vien n: ");
            int n = int.Parse(Console.ReadLine());
            PhongBan pb = new PhongBan(n);
            Console.WriteLine();
            pb.Input();
            Console.WriteLine();
            Console.WriteLine("Danh sach nhan vien:");
            pb.Output();
            Console.WriteLine();
            Console.WriteLine("Tong luong phong ban: " + pb.TinhTongLuong());
        }
    }
}