using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Division
    {
        public void FindQuotientAndRem()
        {
            int dividend, divisor;
            double rem, quotient;
            Console.WriteLine("Find Quotient and remainder");
            Console.WriteLine("\nEnter Dividend ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor ");
            divisor = Convert.ToInt32(Console.ReadLine());
            rem = dividend % divisor;
            quotient = dividend / divisor;
            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + rem);
        }
    }
}
