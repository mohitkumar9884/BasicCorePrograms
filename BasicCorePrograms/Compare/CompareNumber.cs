using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.Compare
{
    internal class CompareNumber
    {
        public void ThreeNumbers()
        {
            Console.WriteLine("Enter three numbers for comparison: ");

            Console.WriteLine("Number1: ");
            int Number1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number2: ");
            int Number2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number3: ");
            int Number3=Convert.ToInt32(Console.ReadLine());

            // Arrange the numbers in descending order using math functions
            int max = Math.Max(Number1, Math.Max(Number2, Number3));
            int min = Math.Min(Number1, Math.Min(Number2, Number3));
            int mid = (Number1 + Number2 + Number3) - (max + min);

            Console.WriteLine("Largest number between given numbers is:{0}",max);
        }
    }
}
