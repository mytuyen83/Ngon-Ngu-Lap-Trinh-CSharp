using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class ThongKeMangSo
    {
        public static void Bai3_1()
        {
            // đề cho
            int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
            Console.WriteLine("Mang goc: " + string.Join(", ", mangSo));

            // a. Đếm phần tử
            int tongPhanTu = mangSo.Count(); //đếm tất cả
            int soChan = mangSo.Count(x => x % 2 == 0); //đếm các số chẵn
            int soLe = mangSo.Count(x => x % 2 != 0); //đếm các số lẻ
            Console.WriteLine("a. Tong so phan tu: " + tongPhanTu);
            Console.WriteLine("a. So phan tu chan: " + soChan);
            Console.WriteLine("a. So phan tu le: " + soLe);

            // b. Tính tổng, lớn nhất, nhỏ nhất
            Console.WriteLine("b. Tong cac gia tri: " + mangSo.Sum());
            Console.WriteLine("b. Gia tri lon nhat: " + mangSo.Max());
            Console.WriteLine("b. Gia tri nho nhat: " + mangSo.Min());

            // c. Các giá trị khác nhau trong mảng
            Console.WriteLine("c. So gia tri khac nhau: " + mangSo.Distinct().Count()); // Distinct() bỏ qua các giá trị trùng nhau

            // d. Chia các số thành nhóm theo số dư khi chia cho 5
            var nhom = from x in mangSo
                       group x by x % 5 into g
                       orderby g.Key
                       select g;
            Console.WriteLine("d. Phan nhom theo so du khi chia cho 5:");
            foreach (var g in nhom)
                Console.WriteLine("   Du " + g.Key + ": " + string.Join(", ", g));
        }
    }
}