using System;

namespace Task04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[n, n];
            int num = 1;
            for (int m = 0; m < n / 2; m++)
            {
                int i = m;
                int j = m;
                while (j <= n - 1 - m)
                {
                    mas[i, j] = num;
                    num++;
                    j++;
                }
                j--;
                i++;
                while (i <= n - 1 - m)
                {
                    mas[i, j] = num;
                    num++;
                    i++;
                }
                i--;
                j--;
                while (j >= 0 + m)
                {
                    mas[i, j] = num;
                    num++;
                    j--;
                }
                j++;
                i--;
                while (i >= 0 + m)
                {
                    mas[i, j] = num;
                    num++;
                    i--;
                }
                
            }
            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    Console.Write(mas[k, l] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
