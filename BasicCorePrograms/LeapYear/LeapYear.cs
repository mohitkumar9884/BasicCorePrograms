using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms.LeapYear
{
    internal class LeapYear
    {
        public void Year() 
        {
            
            Console.WriteLine("Enter a year to check LeapYear");
            int year =Convert.ToInt32(Console.ReadLine());
            

            bool isFourDigit = year >= 1000 && year <= 9999;
            bool isDivisibleByFour = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;

            if (isFourDigit && isDivisibleByFour)
            {
                Console.WriteLine("{0} is a 4-digit number and a Leap Year", year);
            }
            else if (isFourDigit)
            {
                Console.WriteLine("{0} is a 4-digit number, but not a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a 4-digit number,enter a valid year", year);
            }



        }
    }
}
