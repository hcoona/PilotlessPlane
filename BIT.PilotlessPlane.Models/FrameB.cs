using System.Diagnostics.Contracts;
using System.Net;
using UnderlyingFrameB = BIT.PilotlessPlane.Models.Underlying.FrameB;

namespace BIT.PilotlessPlane.Models
{
    public partial struct FrameB
    {
        private readonly double m_GPS经度;
        private readonly double m_GPS维度;
        private readonly double m_GPS地速;
        private readonly double m_GPS地速方向;
        private readonly double m_GPS高度;
        private readonly double m_GPS升降速度;
        private readonly int m_GPS可见星数;
        private readonly int m_GPS工作状态;
        private readonly double m_GPS东向速度;
        private readonly double m_GPS北向速度;
        private readonly double m_f俯仰给定;
        private readonly double m_g滚转给定;
        private readonly double m_g高度积分;
        private readonly double m_f俯仰积分;
        private readonly double m_f滚转积分;
        private readonly int m_GPS时;
        private readonly int m_GPS分;
        private readonly int m_GPS秒;
        private readonly int m_z帧计数;

        public FrameB(UnderlyingFrameB obj)
        {
            Contract.Requires(obj.z帧头0 == 0xEB && obj.z帧头1 == 0x90, "帧头必须为 0xEB 0x90");
            Contract.Requires(obj.z帧属性 == 0x55, "帧属性必须为 0x55");
            Contract.Requires(obj.z帧特征字 == 'B', "帧特征字必须为 B");

            this.m_GPS经度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS经度) / 1E7D;
            this.m_GPS维度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS维度) / 1E7D;
			this.m_GPS地速 = obj.GPS地速 / 5D;
            this.m_GPS地速方向 = ByteOrderConverter.NetworkToHostOrder(obj.GPS地速方向) / 10D;
            this.m_GPS高度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS高度) / 10D;
            this.m_GPS升降速度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS升降速度) / 10D;
			this.m_GPS可见星数 = obj.GPS可见星数;
			this.m_GPS工作状态 = obj.GPS工作状态;
            this.m_GPS东向速度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS东向速度) / 10D;
            this.m_GPS北向速度 = ByteOrderConverter.NetworkToHostOrder(obj.GPS北向速度) / 10D;
			this.m_f俯仰给定 = obj.f俯仰给定 / 5D;
			this.m_g滚转给定 = obj.g滚转给定 / 5D;
			this.m_g高度积分 = obj.g高度积分 / 10D;
			this.m_f俯仰积分 = obj.f俯仰积分 / 10D;
			this.m_f滚转积分 = obj.f滚转积分 / 10D;
			this.m_GPS时 = obj.GPS时;
			this.m_GPS分 = obj.GPS分;
			this.m_GPS秒 = obj.GPS秒;
			this.m_z帧计数 = obj.z帧计数;
        }

        public double GPS经度 { get { return this.m_GPS经度; } }
        public double GPS维度 { get { return this.m_GPS维度; } }
        public double GPS地速 { get { return this.m_GPS地速; } }
        public double GPS地速方向 { get { return this.m_GPS地速方向; } }
        public double GPS高度 { get { return this.m_GPS高度; } }
        public double GPS升降速度 { get { return this.m_GPS升降速度; } }
        public int GPS可见星数 { get { return this.m_GPS可见星数; } }
        public int GPS工作状态 { get { return this.m_GPS工作状态; } }
        public double GPS东向速度 { get { return this.m_GPS东向速度; } }
        public double GPS北向速度 { get { return this.m_GPS北向速度; } }
        public double f俯仰给定 { get { return this.m_f俯仰给定; } }
        public double g滚转给定 { get { return this.m_g滚转给定; } }
        public double g高度积分 { get { return this.m_g高度积分; } }
        public double f俯仰积分 { get { return this.m_f俯仰积分; } }
        public double f滚转积分 { get { return this.m_f滚转积分; } }
        public int GPS时 { get { return this.m_GPS时; } }
        public int GPS分 { get { return this.m_GPS分; } }
        public int GPS秒 { get { return this.m_GPS秒; } }
        public int z帧计数 { get { return this.m_z帧计数; } }
    }
}
