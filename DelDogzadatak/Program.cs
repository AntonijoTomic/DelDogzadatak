using System;

namespace DelDogzadatak
{
    internal class Program
    {
        public delegate void MatematickeOperacije(int a, int b);
        static void Main(string[] args)
        {

            MatematickeOperacije delegatMatematicar = Zbroji;
            delegatMatematicar += Pomnozi;
            delegatMatematicar += Oduzmi;

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
