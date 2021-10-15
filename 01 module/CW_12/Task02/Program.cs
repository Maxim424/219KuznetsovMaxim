using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static bool IsPalindrome(int s) {
            bool flag = true;
            string str = s.ToString();
            for (int i = 0; i < str.Length/2; i++)
            {
                if (str[i]!=str[str.Length-i-1])
                {
                    flag = false;
                }
            }
            return flag;
        }

        static int Sum(int s)
        {
            int sum = 0;
            while(s!=0)
            {
                sum += s % 10;
                s /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                nums[i] = random.Next(10, 99);
                //Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            var res1 = from s in nums
                       where s % 3 == 0 & s.ToString().Length == 2
                       orderby s ascending
                       select s;
            Console.WriteLine("Запрос 1:");
            foreach (var s in res1) {
                Console.Write(s + " ");
            }

            var res2 = from s in nums
                       where IsPalindrome(s)
                       orderby s ascending
                       select s;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Запрос 2:");
            foreach (var s in res2)
            {
                Console.Write(s + " ");
            }

            var res3 = nums.OrderBy(element => Sum(element)).ThenBy(element => element);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Запрос 3:");
            foreach (var s in res3)
            {
                Console.Write(s + " ");
            }

            var res4 = (from s in nums
                        where s.ToString().Length == 4
                        select s).ToArray().Sum();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Запрос 4:");
            Console.WriteLine(res4);
        }
    }
}
