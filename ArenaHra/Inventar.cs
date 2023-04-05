﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaHra
{
    public partial class Inventar : UserControl
    {
        private Hrac hrac;
        private List<Zbran> inventar;
        public event EventHandler Finished;
        private Zbran aktualniZbran;
        private int aktualniIndex;
        public Inventar()
        {
            InitializeComponent();
            
        }

        public void PridatHrace(Hrac hrac)
        {
            this.hrac = hrac;
            inventar = hrac.ZiskatInventar();
            InicializaceListBox();
        }

        private void InicializaceListBox()
        {
            List<string> list = new List<string>(); 
            foreach (Zbran zbran in inventar) 
            {
                list.Add(zbran.Jmeno);
            }
            listBox1.DataSource = list;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                aktualniIndex = listBox1.SelectedIndex;
                aktualniZbran = inventar[aktualniIndex];
                jmenoLabel.Text = String.Format("Jmeno: " + aktualniZbran.Jmeno);
                utokLabel.Text = String.Format("Utok: " + aktualniZbran.Utok.ToString());
                kritickaSanceLabel.Text = String.Format("Krit: " + aktualniZbran.KritickaSance.ToString());
                cenaLabel.Text = String.Format("Cena: " + aktualniZbran.Cena.ToString());
            }
            catch 
            {
                
            }
            

        }

        private void odejitBtn_Click(object sender, EventArgs e)
        {
            Hide();
            OnFinished();
        }

        protected virtual void OnFinished()
        {
            if (Finished != null)
            {
                Finished(this, EventArgs.Empty);
            }
        }

        private void nasaditBtn_Click(object sender, EventArgs e)
        {
            Zbran zbran = hrac.ZmenitZbran(aktualniZbran);
            inventar.RemoveAt(aktualniIndex);
            inventar.Insert(aktualniIndex, zbran);
            ObnovitListBox();
        }

        public void ObnovitListBox()
        {
            listBox1.DataSource = null;
            InicializaceListBox();
        }
    }
}
