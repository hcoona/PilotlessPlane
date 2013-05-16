using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Autofac;
using Autofac.Configuration;
using BIT.PilotlessPlane.Client.Views;
using BIT.PilotlessPlane.Providers.Implement.Local;
using BIT.PilotlessPlane.Providers.Interface;
using LocalDataResources = BIT.PilotlessPlane.Providers.Implement.Local.Properties.Resources;

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
            MessageBox.Show(((Exception)e.ExceptionObject).Message);
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder
                .Register<LocalFrameProvider>(ctx => new LocalFrameProvider("_20130510_txt", 7))
                .As<IFrameProvider>()
                .SingleInstance();
            builder.RegisterModule<ConfigurationSettingsReader>();
            return builder.Build();
        }
    }
}
