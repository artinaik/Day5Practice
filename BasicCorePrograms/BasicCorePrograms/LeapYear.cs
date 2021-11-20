using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class LeapYear
    {
        public void CheckLeap()
        {
            Console.WriteLine("Problem:Leap Year");
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year.ToString().Length == 4)
            {
                if (year % 4 == 0)
                    Console.WriteLine("Year is Leap Year");
                else
                    Console.WriteLine("Year is not a Leap Year");
            }
            else
            Console.WriteLine("Year should be 4 digit");
        }
    }
}
