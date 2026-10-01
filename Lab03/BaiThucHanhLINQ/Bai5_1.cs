using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class TruyVanMonHoc
    {
        public static void Bai5_1()
        {
            var ds = DuLieu.DS_Mon();

            // a. Lấy tên các môn bắt đầu bằng "Lập trình"
            var a = from m in ds
                    where m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)
                    select m.TenMon; // lấy tên môn
            // Method Syntax
            Console.WriteLine("a. Cac mon bat dau bang \"Lap trinh\":");
            foreach (var item in a)
                Console.WriteLine("   " + item);

            // b. Các môn hệ CD: số tiết giảm dần, mã môn tăng dần
            var b = ds.Where(m => m.He == "CD")
                      .OrderByDescending(m => m.SoTiet) // xếp theo tiêu chí chính: số tiết giảm dần
                      .ThenBy(m => m.MaMon); // xếp theo tiêu chí phụ: mã môn tăng dần
            // Query Syntax
            Console.WriteLine("b. Cac mon he CD (so tiet giam dan, ma mon tang dan):");
            foreach (var item in b)
                Console.WriteLine("   " + item);

            // c. Các môn có tên chứa chữ "web", chỉ lấy Tên môn và Hệ
            var c = from m in ds
                    where m.TenMon.IndexOf("web", StringComparison.OrdinalIgnoreCase) >= 0 // tìm tên môn có chứa "web", không phân biệt hoa thường
                    select new { m.TenMon, m.He }; // lấy 2 cột tên môn và hệ
            Console.WriteLine("c. Cac mon co ten chua \"web\" (Ten mon, He):");
            foreach (var item in c)
                Console.WriteLine("   " + item.TenMon + " | " + item.He);

            // d. Các môn hệ KTV, xếp theo mã môn tăng dần
            var d = ds.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
            Console.WriteLine("d. Cac mon he KTV (ma mon tang dan):");
            foreach (var item in d)
                Console.WriteLine("   " + item);
        }
    }
}