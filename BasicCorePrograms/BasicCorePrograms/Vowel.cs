using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    class Vowel
    {
        public void CheckAlphabet()
        {
            char input;
            Console.WriteLine("Problem:Check alphabet is Vowel or Consonant");
            Console.WriteLine("Enter alphabet");
            input =Convert.ToChar(Console.ReadLine());
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
                Console.WriteLine("Alphabet is Vowel");
            else
                Console.WriteLine("Alphabet is Consonant");
        }
    }
}
