using System;

namespace MTA_P7
{

    abstract class Animal
    {
        public abstract void eat();
        public abstract void drink();

    }
    interface DongVatAnThit
    {
        public void sanmoi();
    }

    class Person : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("Person drink");
        }

        public override void eat()
        {
            Console.WriteLine("Person eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("Person sanmoi");
        }
    }
    class Snake : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("Snake drink");
        }

        public override void eat()
        {
            Console.WriteLine("Snake eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("Snake sanmoi");
        }
    }
    class Lion : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("Lion drink");
        }

        public override void eat()
        {
            Console.WriteLine("Lion eat");
        }

        public void sanmoi()
        {
            Console.WriteLine("Lion sanmoi");
        }
        public static void voMoi() { }
        public static int age { get; set;}
    }

    sealed class LacDa
    {
        const int age =10;
        public void Run() {
            Console.WriteLine("LacDa sanmoi");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LacDa camel = new LacDa();
            Person person = new Person();
            Lion lion = new Lion();
            Snake snake = new Snake();

            person.drink();
            person.eat();
            person.sanmoi();

            lion.drink();
            lion.eat();
            lion.sanmoi();

            snake.drink();
            snake.eat();
            snake.sanmoi();

        }
    }
}
