using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DelDogzadatak
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] brojevi = { 1, 6, 3, 8, 2, 7, 4, 9 };

            var result = brojevi.Where(num => num > 5);//veci od 5
            var kvadrati = brojevi.Select(x => x * x);//kvadriranje brojeva
            var sortirano = brojevi.OrderBy(x => x);//sortirani
            Console.WriteLine("Brojevi veći od 5:");
            foreach (var num in sortirano)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
        
    }
}
