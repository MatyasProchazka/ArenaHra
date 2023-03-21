using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHra
{
    internal class Arena
    {
        private Postava hrac;
        private Postava protivnik;

        public Arena(Postava hrac, Postava protivnik) 
        {
            this.hrac = hrac;
            this.protivnik = protivnik;
        }

        public void Zapas()
        {

        }
    }
}
