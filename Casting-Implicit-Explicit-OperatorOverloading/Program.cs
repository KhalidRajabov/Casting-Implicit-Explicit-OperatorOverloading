using System;
using Casting_Implicit_Explicit_OperatorOverloading.Models;

namespace Casting_Implicit_Explicit_OperatorOverloading
{
    internal class Program
    {
        enum Currencies : int { USD, EUR, TL };
        static void Main(string[] args)
        {
            do
            {
                Console.Write("How much AZN do you have? ");
                double AZN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Convert {AZN} to: \n" +
                    "1. USD     2. EUR     3. TL");
                int UserCurrency = Convert.ToInt32(Console.ReadLine());
                int usd;
                switch (UserCurrency)
                {
                    case 1:
                        Exchange(Currencies.USD, AZN);
                        break;
                    case 2:
                        Exchange(Currencies.EUR, AZN);
                        break;
                    case 3:
                        Exchange(Currencies.TL, AZN);
                        break;

                    default:
                        break;
                }


                Console.Write("Convert kelvin to celcius: ");

                double klvtoclc = Convert.ToDouble(Console.ReadLine());

                Celcius Celci1 = new Celcius(klvtoclc);
                Kelvin Kelvin1 = Celci1;
                Console.WriteLine($"{klvtoclc} kelvin is {Kelvin1.Kelv} celcius");




            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            static double Exchange(Currencies money, double AZN)
            {
                double Converted = 0;
                if (money is Currencies) //usd is Currencies)
                {
                    if (money is Currencies.USD)
                    {
                        Converted = AZN * 0.59;
                        Console.WriteLine($"{AZN} manat is equal to {Converted} dollar");
                    }
                    else if (money is Currencies.EUR)
                    {
                        Converted = AZN * 0.53;
                        Console.WriteLine($"{AZN} manat is equal to {Converted} euro");
                    }
                    else if (money is Currencies.TL)
                    {
                        Converted = AZN * 8.64;
                        Console.WriteLine($"{AZN} manat is equal to {Converted} Lira");
                    }
                    else
                    {
                        Console.WriteLine(" Oops! Something went wrong!");
                    }
                }
                return Converted;
            }
            
            
            
            
            
            
            
            


           

        }
    }
}
