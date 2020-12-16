using System;

namespace ukol_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej prvni cislo:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej druhe cislo:");
            int b = int.Parse(Console.ReadLine());

            int c = (a + b);
            Console.WriteLine("soucet je: "+ c);

            if (c % 2 == 0)
            {
                Console.WriteLine("vysledek je sudy");
            }

            else
            {
                Console.WriteLine("Vysledek je lichy");
            }
            Console.ReadKey();
            
        }
    }
}
