using System;

namespace Lab02.ThucHanh1
{
    class TimGiaTriLonNhoNhat
    {
        // Tìm giá trị lớn nhất và nhỏ nhất
        public static void TimMaxMin(double So1, double So2, double So3,
                                     out double Max, out double Min)
        {
            Max = So1;
            Min = So1;

            if (So2 > Max)
            {
                Max = So2;
            }

            if (So3 > Max)
            {
                Max = So3;
            }

            if (So2 < Min)
            {
                Min = So2;
            }

            if (So3 < Min)
            {
                Min = So3;
            }
        }

        public static void Bai9()
        {
            double So1, So2, So3;
            double Max, Min;

            // Nhập dữ liệu
            Console.Write("Nhap so thu nhat: ");
            So1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            So2 = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            So3 = double.Parse(Console.ReadLine());

            // Gọi phương thức tìm Max và Min
            TimMaxMin(So1, So2, So3, out Max, out Min);

            // Xuất kết quả
            Console.WriteLine("Gia tri lon nhat: " + Max);
            Console.WriteLine("Gia tri nho nhat: " + Min);
        }
    }
}