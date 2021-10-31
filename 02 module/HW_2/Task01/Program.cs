using System;

namespace Task01
{

    class ConsolePlate
    {
        private char _plateChar;
        private ConsoleColor _plateColor = ConsoleColor.White;
        private ConsoleColor _backgroundColor = ConsoleColor.Black;

        public ConsolePlate()
        {
            _plateChar = 'A';
        }

        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            _plateChar = plateChar;
            _plateColor = plateColor;
        }

        public char PlateChar
        {
            get => _plateChar;

            set
            {
                if (value >='A' && value <='Z')
                {
                    _plateChar = value;
                }
            }
        }

        public ConsoleColor PlateColor
        {
            get => _plateColor;
            set
            {
                if (value!=BackgroundColor)
                {
                    _plateColor = value;
                }
            }
        }
        public ConsoleColor BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                if (value!=PlateColor)
                {
                    _backgroundColor = value;
                }
            }
        }

        public override string ToString()
        {
            return _plateChar.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate cp1 = new ConsolePlate('X', ConsoleColor.White);
            cp1.BackgroundColor = ConsoleColor.DarkRed;

            ConsolePlate cp2 = new ConsolePlate('O', ConsoleColor.White);
            cp2.BackgroundColor = ConsoleColor.Red;

            int n = int.Parse(Console.ReadLine());
            if (n>=2 && n<35)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if ((i+j)%2==0)
                        {
                            Console.ForegroundColor = cp1.PlateColor;
                            Console.BackgroundColor = cp1.BackgroundColor;
                            Console.Write(cp1);
                        }
                        else
                        {
                            Console.ForegroundColor = cp2.PlateColor;
                            Console.BackgroundColor = cp2.BackgroundColor;
                            Console.Write(cp2);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
