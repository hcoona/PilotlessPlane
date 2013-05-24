using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BIT.PilotlessPlane.Models;
using BIT.PilotlessPlane.Providers.Interface;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class MainForm : Form
    {
        private readonly IFrameProvider provider;
        private FrameForm frameForm = null;

        public MainForm(IFrameProvider provider)
            : this()
        {
            this.provider = provider;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var enumerator = provider.GetFrames();
            this.backgroundWorker_Binding.RunWorkerAsync(enumerator);
        }

        private void backgroundWorker_Binding_DoWork(object sender, DoWorkEventArgs e)
        {
            var enumerator = e.Argument as IEnumerator<object>;
            while (enumerator.MoveNext())
            {
                this.backgroundWorker_Binding.ReportProgress(0, enumerator.Current);
            }
            if(enumerator is IDisposable)
            {
                ((IDisposable)enumerator).Dispose();
            }
            this.timer_UpdateUI.Stop();
        }

        private void backgroundWorker_Binding_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frame = e.UserState;
            if (frame is FrameA)
            {
                BindFrameA((FrameA)frame);
            }
            else if (frame is FrameB)
            {
                BindFrameB((FrameB)frame);
            }
            else if (frame is FrameC)
            {
                BindFrameC((FrameC)frame);
            }
        }

        private void backgroundWorker_Binding_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, "Done.");
        }

        private void BindFrameA(FrameA frameA)
        {
            this.gyroscopeUserControl1.f俯仰角 = frameA.f俯仰角;
            this.gyroscopeUserControl1.f俯仰角速率 = frameA.f俯仰角速率;
            this.gyroscopeUserControl1.g滚转角 = frameA.g滚转角;
            this.gyroscopeUserControl1.g滚转角速率 = frameA.g滚转角速率;
            this.gyroscopeUserControl1.c磁航向 = frameA.c磁航向;
            this.gyroscopeUserControl1.p偏航角速率 = frameA.p偏航角速率;

            this.dashboardUserControl1.CurrentValue = frameA.y油门舵量 / 10D;

            this.directionDashboardUserControl1.k空速方向 = frameA.c磁航向;

            if (this.frameForm != null)
            {
                this.frameForm.BindFrameA(frameA);
            }
        }

        private void BindFrameB(FrameB frameB)
        {
            this.gyroscopeUserControl1.GPS高度 = frameB.GPS高度;

            this.dashboardUserControl2.CurrentValue = frameB.GPS高度;
            this.dashboardUserControl3.CurrentValue = frameB.GPS地速;

            this.directionDashboardUserControl1.d地速方向 = frameB.GPS地速方向;

            if (this.frameForm != null)
            {
                this.frameForm.BindFrameB(frameB);
            }
        }

        private void BindFrameC(FrameC frameC)
        {
            if (this.frameForm != null)
            {
                this.frameForm.BindFrameC(frameC);
            }
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (this.frameForm == null)
            {
                this.frameForm = new FrameForm();
                this.frameForm.FormClosed += delegate { this.frameForm = null; };
            }
            this.frameForm.Show(this);
        }

        private void timer_UpdateUI_Tick(object sender, EventArgs e)
        {
            this.gyroscopeUserControl1.Refresh();
            this.dashboardUserControl1.Refresh();
            this.dashboardUserControl2.Refresh();
            this.dashboardUserControl3.Refresh();
            this.directionDashboardUserControl1.Refresh();
        }
    }
}
