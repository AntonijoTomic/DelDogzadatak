using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                OnStanjePromjenjeno(value);
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

   
        public void PokreniProces()
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                  
              
                    if (_trenutnaBoja == BojaSvijetla.Crveno)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Semafor s indexom {Index} je Crveno.");
                        Console.ResetColor();
                        PostaviZuto();
                        PostaviZeleno();
                    }
                    else if(_trenutnaBoja== BojaSvijetla.Zeleno)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Semafor s indexom {Index} je zeleno.");
                        Console.ResetColor();
                        PostaviZuto();
                        PostaviCrveno();
                    }
                 
                    Thread.Sleep(5000);
                    Console.Clear();

                }
            });
            thread.Start();
        }
        public virtual void OnStanjePromjenjeno(BojaSvijetla novoStanje)
        {
            StanjePromjenjeno?.Invoke(this, novoStanje);
        }

    }
}
