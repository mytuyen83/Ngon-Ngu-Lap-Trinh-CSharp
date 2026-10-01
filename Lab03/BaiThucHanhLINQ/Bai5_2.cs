using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class ThongKeMonHoc
    {
        private static string TenHe(string he)
        {
            return he == "" ? "(chua co he)" : he; // môn nào chưa có hệ thì in ra "(chua co he)"
        }

        public static void Bai5_2()
        {
            var ds = DuLieu.DS_Mon();

            // a. Tổng số môn
            Console.WriteLine("a. Tong so mon: " + ds.Count());

            // b. Đếm số môn bắt đầu bằng "Lập trình"
            Console.WriteLine("b. So mon bat dau bang \"Lap trinh\": "
                + ds.Count(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)));

            // c. Tổng số tiết của hệ Kỹ thuật viên (KTV)
            int tongTietKTV = ds.Where(m => m.He == "KTV").Sum(m => (int)m.SoTiet); // ép sang int để cộng
            Console.WriteLine("c. Tong so tiet he KTV: " + tongTietKTV);

            // d. Tổng số môn mỗi hệ
            var d = from m in ds
                    group m by m.He into g // gom các môn cùng hệ vào 1 nhóm rồi đếm
                    select new { He = g.Key, TongMon = g.Count() };
            Console.WriteLine("d. Tong so mon cua moi he:");
            foreach (var item in d)
                Console.WriteLine("   " + TenHe(item.He) + ": " + item.TongMon);

            // e. Nhóm theo số tiết, đếm số môn mỗi nhóm, xếp số tiết giảm dần
            var e = from m in ds
                    group m by m.SoTiet into g
                    orderby g.Key descending
                    select new { SoTiet = g.Key, TongMon = g.Count() };
            Console.WriteLine("e. Nhom theo so tiet (giam dan):");
            foreach (var item in e)
                Console.WriteLine("   So tiet " + item.SoTiet + ": " + item.TongMon + " mon");

            // f. Môn có số tiết cao nhất
            // Tìm số tiết lớn nhất, rồi lọc các môn có số tiết đó
            int maxTiet = ds.Max(m => (int)m.SoTiet);
            var f = ds.Where(m => m.SoTiet == maxTiet);
            Console.WriteLine("f. Mon co so tiet cao nhat:");
            foreach (var item in f)
                Console.WriteLine("   " + item);

            // g. Thống kê theo từng hệ: tổng số môn, tổng số tiết, số tiết cao nhất, thấp nhất
            var g2 = from m in ds
                     group m by m.He into g
                     select new
                     {
                         He = g.Key,
                         TongMon = g.Count(),
                         TongTiet = g.Sum(x => (int)x.SoTiet),
                         CaoNhat = g.Max(x => (int)x.SoTiet),
                         ThapNhat = g.Min(x => (int)x.SoTiet)
                     };
            Console.WriteLine("g. Thong ke theo he:");
            foreach (var item in g2)
                Console.WriteLine("   " + TenHe(item.He) + ": " + item.TongMon + " mon, tong "
                    + item.TongTiet + " tiet, cao nhat " + item.CaoNhat + ", thap nhat " + item.ThapNhat);

            // h. Liệt kê các môn, gom theo hệ
            // Dùng 2 vòng foreach: vòng ngoài duyệt từng nhóm (hệ), vòng trong duyệt từng môn của nhóm
            var h = from m in ds
                    group m by m.He into g
                    select g;
            Console.WriteLine("h. Cac mon phan nhom theo he:");
            foreach (var nhom in h)
            {
                Console.WriteLine("   He " + TenHe(nhom.Key) + ":");
                foreach (var m in nhom)
                    Console.WriteLine("      " + m);
            }

            // i. Liệt kê các môn, gom theo số tiết, nhóm nào số tiết nhỏ thì in trước
            var i = ds.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
            Console.WriteLine("i. Cac mon phan nhom theo so tiet (tang dan):");
            foreach (var nhom in i)
            {
                Console.WriteLine("   So tiet " + nhom.Key + ":");
                foreach (var m in nhom)
                    Console.WriteLine("      " + m);
            }

            // j. Hệ KTV, chia theo học phần HP2, HP3, HP4, HP5
            var j = from m in ds
                    where m.He == "KTV"
                    group m by m.MaMon.Substring(0, 3) into g
                    orderby g.Key
                    select g;
            Console.WriteLine("j. He KTV phan nhom theo hoc phan:");
            foreach (var nhom in j)
            {
                Console.WriteLine("   Hoc phan " + nhom.Key + ":");
                foreach (var m in nhom.OrderBy(x => x.MaMon))
                    Console.WriteLine("      " + m);
            }

            // k. Gom theo hệ, nhưng chỉ lấy môn có số tiết > 40, trong mỗi nhóm xếp theo mã môn
            var k = ds.Where(m => m.SoTiet > 40).GroupBy(m => m.He);
            Console.WriteLine("k. Phan nhom theo he (so tiet > 40):");
            foreach (var nhom in k)
            {
                Console.WriteLine("   He " + TenHe(nhom.Key) + ":");
                foreach (var m in nhom.OrderBy(x => x.MaMon))
                    Console.WriteLine("      " + m);
            }
        }
    }
}