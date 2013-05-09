using System;
using System.Collections.Generic;
using System.IO;
using BIT.PilotlessPlane.Providers.Implement.Local.Properties;
using BIT.PilotlessPlane.Providers.Interface;
using BIT.PilotlessPlane.Models.Underlying;

namespace BIT.PilotlessPlane.Providers.Implement.Local
{
    public class LocalFrameProvider : IFrameProvider
    {
        private static readonly int FRAME_SIZE = 36;

        public IEnumerator<object> GetFrames()
        {
            using (var ms = new MemoryStream(Resources._20130402_测试数据))
            {
                while (true)
                {
                    var buffer = new byte[FRAME_SIZE];
                    for (var offset = 0; offset < FRAME_SIZE; )
                    {
                        var nRead = ms.Read(buffer, offset, FRAME_SIZE - offset);
                        if (nRead == 0)
                        {
                            yield break;
                        }
                        offset += nRead;
                    }
                    yield return Parse(buffer);
                    System.Threading.Thread.Sleep(50);
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
                throw new InvalidDataException("Wrong DATA!");
            }
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
