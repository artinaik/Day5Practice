using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class HarmonicNumber
    {
        public void FindHarmonic()
        {
            double harmonicValue = 0, i;
            Console.WriteLine("Problem: Find Harmonic Number");
            Console.WriteLine("Enter Harmonic value N");
            int num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                double value = 1 / i;
                harmonicValue = harmonicValue + value;
                Console.WriteLine("1/{0} = {1} ",i,value);
            }
            Console.WriteLine("\n{0}th Harmonic value is {1}",num,harmonicValue);
        }
    }
}
