using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace ReceiveAndParse.Models
{
    internal static class BitVector32Masks
    {
        public static readonly int bit0;
        public static readonly int bit1;
        public static readonly int bit2;
        public static readonly int bit3;
        public static readonly int bit4;
        public static readonly int bit5;
        public static readonly int bit6;
        public static readonly int bit7;

        static BitVector32Masks()
        {
            bit0 = BitVector32.CreateMask();
            bit1 = BitVector32.CreateMask(bit0);
            bit2 = BitVector32.CreateMask(bit1);
            bit3 = BitVector32.CreateMask(bit2);
            bit4 = BitVector32.CreateMask(bit3);
            bit5 = BitVector32.CreateMask(bit4);
            bit6 = BitVector32.CreateMask(bit5);
            bit7 = BitVector32.CreateMask(bit6);
        }
    }
}
