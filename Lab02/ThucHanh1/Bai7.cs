using System;

namespace Lab02.ThucHanh1
{
    class KiemTraSoNguyenTo
    {
        // Kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int N)
        {
            if (N < 2)
            {
                return false;
            }

            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Bai7()
        {
            int N;

            // Nhập dữ liệu
            Console.Write("Nhap N: ");
            N = int.Parse(Console.ReadLine());

            // Kiểm tra và xuất kết quả
            if (LaSoNguyenTo(N))
            {
                Console.WriteLine(N + " la so nguyen to");
            }
            else
            {
                Console.WriteLine(N + " khong phai la so nguyen to");
            }
        }
    }
}