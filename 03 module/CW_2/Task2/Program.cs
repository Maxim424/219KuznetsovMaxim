﻿using System;

// Презентация 3_01b задача 5.

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -1, 3, 10, 8, -20, 10 };
            Action<int> d1 = x => Console.Write($"{x} ");
            Array.ForEach(arr, d1);
            Console.WriteLine();

            Converter<int, int> d2 = x => x * 2;
            int[] arr2 = Array.ConvertAll(arr, d2);
            Array.ForEach(arr2, d1);
            Console.WriteLine();

            Predicate<int> d3 = (int x) => x > 0;
            int[] arr3 = Array.FindAll(arr, d3);
            Array.ForEach(arr3, d1);
            Console.WriteLine();

            Console.WriteLine(Array.Exists(arr, x => x < 0));
            Console.WriteLine(Array.TrueForAll(arr, d3));

            Comparison<int> d4 = (x, y) => y.CompareTo(x);
            Array.Sort(arr, d4);
            Array.ForEach(arr, d1);
            Console.WriteLine();

            Func<int, double> d5 = x => x / 10.0;
            Console.WriteLine(d5(15));

            Func<int, int, bool> d6 = (x, y) => x > y;
            Console.WriteLine(d6(10, 11));
        }
    }
}
