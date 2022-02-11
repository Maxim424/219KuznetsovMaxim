using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(2);
            stack.Push(6);
            stack.Push(10);
            Console.WriteLine($"Size: {stack.Size()}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");
            Console.WriteLine($"Size: {stack.Size()}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"IsEmpty: {stack.IsEmpty()}");
        }
    }
}