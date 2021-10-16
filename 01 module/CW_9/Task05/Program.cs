using System;
using System.Text;

namespace Task05
{
    //Задание 3.3
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(str);
            while (stringBuilder.ToString().Contains("  "))
            {
                stringBuilder.Replace("  ", " ");
            }
            string[] words = stringBuilder.ToString().Split();
            string letters = "AEIOUY";
            int cnt = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (letters.Contains(words[i].ToUpper()[0]))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
