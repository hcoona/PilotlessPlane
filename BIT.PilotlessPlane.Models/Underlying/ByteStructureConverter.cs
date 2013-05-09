using System.Runtime.InteropServices;

namespace BIT.PilotlessPlane.Models.Underlying
{
    public static class ByteStructureConverter<T> where T : struct
    {
        public static byte[] ToBytes(T obj)
        {
            var size = Marshal.SizeOf(obj);
            var buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(obj, buffer, false);
                var results = new byte[size];
                Marshal.Copy(buffer, results, 0, size);
                return results;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        public static T FromBytes(byte[] data)
        {
            int size = Marshal.SizeOf(typeof(T));
            var buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(data, 0, buffer, size);
                return (T)Marshal.PtrToStructure(buffer, typeof(T));
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
