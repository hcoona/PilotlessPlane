namespace BIT.PilotlessPlane.Models.Underlying
{
    public static class FrameValidator
    {
        public static bool Validate(byte[] buffer)
        {
            return buffer.Length == Global.FrameSize
                && buffer[0] == 0xEB
                && buffer[1] == 0x90
                && buffer[2] == 0x55
                && CheckSum(buffer);
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
