using System;
using System.ComponentModel;
using System.IO.Ports;
using BIT.PilotlessPlane.Providers.Implement.Local;
using BIT.PilotlessPlane.Providers.Implement.SerialPort;
using BIT.PilotlessPlane.Providers.Interface;

namespace BIT.PilotlessPlane.Providers.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFrameProvider provider;
            provider = new SerialPortFrameProvider("COM1", 38400, Parity.None, 8, StopBits.One);
            provider = new LocalFrameProvider(Providers.Implement.Local.Properties.Resources._20130510_txt);
            var enumerator = provider.GetFrames();

            // Running in background threads.
            while(enumerator.MoveNext())
            {
                var frame = enumerator.Current;
                GeneralPrint(frame);
            }
        }

        private static void GeneralPrint(object obj)
        {
            Console.WriteLine("Type={0}", obj.GetType().Name);
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);
                Console.WriteLine("{0}={1}", name, value);
            }
            Console.WriteLine();
        }
    }
}
