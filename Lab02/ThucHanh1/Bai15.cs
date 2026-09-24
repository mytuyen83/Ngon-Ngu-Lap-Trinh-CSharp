using System;

namespace Lab02.ThucHanh1
{
    class XuLyMangSoNguyen
    {
        // Nhập mảng
        public static void NhapMang(int[] Mang)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                Mang[i] = int.Parse(Console.ReadLine());
            }
        }

        // In mảng
        public static void XuatMang(int[] Mang)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Console.Write(Mang[i] + " ");
            }

            Console.WriteLine();
        }

        // Tìm phần tử lớn nhất và nhỏ nhất
        public static void TimMaxMin(int[] Mang, out int Max, out int Min)
        {
            Max = Mang[0];
            Min = Mang[0];

            for (int i = 1; i < Mang.Length; i++)
            {
                if (Mang[i] > Max)
                {
                    Max = Mang[i];
                }

                if (Mang[i] < Min)
                {
                    Min = Mang[i];
                }
            }
        }

        // Kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int So)
        {
            if (So < 2)
            {
                return false;
            }

            for (int i = 2; i < So; i++)
            {
                if (So % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Trả về mảng các số nguyên tố
        public static int[] LayMangNguyenTo(int[] Mang)
        {
            int SoLuong = 0;

            for (int i = 0; i < Mang.Length; i++)
            {
                if (LaSoNguyenTo(Mang[i]))
                {
                    SoLuong++;
                }
            }

            int[] MangNguyenTo = new int[SoLuong];
            int ViTri = 0;

            for (int i = 0; i < Mang.Length; i++)
            {
                if (LaSoNguyenTo(Mang[i]))
                {
                    MangNguyenTo[ViTri] = Mang[i];
                    ViTri++;
                }
            }

            return MangNguyenTo;
        }

        public static void Bai15()
        {
            int N;
            int[] Mang;
            int Max, Min;
            int[] MangNguyenTo;

            // Nhập số lượng phần tử
            Console.Write("Nhap so luong phan tu: ");
            N = int.Parse(Console.ReadLine());

            Mang = new int[N];

            // Nhập và xuất mảng
            NhapMang(Mang);

            Console.Write("Mang vua nhap: ");
            XuatMang(Mang);

            // Tìm giá trị lớn nhất và nhỏ nhất
            TimMaxMin(Mang, out Max, out Min);

            Console.WriteLine("Phan tu lon nhat: " + Max);
            Console.WriteLine("Phan tu nho nhat: " + Min);

            // Lấy mảng số nguyên tố
            MangNguyenTo = LayMangNguyenTo(Mang);

            Console.Write("Mang cac so nguyen to: ");
            XuatMang(MangNguyenTo);
        }
    }
}