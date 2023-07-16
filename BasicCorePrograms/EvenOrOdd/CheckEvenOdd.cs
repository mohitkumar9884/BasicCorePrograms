using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.EvenOrOdd
{
    internal class CheckEvenOdd
    {
        public void Calculate()
        {
            Console.WriteLine("Enter a valid number to check,if it is Even or Odd: ");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number % 2==0)
            {
                Console.WriteLine("Given number is Even");
            }
            else
            {
                Console.WriteLine("Given number is Odd");
            }
        }
    }
}
