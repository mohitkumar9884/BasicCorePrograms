using BasicCorePrograms.FlipCoin;
using BasicCorePrograms.LeapYear;
using BasicCorePrograms.Power;
using BasicCorePrograms.Harmonic;
using BasicCorePrograms.NPrime;
using BasicCorePrograms.EvenOrOdd;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic Core Programs");
        Console.WriteLine("Please chose any One program from below options");
        Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowerOf2\n4.HarmonicNumber\n5.PrimeFactor\n6.EvenOdd");
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
                case 4:
                HarmonicNumber harmonicNumber = new HarmonicNumber();
                harmonicNumber.Compute();
                break;
                case 5:
                PrimeFactor primeFactor = new PrimeFactor();
                primeFactor.Factorize();
                break;
                case 6:
                CheckEvenOdd checkEvenOdd = new CheckEvenOdd();
                checkEvenOdd.Calculate();
                break;
        }
    }
}