using System;

namespace HW_2
{

    class Plant
    {
        private double growth;
        private double photosensitivity;
        private double frostresistance;

        public Plant(double growth, double photosensitivity, double frostresistance)
        {
            this.growth = growth;
            this.photosensitivity = photosensitivity;
            this.frostresistance = frostresistance;
        }

        public double Growth { get => growth; set => growth = value; }
        public double Photosensitivity { get => photosensitivity; set => photosensitivity = value; }
        public double Frostresistance { get => frostresistance; set => frostresistance = value; }

        public override string ToString()
        {
            return $"Growth: {growth}. Photosensitivity: {photosensitivity}. Frostresistance: {frostresistance}";
        }
    }

    class Program
    {
        static int Sort (Plant x, Plant y)
        {
            if (x.Photosensitivity%2==0 && y.Photosensitivity%2==1)
            {
                return 1;
            }
            else if (x.Photosensitivity % 2 == 1 && y.Photosensitivity % 2 == 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            Plant[] array = new Plant[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Plant(rnd.Next(25, 101), rnd.Next(0, 101), rnd.Next(0, 81));
            }
            Console.WriteLine("Элементы массива:");
            Array.ForEach(array, x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("Массив, отсортированный по убыванию роста:");
            Array.Sort(array, delegate (Plant x, Plant y)
            {
                if (x.Growth>y.Growth)
                {
                    return -1;
                }
                else if (x.Growth<y.Growth)
                {
                    return 1;
                }
                else {
                    return 0;
                }
            });
            Array.ForEach(array, x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("Массив, отсортированный по возрастанию морозоустойчивости:");
            Array.Sort(array, (Plant x, Plant y) =>
            {
                if (x.Frostresistance > y.Frostresistance)
                {
                    return 1;
                }
                else if (x.Frostresistance < y.Frostresistance)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            });
            Array.ForEach(array, x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("Массив, отсортированный по четности светочувствительности:");
            Array.Sort(array, Sort);
            Array.ForEach(array, x => Console.WriteLine(x));


            Converter<Plant, Plant> converter = x =>
            {
                if (x.Frostresistance % 2 == 0)
                {
                    x.Frostresistance /= 3;
                }
                else
                {
                    x.Frostresistance /= 2;
                }
                return x;
            };

            Array.ConvertAll(array, converter);
            Console.WriteLine();
            Console.WriteLine("Сконвертированный массив:");
            Array.ForEach(array, x => Console.WriteLine(x));
        }
    }
}
