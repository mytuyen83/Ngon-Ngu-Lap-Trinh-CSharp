using System;

namespace Lab02.ThucHanh1
{
    class KiemTraChuoiDoiXung
    {
        // Kiểm tra chuỗi có đối xứng hay không
        public static bool LaChuoiDoiXung(string Chuoi)
        {
            int Dau = 0;
            int Cuoi = Chuoi.Length - 1;

            while (Dau < Cuoi)
            {
                if (Chuoi[Dau] != Chuoi[Cuoi])
                {
                    return false;
                }

                Dau++;
                Cuoi--;
            }

            return true;
        }

        public static void Bai10()
        {
            string Chuoi;

            // Nhập dữ liệu
            Console.Write("Nhap chuoi: ");
            Chuoi = Console.ReadLine();

            // Kiểm tra và xuất kết quả
            if (LaChuoiDoiXung(Chuoi))
            {
                Console.WriteLine("Chuoi doi xung");
            }
            else
            {
                Console.WriteLine("Chuoi khong doi xung");
            }
        }
    }
}