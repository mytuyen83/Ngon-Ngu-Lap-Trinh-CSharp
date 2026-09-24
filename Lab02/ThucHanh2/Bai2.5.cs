using System;
namespace Lab02.ThucHanh2
{
    class DaThuc
    {
        // Field: lưu các hệ số của đa thức
        private double[] a;
        // Default Constructor: tạo đa thức rỗng
        public DaThuc()
        {
            a = new double[0];
        }
        // Constructor có tham số: tạo đa thức bậc n
        public DaThuc(int n)
        {
            a = new double[n + 1];
        }
        // Copy Constructor: sao chép một đa thức
        public DaThuc(DaThuc p)
        {
            a = new double[p.a.Length];
            for (int i = 0; i < p.a.Length; i++)
                a[i] = p.a[i];
        }
        // Indexer: truy cập hệ số thứ i
        public double this[int i]
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
        // Nhập đa thức
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap he so a" + i + ": ");
                a[i] = double.Parse(Console.ReadLine());
            }
        }
        // Xuất đa thức
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0 && a[i] >= 0)
                    Console.Write("+");
                if (i == 0)
                    Console.Write(a[i]);
                else if (i == 1)
                    Console.Write(a[i] + "x");
                else
                    Console.Write(a[i] + "x^" + i);
            }
            Console.WriteLine();
        }

        // Tính giá trị đa thức tại x
        public double TinhGiaTri(double x)
        {
            double kq = 0;
            for (int i = 0; i < a.Length; i++)
                kq += a[i] * Math.Pow(x, i);
            return kq;
        }

        public static void Bai2_5()
        {
            Console.Write("Nhap bac cua da thuc n: ");
            int n = int.Parse(Console.ReadLine());
            DaThuc p = new DaThuc(n);
            Console.WriteLine("Nhap da thuc:");
            p.Input();
            Console.WriteLine();
            Console.Write("Da thuc P(x) = ");
            p.Output();
            Console.Write("Nhap gia tri x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("P(" + x + ") = " + p.TinhGiaTri(x));
        }
    }
}