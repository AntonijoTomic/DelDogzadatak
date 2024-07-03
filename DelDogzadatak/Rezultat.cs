using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelDogzadatak
{
    internal class Rezultat : IDisposable
    {
        private Utakmica _utakmica;

        public Rezultat(Utakmica utakmica)
        {
            _utakmica = utakmica;
            _utakmica.ZabijenGol += PosaljiObavijest;
        }

        public void PosaljiObavijest(object sender, string noviRezultat)
        {
            Console.WriteLine($"Obavijest: Rezultat utakmice je promijenjen na: {noviRezultat}");
        }

        public void Dispose()
        {
            if (_utakmica != null)
            {
                _utakmica.ZabijenGol -= PosaljiObavijest;
            }
        }
    }
}
