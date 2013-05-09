using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class DirectionDashboardUserControl : UserControl
    {
        public DirectionDashboardUserControl()
        {
            InitializeComponent();
        }

        public double k空速方向 { get; set; }
        public double d地速方向 { get; set; }

        private void DirectionDashboardUserControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(
                string.Format("空速方向 : {0:F1}", this.k空速方向),
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 5));
            e.Graphics.DrawString(
                string.Format("地速方向 : {0:F1}", this.d地速方向),
                Global.EnglishFont,
                Brushes.White,
                new PointF(5, 18));
        }
    }
}
