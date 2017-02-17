using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            if (rate > 49.99)
            {
                Console.WriteLine("ERROR! please re-enter your desired pay rate. ");
                Console.Write("Enter your pay rate here: ");
                rate = Convert.ToDouble(Console.ReadLine());

                if (rate > 49.99)
                {
                    Console.WriteLine("your desired pay rate has been denied! sorry");
                }  
            }

            if (rate < 5.65)
            {
                Console.WriteLine("ERROR! please re-enter your desired pay rate");
                Console.Write("Enter your pay rate here: ");
                rate = Convert.ToDouble(Console.ReadLine());

                if (rate < 5.65)
                {
                    Console.WriteLine("Your desired pay rate has been denied, I'm sorry!");
                }

            }

            if (rate < 5.0 || rate > 50.0)
            {
                // Out of range
            }

            if (rate >= 5.0 && rate <= 50.0)
            {
                // In range
            }
        }
    }
}
