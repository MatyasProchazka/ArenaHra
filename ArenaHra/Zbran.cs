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
        private int utok;
        public int Cena { get; private set; }
        private int kritickaSance;


        public Zbran(string jmeno, int utok, int kritickaSance, int cena)
        {
            this.Jmeno= jmeno;
            this.utok= utok;
            this.kritickaSance= kritickaSance;
            this.Cena= cena;
        }

        public int PripocitatZbran()
        {
            return JeZasahKriticky() ? utok * 2 : utok; 
        }

        private bool JeZasahKriticky()
        {
            Random random = new();
            if (random.Next(0, 101) < kritickaSance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
