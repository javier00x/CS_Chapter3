using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a pay rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            if (rate < 5.65)
            {
                Console.WriteLine("ERROR!");
            }

            if (rate < 5.0 || rate > 10.0)
            {
                // Out of range
            }

            if (rate >= 5.0 && rate <= 10.0)
            {
                // In range
            }

        }
    }
}
