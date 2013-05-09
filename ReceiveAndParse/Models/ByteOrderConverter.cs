using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ReceiveAndParse.Models
{
    public static class ByteOrderConverter
    {
        public static short NetworkToHostOrder(short number)
        {
            return IPAddress.NetworkToHostOrder(number);
        }

        public static ushort NetworkToHostOrder(ushort number)
        {
            if (BitConverter.IsLittleEndian)
            {
                return DoByteOrderConvert(number);
            }
            else
            {
                return number;
            }
        }

        public static int NetworkToHostOrder(int number)
        {
            return IPAddress.NetworkToHostOrder(number);
        }

        public static short HostToNetworkOrder(short number)
        {
            return IPAddress.HostToNetworkOrder(number);
        }

        public static ushort HostToNetworkOrder(ushort number)
        {
            if(BitConverter.IsLittleEndian)
            {
                return DoByteOrderConvert(number);
            }
            else
            {
                return number;
            }
        }

        public static int HostToNetworkOrder(int number)
        {
            return IPAddress.HostToNetworkOrder(number);
        }

        private static ushort DoByteOrderConvert(ushort number)
        {
            var bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes);
            return BitConverter.ToUInt16(bytes, 0);
        }
    }
}
