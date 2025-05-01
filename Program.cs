namespace DBMS_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the login form first
            var loginForm = new Form3();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successfu, show the battle form
                Application.Run(new FormSearch());
            }
        }
    }
}