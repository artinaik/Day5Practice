using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public void FindPower()
        {
            Console.WriteLine("Problem:Print table of Power of Two");
            Console.WriteLine("Enter power value ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0 && num<31)
            {
                for(int i=1;i<=num;i++)
                {
                    Console.WriteLine("2^{0} = {1} ",i,Math.Pow(2,i));
                }
            }
        }
    }
}
