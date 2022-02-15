using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo("1.txt");
            if (fi.Exists)
            {
                byte[] array;
                using (FileStream fs = new FileStream("1.txt", FileMode.Open))
                {
                    array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    foreach (var item in array)
                    {
                        Console.Write((char)item);
                    }
                }
                using (FileStream fs = new FileStream("1.txt", FileMode.Append))
                {
                    byte[] array2 = {(byte)(array[array.Length-1]+1)};
                    fs.Write( array2, 0, array2.Length);
                }
            }
            else
            {
                using (FileStream fs = new FileStream("1.txt", FileMode.Create))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes("A");
                    fs.Write( array, 0, array.Length);
                }
            }
        }
    }
}