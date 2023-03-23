using System;
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
        private Postava hrac;
        public event EventHandler Finished;
        public Staty()
        {
            InitializeComponent();
        }

        public void PridatPostavu(Postava hrac)
        {
            if (hrac != null)
            {
                this.hrac = hrac;
                hracJmenoLabel.Text = hrac.Jmeno;
                hracUtokLabel.Text = hrac.Utok.ToString();
                hracMaxZivotyLabel.Text = hrac.MaxZivot.ToString();
                hracPenizeLabel.Text = hrac.Penize.ToString();
            }
        }

        private void utokPridaniBtn_Click(object sender, EventArgs e)
        {
            hrac.PridatUtok();
            hracUtokLabel.Text = hrac.Utok.ToString();
        }

        private void maxZivotPridatBtn_Click(object sender, EventArgs e)
        {
            hrac.PridatMaxZivoty();
            hracMaxZivotyLabel.Text = hrac.MaxZivot.ToString();
        }

        private void penizePridatBtn_Click(object sender, EventArgs e)
        {
            hrac.PridatPenize();
            hracPenizeLabel.Text = hrac.Penize.ToString();
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

    }
}
