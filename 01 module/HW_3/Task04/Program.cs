using System;

namespace Task04
{
    class Program
    {
        public static int F(int n1, int n2, int n3)
        {
            int r1 = n1 % 100;
            int r2 = n2 % 100;
            int r3 = n3 % 100;
            if (Math.Min(r1, Math.Min(r2, r3)) == r1)
            {
                return n1;
            } else if (Math.Min(r1, Math.Min(r2, r3)) == r2)
            {
                return n2;
            }
            else 
            {
                return n3;
            }
        }
        
        static void Main(string[] args)
        {
            bool flag1, flag2, flag3;
            int n1, n2, n3;
            do
            {
                Console.WriteLine("Введите номер первой аудитории: ");
                flag1 = int.TryParse(Console.ReadLine(), out n1);
            } while (!flag1);
            do
            {
                Console.WriteLine("Введите номер второй аудитории: ");
                flag2 = int.TryParse(Console.ReadLine(), out n2);
            } while (!flag2);
            do
            {
                Console.WriteLine("Введите номер третьей аудитории: ");
                flag3 = int.TryParse(Console.ReadLine(), out n3);
            } while (!flag3);

            Console.WriteLine(F(n1, n2, n3));
        }
    }
}