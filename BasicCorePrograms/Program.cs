using BasicCorePrograms.FlipCoin;

namespace BasicCorePrograms
{
    internal class Program
    {
       static void Main(string[] args)
       {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("Please chose any One program from below options");
            Console.WriteLine("1.FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                    case 1:
                    FlipPercentage flipPercentage = new FlipPercentage();
                    flipPercentage.CoinToss();
                    break;
            }
            
       }
    }
}