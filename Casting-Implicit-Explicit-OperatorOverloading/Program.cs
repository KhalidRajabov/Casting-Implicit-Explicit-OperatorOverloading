using System;

namespace Casting_Implicit_Explicit_OperatorOverloading
{
    internal class Program
    {
        enum Currencies : int { USD=1, EUR, TL };
        static void Main(string[] args)
        {
            Console.Write("How much AZN do you have? ");
            double AZN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Convert {AZN} to: \n" +
                "1. USD     2. EUR     3. TL");
            int UserCurrency= Convert.ToInt32(Console.ReadLine());
            int usd;
            switch (UserCurrency)
            {
                case 1:
                        Exchange(Currencies.USD, AZN);
                    break;
                case (int)Currencies.EUR:
                    Console.WriteLine("EUR");
                    break;
                case (int)Currencies.TL:
                    Console.WriteLine("TL");
                    break;

                default:
                    break;
            }

            static Currencies Exchange(Currencies money, double AZN)
            {
                Currencies USD;
                Currencies EUR;
                Currencies TL;
                double manat = AZN;
                if (money == Currencies.USD) //usd is Currencies)
                {
                    
                        AZN = 0.59;
                        money = money * AZN;
                        return money;
                }
                return money;
                //int Money = obj;
                //double Manat = azn;
                Console.WriteLine("metod isleyir");
            } 
        }
    }
}
