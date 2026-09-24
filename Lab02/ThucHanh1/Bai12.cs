using System;

namespace Lab02.ThucHanh1
{
    class XuLyChuoi
    {
        // Đếm số từ trong chuỗi
        public static int DemSoTu(string Chuoi)
        {
            string[] Tu = Chuoi.Split(
                new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            return Tu.Length;
        }

        public static void Bai12()
        {
            string Chuoi;
            int SoTu;

            // Nhập dữ liệu
            Console.Write("Nhap chuoi: ");
            Chuoi = Console.ReadLine();

            // Chuyển chuỗi thành chữ thường và chữ hoa
            Console.WriteLine("Chuoi chu thuong: " + Chuoi.ToLower());
            Console.WriteLine("Chuoi chu hoa: " + Chuoi.ToUpper());

            // Đếm số từ
            SoTu = DemSoTu(Chuoi);

            // Xuất kết quả
            Console.WriteLine("So tu trong chuoi: " + SoTu);
        }
    }
}