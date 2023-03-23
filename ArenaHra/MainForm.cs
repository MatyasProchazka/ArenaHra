using System.Runtime.CompilerServices;

namespace ArenaHra
{
    public partial class MainForm : Form
    {
        private Postava hrac;
        private Postava protivnik;
        

        public MainForm()
        {
            hrac = new Postava("Matyas", 10, 100);
            protivnik = new Postava("Deges", 5, 150);
            InitializeComponent();
            arenaBoje.Hide();
            staty.Hide();
            arenaBoje.PridatPostavy(hrac, protivnik);
            staty.PridatPostavu(hrac);
            arenaBoje.Finished += OnFinished;
            staty.Finished += OnFinished;
            
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