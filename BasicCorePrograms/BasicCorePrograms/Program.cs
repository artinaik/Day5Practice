using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs");
            FlipCoin flipCoinobj = new FlipCoin();
            flipCoinobj.FlipCoinProblem();
            Console.ReadKey();
        }
    }
}
