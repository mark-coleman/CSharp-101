using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a sentence > ");
            var text = Console.ReadLine();

            
            Console.WriteLine(text.ToUpper().Replace(" ", ""));
            Console.ReadLine();
        }
    }
}
