using System;
using System.Collections;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-10000, 10000);
            }

            Console.WriteLine("\nz1");
            var z1 = from num in array
                select num.ToString()[num.ToString().Length - 1];
            foreach (var item in z1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nz2");
            var z2 = from num in array
                group num by num.ToString()[num.ToString().Length - 1] into newNum
                select newNum;
            foreach (var item in z2)
            {
                Console.WriteLine(item.Key);
                foreach (var num in item)
                {
                    Console.WriteLine(num);
                }
            }
            Console.WriteLine("\nz3");
            var z3 = from num in array
                where num > 0 && num % 2 == 0
                select num;
            Console.WriteLine($"Count: {z3.Count()}");
            foreach (var item in z3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nz4");
            var z4 = (from num in array
                where num % 2 == 0
                select num).Sum();
            Console.WriteLine($"Sum: {z4}");
            Console.WriteLine("\nz5");
            var z5 = from num in array
                orderby num % 10, num, num / Math.Pow(10, num.ToString().Length - 1), num
                select num;
            z5 = array.OrderBy(num => Math.Abs(num) % 10).ThenBy(num => Math.Abs(num) / Math.Pow(10, num.ToString().Length - 1));
            foreach (var item in z5)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}