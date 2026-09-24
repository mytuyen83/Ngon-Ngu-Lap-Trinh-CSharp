using System;
namespace Lab02.ThucHanh2
{
    class Point
    {
        // Field: biến dùng để lưu tọa độ của điểm
        private double x, y;

        // Property: cho phép bên ngoài truy cập và thay đổi Field x, y
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        // Constructor mặc định: khởi tạo x và y bằng 0
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Nhập tọa độ
        public void Input()
        {
            Console.Write("Nhap x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = double.Parse(Console.ReadLine());
        }

        // Xuất tọa độ
        public void Output()
        {
            Console.WriteLine("(" + x + ", " + y + ")");
        }

        // Xuất Point dưới dạng chuỗi
        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

        // Phép toán cộng hai Point
        public static Point operator +(Point A, Point B)
        {
            Point kq = new Point();
            kq.x = A.x + B.x;
            kq.y = A.y + B.y;
            return kq;
        }

        // Phép toán trừ hai Point
        public static Point operator -(Point A, Point B)
        {
            Point kq = new Point();
            kq.x = A.x - B.x;
            kq.y = A.y - B.y;
            return kq;
        }

        // Phép toán lấy âm Point
        public static Point operator -(Point A)
        {
            Point kq = new Point();
            kq.x = -A.x;
            kq.y = -A.y;
            return kq;
        }

        // Tính khoảng cách bằng phương thức thành viên
        public double KhoangCach(Point B)
        {
            double dx = x - B.x;
            double dy = y - B.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Tính khoảng cách bằng phương thức tĩnh
        public static double KhoangCach(Point A, Point B)
        {
            double dx = A.x - B.x;
            double dy = A.y - B.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Tìm trung điểm bằng phương thức thành viên
        public Point TrungDiem(Point B)
        {
            Point kq = new Point();
            kq.x = (x + B.x) / 2;
            kq.y = (y + B.y) / 2;
            return kq;
        }

        // Tìm trung điểm bằng phương thức tĩnh
        public static Point TrungDiem(Point A, Point B)
        {
            Point kq = new Point();
            kq.x = (A.x + B.x) / 2;
            kq.y = (A.y + B.y) / 2;
            return kq;
        }

        public static void Bai1_2()
        {
            Point A = new Point();
            Point B = new Point();
            Point C;
            Point D;
            Point E;
            Point F;

            // Nhập hai điểm
            Console.WriteLine("Nhap diem A:");
            A.Input();
            Console.WriteLine("Nhap diem B:");
            B.Input();

            // Xuất hai điểm
            Console.WriteLine();
            Console.WriteLine("Diem A: " + A);
            Console.WriteLine("Diem B: " + B);

            // Thực hiện các phép toán
            C = A + B;
            D = A - B;
            E = -A;

            Console.WriteLine("A + B = " + C);
            Console.WriteLine("A - B = " + D);
            Console.WriteLine("-A = " + E);

            // Tính khoảng cách
            Console.WriteLine("Khoang cach AB bang phuong thuc thanh vien: " + A.KhoangCach(B));
            Console.WriteLine("Khoang cach AB bang phuong thuc tinh: " + Point.KhoangCach(A, B));

            // Tìm trung điểm
            F = A.TrungDiem(B);
            Console.WriteLine("Trung diem AB bang phuong thuc thanh vien: " + F);
            F = Point.TrungDiem(A, B);
            Console.WriteLine("Trung diem AB bang phuong thuc tinh: " + F);
        }
    }
}