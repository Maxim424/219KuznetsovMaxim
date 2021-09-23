using System;

namespace Task02
{
    class MainClass
    {
        public static bool Shift(ref char ch)
        {
            bool flag;
            flag = char.TryParse(Console.ReadLine(), out ch);
            if (!flag || ch < 97 || ch > 122)
            {
                return false;
            }
            else
            {
                int index = ch - 97;
                index = ((index + 4) % 26) + 97;
                ch = Convert.ToChar(index);
                return true;
            }
            
        }

        public static void Main(string[] args)
        {
            char ch = 'a';
            bool shift;

            do
            {
                Console.WriteLine("Введите символ, удовлетворяющий условию: ");
                shift = Shift(ref ch);
            } while (!shift);
            Console.WriteLine(ch.ToString());
        }
    }
}
