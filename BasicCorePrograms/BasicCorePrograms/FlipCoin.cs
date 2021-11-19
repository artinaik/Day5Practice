using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public double countTails = 0, countHeads = 0;
        public double perTails = 0, perHeads = 0;
        public void FlipCoinProblem()
        {
            
            Console.WriteLine("Problem: Flip coin and print percentage of head and tails");
            Console.WriteLine("Enter number of times you want to flip a coin");
            int num=Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i=0;i<num;i++)
            {
                int check = random.Next(0, 2);

                if (check < 0.5)
                {
                    Console.WriteLine("Tails");
                    countTails = countTails + 1;                    
                }
                else
                {
                    Console.WriteLine("Heads");
                    countHeads = countHeads + 1;
                }
            }
            perTails = countTails / num * 100;
            perHeads = countHeads / num * 100;
            Console.WriteLine("Percentage of Tails is " + perTails);
            Console.WriteLine("Percentage of Heads is "+perHeads);
        }
    }
}
