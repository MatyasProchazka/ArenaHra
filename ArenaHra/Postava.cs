using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHra
{
    public class Postava
    {
        public string Jmeno { get; private set; }
        protected int utok;
        protected int maxZivot;
        protected int zivot;

        public Postava(string jmeno, int utok, int maxZivot)
        {
            this.Jmeno = jmeno;
            this.utok = utok;
            this.maxZivot = maxZivot;
            this.zivot = maxZivot;
        }

        public void Utoc(Postava protivnik)
        {
            protivnik.Obrana(utok);
        }

        public void Obrana(int poskozeni)
        {
            zivot -= poskozeni;
            if (zivot < 0)
            {
                zivot = 0;
            }
        }

        public bool Nazivu()
        {
            return zivot > 0 ? true : false;
        }

        public int PodilZivotu()
        {
            int podil = Convert.ToInt32(((double)zivot / (double)maxZivot) * 100);
            return podil > 0 ? podil : 0;
        }
        
        public int Zivot()
        {
            return zivot;
        }

        public void Vylecit()
        {
            zivot = maxZivot;
        }
    }

}
