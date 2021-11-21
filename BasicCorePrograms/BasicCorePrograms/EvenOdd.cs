using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class EvenOdd
    {
       public void FindEvenOdd()
       {
            int num;
            Console.WriteLine("Problem:Find the number is even or odd ");
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Number is Even number");
            else
                Console.WriteLine("Number is odd number");
       }
    }
}
