using System;
using System.IO;

namespace HW_6
{
    class Point
    {
        int x;
        public Point(int x)
        {
            this.x = x;
        }

        public override string ToString()
        {
            return "Point";
        }
    }



    [Serializable]
    public class MyException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyException"/> class
        /// </summary>
        public MyException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        public MyException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception. </param>
        public MyException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:MyException"/> class
        /// </summary>
        /// <param name="context">The contextual information about the source or destination.</param>
        /// <param name="info">The object that holds the serialized object data.</param>
        protected MyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Point[] array = null;
                Console.WriteLine(array[0]);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException");
            }

            try
            {
                int n = 0;
                Console.WriteLine(2/n);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }

            try
            {
                string[] lines = File.ReadAllLines("abc.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("IOException");
            }

            try
            {
                string str = "A";
                int num = int.Parse(str);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }

            try
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }

            try
            {
                int num = 100;
                if (num==100)
                {
                    throw new MyException("MyException");
                }
            }
            catch (MyException myException)
            {
                Console.WriteLine(myException.Message);
            }
        }
    }
}
