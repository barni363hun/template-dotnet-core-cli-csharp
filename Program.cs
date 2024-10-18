using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Writer();
        }
    }

    class Writer
    {
        public Writer()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
