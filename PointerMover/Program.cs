namespace CursorMover
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////localization code
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                // Pop an error message box
                var text = $"There was an error that caused the application to crash.\n\n{e}";
                MessageBox.Show(text, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}