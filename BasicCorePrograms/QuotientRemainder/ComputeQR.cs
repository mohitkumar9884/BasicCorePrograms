using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.QuotientRemainder
{
    internal class ComputeQR
    {
        public void QR()
        {
            Console.WriteLine("Enter the dividend: ");
            int dividend=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the divisor: ");
            int divisor=Convert.ToInt32(Console.ReadLine()) ;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
