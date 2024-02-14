using System;

class Currancy
{

    static void Main (string[] args)
    {
        Console.WriteLine("Currancy Converter");
        Console.WriteLine("1. USD to GBP");
        Console.WriteLine("2. GBP to USD"); 
        Console.WriteLine("Enter your choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        double usdToGbpRate = 0.75; // Exchange rate from USD to GBP
        double gbpToUsdRate = 1.33; // Exchange rate from GBP to USD


        switch (choice)

        {
            case 1: 
                Console.Write("Enter amount in USD: ");
                double usdAmount = double.Parse(Console.ReadLine());
                double gbpAmount = usdAmount * usdToGbpRate;
                Console.WriteLine($"Converted amount: {gbpAmount} GBP");
                break;
            
            case 2: 
                Console.Write("Enter amount in GBP: ");
                double gbpAmount2 = double.Parse(Console.ReadLine());
                double usdAmount2 = gbpAmount2 * gbpToUsdRate;
                Console.WriteLine($"Converted amount: {usdAmount2} USD");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

}