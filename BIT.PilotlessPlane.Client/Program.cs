using System;
using System.Windows.Forms;
using Autofac;
using Autofac.Configuration;
using BIT.PilotlessPlane.Client.Views;
using System.Diagnostics;
using System.Threading;

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

            if (!Debugger.IsAttached)
            {
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                Application.ThreadException += Application_ThreadException;
            }

            IContainer container = null;
            try
            {
                container = BuildContainer();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Application.Run(container.Resolve<MainForm>());
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Exception", ((Exception)e.ExceptionObject).Message);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Exception", e.Exception.Message);
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<ConfigurationSettingsReader>();
            return builder.Build();
        }
    }
}
