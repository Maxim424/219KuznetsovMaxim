using System;

namespace Task03
{
    class MainClass
    {
        public static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");

            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] mas = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                mas[i - 1] = i;
            }
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(0, 100);
                int b = random.Next(0, 100);
                int c;
                c = mas[a];
                mas[a] = mas[b];
                mas[b] = c;
            }
            int a1, b1;
            do
            {

                a1 = random.Next(0, 100);
                b1 = random.Next(0, 100);

            } while (a1 == b1);
            mas[a1] = mas[b1];
            int xor1 = 0;
            int xor2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                xor1 ^= i;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                xor2 ^= mas[i];
            }
            Array.Sort(mas);
            Print(mas);
            Console.WriteLine(xor1-xor2);
        }
    }
}
