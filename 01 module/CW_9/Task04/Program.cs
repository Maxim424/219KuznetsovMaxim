using System;
using System.Text;

namespace Task04
{
    //Задание 3.2
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
            int cnt = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>4)
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
