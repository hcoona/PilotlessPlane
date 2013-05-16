using System.Collections.Generic;

namespace BIT.PilotlessPlane.Models.Underlying
{
    public static class FrameValidator
    {
        public static readonly byte Header0 = 0xEB;
        public static readonly byte Header1 = 0x90;
        public static readonly byte FrameCharacter = 0x55;
        public static int FrameSize { get { return Global.FrameSize; } }

        public static bool ValidateHeader(IList<byte> buffer)
        {
            return buffer.Count >= 2
                && buffer[0] == Header0
                && buffer[1] == Header1;
        }

        public static bool Validate(IList<byte> buffer)
        {
            return buffer.Count == FrameSize
                && buffer[0] == Header0
                && buffer[1] == Header1
                && buffer[2] == FrameCharacter
                && CheckSum(buffer);
        }

        private static bool CheckSum(IList<byte> buffer)
        {
            byte sum = 0;
            for (var i = 0; i < buffer.Count - 1; i++)
            {
                sum += buffer[i];
            }
            sum = (byte)(256 - sum % 256);
            return sum == buffer[buffer.Count - 1];
        }
    }
}
