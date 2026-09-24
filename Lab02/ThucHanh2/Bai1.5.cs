using System;
namespace Lab02.ThucHanh2
{
    class DonThuc
    {
        // Field: a là hệ số, n là số mũ
        private double a;
        private int n;

        // Default Constructor: tạo đơn thức có hệ số và số mũ bằng 0
        public DonThuc()
        {
            a = 0;
            n = 0;
        }

        // Constructor có tham số: khởi tạo đơn thức từ a và n
        public DonThuc(double a, int n)
        {
            this.a = a;
            this.n = n;
        }

        // Tính giá trị đơn thức P(x) = a.x^n
        public double TinhGiaTri(double x)
        {
            return a * Math.Pow(x, n);
        }

        // Tính đạo hàm của đơn thức
        public DonThuc DaoHam()
        {
            if (n == 0)
                return new DonThuc(0, 0);

            return new DonThuc(a * n, n - 1);
        }

        // Xuất đơn thức dưới dạng chuỗi
        public override string ToString()
        {
            if (n == 0)
                return a.ToString();

            if (n == 1)
                return a + "x";

            return a + "x^" + n;
        }

        public static void Bai1_5()
        {
            double a;
            int n;
            double x;

            Console.Write("Nhap he so a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so mu n: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Nhap gia tri x: ");
            x = double.Parse(Console.ReadLine());

            DonThuc P = new DonThuc(a, n);

            Console.WriteLine();
            Console.WriteLine("Don thuc P(x) = " + P);
            Console.WriteLine("Gia tri P(" + x + ") = " + P.TinhGiaTri(x));

            DonThuc Q = P.DaoHam();
            Console.WriteLine("Dao ham P'(x) = " + Q);
            Console.WriteLine("Gia tri P'(" + x + ") = " + Q.TinhGiaTri(x));
        }
    }
}