using System;

namespace DelDogzadatak
{
    internal class Program
    {
        public delegate void MatematickeOperacije(int a, int b);
        static void Main(string[] args)
        {

            MatematickeOperacije delegatZbrajanje = Zbroji;
            delegatZbrajanje(10, 5);

            MatematickeOperacije delegatOduzimanje = Oduzmi;
            delegatOduzimanje(10, 5);

            MatematickeOperacije delegatMnozenje = Pomnozi;
            delegatMnozenje(10, 5);

            Console.WriteLine();

            MatematickeOperacije delegatMatematicar = delegatZbrajanje + delegatOduzimanje + delegatMnozenje;


            delegatMatematicar.Invoke(10, 5);

            Console.ReadLine();
        
        }
        public static void Zbroji(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Pomnozi(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public static void Oduzmi (int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
