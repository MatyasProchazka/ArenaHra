namespace ArenaHra
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Postava hrac = new Postava("Matyas", 10, 100);
            Postava protivnik = new Postava("Deges", 5, 150);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(hrac, protivnik));
        }
    }
}