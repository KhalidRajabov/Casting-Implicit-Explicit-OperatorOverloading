using System;

namespace Casting_Implicit_Explicit_OperatorOverloading
{
    internal class Program
    {
        enum Currencies : int { USD=1, EUR, TL };
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter currency: \n" +
                "1. USD     2. EUR     3. TL");
            int day = Convert.ToInt32(Console.ReadLine());
            int usd;
            switch (day)
            {
                case (int)Currencies.USD:
                    Console.WriteLine("How much USD do you have? ");
                    usd = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("dollar");
                    Exchange(usd);
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

            static void Exchange(int obj, double azn)
            {
                if (obj is Currencies)
                {
                    if (obj == Currencies.USD)
                    {

                    }
                }
                int Money = obj;
                //double Manat = azn;
                Console.WriteLine("metod isleyir");
            } 
        }
    }
}
