using System;
namespace Lab02.ThucHanh1
{
    class MenuTinhToan
    {
        public static void Bai5()
        {
            double x = 0, y = 0;
            int chon;
            int nhap = 0; //ktra xem da nhap x, y chua

            do
            {
                Console.WriteLine();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: //nhập x, y
                        Console.Write("Nhap x: ");
                        x = double.Parse(Console.ReadLine());

                        Console.Write("Nhap y: ");
                        y = double.Parse(Console.ReadLine());

                        nhap = 1;
                        break;

                    case 2:
                        if (nhap == 0) //kiểm tra xem đã nhập x, y chưa
                        {
                            Console.WriteLine("Chon 1 de nhap x, y truoc!");
                        }
                        else
                        {
                            Console.WriteLine("Ket qua " + x + " mu " + y + " la: " + Math.Pow(x, y)); //tính x^y
                        }
                        break;

                    case 3:
                        if (nhap == 0) //kiểm tra xem đã nhập x, y chưa
                        {
                            Console.WriteLine("Chon 1 de nhap x, y truoc!");
                        }
                        else if (x < 0 || y < 0) //không thể tính căn bậc 2 của số âm
                        {
                            Console.WriteLine("Khong the tinh can bac 2 cua so am!");
                        }
                        else
                        {
                            Console.WriteLine("Can bac 2 cua x = " + Math.Sqrt(x)); //tính căn bậc 2 của x
                            Console.WriteLine("Can bac 2 cua y = " + Math.Sqrt(y)); //tính căn bậc 2 của y
                        }
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Chuc nang khong hop le!");
                        break;
                }

            } while (chon != 4);
        }
    }
}