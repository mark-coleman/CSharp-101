using System;

namespace Ex1_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, nice to meet you");
            Console.ReadLine();
        }
    }
}
