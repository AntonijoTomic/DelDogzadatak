using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelDogzadatak
{
    internal class Utakmica 
    {
        public event EventHandler<string> ZabijenGol;

        private string _TrenutniRezultat;
        public int TimDomaciBrojGolova { get; private set; }
        public int TimGostBrojGolova { get; private set; }

        public string TrenutniRezultat
        {
            get { return _TrenutniRezultat; }
            set
            {
                _TrenutniRezultat = value;
                ZabijenGol?.Invoke(this, value);
            }
        }

        public void GolDomaci()
        {
            TimDomaciBrojGolova++;
            AžurirajRezultat();
        }

        public void GolGost()
        {
            TimGostBrojGolova++;
            AžurirajRezultat();
        }

        private void AžurirajRezultat()
        {
            TrenutniRezultat = $"{TimDomaciBrojGolova}:{TimGostBrojGolova}";
        }


    }
}
