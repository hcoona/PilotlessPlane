using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using BIT.PilotlessPlane.Models.Underlying;
using BIT.PilotlessPlane.Providers.Interface;

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

        public IEnumerator<object> GetFrames()
        {
            using (var port = new global::System.IO.Ports.SerialPort(this.PortName, this.BaudRate, this.Parity, this.DataBits, this.StopBits))
            {
                port.Open();
                while (true)
                {
                    var buffer = new byte[FRAME_SIZE];
                    for (var offset = 0; offset < FRAME_SIZE; )
                    {
                        var nRead = port.Read(buffer, offset, FRAME_SIZE - offset);
                        if (nRead == 0)
                        {
                            yield break;
                        }
                        offset += nRead;
                    }
                    yield return Parse(buffer);
                }
            }
        }

        private static object Parse(byte[] buffer)
        {
            if (buffer[0] == 0xEB && buffer[1] == 0x90 && buffer[2] == 0x55 && CheckSum(buffer))
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

        private static void HexPrint(byte[] buffer)
        {
            var hexBuffer = System.Linq.Enumerable.Select(buffer, b => b.ToString("X2"));
            Console.WriteLine(string.Join(" ", hexBuffer));
        }

        private static bool CheckSum(byte[] buffer)
        {
            byte sum = 0;
            for (var i = 0; i < buffer.Length - 1; i++)
            {
                sum += buffer[i];
            }
            sum = (byte)(256 - sum % 256);
            return sum == buffer[buffer.Length - 1];
        }
    }
}
