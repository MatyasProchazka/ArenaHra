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
        public int Utok { get; private set; }
        public int MaxZivot { get; private set; }
        protected int zivot;
        public int Penize { get; private set; }

        public Postava(string jmeno, int utok, int maxZivot)
        {
            this.Jmeno = jmeno;
            this.Utok = utok;
            this.MaxZivot = maxZivot;
            this.zivot = maxZivot;
            Penize = 0;
        }

        public void Utoc(Postava protivnik)
        {
            protivnik.Obrana(Utok);
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
            int podil = Convert.ToInt32(((double)zivot / (double)MaxZivot) * 100);
            return podil > 0 ? podil : 0;
        }
        
        public int Zivot()
        {
            return zivot;
        }

        public void Vylecit()
        {
            zivot = MaxZivot;
        }

        public void PridatUtok()
        {
            Utok += 1;
        }

        public void PridatMaxZivoty()
        {
            MaxZivot += 10;
            zivot = MaxZivot;
        }

        public void PridatPenize()
        {
            Penize += 1;
        }
    }

}
