using System;

namespace Lab02.ThucHanh1
{
    class HoanViHaiSo
    {
        // Hoán vị hai số thực
        public static void HoanVi(ref double So1, ref double So2)
        {
            double Tam;

            Tam = So1;
            So1 = So2;
            So2 = Tam;
        }

        public static void Bai8()
        {
            double So1, So2;

            // Nhập dữ liệu
            Console.Write("Nhap so thu nhat: ");
            So1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            So2 = double.Parse(Console.ReadLine());

            // Gọi phương thức hoán vị
            HoanVi(ref So1, ref So2);

            // Xuất kết quả
            Console.WriteLine("Sau khi hoan vi:");
            Console.WriteLine("So thu nhat: " + So1);
            Console.WriteLine("So thu hai: " + So2);
        }
    }
}