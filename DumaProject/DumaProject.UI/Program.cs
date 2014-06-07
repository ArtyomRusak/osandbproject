using System;
using System.Data.Entity;
using System.Windows.Forms;
using DumaProject.EFData.EFContext.Initializers;

namespace DumaProject.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new DumaInitializer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
