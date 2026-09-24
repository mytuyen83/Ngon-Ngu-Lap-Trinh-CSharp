using System;

namespace Lab02.ThucHanh1
{
    class XuLyMangHaiChieu
    {
        // Sinh ngẫu nhiên mảng
        public static void SinhMang(int[,] Mang)
        {
            Random NgauNhien = new Random();

            for (int i = 0; i < Mang.GetLength(0); i++)
            {
                for (int j = 0; j < Mang.GetLength(1); j++)
                {
                    Mang[i, j] = NgauNhien.Next(10, 101);
                }
            }
        }

        // In mảng
        public static void XuatMang(int[,] Mang)
        {
            for (int i = 0; i < Mang.GetLength(0); i++)
            {
                for (int j = 0; j < Mang.GetLength(1); j++)
                {
                    Console.Write(Mang[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        // Trả về mảng số chẵn và số lẻ
        public static void TachMang(int[,] Mang, out int[] MangChan, out int[] MangLe)
        {
            int SoLuongChan = 0;
            int SoLuongLe = 0;

            for (int i = 0; i < Mang.GetLength(0); i++)
            {
                for (int j = 0; j < Mang.GetLength(1); j++)
                {
                    if (Mang[i, j] % 2 == 0)
                    {
                        SoLuongChan++;
                    }
                    else
                    {
                        SoLuongLe++;
                    }
                }
            }

            MangChan = new int[SoLuongChan];
            MangLe = new int[SoLuongLe];

            int ViTriChan = 0;
            int ViTriLe = 0;

            for (int i = 0; i < Mang.GetLength(0); i++)
            {
                for (int j = 0; j < Mang.GetLength(1); j++)
                {
                    if (Mang[i, j] % 2 == 0)
                    {
                        MangChan[ViTriChan] = Mang[i, j];
                        ViTriChan++;
                    }
                    else
                    {
                        MangLe[ViTriLe] = Mang[i, j];
                        ViTriLe++;
                    }
                }
            }
        }

        // In mảng một chiều
        public static void XuatMangMotChieu(int[] Mang)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write(Mang[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Bai17()
        {
            int N, M;
            int[,] Mang;
            int[] MangChan;
            int[] MangLe;

            // Nhập kích thước mảng
            Console.Write("Nhap so dong N: ");
            N = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot M: ");
            M = int.Parse(Console.ReadLine());

            Mang = new int[N, M];

            // Sinh và xuất mảng
            SinhMang(Mang);

            Console.WriteLine("Mang:");
            XuatMang(Mang);

            // Tách mảng số chẵn và số lẻ
            TachMang(Mang, out MangChan, out MangLe);

            Console.Write("Mang cac so chan: ");
            XuatMangMotChieu(MangChan);

            Console.Write("Mang cac so le: ");
            XuatMangMotChieu(MangLe);
        }
    }
}