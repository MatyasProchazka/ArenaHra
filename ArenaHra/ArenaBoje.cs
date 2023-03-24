using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArenaHra
{
    public partial class ArenaBoje : UserControl
    {
        private Hrac hrac;
        private Postava protivnik;
        private bool koloHrace = true;
        private bool poprve = true;

        public event EventHandler Finished;
        public ArenaBoje()
        {
            InitializeComponent();

        }


        private void PridatProtivnika()
        {
            protivnik = hrac.VygenerovatProtivnika();
            protivnikJmeno.Text = protivnik.Jmeno;
            protivnikZivot.Text = protivnik.Zivot().ToString();
            protivnikUbralLabel.Hide();
        }

        public void PridatHrace(Hrac hrac)
        {

            this.hrac = hrac;
            hracJmeno.Text = hrac.Jmeno;
            hracZivot.Text = hrac.Zivot().ToString();
            hracUbralLabel.Hide();
            PridatProtivnika();
        }

        private void utokBtn_Click(object sender, EventArgs e)
        {
            //BackgroundWorker backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true; //Report a progress
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork; //The scrape
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            if (poprve)
            {
                
            }
            poprve = false;
            utokBtn.Hide();
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (protivnik.Nazivu() && hrac.Nazivu())
            {
                Thread.Sleep(200);
                if (koloHrace)
                {
                    backgroundWorker1.ReportProgress(0);
                }
                else
                {
                    backgroundWorker1.ReportProgress(1);
                }
            }
        }

        

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
            {
                if (hrac.Nazivu())
                {
                    protivnikUbralLabel.Hide();
                    hracUbralLabel.Text = String.Format("-" + hrac.Utoc(protivnik).ToString());
                    hracUbralLabel.Show();
                    protivnikZivot.Text = protivnik.Zivot().ToString();
                    protivnikProgressBar.Value = protivnik.PodilZivotu();
                    koloHrace = false;
                }
                
            }
            else if (e.ProgressPercentage == 1)
            {
                if (protivnik.Nazivu())
                {
                    hracUbralLabel.Hide();
                    protivnikUbralLabel.Text = String.Format("-" + protivnik.Utoc(hrac).ToString());
                    protivnikUbralLabel.Show();
                    hracZivot.Text = hrac.Zivot().ToString();
                    hracProgressBar.Value = hrac.PodilZivotu();
                    koloHrace = true;
                }
                
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (hrac.Nazivu())
            {
                if (e.Cancelled)
                {
                    MessageBox.Show("kurva");
                    return;
                }
                else if (e.Error != null)
                {
                    MessageBox.Show("Kurva 2");
                }
                else {
                    MessageBox.Show("Vyhral jsi, vracis se do menu");
                    hrac.PocetKol += 1;
                    OnFinished();
                }
                
            }
            else if (protivnik.Nazivu())
            {
                MessageBox.Show("Prohral jsi, vracis se do menu");
                OnFinished();
            }
        }

       protected virtual void OnFinished()
        {
            UkoncovaciPriprava();
            Hide();

            if (Finished != null)
            {
                Finished(this, EventArgs.Empty);
            }
        }

        private void UkoncovaciPriprava()
        {
            protivnik = hrac.VygenerovatProtivnika();
            utokBtn.Show();
            hrac.Vylecit();
            protivnik.Vylecit();
            koloHrace = true;
            hracZivot.Text = hrac.Zivot().ToString();
            hracProgressBar.Value = 100;
            protivnikZivot.Text = protivnik.Zivot().ToString();
            protivnikJmeno.Text = protivnik.Jmeno;
            protivnikProgressBar.Value = 100;
            hracUbralLabel.Hide();
            protivnikUbralLabel.Hide();
            backgroundWorker1.ProgressChanged -= backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork -= backgroundWorker1_DoWork; //The scrape
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_RunWorkerCompleted;

        }


        public void UpdateStaty()
        {
            hracZivot.Text = hrac.MaxZivot.ToString();
        }
    }

    
}
