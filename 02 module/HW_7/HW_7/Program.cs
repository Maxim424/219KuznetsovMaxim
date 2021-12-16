using System;

namespace HW_7
{
    class Creature
    {
        public string Name { get; set; }
        public double Speed { get; set; }

        public Creature(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }

        public virtual string Run()
        {
            return $"I am running with a speed of {Speed}.";
        }

        public override string ToString()
        {
            return Run() + $" My name is {Name}.";
        }
    }

    class Dwarf : Creature
    {
        private int strength;

        public int Strength {
            get
            {
                return strength;
            }
            set
            {
                if (value<1 || value>20)
                {
                    Random rnd = new Random();
                    strength = rnd.Next(1, 21);
                }
            }
        }

        public Dwarf(string name, double speed, int strength) : base(name, speed)
        {
            this.strength = strength;
        }

        public override string Run()
        {
            return base.Run() + $" My strength is {Strength}.";
        }

        public void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff!");
        }
    }

    class Elf : Creature
    {
        public int Age { get; set; } 

        public Elf(string name, double speed, int age) : base(name, speed)
        {
            Age = age;
        }

        public override string Run()
        {
            return $"I am running with a speed of {Speed + Age/77}. My age is {Age}.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Esc to exit.");
            string str;
            do
            {
                str = Console.ReadLine();
                int n;
                if (int.TryParse(str, out n) && n <= 100 && n > 0)
                {
                    Random rnd = new Random();
                    Creature[] array = new Creature[n];
                    for (int i = 0; i < n; i++)
                    {
                        double db = rnd.NextDouble();
                        if (db < 0.2)
                        {
                            array[i] = new Creature(GetName(), rnd.Next(0, 8) * rnd.NextDouble() + 10);
                        }
                        else if (db < 0.6)
                        {
                            array[i] = new Dwarf(GetName(), rnd.Next(0, 9) * rnd.NextDouble() + 10, rnd.Next(-50, 51));
                        }
                        else
                        {
                            array[i] = new Elf(GetName(), rnd.Next(0, 9) * rnd.NextDouble() + 10, rnd.Next(100, 201));
                        }
                    }

                    Array.ForEach(array, element =>
                    {
                        Console.WriteLine(element);
                        if (element.GetType() == (new Dwarf("A", 1.0, 2)).GetType())
                        {
                            ((Dwarf)element).MakeNewStaff();
                        }
                    });
                }
                else
                {
                    if (str!="Esc")
                        Console.WriteLine("Error. Try again.");
                }
            } while (str != "Esc");
        }

        static string GetName()
        {
            Random rnd = new Random();
            int start = 'A';
            int end = 'Z';
            int start2 = 'a';
            int end2 = 'z';
            string result = Convert.ToChar(rnd.Next(start, end + 1)).ToString() +
                Convert.ToChar(rnd.Next(start2, end2 + 1)).ToString() +
                Convert.ToChar(rnd.Next(start2, end2 + 1)).ToString() +
                Convert.ToChar(rnd.Next(start2, end2 + 1)).ToString();
            return result;
        }
    }
}
