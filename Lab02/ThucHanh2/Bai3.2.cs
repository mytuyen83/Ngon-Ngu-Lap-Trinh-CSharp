using System;
namespace Lab02.ThucHanh2
{
    interface ISoSanh<T>
    {
        int SoSanh(T x);
    }
    class SoNguyen : ISoSanh<SoNguyen>
    {
        private int GiaTri;
        public SoNguyen(int GiaTri)
        {
            this.GiaTri = GiaTri;
        }
        public int SoSanh(SoNguyen x)
        {
            return GiaTri.CompareTo(x.GiaTri);
        }
        public void Output()
        {
            Console.Write(GiaTri + " ");
        }
    }
    class SapXep
    {
        // Sắp xếp mảng tổng quát bằng interface
        public static void Sort<T>(T[] a) where T : ISoSanh<T>
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i].SoSanh(a[j]) > 0)
                    {
                        T temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
        public static void Bai3_2()
        {
            SoNguyen[] a =
            {
                new SoNguyen(5),
                new SoNguyen(2),
                new SoNguyen(8),
                new SoNguyen(1),
                new SoNguyen(3)
            };
            Console.WriteLine("Mang truoc khi sap xep:");
            for (int i = 0; i < a.Length; i++)
                a[i].Output();
            Sort(a);
            Console.WriteLine();
            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < a.Length; i++)
                a[i].Output();
            Console.WriteLine();
        }
    }
}