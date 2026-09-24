using System;
namespace Lab02.ThucHanh2
{
    // Delegate: quy định kiểu hàm được gọi khi chọn chức năng
    delegate void XuLyChucNang(int x);
    class ConsoleMenu
    {
        // Event: sự kiện được phát ra khi người dùng chọn chức năng
        public event XuLyChucNang Choose;
        public void Run()
        {
            int x;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Giai phuong trinh bac 2");
                Console.WriteLine("2. Gioi thieu");
                Console.WriteLine("0. Thoat");
                Console.Write("Thuc hien: ");
                x = int.Parse(Console.ReadLine());
                if (x != 0 && Choose != null)
                    Choose(x);
            } while (x != 0);
        }
    }
    // Kế thừa ConsoleMenu
    class PTBac2Console : ConsoleMenu
    {
        public void GiaiPhuongTrinh()
        {
            double a, b, c;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem x = " + x);
                }
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
        public void GioiThieu()
        {
            Console.WriteLine("Chuong trinh giai phuong trinh bac 2.");
        }
        public void XuLy(int x)
        {
            if (x == 1)
                GiaiPhuongTrinh();
            else if (x == 2)
                GioiThieu();
        }
        public static void Bai3_4()
        {
            PTBac2Console app = new PTBac2Console();
            // Đăng ký các chức năng vào event Choose
            app.Choose += app.XuLy;
            app.Run();
        }
    }
}