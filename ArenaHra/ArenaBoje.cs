using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArenaHra
{
    public partial class ArenaBoje : UserControl
    {
        private Postava hrac;
        private Postava protivnik;
        private bool koloHrace = true;
        private bool hotovo = false;

        public event EventHandler ZapasFinished;
        public ArenaBoje()
        {
            InitializeComponent();
            
        }


        public void PridatPostavy(Postava hrac, Postava protivnik)
        {
            this.hrac = hrac;
            this.protivnik = protivnik;
            hracJmeno.Text = hrac.Jmeno;
            hracZivot.Text = hrac.Zivot().ToString();
            protivnikJmeno.Text = protivnik.Jmeno;
            protivnikZivot.Text = protivnik.Zivot().ToString();

            //Arena arena = new Arena(hrac, protivnik);
        }

        private void utokBtn_Click(object sender, EventArgs e)
        {
            //BackgroundWorker backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true; //Report a progress
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork; //The scrape
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

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
                hrac.Utoc(protivnik);
                protivnikZivot.Text = protivnik.Zivot().ToString();
                protivnikProgressBar.Value = protivnik.PodilZivotu();
                koloHrace = false;
            }
            else if (e.ProgressPercentage == 1)
            {
                protivnik.Utoc(hrac);
                hracZivot.Text = hrac.Zivot().ToString();
                hracProgressBar.Value = hrac.PodilZivotu();
                koloHrace = true;
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
                    MessageBox.Show("Vyhra");
                    OnZapasFinished();
                }
                
            }
        }

       protected virtual void OnZapasFinished()
        {
            MessageBox.Show("vracis se zpatky do menu");
            utokBtn.Show();
            hrac.Vylecit();
            protivnik.Vylecit();
            koloHrace = true;
            hracZivot.Text = hrac.Zivot().ToString();
            hracProgressBar.Value = 100;
            protivnikZivot.Text = protivnik.Zivot().ToString();
            protivnikProgressBar.Value = 100;
            backgroundWorker1.ProgressChanged -= backgroundWorker1_ProgressChanged;
            backgroundWorker1.DoWork -= backgroundWorker1_DoWork; //The scrape
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_RunWorkerCompleted;
            Hide();
            
            if (ZapasFinished != null)
            {
                ZapasFinished(this, EventArgs.Empty);
            }
        }


    }
}
