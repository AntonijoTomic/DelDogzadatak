using System;

namespace DelDogzadatak
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Utakmica utakmica = new Utakmica();
            using (Rezultat rezultat = new Rezultat(utakmica))
            {
                // Simulacija golova
                utakmica.GolDomaci();
                utakmica.GolGost();
                utakmica.GolDomaci();

                Console.ReadKey();
            }
        }

    }
}
