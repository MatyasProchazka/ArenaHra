using System.Runtime.CompilerServices;

namespace ArenaHra
{
    public partial class MainForm : Form
    {
        private Hrac hrac;
        private Postava protivnik;
        

        public MainForm()
        {
            Zbran zbranHrac = new Zbran("Mec", 3, 15, 10);
            hrac = new Hrac("Matyas", 10, 100, 4, zbranHrac);
            InitializeComponent();
            arenaBoje.Hide();
            staty.Hide();
            inventar.Hide();
            arenaBoje.PridatHrace(hrac);
            staty.PridatHrace(hrac);
            inventar.PridatHrace(hrac);
            arenaBoje.Finished += OnFinished;
            staty.Finished += OnFinished;
            inventar.Finished += OnFinished;
            
        }

        private void arenaBtn_Click(object sender, EventArgs e)
        {
            arenaBoje.Show();
            arenaBoje.UpdateStaty();
            SchovatMenu();
        }

        private void statyBtn_Click(object sender, EventArgs e)
        {
            staty.Show();

            SchovatMenu();
        }

        private void inventarBtn_Click(object sender, EventArgs e)
        {
            inventar.Show();
            SchovatMenu();
        }

        private void odejitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SchovatMenu()
        {
            arenaBtn.Hide();
            statyBtn.Hide();
            inventarBtn.Hide();
            obchodBtn.Hide();
            odejitBtn.Hide();
        }

        private void UkazatMenu()
        {
            arenaBtn.Show();
            statyBtn.Show();
            inventarBtn.Show();
            obchodBtn.Show();
            odejitBtn.Show();
        }

        private void OnFinished(object sender, EventArgs e)
        {
            UkazatMenu();
        }

    }
}