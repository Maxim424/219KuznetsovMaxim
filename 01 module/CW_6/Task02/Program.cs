using System;

namespace Task02
    // задача 6
{
    class MainClass
    {
        public static void F(int[] a, int cnt)
        {
            int i = 0;
            while (i<cnt-1)
            {
               
                if ((a[i] + a[i+1]) % 3 == 0)
                {
                    a[i] = a[i] * a[i+1];
                    for (int m = i+1; m < cnt - 1; m++)
                    {
                        a[m] = a[m + 1];
                    }
                    cnt--;
                }
                
                i++;
            }
            int[] b = new int[cnt];
            for (int c = 0; c < cnt; c++)
            {
                b[c] = a[c];
            }
            for (int c = 0; c < b.Length; c++)
            {
                Console.Write(b[c]);
            }
        }

        public static void Main(string[] args)
        {
            int cnt = 6;
            int[] a = new int[] { 1, 2, 3, 4, 5, 6};
            
            F(a, cnt);
            
        }
    }
}
