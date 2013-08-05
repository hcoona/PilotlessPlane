using System;
using System.Drawing;
using System.Windows.Forms;
using BIT.PilotlessPlane.Client.Properties;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class GyroscopeUserControl : UserControl
    {
        public GyroscopeUserControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public double f俯仰角 { get; set; }
        public double g滚转角 { get; set; }
        public double c磁航向 { get; set; }
        public double f俯仰角速率 { get; set; }
        public double g滚转角速率 { get; set; }
        public double p偏航角速率 { get; set; }
        public double GPS高度 { get; set; }

        private int ClientWidth { get { return this.ClientSize.Width; } }
        private int ClientHeight { get { return this.ClientSize.Height; } }

        private Point Center
        {
            get
            {
                return new Point(this.ClientWidth / 2, this.ClientHeight / 2);
            }
        }

        private void GyroscopeUserControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            e.Graphics.TranslateTransform(0F, (float)(this.f俯仰角 / 0.5));
            e.Graphics.RotateTransform(-(float)this.g滚转角);
            var t陀螺仪背景Rectangle = new Rectangle(
                -Convert.ToInt32((Resources.陀螺仪背景.Width - ClientWidth) / 2D),
                -Convert.ToInt32((Resources.陀螺仪背景.Height - ClientHeight) / 2D),
                Resources.陀螺仪背景.Width,
                Resources.陀螺仪背景.Height);
            e.Graphics.DrawImage(
                Resources.陀螺仪背景,
                t陀螺仪背景Rectangle);
            e.Graphics.ResetTransform();

            e.Graphics.DrawImage(Resources.陀螺仪框架, this.ClientRectangle);

            e.Graphics.TranslateTransform(this.Center.X, this.Center.Y);
            e.Graphics.RotateTransform(-(float)this.g滚转角);
            var t陀螺仪标度Rectangle = this.ClientRectangle;
            t陀螺仪标度Rectangle.Offset(-this.Center.X, -this.Center.Y);
            e.Graphics.DrawImage(Resources.陀螺仪标度, t陀螺仪标度Rectangle);
            e.Graphics.ResetTransform();

            e.Graphics.DrawString(
                string.Format("俯仰角 : {0:F1}", this.f俯仰角),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 5));
            e.Graphics.DrawString(
                string.Format("滚转角 : {0:F1}", this.g滚转角),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 18));
            e.Graphics.DrawString(
                string.Format("磁航向 : {0:F1}", this.c磁航向),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 31));
            e.Graphics.DrawString(
                string.Format("俯仰角速率 : {0:F1}", this.f俯仰角速率),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 44));
            e.Graphics.DrawString(
                string.Format("滚转角速率 : {0:F1}", this.g滚转角速率),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 57));
            e.Graphics.DrawString(
                string.Format("偏航角速率 : {0:F1}", this.p偏航角速率),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 70));
            e.Graphics.DrawString(
                string.Format("GPS高度：{0:F1}", this.GPS高度),
                Global.EnglishFont, Brushes.White,
                new PointF(5, 83));
        }
    }
}
