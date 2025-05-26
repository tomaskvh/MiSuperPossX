using System.Diagnostics;
using WinFormsApp1.Lib;
using WinFormsApp1.Modelo;

namespace WinFormsApp1
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

            DataManagment dm = new DataManagment();
            new logs("Aplicación Iniciada", true, 0);
            ApplicationConfiguration.Initialize();
            Application.Run(new PossMenu());
            
        }
    }
}