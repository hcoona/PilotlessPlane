using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Forms;
using BIT.PilotlessPlane.Models;
using BIT.PilotlessPlane.Providers.Interface;
using FrameValidator = BIT.PilotlessPlane.Models.Underlying.FrameValidator;
using System.Reactive.Disposables;
using System.Threading.Tasks;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class MainForm : Form
    {
        private readonly IFrameProvider provider;
        private IDisposable subscribe = null;
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
            var header0Array = new byte[] { FrameValidator.Header0 };

            var rawSource = provider.GetBytes().Publish();
            var bufferedSource = rawSource
                .Buffer(FrameValidator.FrameSize, 1)
                .Where(FrameValidator.ValidateHeader);
            var source = bufferedSource
                .Where(FrameValidator.Validate)
                .Select(x => FrameParser.ParseFrame(x.ToArray()));
            var invalidSource = bufferedSource.Where(x => !FrameValidator.Validate(x));

            this.subscribe = new CompositeDisposable(
                source.SubscribeOn(this).Subscribe(
                    this.BindFrame,
                    ex => this.LogException(ex),
                    () => { this.timer_UpdateUI.Stop(); MessageBox.Show(this, "Done."); }),
                invalidSource.Subscribe(
                    bytes => Console.WriteLine(string.Join(" ", bytes.Select(b => b.ToString("X2")))))
                );

            rawSource.Connect();
        }

        private void LogException(Exception ex)
        {
            throw new NotImplementedException();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.subscribe != null)
            {
                this.subscribe.Dispose();
            }
        }

        private void BindFrame(IReceivedFrame frame)
        {
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
            else
            {
                throw new ArgumentOutOfRangeException();
            }
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

            this.dashboardUserControl3.CurrentValue = frameB.GPS地速;

            this.directionDashboardUserControl1.d地速方向 = frameB.GPS地速方向;

            if (this.frameForm != null)
            {
                this.frameForm.BindFrameB(frameB);
            }
        }

        private void BindFrameC(FrameC frameC)
        {
            this.dashboardUserControl2.CurrentValue = frameC.z指示空速;

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
            this.Refresh();
            //this.gyroscopeUserControl1.Refresh();
            //this.dashboardUserControl1.Refresh();
            //this.dashboardUserControl2.Refresh();
            //this.dashboardUserControl3.Refresh();
            //this.directionDashboardUserControl1.Refresh();
        }
    }
}
