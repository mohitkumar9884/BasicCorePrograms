using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.CheckAlphabet
{
    internal class VowelConsonant
    {
        public void CheckVC()
        {
          
            Console.WriteLine("Enter an Alphabet to check whether it is vowel or consonant: ");
            char input = Convert.ToChar(Console.ReadLine());

            // Convert input to lowercase for easy comparison
            char lowercaseInput = char.ToLower(input);

            if (IsVowel(lowercaseInput))    
            {
                Console.WriteLine("\nIt is a vowel.");
            }
            else if (char.IsLetter(lowercaseInput))
            {
                Console.WriteLine("\nIt is a consonant");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a single alphabet character.");
            }
        }

        static bool IsVowel(char ch)
        {
            // Check if the character is a vowel
            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
    
}
