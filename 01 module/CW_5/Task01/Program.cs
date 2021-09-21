using System;

namespace Task01
{
    class MainClass
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            string str = number.ToString();
            int j = 1;
            foreach (var i in str)
            {
                if (j%2==0)
                {
                    sumEven += uint.Parse(i.ToString());
                }
                else
                {
                    sumOdd += uint.Parse(i.ToString());
                }
                j++;
            }
        }

        public static void Main(string[] args)
        {
            uint number, sumEven, sumOdd;
            bool flag;

            do
            {
                flag = uint.TryParse(Console.ReadLine(), out number);
            } while (!flag);
            Sums(number, out sumEven, out sumOdd);
            Console.WriteLine(sumEven + " " + sumOdd);
        }
    }
}
