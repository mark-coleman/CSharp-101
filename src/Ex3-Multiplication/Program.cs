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
            // Get the initial number to use (between 1 and 20)
            int number = 0;
            do
            {
                Console.Write("Please enter a number between 1 and 20 > ");
                var input = Console.ReadLine();

                number = int.Parse(input);

            } while (number < 0 || number > 20);
            
            // Print the multiplication table
            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }

            Console.ReadLine();
        }
    }
}
