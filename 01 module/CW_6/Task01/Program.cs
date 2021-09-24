using System;

namespace Task01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint n1 = n;
            int cnt = 0;
            while (n1!=0)
            {
                n1 /= 10;
                cnt++;
            }
            for (int i = 0; i < cnt; i++) {
                for (int j = i+1; j < cnt; j++)
                {
                    uint ai = (uint)(n / Math.Pow(10, i )) % 10;
                    uint aj = (uint)(n / Math.Pow(10, j )) % 10;
                    if (aj>ai)
                    {
                        uint c = ai;
                        ai = aj;
                        aj = c;
                    }
                    n = (uint)(((uint)(n / Math.Pow(10, i + 1)) * 10 + ai) * Math.Pow(10, i) + n % Math.Pow(10, i));
                    n = (uint)(((uint)(n / Math.Pow(10, j + 1)) * 10 + aj) * Math.Pow(10, j) + n % Math.Pow(10, j));
                }
            }
            Console.WriteLine(n);

            
        }
    }
}
