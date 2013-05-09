using System;
using System.ComponentModel;
using BIT.PilotlessPlane.Providers.Implement.Local;
using BIT.PilotlessPlane.Providers.Interface;

namespace BIT.PilotlessPlane.Providers.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFrameProvider provider = new LocalFrameProvider();
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
