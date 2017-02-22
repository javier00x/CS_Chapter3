using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of wood for your table");
            Console.Write("Enter P for Pine O for Oak, M for Mahogany: ");

            string input = Console.ReadLine();

            if (input == "P")
            {
                Console.WriteLine("the pirce for the Pine is $100.00");

            }

            else if (input == "O")
            {
                Console.WriteLine("the price for Oak is $225.00");
            }

            else if (input == "M")
            {
                Console.WriteLine("the price for the Mahogany is $310.00");
            }

            else
            {
                Console.WriteLine("ERROR! please choose either P, O, or M as your choice of wood");
            }
        }
    }
}
