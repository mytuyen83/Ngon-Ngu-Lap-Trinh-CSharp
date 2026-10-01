using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class JoinHaiNguon
    {
        // Hai danh sách này liên kết với nhau qua He.MaHe == MonHoc.He
        public static void Bai6_2()
        {
            var dsMon = DuLieu.DS_Mon();
            var dsHe = DuLieu.DS_He();

            // a. dùng join để liệt kê
            var a = from h in dsHe
                    join m in dsMon on h.MaHe equals m.He
                    select new { h.TenHe, m.MaMon, m.TenMon };
            Console.WriteLine("a. Join (Ten he | Ma mon | Ten mon):");
            foreach (var item in a)
                Console.WriteLine("   " + item.TenHe + " | " + item.MaMon + " | " + item.TenMon);

            // b. Liệt kệ những hệ chưa có môn nào
            var b = from h in dsHe
                    join mon in dsMon on h.MaHe equals mon.He into nhom
                    from m in nhom.DefaultIfEmpty()
                    select new
                    {
                        h.TenHe,
                        MaMon = m == null ? "-" : m.MaMon,
                        TenMon = m == null ? "-" : m.TenMon
                    };
            Console.WriteLine("b. Left outer join (ke ca he chua co mon):");
            foreach (var item in b)
                Console.WriteLine("   " + item.TenHe + " | " + item.MaMon + " | " + item.TenMon);

            // c. Liệt kê cả hệ chưa có môn và môn chưa có hệ
            // sử dụng kết quả câu b 
            var monMoCoi = from m in dsMon
                           where !dsHe.Any(h => h.MaHe == m.He)
                           select new { TenHe = "(chua khai bao he)", m.MaMon, m.TenMon };
            var c = b.Concat(monMoCoi); // nối 2 danh sách hệ chưa có môn và môn chưa có hệ với nhau
            Console.WriteLine("c. Ca he chua co mon va mon chua khai bao he:");
            foreach (var item in c)
                Console.WriteLine("   " + item.TenHe + " | " + item.MaMon + " | " + item.TenMon);

            // d. Chỉ liệt kê hệ chưa có môn và môn chưa có hệ
            var heChuaCoMon = from h in dsHe
                              where !dsMon.Any(m => m.He == h.MaHe) 
                              select new { h.TenHe, MaMon = "-", TenMon = "-" };
            var d = heChuaCoMon.Concat(monMoCoi);
            Console.WriteLine("d. Chi he chua co mon va mon chua khai bao he:");
            foreach (var item in d)
                Console.WriteLine("   " + item.TenHe + " | " + item.MaMon + " | " + item.TenMon);

            // e. Lấy 5 môn đầu tiên có số tiết giảm dần
            var e = (from h in dsHe
                     join m in dsMon on h.MaHe equals m.He
                     orderby m.SoTiet descending, m.MaMon
                     select new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet }).Take(5); // lấy 5 phần tử đầu tiên
            Console.WriteLine("e. 5 mon co so tiet cao nhat (Ten he | Ma mon | Ten mon | So tiet):");
            foreach (var item in e)
                Console.WriteLine("   " + item.TenHe + " | " + item.MaMon + " | " + item.TenMon + " | " + item.SoTiet);

            // f. Tổng số môn của mỗi hệ
            var f = from h in dsHe
                    join m in dsMon on h.MaHe equals m.He into nhom
                    select new { h.MaHe, h.TenHe, TongMon = nhom.Count() };
            Console.WriteLine("f. Tong so mon moi he (Ma he | Ten he | Tong so mon):");
            foreach (var item in f)
                Console.WriteLine("   " + item.MaHe + " | " + item.TenHe + " | " + item.TongMon);

            // g. Có bao nhiêu loại số tiết khác nhau
            var cacSoTiet = dsMon.Select(m => m.SoTiet).Distinct().OrderBy(x => x).ToList();
            Console.WriteLine("g. So loai so tiet khac nhau: " + cacSoTiet.Count
                + " (" + string.Join(", ", cacSoTiet) + ")");

            // h. Tìm môn đầu tiên có tên bắt đầu bằng "Lập trình"
            var h1 = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình", StringComparison.OrdinalIgnoreCase)); // FirstOrDefault() trả về null nếu không tìm thấy
            Console.WriteLine("h. Mon dau tien bat dau bang \"Lap trinh\": " + (h1 == null ? "(khong co)" : h1.ToString())); // kiểm tra null trước khi in ra

            // i. Liệt kê môn theo từng hệ, và đánh số thứ tự trong mỗi hệ
            var i = dsMon.GroupBy(m => m.He);
            Console.WriteLine("i. Cac mon theo tung he (co so thu tu):");
            foreach (var nhom in i)
            {
                var he = dsHe.FirstOrDefault(x => x.MaHe == nhom.Key);
                string ten = he == null ? "(chua khai bao he)" : he.TenHe + " (" + he.MaHe + ")";
                Console.WriteLine("   He " + ten + ":");
                var danhSo = nhom.Select((m, stt) => new { STT = stt + 1, m.MaMon, m.TenMon }); // them số thứ tự cho từng môn trong nhóm
                foreach (var m in danhSo)
                    Console.WriteLine("      " + m.STT + ". " + m.MaMon + " - " + m.TenMon);
            }
        }
    }
}