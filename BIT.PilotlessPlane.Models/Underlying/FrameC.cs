// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;

namespace BIT.PilotlessPlane.Models.Underlying
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1 /* Not Zero! */, Size = Global.FrameSize)]
    public struct FrameC
    {
        public byte z帧头0;
        public byte z帧头1;
        public byte z帧属性;
        public char z帧特征字;
        public byte f飞行模态;
        public byte g故障标志字;
        public byte k开关量标志字1;
        public byte k开关量标志字2;
        public short h航向偏差;
        public byte h航段号;
        public short d待飞距离;
        public short c侧偏距;
        public ushort q气压高度;
        public ushort z指示空速;
        public ushort z真空速;
        public short g高度给定;
        public short g高度差;
        public byte b备用27;
        public byte b备用28;
        public byte b备用29;
        public byte b备用30;
        public byte GPS时;
        public byte GPS分;
        public byte GPS秒;
        public byte z帧计数;
        public byte j校验和;
    }
}
