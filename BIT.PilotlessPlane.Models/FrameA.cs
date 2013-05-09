using System.Diagnostics.Contracts;
using System.Net;
using UnderlyingFrameA = BIT.PilotlessPlane.Models.Underlying.FrameA;

namespace BIT.PilotlessPlane.Models
{
    public partial struct FrameA
    {
        private readonly double m_f俯仰角;
        private readonly double m_f滚转角;
        private readonly double m_c磁航向;
        private readonly double m_g滚转角速率;
        private readonly double m_p偏航角速率;
        private readonly double m_f俯仰角速率;
        private readonly double m_X轴线加速度;
        private readonly double m_Y轴线加速度;
        private readonly double m_Z轴线加速度;
        private readonly double m_s升降舵量;
        private readonly double m_f副翼舵量;
        private readonly double m_f方向舵量;
        private readonly int m_y油门舵量;
        private readonly double m_s升降速度;
        private readonly double m_c超声波高度;
        private readonly int m_GPS时;
        private readonly int m_GPS分;
        private readonly int m_GPS秒;
        private readonly int m_z帧计数;

        public FrameA(UnderlyingFrameA obj) 
        {
            Contract.Requires(obj.z帧头0 == 0xEB && obj.z帧头1 == 0x90, "帧头必须为 0xEB 0x90");
            Contract.Requires(obj.z帧属性 == 0x55, "帧属性必须为 0x55");
            Contract.Requires(obj.z帧特征字 == 'A', "帧特征字必须为 A");

            this.m_f俯仰角 = ByteOrderConverter.NetworkToHostOrder(obj.f俯仰角) / 10D;
            this.m_f滚转角 = ByteOrderConverter.NetworkToHostOrder(obj.f滚转角) / 10D;
            this.m_c磁航向 = ByteOrderConverter.NetworkToHostOrder(obj.c磁航向) / 10D;
            this.m_g滚转角速率 = ByteOrderConverter.NetworkToHostOrder(obj.g滚转角速率) / 10D;
            this.m_p偏航角速率 = ByteOrderConverter.NetworkToHostOrder(obj.p偏航角速率) / 10D;
            this.m_f俯仰角速率 = ByteOrderConverter.NetworkToHostOrder(obj.f俯仰角速率) / 10D;
            this.m_X轴线加速度 = ByteOrderConverter.NetworkToHostOrder(obj.X轴线加速度) / 100D;
            this.m_Y轴线加速度 = ByteOrderConverter.NetworkToHostOrder(obj.Y轴线加速度) / 100D;
            this.m_Z轴线加速度 = ByteOrderConverter.NetworkToHostOrder(obj.Z轴线加速度) / 100D;
            this.m_s升降舵量 = ByteOrderConverter.NetworkToHostOrder(obj.s升降舵量) / 10D;
            this.m_f副翼舵量 = ByteOrderConverter.NetworkToHostOrder(obj.f副翼舵量) / 10D;
            this.m_f方向舵量 = ByteOrderConverter.NetworkToHostOrder(obj.f方向舵量) / 10D;
			this.m_y油门舵量 = obj.y油门舵量;
			this.m_s升降速度 = obj.s升降速度 / 10D;
			this.m_c超声波高度 = obj.c超声波高度 / 10D;
			this.m_GPS时 = obj.GPS时;
			this.m_GPS分 = obj.GPS分;
			this.m_GPS秒 = obj.GPS秒;
            this.m_z帧计数 = obj.z帧计数;
        }

        public double f俯仰角 { get { return this.m_f俯仰角; } }
        public double g滚转角 { get { return this.m_f滚转角; } }
        public double c磁航向 { get { return this.m_c磁航向; } }
        public double g滚转角速率 { get { return this.m_g滚转角速率; } }
        public double p偏航角速率 { get { return this.m_p偏航角速率; } }
        public double f俯仰角速率 { get { return this.m_f俯仰角速率; } }
        public double X轴线加速度 { get { return this.m_X轴线加速度; } }
        public double Y轴线加速度 { get { return this.m_Y轴线加速度; } }
        public double Z轴线加速度 { get { return this.m_Z轴线加速度; } }
        public double s升降舵量 { get { return this.m_s升降舵量; } }
        public double f副翼舵量 { get { return this.m_f副翼舵量; } }
        public double f方向舵量 { get { return this.m_f方向舵量; } }
        public int y油门舵量 { get { return this.m_y油门舵量; } }
        public double s升降速度 { get { return this.m_s升降速度; } }
        public double c超声波高度 { get { return this.m_c超声波高度; } }
        public int GPS时 { get { return this.m_GPS时; } }
        public int GPS分 { get { return this.m_GPS分; } }
        public int GPS秒 { get { return this.m_GPS秒; } }
        public int z帧计数 { get { return this.m_z帧计数; } }
    }
}
