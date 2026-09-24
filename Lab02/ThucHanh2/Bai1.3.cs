using System;
namespace Lab02.ThucHanh2
{
    class Person
    {
        // Field: lưu mã số, họ tên, năm sinh và năm mất của một người
        private int Id;
        private string HoTen;
        private int NamSinh;
        private int NamMat;

        // Default Constructor: khởi tạo Person với dữ liệu ban đầu
        public Person()
        {
            Id = 0;
            HoTen = "";
            NamSinh = 0;
            NamMat = 0;
        }

        // Copy Constructor: tạo Person mới bằng cách sao chép dữ liệu từ Person khác
        public Person(Person P)
        {
            Id = P.Id;
            HoTen = P.HoTen;
            NamSinh = P.NamSinh;
            NamMat = P.NamMat;
        }

        // Nhập dữ liệu của Person
        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhap nam mat (0 neu con song): ");
            NamMat = int.Parse(Console.ReadLine());
        }

        // Xuất dữ liệu của Person
        public void Output()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Ho ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Nam mat: " + NamMat);
            Console.WriteLine("Con song: " + IsLiving());
        }

        // Kiểm tra Person còn sống hay không
        // yod = 0: còn sống, yod khác 0: đã mất
        public bool IsLiving()
        {
            return NamMat == 0;
        }

        public static void Bai1_3()
        {
            Person P1 = new Person();

            Console.WriteLine("Nhap thong tin Person:");
            P1.Input();

            Console.WriteLine();
            Console.WriteLine("Thong tin Person:");
            P1.Output();

            // Tạo Person mới bằng Copy Constructor
            Person P2 = new Person(P1);

            Console.WriteLine();
            Console.WriteLine("Thong tin Person sao chep:");
            P2.Output();
        }
    }
}