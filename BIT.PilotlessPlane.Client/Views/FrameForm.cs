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
            var sb = new StringBuilder();
            sb.AppendFormat("{0}：{1:F1}", "俯仰角", frame.f俯仰角).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "滚转角", frame.g滚转角).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "磁航向", frame.c磁航向).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "滚转角速率", frame.g滚转角速率).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "偏航角速率", frame.p偏航角速率).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "俯仰角速率", frame.f俯仰角速率).AppendLine();
            sb.AppendFormat("{0}：{1:F2}", "X轴线加速度", frame.X轴线加速度).AppendLine();
            sb.AppendFormat("{0}：{1:F2}", "Y轴线加速度", frame.Y轴线加速度).AppendLine();
            sb.AppendFormat("{0}：{1:F2}", "Z轴线加速度", frame.Z轴线加速度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "升降舵量", frame.s升降舵量).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "副翼舵量", frame.f副翼舵量).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "方向舵量", frame.f方向舵量).AppendLine();
            sb.AppendFormat("{0}：{1}", "油门舵量", frame.y油门舵量).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "升降速度", frame.s升降速度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "超声波高度", frame.c超声波高度).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS时", frame.GPS时).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS分", frame.GPS分).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS秒", frame.GPS秒).AppendLine();
            sb.AppendFormat("{0}：{1}", "z帧计数", frame.z帧计数).AppendLine();
            this.textBox_FrameA.Text = sb.ToString();
        }

        public void BindFrameB(FrameB frame)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}：{1:F7}", "GPS经度", frame.GPS经度).AppendLine();
            sb.AppendFormat("{0}：{1:F7}", "GPS维度", frame.GPS维度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS地速", frame.GPS地速).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS地速方向", frame.GPS地速方向).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS高度", frame.GPS高度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS升降速度", frame.GPS升降速度).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS可见星数", frame.GPS可见星数).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS工作状态", frame.GPS工作状态).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS东向速度", frame.GPS东向速度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "GPS北向速度", frame.GPS北向速度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "俯仰给定", frame.f俯仰给定).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "滚转给定", frame.g滚转给定).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "高度积分", frame.g高度积分).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "俯仰积分", frame.f俯仰积分).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "滚转积分", frame.f滚转积分).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS时", frame.GPS时).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS分", frame.GPS分).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS秒", frame.GPS秒).AppendLine();
            sb.AppendFormat("{0}：{1}", "z帧计数", frame.z帧计数).AppendLine();
            this.textBox_FrameB.Text = sb.ToString();
        }

        public void BindFrameC(FrameC frame)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0}：{1}", "纵向模态", frame.z纵向模态).AppendLine();
            sb.AppendFormat("{0}：{1}", "横向模态", frame.h横向模态).AppendLine();
            sb.AppendFormat("{0}：{1}", "导航模态", frame.d导航模态).AppendLine();
            sb.AppendFormat("{0}：{1}", "故障标志字", frame.g故障标志字).AppendLine();
            sb.AppendFormat("{0}：{1}", "开关量标志字1", frame.k开关量标志字1.ToString().Substring("BitVector32{".Length + 32 - 8, 8)).AppendLine();
            sb.AppendFormat("{0}：{1}", "开关量标志字2", frame.k开关量标志字2.ToString().Substring("BitVector32{".Length + 32 - 8, 8)).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "航向偏差", frame.h航向偏差).AppendLine();
            sb.AppendFormat("{0}：{1}", "航段号", frame.h航段号).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "待飞距离", frame.d待飞距离).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "侧偏距", frame.c侧偏距).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "气压高度", frame.q气压高度).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "指示空速", frame.z指示空速).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "真空速", frame.z真空速).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "高度给定", frame.g高度给定).AppendLine();
            sb.AppendFormat("{0}：{1:F1}", "高度差", frame.g高度差).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS时", frame.GPS时).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS分", frame.GPS分).AppendLine();
            sb.AppendFormat("{0}：{1}", "GPS秒", frame.GPS秒).AppendLine();
            sb.AppendFormat("{0}：{1}", "z帧计数", frame.z帧计数).AppendLine();
            this.textBox_FrameC.Text = sb.ToString();
        }
    }
}
