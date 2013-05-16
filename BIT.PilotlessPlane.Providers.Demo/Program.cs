using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Reactive.Linq;
using BIT.PilotlessPlane.Providers.Implement.Local;
//using BIT.PilotlessPlane.Providers.Implement.SerialPort;
using BIT.PilotlessPlane.Providers.Interface;
using BIT.PilotlessPlane.Models.Underlying;
using IReceivedFrame = BIT.PilotlessPlane.Models.IReceivedFrame;
using System.IO;
using System.Reactive.Disposables;

namespace BIT.PilotlessPlane.Providers.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFrameProvider provider;
            //provider = new SerialPortFrameProvider("COM1", 38400, Parity.None, 8, StopBits.One);
            provider = new LocalFrameProvider("_20130510_txt", 7);

            var rawSource = provider.GetBytes().Publish();
            var bufferedSource = rawSource.Buffer(
                rawSource.Buffer(2, 1).Where(bytes => FrameValidator.ValidateHeader(bytes)),
                _ => rawSource.Skip(FrameValidator.FrameSize - 2 - 1)).Select(tl => new byte[] { FrameValidator.Header0 }.Concat(tl).ToArray());
            var invalidSource = bufferedSource.Where(buffer => !FrameValidator.Validate(buffer));
            var source = (from buffer in bufferedSource
                          where FrameValidator.Validate(buffer)
                          select ParseFrame(buffer.ToArray())).Sample(TimeSpan.FromSeconds(1D / 30D));

            using (new CompositeDisposable(
                invalidSource.Subscribe(bytes => Console.WriteLine("Invalid Data: {0}", string.Join(" ", bytes.Select(b => b.ToString("X2"))))),
                source.Subscribe(
                    frame => GeneralPrint(frame),
                    ex => Console.WriteLine("\r\nException: {0}", ex.Message),
                    () => Console.WriteLine("Complete."))))
            {
                rawSource.Connect();
                Console.ReadLine();
            }
        }

        private static IReceivedFrame ParseFrame(byte[] buffer)
        {
            switch (Convert.ToChar(buffer[3]))
            {
                case 'A':
                    {
                        var frame = ByteStructureConverter<FrameA>.FromBytes(buffer);
                        return new Models.FrameA(frame);
                    }
                case 'B':
                    {
                        var frame = ByteStructureConverter<FrameB>.FromBytes(buffer);
                        return new Models.FrameB(frame);
                    }
                case 'C':
                    {
                        var frame = ByteStructureConverter<FrameC>.FromBytes(buffer);
                        return new Models.FrameC(frame);
                    }
                default:
                    throw new InvalidDataException("Wrong Frame Character!");
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
