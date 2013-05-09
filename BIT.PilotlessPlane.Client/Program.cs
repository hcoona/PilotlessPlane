using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BIT.PilotlessPlane.Client.Views;

namespace BIT.PilotlessPlane.Client
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
            Application.Run(new MainForm());
        }
    }
}
