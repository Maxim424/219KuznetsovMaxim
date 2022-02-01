using System;

namespace Task1
{
    /// <summary>
    /// Структуры не наследуются от других структур,
    /// но могут от интерфейсов.
    /// struct -> valueType -> object.
    /// </summary>
    struct Person
    {
        public string Name;
        public int Age;

        public void Print()
        {
            Console.WriteLine($"Name: {Name}; age: {Age}");
        }

        public Person(string name, int age)
        {
            // Нужно проинициализировать все поля
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.Name = "Max";
            person.Age = 17;
            person.Print();
            Person person1 = new Person();
            Console.WriteLine(person1.Age);
        }
    }
}
