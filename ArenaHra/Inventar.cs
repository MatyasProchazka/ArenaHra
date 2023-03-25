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
    public partial class Inventar : UserControl
    {
        private Hrac hrac;
        private List<Zbran> inventar;
        public event EventHandler Finished;
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
            int index = listBox1.SelectedIndex;
            Zbran zbran = inventar[index];
            jmenoLabel.Text = String.Format("Jmeno: " + zbran.Jmeno);
            utokLabel.Text = String.Format("Utok: " + zbran.Utok.ToString());
            kritickaSanceLabel.Text = String.Format("Krit: " + zbran.KritickaSance.ToString());
            cenaLabel.Text = String.Format("Cena: " + zbran.Cena.ToString());

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
