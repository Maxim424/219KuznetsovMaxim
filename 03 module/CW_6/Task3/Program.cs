using System;

namespace Task3
{
    interface IRunable
    {
        public int Speed { get; set; }

        void Run();
    }

    interface IJumpable
    {
        public int Length { get; set; }

        void Jump();
    }

    abstract class Animal : IComparable<Animal>
    {
        public int Age { get; set; }

        public int CompareTo(Animal other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }

    class Beetle : Animal, IRunable
    {
        private int speed;

        public Beetle()
        {
        }

        public Beetle(int speed, int age)
        {
            Speed = speed;
            Age = age;
        }

        public int Speed { get => speed; set => speed = value; }

        public void Run()
        {
            Console.WriteLine($"Beetle >> run with speed {Speed}");
        }

        public override string ToString()
        {
            return $"Beetle with speed {speed}";
        }
    }

    class Kangaroo : Animal, IJumpable
    {
        private int length;

        public Kangaroo()
        {
        }

        public Kangaroo(int length, int age)
        {
            Length = length;
            Age = age;
        }

        public int Length { get => length; set => length = value; }

        public void Jump()
        {
            Console.WriteLine($"Kangaroo >> jump");
        }

        public override string ToString()
        {
            return $"Kangaroo with length {length}";
        }
    }

    class Сheetah : Animal, IRunable, IJumpable
    {
        private int speed;
        private int length;

        public Сheetah()
        {
        }

        public Сheetah(int speed, int length, int age)
        {
            Speed = speed;
            Length = length;
            Age = age;
        }

        public int Speed { get => speed; set => speed = value; }

        public int Length { get => length; set => length = value; }

        public void Jump()
        {
            Console.WriteLine("Cheetah >> jump");
        }

        public void Run()
        {
            Console.WriteLine("Cheetah >> run");
        }

        public override string ToString()
        {
            return $"Сheetah with speed {speed} and length {length}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[6];
            animals[0] = new Beetle(10, 1);
            animals[1] = new Beetle(20, 1);
            animals[2] = new Kangaroo(50, 4);
            animals[3] = new Kangaroo(55, 5);
            animals[4] = new Сheetah(60, 100, 4);
            animals[5] = new Сheetah(65, 105, 3);
            foreach (Animal i in animals)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("********************");

            IRunable[] runables = { (IRunable)animals[0], (IRunable)animals[1], (IRunable)animals[4], (IRunable)animals[5] };
            foreach (IRunable i in runables)
            {
                i.Run();
            }
            IJumpable[] jumpables = { (IJumpable)animals[2], (IJumpable)animals[3], (IJumpable)animals[4], (IJumpable)animals[5] };
            foreach (IJumpable i in jumpables)
            {
                i.Jump();
            }
        }
    }
}
