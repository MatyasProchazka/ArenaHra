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
    public partial class Staty : UserControl
    {
        private Hrac hrac;
        public event EventHandler Finished;
        public Staty()
        {
            InitializeComponent();
        }

        public void PridatHrace(Hrac hrac)
        {
            if (hrac != null)
            {
                this.hrac = hrac;
                hracJmenoLabel.Text = hrac.Jmeno;
                hracUtokLabel.Text = hrac.Utok.ToString();
                hracMaxZivotyLabel.Text = hrac.MaxZivot.ToString();
                hracPenizeLabel.Text = hrac.Penize.ToString();
                Zbran zbran = hrac.AktualniZbran();
                hracZbranLabel.Text = String.Format("Zbran: " + zbran.Jmeno + "  Utok: " + zbran.Utok);
            }
        }

        private void utokPridaniBtn_Click(object sender, EventArgs e)
        {
            if (hrac.PridatUtok())
            {
                hracUtokLabel.Text = hrac.Utok.ToString();
                hracPenizeLabel.Text = hrac.Penize.ToString();
            }
            else
            {
                MessageBox.Show("Nedostatek penez");
            }
            
        }

        private void maxZivotPridatBtn_Click(object sender, EventArgs e)
        {
            hrac.PridatMaxZivoty();
            hracMaxZivotyLabel.Text = hrac.MaxZivot.ToString();
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

        private void utokPridaniBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(utokPridaniBtn, String.Format("Cena vylepseni: " + hrac.CenaUtoku.ToString() + "/bod"));
        }

        public void Aktualizovat()
        {
            Zbran zbran = hrac.AktualniZbran();
            hracZbranLabel.Text = String.Format("Zbran: " + zbran.Jmeno + "  Utok: " + zbran.Utok);
            hracPenizeLabel.Text = hrac.Penize.ToString();
        }

        private void maxZivotPridatBtn_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maxZivotPridatBtn, String.Format("Cena vylepseni: " + hrac.CenaMaxZivotu.ToString() + "/bod"));
        }
    }
}
