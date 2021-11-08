using System;
using System.Text;

// Презентация 2_02a, задача 5.
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoFile vf1 = new VideoFile("vf1", 60, 1440);
            Console.WriteLine("vf1");
            Console.WriteLine(vf1);
            Random random = new Random();
            int n = random.Next(5, 16);
            Console.WriteLine("n: " + n);
            VideoFile[] array = new VideoFile[n];
            Console.WriteLine();
            Console.WriteLine("Ответ");
            for (int i = 0; i < array.Length; i++)
            {
                int m = random.Next(2, 10);
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < m; j++)
                {
                    sb.Append(Convert.ToChar(random.Next('a', 'z')));
                }
                array[i] = new VideoFile(sb.ToString(), random.Next(60, 361), random.Next(100, 1001));
                if (array[i].Size>vf1.Size)
                {
                    Console.WriteLine(array[i]);
                }
            }
            
        }
    }
}
