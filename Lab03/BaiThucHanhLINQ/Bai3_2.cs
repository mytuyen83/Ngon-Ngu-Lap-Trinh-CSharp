using System;
using System.Linq;

namespace Lab03.BaiThucHanhLINQ
{
    class ThongKeMangChuoi
    {
        public static void Bai3_2()
        {
            // đề cho
            string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
                "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };

            // a. Tìm phần tử có chiều dài ngắn nhất và dài nhất
            // tìm xem độ dài ngắn nhất và dài nhất là bao nhiêu, lọc ra tất cả món có độ dài đó vì có thể có nhiều món cùng độ dài
            int ngan = monAn.Min(s => s.Length);
            int dai = monAn.Max(s => s.Length);
            var nganNhat = monAn.Where(s => s.Length == ngan);
            var daiNhat = monAn.Where(s => s.Length == dai);
            Console.WriteLine("a. Ngan nhat (" + ngan + " ky tu): " + string.Join("; ", nganNhat));
            Console.WriteLine("a. Dai nhat (" + dai + " ky tu): " + string.Join("; ", daiNhat));

            // b. Nhóm các món theo từ đầu tiên
            var nhom = from s in monAn
                       group s by s.Split(' ')[0] into g // cắt tên món theo dấu cách, [0] là lấy từ đầu tiên
                       select g;
            Console.WriteLine("b. Phan nhom theo tu dau tien:");
            foreach (var g in nhom)
                Console.WriteLine("   [" + g.Key + "] (" + g.Count() + "): " + string.Join(", ", g));

            // c. Đếm số món có từ đầu tiên là "Bánh"
            int soBanh = monAn.Count(s => s.Split(' ')[0] == "Bánh"); 
            Console.WriteLine("c. So phan tu co tu dau tien la \"Banh\": " + soBanh);
        }
    }
}