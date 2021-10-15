using System;
using System.Collections.Generic;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abc", "def", "ghi", "jkl", "Afgh", "ahjm", "hjk"};
            List<string> str = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToUpper().StartsWith("A"))
                    str.Add(names[i]);
            }
            foreach(var i in str)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var str2 = from s in names
                       where s.ToUpper().StartsWith("A")
                       orderby s descending
                       select s;
            foreach (var i in str2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
