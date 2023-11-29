namespace Store
{
    internal static class Program
    {
        // Static variable that can be used through out the whole environment
        public static readonly Store store = new Store();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            store.Init();

            Application.Run(store.homePage);
        }
    }
}