﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaHra
{
    public class Hrac : Postava
    {
        public new string Jmeno { get; private set; }
        public new int MaxZivot { get; private set; }

        private readonly Zbran zbran;
        public int PocetKol { get; set; }
        public new int Utok { get; private set; }
        protected new int zivot;
        public int Penize { get; private set; }
        private int velikostInventare;
        private string[] listJmenProtivnik = { "Hugo", "Martin", "Jon", "Jakub", "SKeleton", "Roman", "Baba", "Jeliman", "SEXY", "DEBIL" };
        private List<Zbran> inventar = new List<Zbran>();

        public Hrac(string jmeno, int utok, int maxZivot, int velikostInventare, Zbran zbran) : base(jmeno, utok, maxZivot)
        {
            this.zbran = zbran;
            this.Utok = utok;
            this.MaxZivot= maxZivot;
            this.Jmeno= jmeno;
            this.zivot = maxZivot;
            Penize= 0;
            PocetKol= 0;
            this.velikostInventare = velikostInventare;
            InicializaceInventare();
        }

        public override int Utoc(Postava protivnik)
        {
            Random random = new();
            int poskozeni = Utok + random.Next(1, 10 + PocetKol) + zbran.PripocitatZbran();
            protivnik.Obrana(poskozeni);
            return poskozeni;
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

        public Postava VygenerovatProtivnika()
        {
            Random rdm = new();
            return new Postava(listJmenProtivnik[rdm.Next(0, listJmenProtivnik.Length)], 5 + PocetKol + rdm.Next(1,  2 + 2 * PocetKol), 80 + 4 * PocetKol + rdm.Next(1, 2 + PocetKol * 2));
        }

        private void InicializaceInventare()
        {
            for (int i = 0; i < velikostInventare;i++)
            {
                inventar.Add(Zbran.VytvoritZbran(PocetKol));
            }
        }

        public List<Zbran> ZiskatInventar()
        {
            return inventar;
        }
    }
}
