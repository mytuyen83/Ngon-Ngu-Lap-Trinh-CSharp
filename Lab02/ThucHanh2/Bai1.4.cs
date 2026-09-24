using System;
namespace Lab02.ThucHanh2
{
    class PhanSo
    {
        // Field: lưu tử số và mẫu số
        private int Tu;
        private int Mau;

        // Default Constructor: tạo phân số 0/1
        public PhanSo()
        {
            Tu = 0;
            Mau = 1;
        }

        // Constructor có tham số: khởi tạo phân số từ tử và mẫu
        public PhanSo(int Tu, int Mau)
        {
            this.Tu = Tu;
            this.Mau = Mau;
        }

        // Constructor sao chép: tạo phân số mới từ phân số khác
        public PhanSo(PhanSo P)
        {
            Tu = P.Tu;
            Mau = P.Mau;
        }

        // Xuất phân số dưới dạng chuỗi
        public override string ToString()
        {
            return Tu + "/" + Mau;
        }

        // Phép cộng một ngôi
        public static PhanSo operator +(PhanSo P)
        {
            return new PhanSo(P.Tu, P.Mau);
        }

        // Phép lấy âm một ngôi
        public static PhanSo operator -(PhanSo P)
        {
            return new PhanSo(-P.Tu, P.Mau);
        }

        // Phép cộng hai phân số
        public static PhanSo operator +(PhanSo A, PhanSo B)
        {
            return new PhanSo(A.Tu * B.Mau + B.Tu * A.Mau, A.Mau * B.Mau);
        }

        // Phép trừ hai phân số
        public static PhanSo operator -(PhanSo A, PhanSo B)
        {
            return new PhanSo(A.Tu * B.Mau - B.Tu * A.Mau, A.Mau * B.Mau);
        }

        // Phép nhân hai phân số
        public static PhanSo operator *(PhanSo A, PhanSo B)
        {
            return new PhanSo(A.Tu * B.Tu, A.Mau * B.Mau);
        }

        // Phép chia hai phân số
        public static PhanSo operator /(PhanSo A, PhanSo B)
        {
            return new PhanSo(A.Tu * B.Mau, A.Mau * B.Tu);
        }

        // So sánh hai phân số
        public static bool operator >(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau > B.Tu * A.Mau;
        }
        public static bool operator <(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau < B.Tu * A.Mau;
        }
        public static bool operator >=(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau >= B.Tu * A.Mau;
        }
        public static bool operator <=(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau <= B.Tu * A.Mau;
        }
        public static bool operator ==(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau == B.Tu * A.Mau;
        }
        public static bool operator !=(PhanSo A, PhanSo B)
        {
            return A.Tu * B.Mau != B.Tu * A.Mau;
        }

        public static void Bai1_4()
        {
            PhanSo A = new PhanSo(1, 2);
            PhanSo B = new PhanSo(2, 3);

            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            Console.WriteLine("+A = " + (+A));
            Console.WriteLine("-A = " + (-A));

            Console.WriteLine("A + B = " + (A + B));
            Console.WriteLine("A - B = " + (A - B));
            Console.WriteLine("A * B = " + (A * B));
            Console.WriteLine("A / B = " + (A / B));

            Console.WriteLine("A > B: " + (A > B));
            Console.WriteLine("A < B: " + (A < B));
            Console.WriteLine("A >= B: " + (A >= B));
            Console.WriteLine("A <= B: " + (A <= B));
            Console.WriteLine("A == B: " + (A == B));
            Console.WriteLine("A != B: " + (A != B));
        }
    }
}