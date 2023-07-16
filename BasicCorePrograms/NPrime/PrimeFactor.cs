using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.NPrime
{
    internal class PrimeFactor
    {
        public void Factorize()
        {
            Console.WriteLine("Enter a number to find prime factors: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factors of {0}:", number);

            // Divide by 2 repeatedly while the number is even
             while (number % 2==0)
             {
                 Console.WriteLine(2);
                 number /= 2;
             }

             //Check for prime factors starting from 3
             for (int i = 3; i*i <= number; i=i+2)
             {
                while (number%i ==0)
                {
                    Console.WriteLine(i);
                    number /= i;
                }
             }
             // If number is still greater than 2 , it is a prime factor itself
             if (number > 2)
             {
                Console.WriteLine(number); 
             }
        }
    }
}
