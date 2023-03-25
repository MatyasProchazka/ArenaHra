using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHra
{
    public class Zbran
    {
        public string Jmeno { get; private set; }
        public int Utok { get; private set; }
        public int Cena { get; private set; }
        public int KritickaSance { get; private set; }


        public Zbran(string jmeno, int utok, int kritickaSance, int cena)
        {
            this.Jmeno= jmeno;
            this.Utok= utok;
            this.KritickaSance= kritickaSance;
            this.Cena= cena;
        }

        public int PripocitatZbran()
        {
            return JeZasahKriticky() ? Utok * 2 : Utok; 
        }

        private bool JeZasahKriticky()
        {
            Random random = new();
            if (random.Next(0, 101) < KritickaSance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Zbran VytvoritZbran(int pocetKol)
        {
            return new Zbran("Nic", 10, 20, 10);
        }
 
    }
}
