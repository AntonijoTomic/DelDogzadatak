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
           

            List<Osoba> osobe = new List<Osoba>() {
            new Osoba("Marko", "Marković", 10),
            new Osoba("Ana", "Anić", 22),
            new Osoba("Petar", "Petrović", 2),
            new Osoba("Jelena", "Jelić", 24),
            new Osoba("Ivan", "Ivanić", 32)};

            var Punoljetni = osobe.Where(o => o.Godine > 17);
            var imeNaM = osobe.Where(o => o.Ime.StartsWith("M"));
            foreach (var osoba in Punoljetni)
            {
                Console.WriteLine($"{osoba.Ime} {osoba.Prezime}, {osoba.Godine} godina");
            }
            Console.ReadLine();
        }
        
    }

    public class Osoba
    {
    
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine { get; set; }

        public Osoba(string ime, string prezime, int godine)
        {
            Ime = ime;
            Prezime = prezime;
            Godine = godine;
        }
    }
}
