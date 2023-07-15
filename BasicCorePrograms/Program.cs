using BasicCorePrograms.FlipCoin;
using BasicCorePrograms.LeapYear;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic Core Programs");
        Console.WriteLine("Please chose any One program from below options");
        Console.WriteLine("1.FlipCoin\n2.LeapYear");
        Console.WriteLine(" ");
        int option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
                case 1:
                FlipPercentage flipPercentage = new FlipPercentage();
                flipPercentage.CoinToss();
                break;
                case 2:
                LeapYear leapYear = new LeapYear();
                leapYear.Year();
                break;
        }
    }
}