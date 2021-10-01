using System;

namespace Task02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] mas = new int[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[rnd.Next(5, 15)];
                for (int j = 0; j<mas[i].Length; j++)
                {
                    mas[i][j] = rnd.Next(-10, 10);
                }
                Array.Sort(mas[i], (int a, int b) =>
                {
                    if (a > b)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                });
            }
            Array.Sort(mas, (int[] a, int[] b) =>
            {
                if (a.Length > b.Length)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            });
            Array.ForEach(mas, el =>
            {
                Array.ForEach(el, elem =>
                {
                    Console.Write(elem + " ");
                });
                Console.WriteLine();
            });

        }
    }
}
