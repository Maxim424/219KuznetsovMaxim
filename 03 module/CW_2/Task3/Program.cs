using System;
using System.Text;

// Презентация 3_01b задача 1

namespace Task3
{
    public delegate string ConvertRule(string str);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }

    class Program
    {
        public static string RemoveDigits(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for(int i = '0'; i <= '9'; i++)
            {
                sb.Replace(((char)i).ToString(), "");
            }
            return sb.ToString();
        }

        public static string RemoveSpaces(string str)
        {
            return str.Replace(" ", "");
        }

        static void Main(string[] args)
        {
            string[] array = { "Hello, 1World!", "Hello, World!11!!1"};
            ConvertRule convertRule = RemoveDigits;
            convertRule += RemoveSpaces;
            foreach (var item in convertRule.GetInvocationList())
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(item.DynamicInvoke(array[i]));
                }
            }
        }
    }
}
