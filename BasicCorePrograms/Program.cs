﻿using BasicCorePrograms.FlipCoin;
using BasicCorePrograms.LeapYear;
using BasicCorePrograms.Power;
using BasicCorePrograms.Harmonic;
using BasicCorePrograms.NPrime;
using BasicCorePrograms.EvenOrOdd;
using BasicCorePrograms.Compare;
using BasicCorePrograms.CheckAlphabet;
using BasicCorePrograms.TwoSwap;
using BasicCorePrograms.QuotientRemainder;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Basic Core Programs");
        Console.WriteLine("Please chose any One program from below options");
        Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.PowerOf2\n4.HarmonicNumber\n5.PrimeFactor\n6.EvenOdd\n7.LargestNumber\n8.Alphabet\n9.SwapNumbers\n10.CalculateQuotientRemainder");
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
                case 7:
                CompareNumber compareNumber= new CompareNumber();
                compareNumber.ThreeNumbers();
                break;
                case 8:
                VowelConsonant vowelConsonant = new VowelConsonant();
                vowelConsonant.CheckVC();
                break;
                case 9:
                SwapNumbers swapNumbers = new SwapNumbers();
                swapNumbers.Swap();
                break;
                case 10:
                ComputeQR computeQR= new ComputeQR();
                computeQR.QR();
                break;
        }
    }
}