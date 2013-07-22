using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using BIT.PilotlessPlane.Models.Underlying;
using BIT.PilotlessPlane.Providers.Interface;
using ZhangShuai.Extensions;
using IReceivedFrame = BIT.PilotlessPlane.Models.IReceivedFrame;

namespace BIT.PilotlessPlane.Providers.Implement.SerialPort
{
    public class SerialPortFrameProvider : IFrameProvider
    {
        private static readonly int FRAME_SIZE = 36;

        private readonly string PortName;
        private readonly int BaudRate;
        private readonly Parity Parity;
        private readonly int DataBits;
        private readonly StopBits StopBits;

        public SerialPortFrameProvider(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            this.PortName = portName;
            this.BaudRate = baudRate;
            this.Parity = parity;
            this.DataBits = dataBits;
            this.StopBits = stopBits;
        }

        public IEnumerator<IReceivedFrame> GetFrames()
        {
            bool lastestFailed = true;
            var e = this.GetBytes()
                .ToWindowed(FRAME_SIZE)
                .GetEnumerator();
            while (e.MoveNext())
            {
                var buffer = e.Current;
                if (FrameValidator.Validate(buffer))
                {
                    if (lastestFailed)
                    {
                        //Console.WriteLine("Finally Success:");
                        //Console.Write('\t');
                        //Console.WriteLine(ToHexString(buffer));
                        lastestFailed = false;
                    }
                    yield return Parse(buffer);
                    for (var i = 1; i < FRAME_SIZE; i++)
                    {
                        e.MoveNext();
                    }
                }
                else
                {
                    lastestFailed = true;
                    //Console.WriteLine("Drop data:");
                    //Console.Write('\t');
                    //Console.WriteLine(ToHexString(buffer));
                }
            }
        }

        private IEnumerable<byte> GetBytes()
        {
            using (var port = new global::System.IO.Ports.SerialPort(this.PortName, this.BaudRate, this.Parity, this.DataBits, this.StopBits))
            {
                port.Open();
                int b;
                while((b = port.ReadByte()) != -1)
                {
                    yield return (byte)b;
                }
            }            
        }

        private static IReceivedFrame Parse(byte[] buffer)
        {
            if (FrameValidator.Validate(buffer))
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
            else
            {
                HexPrint(buffer);
                throw new InvalidDataException("Wrong DATA!");
            }
        }

        private static string ToHexString(byte[] buffer)
        {
            return string.Join(" ", System.Linq.Enumerable.Select(buffer, b => b.ToString("X2")));
        }

        private static void HexPrint(byte[] buffer)
        {
            var hexBuffer = System.Linq.Enumerable.Select(buffer, b => b.ToString("X2"));
            Console.WriteLine(string.Join(" ", hexBuffer));
        }
    }
}
