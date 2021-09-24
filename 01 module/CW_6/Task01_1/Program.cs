using System;

namespace Task01_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = 1234567;
            for (int i = 9; i>=0; i--)
            {
                int num = n;
                while (num>0) {
                    if (num%10==i)
                    {
                        Console.Write(i);
                    }
                    num /= 10;
                }

            }
        }
    }
}
