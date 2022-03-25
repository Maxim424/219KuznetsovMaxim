using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Linq;

namespace HW_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int>();
            Console.WriteLine("Введите размер коллекции");
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                collection.Add(rnd.Next(-1000, 1001));
            }

            Console.WriteLine("Изначальная коллекция");
            collection.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\nКоллекция квадратов");
            var z1 = from elem in collection
                select elem * elem;
            foreach (var item in z1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nКоллекция положительных двузначных чисел");
            var z2 = from elem in collection
                where elem>0 && elem.ToString().Length==2
                select elem;
            foreach (var item in z2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nКоллекция чётных чисел с сортировкой по убыванию");
            var z3 = from elem in collection
                where elem%2==0
                orderby elem descending 
                select elem;
            foreach (var item in z3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nКоллекция с группировкой по порядку");
            var z4 = from elem in collection
                group elem by Math.Abs(elem).ToString().Length
                into newCollection
                select newCollection;
            foreach (var item in z4)
            {
                Console.WriteLine(item.Key);
                foreach (var num in item)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }
}