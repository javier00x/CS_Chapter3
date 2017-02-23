using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("your hourly pay rate: ");
            double payrate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Now enter the amount of hours worked: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            double grosspay = hours * payrate;


            if (grosspay <= 300.00)
            {

                double withholdingtax = 10;
                double netpay = grosspay - withholdingtax;

                Console.WriteLine("your withholding tax would be {0}", withholdingtax);

            }

            else if (grosspay > 300.01)
            {
                double withholdingtax = 12;
                double netpay = grosspay - withholdingtax;

                Console.WriteLine("your withholdingtax would be {0}%", withholdingtax);
            }


        }
    }
}
