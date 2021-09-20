using System;

namespace Task02
{
    class MainClass
    {
        public static void FindMax(int P) {
            int n1 = P % 10;
            int n2 = (P / 10) % 10;
            int n3 = (P / 100) % 10;
            int res1 = n1 * 100 + n2 * 10 + n3;
            int res2 = n1 * 100 + n3 * 10 + n2;
            int res3 = n2 * 100 + n1 * 10 + n3;
            int res4 = n2 * 100 + n3 * 10 + n1;
            int res5 = n3 * 100 + n1 * 10 + n2;
            int res6 = n3 * 100 + n2 * 10 + n1;

            Console.WriteLine(Math.Max(res1, Math.Max(res2, Math.Max(res3, Math.Max(res4, Math.Max(res5, res6))))));
        }

        public static void Main(string[] args)
        {
            int P;
            bool flag;
            do
            {
                do
                {
                    Console.WriteLine("Введите P: ");
                    flag = int.TryParse(Console.ReadLine(), out P);
                } while (!flag || Convert.ToString(P).Length != 3 || P <= 0);
                FindMax(P);
                Console.WriteLine("Для выхода из программы нажмите [Esc]. Чтобы повторить решение нажмите [Enter]");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
        }
    }
}
