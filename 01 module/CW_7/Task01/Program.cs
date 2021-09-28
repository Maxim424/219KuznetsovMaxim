using System;
// Задача 2
namespace Task01
{
    class MainClass
    {
        public static void Print(char[] mas)
        {
            for (int i =  0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
                
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] mas = new char[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                mas[i] = (char)random.Next('A', 'Z' + 1);
            }
            Print(mas);
            char[] mas2 = new char[k];
            Array.Copy(mas, mas2, k);
            Array.Sort(mas2);
            Print(mas2);
            Array.Reverse(mas2);
            Print(mas2);
        }
    }
}
