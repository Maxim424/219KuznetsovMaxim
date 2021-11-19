using System;

namespace Task01
{
    abstract class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public abstract void AnimalSound();

        public abstract void AnimalInfo();

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public string Breed
        {
            get;

            private set;
        }

        public bool IsTrained
        {
            get;

            private set;
        }

        public override void AnimalInfo()
        {
            Console.WriteLine("This is dog.");
            Console.WriteLine(Name + " " + Age + " " + IsTrained + " " + Breed);
        }

        public override void AnimalSound()
        {
            Console.WriteLine("woof!");
        }
    }

    class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age)
        {
        }

        public double AmountOfMilkPerDay
        {
            get;

            private set;
        }

        public override void AnimalInfo()
        {
            Console.WriteLine("This is cow.");
            Console.WriteLine(Name + " " + Age + " " + AmountOfMilkPerDay);
        }

        public override void AnimalSound()
        {
            Console.WriteLine("moo...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Dog("Dog", 1);
            Animal a2 = new Cow("Cow", 3);
            a1.AnimalInfo();
            a1.AnimalSound();
            Console.WriteLine();
            a2.AnimalInfo();
            a2.AnimalSound();
        }
    }
}