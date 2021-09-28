using System;

namespace Task02
{
    class MainClass
    {
        public static void Print(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");

            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Random random = new Random();
            int[] mas = new int[100];
            for (int i = 1; i <= 100; i++)
            {
                mas[i-1] = i;
            }
            for (int i = 0; i < 100; i++)
            {
                int a = random.Next(0, 100);
                int b = random.Next(0, 100);
                int c;
                c = mas[a];
                mas[a] = mas[b];
                mas[b] = c;
            }
            Array.Resize(ref mas, 99);
            //Console.WriteLine(mas.Length);
            Array.Sort(mas);
            //Print(mas);
            int res = 0;
            for (int i = 0; i < 99; i++)
            {
                if(mas[i]!=i+1)
                {
                    res = i + 1;
                    break;
                }
            }
            if (res==0)
            {
                Console.WriteLine(100);
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}
