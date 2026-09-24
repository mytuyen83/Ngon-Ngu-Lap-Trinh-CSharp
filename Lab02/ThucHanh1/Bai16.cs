using System;

namespace Lab02.ThucHanh1
{
    class SapXepHoTen
    {
        // Nhập mảng họ tên
        public static void NhapMang(string[] Mang)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write("Nhap ho ten thu " + (i + 1) + ": ");
                Mang[i] = Console.ReadLine();
            }
        }

        // In mảng họ tên
        public static void XuatMang(string[] Mang)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.WriteLine(Mang[i]);
            }
        }

        // Sắp xếp mảng họ tên tăng dần
        public static void SapXep(string[] Mang)
        {
            for (int i = 0; i < Mang.Length - 1; i++)
            {
                for (int j = i + 1; j < Mang.Length; j++)
                {
                    if (string.Compare(Mang[i], Mang[j]) > 0)
                    {
                        string Tam = Mang[i];
                        Mang[i] = Mang[j];
                        Mang[j] = Tam;
                    }
                }
            }
        }

        public static void Bai16()
        {
            int N;
            string[] Mang;

            // Nhập số lượng người
            Console.Write("Nhap so luong nguoi: ");
            N = int.Parse(Console.ReadLine());

            Mang = new string[N];

            // Nhập và xuất mảng
            NhapMang(Mang);

            // Sắp xếp mảng
            SapXep(Mang);

            // Xuất kết quả
            Console.WriteLine();
            Console.WriteLine("Danh sach sau khi sap xep:");
            XuatMang(Mang);
        }
    }
}