using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class MangSo
    {
        public static void Bai2_1()
        {
            // đề cho
            int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
            Console.WriteLine("Mang goc: " + string.Join(", ", mangSo));

            // a. Lấy các số chia hết cho cả 4 và 3
            // Cách 1 - Query Syntax: dùng từ khóa from, where, select
            var a1 = from x in mangSo
                     where x % 4 == 0 && x % 3 == 0
                     select x;
            // Cách 2 - Method Syntax: gọi hàm Where, điều kiện viết bằng lambda
            var a2 = mangSo.Where(x => x % 4 == 0 && x % 3 == 0);
            Console.WriteLine("a. Chia het cho 4 va 3 (Query Syntax): " + string.Join(", ", a1));
            Console.WriteLine("a. Chia het cho 4 va 3 (Method Syntax): " + string.Join(", ", a2));

            // b. Lấy các số nhỏ hơn hoặc bằng 3
            var b1 = from x in mangSo
                     where x <= 3
                     select x;
            var b2 = mangSo.Where(x => x <= 3);
            Console.WriteLine("b. Nho hon hoac bang 3 (Query Syntax): " + string.Join(", ", b1));
            Console.WriteLine("b. Nho hon hoac bang 3 (Method Syntax): " + string.Join(", ", b2));

            // c. Tạo dãy mới: số chẵn thì chia đôi, số lẻ thì giữ nguyên
            // Dùng select để biến đổi từng phần tử thành giá trị khác
            var c1 = from x in mangSo
                     select x % 2 == 0 ? x / 2 : x;
            var c2 = mangSo.Select(x => x % 2 == 0 ? x / 2 : x);
            Console.WriteLine("c. Day moi (Query Syntax): " + string.Join(", ", c1));
            Console.WriteLine("c. Day moi (Method Syntax): " + string.Join(", ", c2));
        }
    }
}