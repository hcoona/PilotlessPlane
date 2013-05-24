using System;
using System.Drawing;
using System.Windows.Forms;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class DashboardUserControl : UserControl
    {
        private static readonly double BigPhaseGap = Math.PI / 6D;
        private static readonly double SmallPhaseGap = BigPhaseGap / 10D;
        private static readonly double InitialPhase = BigPhaseGap * 4D;
        private double m_min = 0;
        private double m_max = 0;
        private double m_value = 0;
        private string m_unit = "请标明单位";
        private string m_title = "请标明标题";
        private string m_unitFormat = "R";
        private Pen m_pointerPen = new Pen(Color.Red);

        public DashboardUserControl()
        {
            InitializeComponent();
            this.Disposed += delegate { this.m_pointerPen.Dispose(); };
        }

        public double Min
        {
            get { return this.m_min; }
            set { this.m_min = value; }
        }

        public double Max
        {
            get { return this.m_max; }
            set { this.m_max = value; }
        }

        public double CurrentValue
        {
            get { return this.m_value; }
            set { this.m_value = value; }
        }

        public string Unit
        {
            get { return this.m_unit; }
            set { this.m_unit = value; }
        }

        public string UnitFormat
        {
            get { return this.m_unitFormat; }
            set { this.m_unitFormat = value; }
        }

        public string Title
        {
            get { return this.m_title; }
            set { this.m_title = value; }
        }

        public Color PointerColor
        {
            get { return this.m_pointerPen.Color; }
            set { this.m_pointerPen.Color = value; }
        }

        private Pen PointerPen
        {
            get { return this.m_pointerPen; }
        }

        private int ClientWidth { get { return this.ClientSize.Width; } }
        private int ClientHeight { get { return this.ClientSize.Height; } }

        private void DashboardUserControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float semiMajorAxis = this.ClientWidth / 2F;
            float semiMinorAxis = this.ClientHeight / 2F;
            e.Graphics.TranslateTransform(semiMajorAxis, semiMinorAxis);

            DrawTitle(e.Graphics, semiMinorAxis);
            DrawUnit(e.Graphics, semiMinorAxis);
            DrawScales(e.Graphics, semiMajorAxis, semiMinorAxis);
            DrawPointer(e.Graphics, semiMajorAxis, semiMinorAxis);
        }

        private static double GetScalesAxis(double fullAxis) { return fullAxis * 0.6 - 5; }

        private static PointF GetEllipsePoint(double xAxis, double yAxis, double phase)
        {
            return new PointF(
                Convert.ToSingle(xAxis * Math.Cos(phase)),
                Convert.ToSingle(yAxis * Math.Sin(phase))
            );
        }

        private void DrawTitle(Graphics g, float yAxis)
        {
            var size = g.MeasureString(this.Title, Global.SmallChineseFont);
            g.DrawString(
                this.Title,
                Global.SmallChineseFont,
                Brushes.White,
                -size.Width / 2F,
                Convert.ToSingle(yAxis * 0.7 - size.Height / 2D));
        }

        private void DrawUnit(Graphics g, float yAxis)
        {
            ;
        }

        private void DrawScales(Graphics g, double xAxis, double yAxis)
        {
            var scalesGap = (this.Max - this.Min) / 10D;
            for (var idx = 0; idx <= 10; idx++)
            {
                var phase = InitialPhase + BigPhaseGap * idx;

                var targetString = (this.Min + scalesGap * idx).ToString(this.UnitFormat);

                var targetStringSize = g.MeasureString(
                    targetString,
                    Global.SmallEnglishFont
                );

                var targetPoint = PointF.Subtract(
                    GetEllipsePoint(GetScalesAxis(xAxis), GetScalesAxis(yAxis), phase),
                    new SizeF(targetStringSize.Width / 2F, targetStringSize.Height / 2F));
                g.DrawString(
                    targetString,
                    Global.SmallEnglishFont,
                    Brushes.White,
                    targetPoint
                );
            }
        }

        private void DrawPointer(Graphics g, float xAxis, float yAxis)
        {
            var phase = InitialPhase + SmallPhaseGap * CurrentValue;
            var targetPoint = GetEllipsePoint(GetScalesAxis(xAxis), GetScalesAxis(yAxis), phase);

            g.DrawLine(this.PointerPen, PointF.Empty, targetPoint);
        }

        private void Debug(Graphics g)
        {
            g.DrawString(
                this.Title,
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 5));
            g.DrawString(
                string.Format("Min : {0} {1}", this.Min.ToString(this.UnitFormat), this.Unit),
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 18));
            g.DrawString(
                string.Format("Max : {0} {1}", this.Max.ToString(this.UnitFormat), this.Unit),
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 31));
            g.DrawString(
                string.Format("Value : {0} {1}", this.CurrentValue.ToString(this.UnitFormat), this.Unit),
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 44));
        }
    }
}
