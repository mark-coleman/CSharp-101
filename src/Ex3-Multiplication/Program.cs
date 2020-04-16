using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number > ");
            var input = Console.ReadLine();

            int number = int.Parse(input);

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            Console.ReadLine();
        }
    }
}
