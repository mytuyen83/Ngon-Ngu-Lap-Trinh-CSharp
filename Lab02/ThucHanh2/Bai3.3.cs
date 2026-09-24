using System;
namespace Lab02.ThucHanh2
{
    delegate int SoSanh<T>(T x, T y);
    class SapXepDelegate
    {
        // Sắp xếp mảng tổng quát bằng delegate
        public static void Sort<T>(T[] a, SoSanh<T> ss)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (ss(a[i], a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        // Hàm so sánh hai số nguyên
        public static int SoSanhSoNguyen(int x, int y)
        {
            return x.CompareTo(y);
        }
        public static void Bai3_3()
        {
            int[] a = { 7, 2, 1, 4, 9, 2, 15, 6, 8 };
            Console.WriteLine("Mang truoc khi sap xep:");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Sort(a, SoSanhSoNguyen);
            Console.WriteLine();
            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}