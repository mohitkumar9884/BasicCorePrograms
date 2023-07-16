using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.Harmonic
{
    internal class HarmonicNumber
    {
        public void Compute()
        {
            Console.WriteLine("Enter a Harmonic value of N(N!=0): ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("Provide a valid input");
                return;
            }
            double harmonicValue = 0;
            for(int i = 1; i <= N; i++)
            {
                harmonicValue += 1.0 / i;
            }
            Console.WriteLine("Nth Harmonic Value:{0}", harmonicValue);
        }
    }
}
