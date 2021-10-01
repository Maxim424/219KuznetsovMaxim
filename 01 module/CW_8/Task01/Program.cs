using System;

namespace Task01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++) {
                mas[i] = random.Next(0, 1000);
            }
            Array.Sort(mas, (int a, int b) =>
            {
                if (a % 2 == 0 && b % 2 == 1)
                {
                    return 1;
                }
                else if (a % 2 == 1 && b % 2 == 0)
                {
                    return -1;
                }
                else if ((a%2==0 && b%2==0 && a < b) || (a % 2 == 1 && b % 2 == 1 && a < b))
                {
                    return -1;
                }
                else if ((a % 2 == 0 && b % 2 == 0 && a > b) || (a % 2 == 1 && b % 2 == 1 && a > b))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
            Console.WriteLine("Сортировка по чётности");
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            Console.WriteLine("Сортировка по количеству цифр в числе");
            Array.Sort(mas, (int a, int b) => {
                int cnt1 = 0;
                while (a!=0)
                {
                    a /= 10;
                    cnt1 += 1;
                }
                int cnt2 = 0;
                while (b != 0)
                {
                    b /= 10;
                    cnt2 += 1;
                }
                if (cnt1>cnt2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });
            Array.ForEach(mas, el => Console.Write(el + " "));
            Console.WriteLine();
            Console.WriteLine("Сортировка по сумме цифр в числе");
            Array.Sort(mas, (int a, int b) => {
                int sum1 = 0;
                while (a != 0)
                {
                    sum1 += a % 10;
                    a /= 10;
                    
                }
                int sum2 = 0;
                while (b != 0)
                {
                    sum2 += b % 10;
                    b /= 10;
                    
                }
                if (sum1 > sum2)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });
            Array.ForEach(mas, el => Console.Write(el + " "));
        }
    }
}
