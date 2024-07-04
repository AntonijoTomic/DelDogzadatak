using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DelDogzadatak
{
    internal class Program
    {
        static Action pozdrav = () =>
        {
            Console.WriteLine("Pozdrav! Akcijska metoda!");
        };

        
        static Func<int, double> KorijenBroja= (broj) =>
        {
            return Math.Sqrt(broj);
        };

        static void Main(string[] args)
        {

            pozdrav();

            // Pozivanje Func delegata
            int broj = 25;
            double korijen = KorijenBroja(broj);
            Console.WriteLine($"Korijen broja '{broj}' u func metodi je {korijen}.");
        

        Console.ReadLine();
        }
        
    }

  
}
