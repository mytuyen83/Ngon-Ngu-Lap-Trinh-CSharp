using System;
using System.Collections;

namespace Lab02.ThucHanh2
{
    class ArrayPoint
    {
        // Field: lưu danh sách các đối tượng Point
        private ArrayList DanhSach;

        // Default Constructor: tạo ArrayList rỗng
        public ArrayPoint()
        {
            DanhSach = new ArrayList();
        }

        // Indexer: truy cập Point thứ i trong ArrayList
        public Point this[int i]
        {
            get
            {
                return (Point)DanhSach[i];
            }
            set
            {
                DanhSach[i] = value;
            }
        }

        // Thêm một Point vào ArrayList
        public void Them(Point P)
        {
            DanhSach.Add(P);
        }

        public static void Bai2_1()
        {
            ArrayPoint ds = new ArrayPoint();

            Point A = new Point();
            Point B = new Point();
            Point C = new Point();

            Console.WriteLine("Nhap diem A:");
            A.Input();

            Console.WriteLine("Nhap diem B:");
            B.Input();

            Console.WriteLine("Nhap diem C:");
            C.Input();

            ds.Them(A);
            ds.Them(B);
            ds.Them(C);

            Console.WriteLine();
            Console.WriteLine("Danh sach cac Point:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Point " + i + ": " + ds[i]);
            }
        }
    }
}