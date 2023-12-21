namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            CheckUser user = new CheckUser("admin", true);
            //ярпнйс бхье онрп╡амн асде бхдюкхрх!!!!!!!!!!!!!!!!!!!!!!!
            Application.Run(new Main_Form(user));
        }
    }
}