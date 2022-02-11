using System;

namespace Task1
{
    struct Person : IComparable
    {
        private string name;
        private string lastname;
        private int age;

        public Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            if (age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }

        public int CompareTo(object obj)
        {
            return age.CompareTo(((Person)obj).Age);
        }

        public override string ToString()
        {
            return $"{name} {lastname}: {age}.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] characters = new Person[n];

        }
    }
}
