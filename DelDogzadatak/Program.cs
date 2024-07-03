using System;
using System.Collections.Generic;
using System.IO;

namespace DelDogzadatak
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Semafor s1 = new Semafor(2);
            Semafor s2 = new Semafor(3);
            Semafor s3 = new Semafor(4);
            Semafor s4 = new Semafor(5);

            s2.PostaviZeleno();
            s4.PostaviZeleno();
         List<Semafor> list = new List<Semafor>() { s1,s2,s3,s4};

            foreach (Semafor s in list)
            {
                s.PokreniProces();
            }


            Console.ReadLine();
        }
        
    }
}
