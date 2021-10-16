using System;
using System.Text;

namespace Task03
{
    //Задание 3.1
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(str);
            while(stringBuilder.ToString().Contains("  ")) {
                stringBuilder.Replace("  ", " ");
            }            
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
