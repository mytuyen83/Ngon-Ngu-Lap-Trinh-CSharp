using System;
namespace Lab02.ThucHanh2
{
    class MangHaiChieu
    {
        // Field: lưu mảng 2 chiều
        private int[,] a;
        // Default Constructor: tạo mảng rỗng
        public MangHaiChieu()
        {
            a = new int[0, 0];
        }
        // Constructor có tham số: tạo mảng n dòng, m cột
        public MangHaiChieu(int n, int m)
        {
            a = new int[n, m];
        }
        // Copy Constructor: sao chép một mảng 2 chiều
        public MangHaiChieu(MangHaiChieu b)
        {
            int n = b.a.GetLength(0);
            int m = b.a.GetLength(1);
            a = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = b.a[i, j];
        }
        // Indexer: truy cập phần tử tại dòng i, cột j
        public int this[int i, int j]
        {
            get
            {
                return a[i, j];
            }
            set
            {
                a[i, j] = value;
            }
        }

        // Nhập mảng
        public void Input()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("Nhap a[" + i + "," + j + "]: ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Xuất mảng
        public void Output()
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + "\t");

                Console.WriteLine();
            }
        }

        // Kiểm tra một số có phải số nguyên tố hay không
        private bool LaSoNguyenTo(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        // Tìm và xuất các số nguyên tố trong mảng
        public void TimSoNguyenTo()
        {
            Console.Write("Cac so nguyen to: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (LaSoNguyenTo(a[i, j]))
                        Console.Write(a[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void Bai2_4()
        {
            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            MangHaiChieu a = new MangHaiChieu(n, m);
            Console.WriteLine("Nhap mang:");
            a.Input();
            Console.WriteLine();
            Console.WriteLine("Mang 2 chieu:");
            a.Output();
            a.TimSoNguyenTo();
        }
    }
}