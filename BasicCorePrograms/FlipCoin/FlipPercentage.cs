using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.FlipCoin
{
    internal class FlipPercentage
    {
        public void CoinToss()
        {
            double head = 0;
            double tail = 0;
            double headPercentage, tailPercentage;
            Console.WriteLine("Enter number of times the coin should be flipped: ");

            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Random rnd = new Random();
                double result= rnd.NextDouble();

                if (result > 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            Console.WriteLine("Head count: " + head);
            Console.WriteLine("Tail count: " + tail);

            headPercentage= (head/num) * 100;
            Console.WriteLine("Head Percentage: " + headPercentage);
            tailPercentage= (tail/num) * 100;
            Console.WriteLine("Tail Percentage: " + tailPercentage);

        }
    }
}
