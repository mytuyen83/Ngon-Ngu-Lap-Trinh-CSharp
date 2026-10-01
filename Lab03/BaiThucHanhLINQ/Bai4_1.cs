using System;
using System.Collections.Generic;

namespace Lab03.BaiThucHanhLINQ
{
    public class MonHoc
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public string He { get; set; } = "";
        public byte SoTiet { get; set; }

        // Ghi đè ToString để khi in ra màn hình hiện gọn trên 1 dòng
        public override string ToString()
        {
            string he = He == "" ? "(chua co he)" : He;
            return MaMon + " | " + TenMon + " | " + he + " | " + SoTiet;
        }
    }

    public static partial class DuLieu // dữ liệu các môn học
    {
        private static MonHoc Mon(string ma, string ten, string he, byte soTiet)
        {
            return new MonHoc { MaMon = ma, TenMon = ten, He = he, SoTiet = soTiet };
        }

        public static List<MonHoc> DS_Mon()
        {
            return new List<MonHoc>
            {
                Mon("HP2_1", "Nền tảng C#", "KTV", 64),
                Mon("HP2_2", "Công nghệ ADO.NET", "KTV", 64),
                Mon("HP3_1", "Lập trình Windows Forms", "KTV", 64),
                Mon("HP3_2", "Xây dựng ứng dụng Windows Forms", "KTV", 64),
                Mon("HP4_1", "Lập trình Web với HTML, CSS và JavaScript", "KTV", 64),
                Mon("HP4_2", "Xây dựng ứng dụng Web với ASP.NET", "KTV", 64),
                Mon("HP5_1", "Lập trình CSDL SQL Server căn bản", "KTV", 64),
                Mon("HP5_2", "Lập trình CSDL SQL Server nâng cao", "KTV", 64),
                Mon("JLCB", "Joomla cơ bản", "CD", 72),
                Mon("LINQ", "Language-Integrated Query", "CD", 64),
                Mon("DAWEB", "Đồ án thực tế Web với ASP.NET", "CD", 40),
                Mon("DAWIN", "Đồ án thực tế Windows Forms", "CD", 40),
                Mon("CC++", "Lập trình hướng đối tượng với C/C++", "CD", 128),
                Mon("JQUE", "JQuery", "CD", 22),
                Mon("XML", "Công nghệ XML", "CD", 32),
                Mon("CRYS", "Crystal Report trong Visual Studio", "CD", 32),
                Mon("BWEB", "HTML, CSS và JavaScript", "CD", 32),
                Mon("XYZ", "Chưa đặt tên môn", "", 0)  
            };
        }
    }
}