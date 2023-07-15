using BasicCorePrograms.FlipCoin;
using BasicCorePrograms.LeapYear;
using BasicCorePrograms.Power;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic Core Programs");
        Console.WriteLine("Please chose any One program from below options");
        Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowerOf2");
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
                case 3:
                PowerTable powerTable= new PowerTable();
                powerTable.NthPower();
                break;
        }
    }
}