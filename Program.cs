using Nike_Shop_Management.GUI;
using System;
using System.Windows.Forms;

namespace Nike_Shop_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagementForm());
        }

    }
}
