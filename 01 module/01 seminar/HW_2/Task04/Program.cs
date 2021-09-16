using System;

namespace Task04
{
    class MainClass
    {
        public static void Reverse(int x)
        {
            string str = Convert.ToString(x);
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                res += str[str.Length - i - 1];
            }

            Console.WriteLine(res);
        }
        
        public static void Main(string[] args)
        {
            int x;
            bool flag;
            do
            {
                do
                {
                    Console.WriteLine("Введите четырехзначное натуральное число: ");
                    flag = int.TryParse(Console.ReadLine(), out x);
                } while (!flag || x<=999 || x>=10000);
                Reverse(x);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            }while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
