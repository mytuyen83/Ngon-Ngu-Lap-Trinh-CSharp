using System;
namespace Lab02.ThucHanh2
{
    class SinhVienSort : IComparable<SinhVienSort>
    {
        // Field: lưu mã số, họ tên và điểm của sinh viên
        private int MaSo;
        private string HoTen;
        private double Diem;
        // Constructor: khởi tạo thông tin sinh viên
        public SinhVienSort(int MaSo, string HoTen, double Diem)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.Diem = Diem;
        }
        // So sánh hai đối tượng SinhVienSort theo họ tên
        public int CompareTo(SinhVienSort sv)
        {
            return HoTen.CompareTo(sv.HoTen);
        }
        // Xuất thông tin sinh viên
        public void Output()
        {
            Console.WriteLine(MaSo + "\t" + HoTen + "\t" + Diem);
        }
        public static void Bai3_1()
        {
            SinhVienSort[] ds =
            {
                new SinhVienSort(3, "Nguyen Van B", 8.5),
                new SinhVienSort(1, "Tran Thi A", 9.0),
                new SinhVienSort(2, "Le Van C", 7.5)
            };
            Console.WriteLine("Danh sach truoc khi sap xep:");
            for (int i = 0; i < ds.Length; i++)
                ds[i].Output();
            Array.Sort(ds);
            Console.WriteLine();
            Console.WriteLine("Danh sach sau khi sap xep:");
            for (int i = 0; i < ds.Length; i++)
                ds[i].Output();
        }
    }
}