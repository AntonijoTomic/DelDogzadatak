using System;

namespace DelDogzadatak
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Utakmica utakmica = new Utakmica();
            Rezultat rezultat = new Rezultat(utakmica);
           
            utakmica.GolDomaci();
            utakmica.GolGost();
            utakmica.GolDomaci();

            Console.ReadKey();
            
        }

    }
}
