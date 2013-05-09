using System;
using System.Windows.Forms;
using Autofac;
using BIT.PilotlessPlane.Client.Views;
using BIT.PilotlessPlane.Providers.Implement.Local;
using BIT.PilotlessPlane.Providers.Interface;

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

            IContainer container = BuildContainer();
            Application.Run(container.Resolve<MainForm>());
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LocalFrameProvider>().As<IFrameProvider>();
            builder.RegisterType<MainForm>();
            return builder.Build();
        }
    }
}
