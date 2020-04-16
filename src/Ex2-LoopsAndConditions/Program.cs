using System;

namespace Ex2_NumbersAndColours
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 31; i++)
            {
                if (i < 11)
                {
                    Console.WriteLine($"Small {i}");
                }
                else if (i < 21)
                {
                    Console.WriteLine($"Medium {i}");
                }
                else
                {
                    Console.WriteLine($"Large {i}");
                }
            }
            Console.ReadLine();
        }
    }
}
