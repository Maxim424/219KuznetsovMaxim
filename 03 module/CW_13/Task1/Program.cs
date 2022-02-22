using System;
using System.Collections;

namespace Task1
{
    class Fibbonacci : IEnumerable
    {
        private int _firstNumber = 1;
        private int _secondNumber = 1;
        private const int CountOfIterations = 10;
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < CountOfIterations; i++)
            {
                yield return _secondNumber;
                int t = _secondNumber;
                _secondNumber += _firstNumber;
                _firstNumber = t;
            }
            _firstNumber = 1;
            _secondNumber = 1;
        }

        public IEnumerable NextElement(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return _secondNumber;
                int t = _secondNumber;
                _secondNumber += _firstNumber;
                _firstNumber = t;
            }
            _firstNumber = 1;
            _secondNumber = 1;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fibbonacci = new Fibbonacci();
            foreach (var item in fibbonacci)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in fibbonacci.NextElement(3))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in fibbonacci)
            {
                Console.WriteLine(item);
            }
        }
    }
}