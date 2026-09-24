using System;
using System.Collections;
namespace Lab02.ThucHanh2
{
    class PersonList
    {
        // Field: lưu danh sách các Person
        private ArrayList DanhSach;

        // Default Constructor: tạo danh sách rỗng
        public PersonList()
        {
            DanhSach = new ArrayList();
        }

        // Copy Constructor: sao chép danh sách Person
        public PersonList(PersonList ds)
        {
            DanhSach = new ArrayList();
            for (int i = 0; i < ds.DanhSach.Count; i++)
            {
                Person p = new Person((Person)ds.DanhSach[i]);
                DanhSach.Add(p);
            }
        }

        // Thêm một Person vào danh sách
        public void Add(Person x)
        {
            DanhSach.Add(x);
        }

        // Nhập danh sách Person
        public void Input()
        {
            Console.Write("Nhap so luong nguoi: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Nhap Person thu " + (i + 1) + ":");
                Person p = new Person();
                p.Input();
                Add(p);
            }
        }

        // Xuất danh sách Person
        public void Output()
        {
            for (int i = 0; i < DanhSach.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Person thu " + (i + 1) + ":");
                ((Person)DanhSach[i]).Output();
            }
        }

        // Tạo PersonList gồm những người còn sống
        public PersonList LivingPeople()
        {
            PersonList kq = new PersonList();
            for (int i = 0; i < DanhSach.Count; i++)
            {
                Person p = (Person)DanhSach[i];
                if (p.IsLiving())
                    kq.Add(new Person(p));
            }
            return kq;
        }

        public static void Bai2_2()
        {
            PersonList ds = new PersonList();
            ds.Input();
            Console.WriteLine();
            Console.WriteLine("Danh sach Person:");
            ds.Output();
            PersonList kq = ds.LivingPeople();
            Console.WriteLine();
            Console.WriteLine("Danh sach nguoi con song:");
            kq.Output();
        }
    }
}