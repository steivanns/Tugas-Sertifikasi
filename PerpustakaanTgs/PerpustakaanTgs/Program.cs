using PerpustakaanTgs.Forms;

namespace PerpustakaanTgs
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
            // Application.Run(new FormBuku1());
            // Application.Run(new FormAnggota());
            // Application.Run(new FormPeminjaman());
            Application.Run(new FormPemilihan());
        }
    }
}