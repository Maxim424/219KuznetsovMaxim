using System;

namespace Task03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = num;
                        num++;
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        mas[i, j] = num;
                        num++;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
