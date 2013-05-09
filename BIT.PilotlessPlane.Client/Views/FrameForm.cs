using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BIT.PilotlessPlane.Models;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class FrameForm : Form
    {
        public FrameForm()
        {
            InitializeComponent();
        }

        public void BindFrameA(FrameA frame)
        {
            this.label_f俯仰角_value.Text = frame.f俯仰角.ToString("F1");
            this.label_f滚转角_value.Text = frame.g滚转角.ToString("F1");
            this.label_c磁航向_value.Text = frame.c磁航向.ToString("F1");
            this.label_g滚转角速率_value.Text = frame.g滚转角速率.ToString("F1");
            this.label_p偏航角速率_value.Text = frame.p偏航角速率.ToString("F1");
            this.label_f俯仰角速率_value.Text = frame.f俯仰角速率.ToString("F1");
            this.label_X轴线加速度_value.Text = frame.X轴线加速度.ToString("F2");
            this.label_Y轴线加速度_value.Text = frame.Y轴线加速度.ToString("F2");
            this.label_Z轴线加速度_value.Text = frame.Z轴线加速度.ToString("F2");
            this.label_s升降舵量_value.Text = frame.s升降舵量.ToString("F1");
            this.label_f副翼舵量_value.Text = frame.f副翼舵量.ToString("F1");
            this.label_f方向舵量_value.Text = frame.f方向舵量.ToString("F1");
            this.label_y油门舵量_value.Text = frame.y油门舵量.ToString();
            this.label_s升降速度_value.Text = frame.s升降速度.ToString("F1");
            this.label_c超声波高度_value.Text = frame.c超声波高度.ToString("F1");
            this.label_GPS时_value.Text = frame.GPS时.ToString();
            this.label_GPS分_value.Text = frame.GPS分.ToString();
            this.label_GPS秒_value.Text = frame.GPS秒.ToString();
            this.label_z帧计数_value.Text = frame.z帧计数.ToString();
        }

        public void BindFrameB(FrameB frame)
        {
            this.label_FrameB_GPS经度_value.Text = frame.GPS经度.ToString("F7");
            this.label_FrameB_GPS维度_value.Text = frame.GPS维度.ToString("F7");
            this.label_FrameB_GPS地速_value.Text = frame.GPS地速.ToString("F1");
            this.label_FrameB_GPS地速方向_value.Text = frame.GPS地速方向.ToString("F1");
            this.label_FrameB_GPS高度_value.Text = frame.GPS高度.ToString("F1");
            this.label_FrameB_GPS升降速度_value.Text = frame.GPS升降速度.ToString("F1");
            this.label_FrameB_GPS可见星数_value.Text = frame.GPS可见星数.ToString();
            this.label_FrameB_GPS工作状态_value.Text = frame.GPS工作状态.ToString();
            this.label_FrameB_GPS东向速度_value.Text = frame.GPS东向速度.ToString("F1");
            this.label_FrameB_GPS北向速度_value.Text = frame.GPS北向速度.ToString("F1");
            this.label_FrameB_f俯仰给定_value.Text = frame.f俯仰给定.ToString("F1");
            this.label_FrameB_g滚转给定_value.Text = frame.g滚转给定.ToString("F1");
            this.label_FrameB_g高度积分_value.Text = frame.g高度积分.ToString("F1");
            this.label_FrameB_f俯仰积分_value.Text = frame.f俯仰积分.ToString("F1");
            this.label_FrameB_f滚转积分_value.Text = frame.f滚转积分.ToString("F1");
            this.label_FrameB_GPS时_value.Text = frame.GPS时.ToString();
            this.label_FrameB_GPS分_value.Text = frame.GPS分.ToString();
            this.label_FrameB_GPS秒_value.Text = frame.GPS秒.ToString();
            this.label_FrameB_z帧计数_value.Text = frame.z帧计数.ToString();
        }

        public void BindFrameC(FrameC frame)
        {
            this.label_FrameC_z纵向模态_value.Text = frame.z纵向模态.ToString();
            this.label_FrameC_h横向模态_value.Text = frame.h横向模态.ToString();
            this.label_FrameC_d导航模态_value.Text = frame.d导航模态.ToString();
            this.label_FrameC_g故障标志字_value.Text = frame.g故障标志字.ToString().Substring("BitVector32{".Length + 32 - 8, 8);
            this.label_FrameC_k开关量标志字1_value.Text = frame.k开关量标志字1.ToString().Substring("BitVector32{".Length + 32 - 8, 8);
            this.label_FrameC_k开关量标志字2_value.Text = frame.k开关量标志字2.ToString().Substring("BitVector32{".Length + 32 - 8, 8);
            this.label_FrameC_h航向偏差_value.Text = frame.h航向偏差.ToString("F1");
            this.label_FrameC_h航段号_value.Text = frame.h航段号.ToString();
            this.label_FrameC_d待飞距离_value.Text = frame.d待飞距离.ToString("F1");
            this.label_FrameC_c侧偏距_value.Text = frame.c侧偏距.ToString("F1");
            this.label_FrameC_q气压高度_value.Text = frame.q气压高度.ToString("F1");
            this.label_FrameC_z指示空速_value.Text = frame.z指示空速.ToString("F1");
            this.label_FrameC_z真空速_value.Text = frame.z真空速.ToString("F1");
            this.label_FrameC_g高度给定_value.Text = frame.g高度给定.ToString();
            this.label_FrameC_g高度差_value.Text = frame.g高度差.ToString("F1");
            this.label_FrameC_GPS时_value.Text = frame.GPS时.ToString();
            this.label_FrameC_GPS分_value.Text = frame.GPS分.ToString();
            this.label_FrameC_GPS秒_value.Text = frame.GPS秒.ToString();
            this.label_FrameC_z帧计数_value.Text = frame.z帧计数.ToString();
        }
    }
}
