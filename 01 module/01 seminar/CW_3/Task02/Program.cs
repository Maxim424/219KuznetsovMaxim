using System;

namespace Task02
{
    class MainClass
    {
        public static void F1() {
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(i*i);
            }
        }

        public static void F2()
        {
            int i= 1;
            while (i < 11)
            {
                Console.WriteLine(i*i);
                i++;
            }
        }

        public static void F3()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i*i);
                i++;
            } while (i < 11);
        }


        public static void Main(string[] args)
        {
            F1();
            F2();
            F3();
        }
    }
}
