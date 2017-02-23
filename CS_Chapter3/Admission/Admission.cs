using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numeric high school grade point average: ");
            double GPA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an admission test score: ");
            double testScore = Convert.ToDouble(Console.ReadLine());

            if (GPA >= 3.0)
            {
                if (testScore >= 60)
                {
                    Console.WriteLine("Accepted!");
                }

                else
                {
                    Console.WriteLine("Rejected :(");
                }
            }

            else if (GPA < 3.0)
            {
                if (testScore >= 80)
                {
                    Console.WriteLine("Accepted!");
                }

                else
                {
                    Console.WriteLine("Rejected :(");
                }
            }
        }
    }
}