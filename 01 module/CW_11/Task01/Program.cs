using System;
using System.IO;
using System.Text;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Data.txt";

            // Создаем файл с данными
            if (!File.Exists(path))
            {
                // Сейчас данные для записи вбиты в коде
                // TODO1: сохранить в файл целые случайные значения из диапазона [10;100)
                StringBuilder sb = new StringBuilder();
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    if (i!=0 && i%5==0)
                    {
                        sb.Append(Environment.NewLine);
                        sb.Append(random.Next(10, 100));
                    }
                    else if (i==0)
                    {
                        sb.Append(random.Next(10, 100));
                    }
                    else
                    {
                        sb.Append(" ");
                        sb.Append(random.Next(10, 100));
                    }
                }
                
                File.WriteAllText(path, sb.ToString(), Encoding.UTF8);
                
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(' ');
                int[] arr = StringArrayToIntArray(stringValues);
                Console.WriteLine("arr:");
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                int evenCount = 0;
                int oddCount = 0;
                
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]%2==0)
                    {
                        evenCount++;
                    }
                    else
                    {
                        oddCount++;
                    }
                }
                int[] even = new int[evenCount];
                int[] odd = new int[oddCount];
                int a = 0;
                int b = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]%2==0)
                    {
                        even[a] = i;
                        a++;
                    }
                    else {
                        odd[b] = i;
                        b++;
                    }
                }
                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (int i = 0; i < oddCount; i++)
                {
                    arr[odd[i]] = 0;
                }
                Console.WriteLine("arr:");
                Array.ForEach(arr, x => Console.Write(x + " "));
                Console.WriteLine();
                Console.WriteLine("even:");
                Array.ForEach(even, x => Console.Write(x + " "));
                Console.WriteLine();
                Console.WriteLine("odd:");
                Array.ForEach(odd, x => Console.Write(x + " "));
                Console.WriteLine();
                File.Delete(path);
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        }
    }
}