using System;

namespace Task03
{
    class Program
    {
        public static void Recursion(int cnt, int num)
        {
            if (num == 0)
            {
                Console.WriteLine(cnt);
            }
            else if (num > 0)
            {
                num /= 10;
                cnt++;
                Recursion(cnt, num);
            }
        }
        
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Recursion(0, num);
        }
    }
}