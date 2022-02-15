using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("Numbers.txt", FileMode.OpenOrCreate)))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    bw.Write(random.Next(1, 101));
                }
            }

            int[] array = new int[10];
            using (BinaryReader br = new BinaryReader(new FileStream("Numbers.txt", FileMode.Open)))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = br.ReadInt32();
                }
            }
            Array.ForEach(array, x=>Console.Write(x + " "));
        }
    }
}