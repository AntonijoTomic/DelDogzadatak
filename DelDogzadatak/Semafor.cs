using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelDogzadatak
{
    internal class Semafor
    {
        public event EventHandler<BojaSvijetla> StanjePromjenjeno;
        public enum BojaSvijetla 
        {
            Crveno,
            Zuto,
            Zeleno
        }
        private BojaSvijetla _trenutnaBoja;
        public BojaSvijetla TrenutnoSvijetlo {
            get { return _trenutnaBoja; }
            set { 
                _trenutnaBoja = value;
                StanjePromjenjeno.Invoke(this, value);
            }
        }
        public int Index { get; }

        public Semafor(int index)
        {
            Index = index;
            _trenutnaBoja = BojaSvijetla.Crveno; 
        }


        public void PostaviCrveno()
        {
            TrenutnoSvijetlo = BojaSvijetla.Crveno;
        }      
        public void PostaviZuto()
        {
            TrenutnoSvijetlo = BojaSvijetla.Zuto;
        }
        public void PostaviZeleno()
        {
            TrenutnoSvijetlo = BojaSvijetla.Zeleno;
        }




    }
}
