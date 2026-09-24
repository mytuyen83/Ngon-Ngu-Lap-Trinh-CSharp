using System;

namespace Lab02.ThucHanh1
{
    class DaoChuoi
    {
        // Đảo chuỗi
        public static string Dao(string Chuoi)
        {
            string Kq = "";

            for (int i = Chuoi.Length - 1; i >= 0; i--)
            {
                Kq = Kq + Chuoi[i];
            }

            return Kq;
        }

        public static void Bai11()
        {
            string Chuoi;
            string Kq;

            // Nhập dữ liệu
            Console.Write("Nhap chuoi: ");
            Chuoi = Console.ReadLine();

            // Gọi phương thức đảo chuỗi
            Kq = Dao(Chuoi);

            // Xuất kết quả
            Console.WriteLine("Chuoi dao: " + Kq);
        }
    }
}