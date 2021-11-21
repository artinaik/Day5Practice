using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Swapping
    {
        public void SwapNumbers()
        {
            int num1, num2,temp;
            Console.WriteLine("Enter First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("First Number is " + num1);
            Console.WriteLine("Second Number is " + num2);

        }
    }
}
