using System;

namespace MTA_P8
{


    class Person
    {
        private string diaChi { get; set; }
        private string ten { get; set; }
        private int tuoi { get; set; }

        public void Nhap() {
            Console.WriteLine("Nhap ten");
            this.ten = Console.ReadLine();

            Console.WriteLine("Nhap tuoi");
            this.tuoi = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap dia chi");
            this.diaChi = Console.ReadLine();

        }
        public void HienThi() {
            Console.WriteLine("Tên: "+ this.ten);
            Console.WriteLine("Tuổi: "+ this.tuoi);
            Console.WriteLine("Địa chỉ: "+ this.diaChi);
        }
    }

    class Studen : Person
    {
        private int speed;
        public void Di() { }
        public void Di(int speed)
        {
            this.speed = speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            p1.Nhap();
            p1.HienThi();

            p2.Nhap();
            p2.HienThi();

            Studen studen1 = new Studen();
            Studen studen2 = new Studen();

            studen1.Di();
            studen1.Di(15);
            studen1.Nhap(); ;
            studen1.HienThi();

            studen2.Di();
            studen2.Di(14);
            studen2.Nhap(); ;
            studen2.HienThi();

        }
    }
}
