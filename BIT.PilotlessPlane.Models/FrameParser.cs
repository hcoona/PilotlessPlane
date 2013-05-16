using System;
using System.IO;

namespace BIT.PilotlessPlane.Models
{
    public static class FrameParser
    {
        public static IReceivedFrame ParseFrame(byte[] buffer)
        {
            switch (Convert.ToChar(buffer[3]))
            {
                case 'A':
                    {
                        var frame = Underlying.ByteStructureConverter<Underlying.FrameA>.FromBytes(buffer);
                        return new FrameA(frame);
                    }
                case 'B':
                    {
                        var frame = Underlying.ByteStructureConverter<Underlying.FrameB>.FromBytes(buffer);
                        return new FrameB(frame);
                    }
                case 'C':
                    {
                        var frame = Underlying.ByteStructureConverter<Underlying.FrameC>.FromBytes(buffer);
                        return new FrameC(frame);
                    }
                default:
                    throw new InvalidDataException("Wrong Frame Character!");
            }
        }
    }
}
