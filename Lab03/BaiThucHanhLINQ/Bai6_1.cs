using System;
using System.Collections.Generic;

namespace Lab03.BaiThucHanhLINQ
{
    public class He
    {
        public string MaHe { get; set; } = "";
        public string TenHe { get; set; } = "";
    }

    public static partial class DuLieu // dữ liệu các hệ
    {
        public static List<He> DS_He()
        {
            return new List<He>
            {
                new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
                new He { MaHe = "CD", TenHe = "Chuyên đề" },
                new He { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" }   // hệ này chưa có môn nào, để thử left join ở Bài 6.2
            };
        }
    }
}