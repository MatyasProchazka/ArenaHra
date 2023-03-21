using System.Runtime.CompilerServices;

namespace ArenaHra
{
    public partial class MainForm : Form
    {

        

        public MainForm(Postava hrac, Postava protivnik)
        {

            InitializeComponent();
            arenaBoje.Hide();
            arenaBoje.PridatPostavy(hrac, protivnik);
            arenaBoje.ZapasFinished += OnZapasFinished;
            
        }

        private void arenaBtn_Click(object sender, EventArgs e)
        {
            arenaBoje.Show();
            SchovatMenu();
        }

        private void SchovatMenu()
        {
            arenaBtn.Hide();

        }

        private void UkazatMenu()
        {
            arenaBtn.Show();
        }

        private void OnZapasFinished(object sender, EventArgs e)
        {
            UkazatMenu();
        }

        
    }
}