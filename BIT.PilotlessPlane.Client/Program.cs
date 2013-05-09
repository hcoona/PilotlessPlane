using System;
using System.Windows.Forms;
using Autofac;
using Autofac.Configuration;
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

            var container = BuildContainer();
            Application.Run(container.Resolve<MainForm>());
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ConfigurationSettingsReader>();
            return builder.Build();
        }
    }
}
