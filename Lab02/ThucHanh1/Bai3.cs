using System;
namespace Lab02.ThucHanh1
{
    class LuyThua
    {
        public static void Bai3()
        {
            //Khai báo biến
            int x, y;
            int kq = 1;

            //Nhập dữ liệu
            Console.Write("Nhap so nguyen x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            y = int.Parse(Console.ReadLine());

            //Tính x^y
            for (int i = 1; i <= y; i++)
            {
                kq = kq * x;
            }
            
            //Xuất dữ liệu
            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + kq);
        }
    }
}