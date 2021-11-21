using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Largest
    {
        public void FindLargest()
        {
            int num1, num2, num3;
            Console.WriteLine("Problem:Find largest among three numbers");
            Console.WriteLine("Enter First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
                Console.WriteLine("Firsr Number {0} is greater number ", num1);
            else if (num2 > num1 && num2 > num3)
                Console.WriteLine("Second Number {0} is greater number ", num2);
            else
                Console.WriteLine("Third number {0} is greater number ", num3);

        }
    }
}
