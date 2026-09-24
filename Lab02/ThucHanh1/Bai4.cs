using System;

namespace Lab02.ThucHanh1
{
    class KTSoNguyen
    {
        public static void Bai4()
        {
            //Khai báo biến
            int x, y;
            int kq = 1;
            string chuoi;

            //Nhập dữ liệu
            Console.Write("Nhap so nguyen x: ");
            chuoi = Console.ReadLine();
            if (!int.TryParse(chuoi, out x)) //Kiểm tra xem x có phải là số nguyên hay không
            {
                Console.WriteLine("x khong phai la so nguyen!");
                return;
            }

            Console.Write("Nhap so nguyen y: ");
            chuoi = Console.ReadLine();
            if (!int.TryParse(chuoi, out y)) //Kiểm tra xem y có phải là số nguyên hay không
            {
                Console.WriteLine("y khong phai la so nguyen!");
                return;
            }

            //nếu x, y đều là số nguyên thì tính x^y
            for (int i = 1; i <= y; i++)
            {
                kq = kq * x;
            }

            //xuất dữ liệu
            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + kq);
        }
    }
}