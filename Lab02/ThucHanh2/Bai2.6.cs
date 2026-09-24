using System;
namespace Lab02.ThucHanh2
{
    class DayPhanSo
    {
        // Field: lưu tử số và mẫu số của n phân số
        private int[] tu;
        private int[] mau;
        // Default Constructor: tạo dãy phân số rỗng
        public DayPhanSo()
        {
            tu = new int[0];
            mau = new int[0];
        }
        // Constructor có tham số: tạo dãy gồm n phân số
        public DayPhanSo(int n)
        {
            tu = new int[n];
            mau = new int[n];
        }
        // Copy Constructor: sao chép một dãy phân số
        public DayPhanSo(DayPhanSo p)
        {
            tu = new int[p.tu.Length];
            mau = new int[p.mau.Length];
            for (int i = 0; i < p.tu.Length; i++)
            {
                tu[i] = p.tu[i];
                mau[i] = p.mau[i];
            }
        }
        // Indexer: truy cập phân số thứ i
        public string this[int i]
        {
            get
            {
                return tu[i] + "/" + mau[i];
            }
        }
        // Nhập dãy phân số
        public void Input()
        {
            for (int i = 0; i < tu.Length; i++)
            {
                Console.WriteLine("Nhap phan so thu " + (i + 1) + ":");
                Console.Write("Nhap tu so: ");
                tu[i] = int.Parse(Console.ReadLine());
                do
                {
                    Console.Write("Nhap mau so: ");
                    mau[i] = int.Parse(Console.ReadLine());
                    if (mau[i] == 0)
                        Console.WriteLine("Mau so phai khac 0.");
                }
                while (mau[i] == 0);
            }
        }
        // Xuất dãy phân số
        public void Output()
        {
            for (int i = 0; i < tu.Length; i++)
            {
                Console.Write(this[i]);
                if (i < tu.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
        // Tính tổng các phân số
        public void TinhTong(out int tuTong, out int mauTong)
        {
            tuTong = 0;
            mauTong = 1;
            for (int i = 0; i < tu.Length; i++)
            {
                tuTong = tuTong * mau[i] + tu[i] * mauTong;
                mauTong = mauTong * mau[i];
            }
            int ucln = TimUCLN(Math.Abs(tuTong), Math.Abs(mauTong));
            tuTong = tuTong / ucln;
            mauTong = mauTong / ucln;
        }
        // Tìm ước chung lớn nhất
        private int TimUCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        public static void Bai2_6()
        {
            Console.Write("Nhap so luong phan so n: ");
            int n = int.Parse(Console.ReadLine());
            DayPhanSo ds = new DayPhanSo(n);
            Console.WriteLine();
            ds.Input();
            Console.WriteLine();
            Console.Write("Day phan so: ");
            ds.Output();
            int tuTong;
            int mauTong;
            ds.TinhTong(out tuTong, out mauTong);
            Console.WriteLine("Tong cac phan so = " + tuTong + "/" + mauTong);
        }
    }
}