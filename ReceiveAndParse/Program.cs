using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using ReceiveAndParse.Underlying;

namespace ReceiveAndParse
{
    class Program
    {
        private const int FRAME_SIZE = 36;

        static void Main(string[] args)
        {
            //using (var port = new SerialPort())
            //{
            //    port.Open();
            //    while (true)
            //    {
            //        var buffer = new byte[FRAME_SIZE];
            //        for (var offset = 0; offset < FRAME_SIZE; )
            //        {
            //            var nRead = port.Read(buffer, offset, FRAME_SIZE - offset);
            //            offset += nRead;
            //        }
            //        ParseAndPrint(buffer);
            //    }
            //}

            var data = File.ReadAllBytes(@"D:\Projects\PilotlessPlane\20130402 测试数据.bin");
            using (var ms = new MemoryStream(data))
            {
                var i = 0;
                while (true)
                {
                    var buffer = new byte[FRAME_SIZE];
                    for (var offset = 0; offset < FRAME_SIZE; )
                    {
                        var nRead = ms.Read(buffer, offset, FRAME_SIZE - offset);
                        if (nRead == 0)
                        {
                            return;
                        }
                        offset += nRead;
                    }
                    ParseAndPrint(buffer);
                    i++;
                    if (i == 6) break;
                }
            }
        }

        private static void ParseAndPrint(byte[] buffer)
        {
            if (buffer[0] == 0xEB && buffer[1] == 0x90 && buffer[2] == 0x55 && CheckSum(buffer))
            {
                switch (Convert.ToChar(buffer[3]))
                {
                    case 'A':
                        {
                            var frame = ByteStructureConverter<FrameA>.FromBytes(buffer);
                            var model = new Models.FrameA(frame);
                            GeneralPrint(model);
                            break;
                        }
                    case 'B':
                        {
                            var frame = ByteStructureConverter<FrameB>.FromBytes(buffer);
                            var model = new Models.FrameB(frame);
                            GeneralPrint(model);
                            break;
                        }
                    case 'C':
                        {
                            var frame = ByteStructureConverter<FrameC>.FromBytes(buffer);
                            var model = new Models.FrameC(frame);
                            GeneralPrint(model);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong Frame Character!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong DATA!");
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
