using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Lab03.BaiThucHanhLINQ
{
    class MangChuoi
    {
        // tách dấu ra khỏi chữ cái, rồi ghép lại để thành chuỗi không dấu
        private static string BoDau(string s)
        {
            string d = s.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (char ch in d)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        public static void Bai2_2()
        {
            // đề cho
            string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
            Console.WriteLine("Mang goc: " + string.Join(", ", mangChuoi));

            // a. Lấy các từ có đúng 4 ký tự, rồi sắp xếp theo chữ cái đầu
            var a1 = from s in mangChuoi
                     where s.Length == 4
                     orderby s[0]
                     select s;
            var a2 = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
            Console.WriteLine("a. Co 4 ky tu, sap xep theo ky tu dau (Query Syntax): " + string.Join(", ", a1));
            Console.WriteLine("a. Co 4 ky tu, sap xep theo ky tu dau (Method Syntax): " + string.Join(", ", a2));

            // b. Biến mỗi từ thành dạng "chữ thường - CHỮ HOA"
            var b = from s in mangChuoi
                    select s.ToLower() + " - " + s.ToUpper();
            // Viết kiểu Method Syntax thì là: mangChuoi.Select(s => s.ToLower() + " - " + s.ToUpper());
            Console.WriteLine("b. Dang <chu thuong> - <CHU HOA>:");
            foreach (var item in b)
                Console.WriteLine("   " + item);

            // c. Lấy các từ có chứa chữ "u"
            // bỏ dấu trước rồi mới tìm
            var c = from s in mangChuoi
                     where BoDau(s).Contains("u")
                     select s;
            Console.WriteLine("c. Chua ky tu \"u\": " + string.Join(", ", c));

            // d. Lấy các từ bắt đầu bằng chữ in hoa
            var d = mangChuoi.Where(s => char.IsUpper(s[0]));
            Console.WriteLine("d. Bat dau bang chu hoa: " + string.Join(" ", d));
        }
    }
}