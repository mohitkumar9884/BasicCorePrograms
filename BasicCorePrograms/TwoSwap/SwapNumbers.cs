using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.TwoSwap
{
    internal class SwapNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Swap Numbers Using Temporary Variable
            int temp = number1;
            number1 = number2;
            number1 = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First number: " + number1);
            Console.WriteLine("Second number: " + number2);

        }    
    }
}
