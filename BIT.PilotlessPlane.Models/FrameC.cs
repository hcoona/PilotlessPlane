using System.Collections.Specialized;
using System.Diagnostics.Contracts;
using UnderlyingFrameC = BIT.PilotlessPlane.Models.Underlying.FrameC;

namespace BIT.PilotlessPlane.Models
{
    public partial struct FrameC : IReceivedFrame
    {
        private static readonly BitVector32.Section z纵向模态Section = BitVector32.CreateSection(7);
        private static readonly BitVector32.Section h横向模态Section = BitVector32.CreateSection(7, z纵向模态Section);
        private static readonly BitVector32.Section d导航模态Section = BitVector32.CreateSection(3, h横向模态Section);
        
        private readonly BitVector32 m_f飞行模态;
        private readonly BitVector32 m_g故障标志字;
        private readonly BitVector32 m_k开关量标志字1;
        private readonly BitVector32 m_k开关量标志字2;
        private readonly double m_h航向偏差;
        private readonly byte m_h航段号;
        private readonly double m_d待飞距离;
        private readonly double m_c侧偏距;
        private readonly ushort m_q气压高度;
        private readonly double m_z指示空速;
        private readonly double m_z真空速;
        private readonly int m_g高度给定;
        private readonly double m_g高度差;
        private readonly int m_GPS时;
        private readonly int m_GPS分;
        private readonly int m_GPS秒;
        private readonly int m_z帧计数;

        public FrameC(UnderlyingFrameC obj)
        {
            Contract.Requires(obj.z帧头0 == 0xEB && obj.z帧头1 == 0x90, "帧头必须为 0xEB 0x90");
            Contract.Requires(obj.z帧属性 == 0x55, "帧属性必须为 0x55");
            Contract.Requires(obj.z帧特征字 == 'C', "帧特征字必须为 C");

            this.m_f飞行模态 = new BitVector32(obj.f飞行模态);
            this.m_g故障标志字 = new BitVector32(obj.g故障标志字);
            this.m_k开关量标志字1 = new BitVector32(obj.k开关量标志字1);
            this.m_k开关量标志字2 = new BitVector32(obj.k开关量标志字2);
            this.m_h航向偏差 = ByteOrderConverter.NetworkToHostOrder(obj.h航向偏差) / 10D;
            this.m_h航段号 = obj.h航段号;
            this.m_d待飞距离 = ByteOrderConverter.NetworkToHostOrder(obj.d待飞距离) / 10D;
            this.m_c侧偏距 = ByteOrderConverter.NetworkToHostOrder(obj.c侧偏距) / 10D;
            this.m_q气压高度 = ByteOrderConverter.NetworkToHostOrder(obj.q气压高度);
            this.m_z指示空速 = ByteOrderConverter.NetworkToHostOrder(obj.z指示空速) / 10D;
            this.m_z真空速 = ByteOrderConverter.NetworkToHostOrder(obj.z真空速) / 10D;
            this.m_g高度给定 = ByteOrderConverter.NetworkToHostOrder(obj.g高度给定);
            this.m_g高度差 = ByteOrderConverter.NetworkToHostOrder(obj.g高度差) / 10D;
            this.m_GPS时 = obj.GPS时;
            this.m_GPS分 = obj.GPS分;
            this.m_GPS秒 = obj.GPS秒;
            this.m_z帧计数 = obj.z帧计数;
        }

        public int z纵向模态 { get { return this.m_f飞行模态[FrameC.z纵向模态Section]; } }
        public int h横向模态 { get { return this.m_f飞行模态[FrameC.h横向模态Section]; } }
        public int d导航模态 { get { return this.m_f飞行模态[FrameC.d导航模态Section]; } }
        public BitVector32 g故障标志字 { get { return this.m_g故障标志字; } }
        public bool y遥控失灵 { get { return this.m_g故障标志字[BitVector32Masks.bit0]; } }
        public bool g惯导故障 { get { return this.m_g故障标志字[BitVector32Masks.bit1]; } }
        public bool GPS故障 { get { return this.m_g故障标志字[BitVector32Masks.bit2]; } }
        public bool d大气机故障 { get { return this.m_g故障标志字[BitVector32Masks.bit3]; } }
        public BitVector32 k开关量标志字1 { get { return this.m_k开关量标志字1; } }
        public bool f复位 { get { return this.m_k开关量标志字1[BitVector32Masks.bit0]; } }
        public bool q起飞 { get { return this.m_k开关量标志字1[BitVector32Masks.bit1]; } }
        public bool y预停车 { get { return this.m_k开关量标志字1[BitVector32Masks.bit2]; } }
        public bool t停车 { get { return this.m_k开关量标志字1[BitVector32Masks.bit3]; } }
        public bool h回收 { get { return this.m_k开关量标志字1[BitVector32Masks.bit4]; } }
        public BitVector32 k开关量标志字2 { get { return this.m_k开关量标志字2; } }
        public bool k空中 { get { return this.m_k开关量标志字2[BitVector32Masks.bit0]; } }
        public bool d导航 { get { return this.m_k开关量标志字2[BitVector32Masks.bit1]; } }
        public bool d点号切入 { get { return this.m_k开关量标志字2[BitVector32Masks.bit2]; } }
        public double h航向偏差 { get { return this.m_h航向偏差; } }
        public int h航段号 { get { return this.m_h航段号; } }
        public double d待飞距离 { get { return this.m_d待飞距离; } }
        public double c侧偏距 { get { return this.m_c侧偏距; } }
        public ushort q气压高度 { get { return this.m_q气压高度; } }
        public double z指示空速 { get { return this.m_z指示空速; } }
        public double z真空速 { get { return this.m_z真空速; } }
        public int g高度给定 { get { return this.m_g高度给定; } }
        public double g高度差 { get { return this.m_g高度差; } }
        public int GPS时 { get { return this.m_GPS时; } }
        public int GPS分 { get { return this.m_GPS分; } }
        public int GPS秒 { get { return this.m_GPS秒; } }
        public int z帧计数 { get { return this.m_z帧计数; } }
    }
}
