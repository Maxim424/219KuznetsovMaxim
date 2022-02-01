using System;

namespace Task1
{
    // Композиция.
    // При уничтожении "животного" объект "мозг" тоже уничтожается.
    class Animal
    {
        Brain brain;

        public Animal()
        {
            brain = new Brain();
        }
    }

    class Brain { }

    // Агрегация.
    // При уничтожении "автомобиля" объект "колесо" продолжит существовать.
    class Car
    {
        Wheel wheel;

        public Car(Wheel wheel)
        {
            this.wheel = wheel;
        }
    }

    class Wheel { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
