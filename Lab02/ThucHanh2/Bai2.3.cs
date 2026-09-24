using System;
namespace Lab02.ThucHanh2
{
    class DaySo
    {
        // Field: lưu dãy số nguyên
        private int[] a;
        // Default Constructor: tạo dãy rỗng
        public DaySo()
        {
            a = new int[0];
        }
        // Constructor có tham số: tạo dãy có n phần tử
        public DaySo(int n)
        {
            a = new int[n];
        }
        // Copy Constructor: sao chép một dãy số
        public DaySo(DaySo ds)
        {
            a = new int[ds.a.Length];
            for (int i = 0; i < ds.a.Length; i++)
                a[i] = ds.a[i];
        }
        // Indexer: truy cập phần tử thứ i
        public int this[int i]
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

        // Nhập dãy số
        public void Input()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Nhap a[" + i + "]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Xuất dãy số
        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }

        // Tìm và xuất các số chẵn
        public void TimSoChan()
        {
            Console.Write("Cac so chan: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Bai2_3()
        {
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());
            DaySo ds = new DaySo(n);
            Console.WriteLine("Nhap day so:");
            ds.Input();
            Console.WriteLine();
            Console.Write("Day so: ");
            ds.Output();
            ds.TimSoChan();
        }
    }
}