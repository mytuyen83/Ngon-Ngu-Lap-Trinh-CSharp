using System;

namespace Lab02.ThucHanh1
{
    class TimGiaTriLonNhat
    {
        // Phuong thuc tim gia tri lon nhat cua ba so nguyen
        public static int TimMax(int So1, int So2, int So3)
        {
            int Max = So1;
            if (So2 > Max)
            {
                Max = So2;
            }
            if (So3 > Max)
            {
                Max = So3;
            }
            return Max;
        }

        public static void Bai6()
        {
            int So1, So2, So3;
            int kq;

            // Nhap du lieu
            Console.Write("Nhap so thu nhat: ");
            So1 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            So2 = int.Parse(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            So3 = int.Parse(Console.ReadLine());

            // Goi phuong thuc va nhan gia tri tra ve
            kq = TimMax(So1, So2, So3);

            // Xuat ket qua
            Console.WriteLine("Gia tri lon nhat: " + kq);
        }
    }
}