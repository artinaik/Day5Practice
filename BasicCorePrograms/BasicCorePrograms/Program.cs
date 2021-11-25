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
            Console.WriteLine("\n1)Flip Coin \n2)Leap Year \n3)Power of Two \n4)Harmonic number \n5)Factors of number \n6)Quotient and remainder" +
                "\n7)Swapping \n8)Even odd \n9)Vowel or Consonant \n10)Largest number");
            Console.WriteLine("Enter your choice number ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FlipCoin flipCoinobj = new FlipCoin();
                    flipCoinobj.FlipCoinProblem();
                    break;
                case 2:
                    LeapYear leapYearobj = new LeapYear();
                    leapYearobj.CheckLeap();
                    break;
                case 3:
                    PowerOfTwo powerOfTwoobj = new PowerOfTwo();
                    powerOfTwoobj.FindPower();
                    break;
                case 4:
                    HarmonicNumber harmonicNumberobj = new HarmonicNumber();
                    harmonicNumberobj.FindHarmonic();
                    break;
                case 5:
                    Factors factorsobj = new Factors();
                    factorsobj.FindFactors();
                    break;
                case 6:
                    Division divisionobj = new Division();
                    divisionobj.FindQuotientAndRem();
                    break;
                case 7:
                    Swapping swappingobj = new Swapping();
                    swappingobj.SwapNumbers();
                    break;
                case 8:
                    EvenOdd evenOddobj = new EvenOdd();
                    evenOddobj.FindEvenOdd();
                    break;
                case 9:
                    Vowel vowelobj = new Vowel();
                    vowelobj.CheckAlphabet();
                    break;
                case 10:
                    Largest largestobj = new Largest();
                    largestobj.FindLargest();
                    break;
            Console.ReadKey();
        }
    }
}
