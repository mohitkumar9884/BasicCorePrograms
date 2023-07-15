using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.Power
{
    internal class PowerTable
    {
        public void NthPower()
        {
            
            Console.WriteLine("Enter an integer(I) to get power of 2 (I<31): ");
            int k=Convert.ToInt32(Console.ReadLine());

            if(k>=31)
            {
                Console.WriteLine("Invalid input! k should be less than 31.");
                return;
            }


            for (int N = 0; N<=k; N++)
            {
                int Z= (int)Math.Pow(2, N);
                Console.WriteLine("Power of 2 for N = {0}:{1}", N, Z);
            }
        }
    }
}
