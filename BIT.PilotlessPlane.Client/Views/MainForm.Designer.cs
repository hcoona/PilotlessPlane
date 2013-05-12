namespace BIT.PilotlessPlane.Client.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gyroscopeUserControl1 = new BIT.PilotlessPlane.Client.Views.GyroscopeUserControl();
            this.dashboardUserControl1 = new BIT.PilotlessPlane.Client.Views.DashboardUserControl();
            this.dashboardUserControl2 = new BIT.PilotlessPlane.Client.Views.DashboardUserControl();
            this.dashboardUserControl3 = new BIT.PilotlessPlane.Client.Views.DashboardUserControl();
            this.directionDashboardUserControl1 = new BIT.PilotlessPlane.Client.Views.DirectionDashboardUserControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker_Binding = new System.ComponentModel.BackgroundWorker();
            this.timer_UpdateUI = new System.Windows.Forms.Timer(this.components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(this.gyroscopeUserControl1, 0, 0);
            tableLayoutPanel2.Controls.Add(this.dashboardUserControl1, 0, 4);
            tableLayoutPanel2.Controls.Add(this.dashboardUserControl2, 1, 4);
            tableLayoutPanel2.Controls.Add(this.dashboardUserControl3, 2, 4);
            tableLayoutPanel2.Controls.Add(this.directionDashboardUserControl1, 3, 4);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new System.Drawing.Size(480, 600);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // gyroscopeUserControl1
            // 
            tableLayoutPanel2.SetColumnSpan(this.gyroscopeUserControl1, 4);
            this.gyroscopeUserControl1.c磁航向 = 0D;
            this.gyroscopeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gyroscopeUserControl1.f俯仰角 = 0D;
            this.gyroscopeUserControl1.f俯仰角速率 = 0D;
            this.gyroscopeUserControl1.GPS高度 = 0D;
            this.gyroscopeUserControl1.g滚转角 = 0D;
            this.gyroscopeUserControl1.g滚转角速率 = 0D;
            this.gyroscopeUserControl1.Location = new System.Drawing.Point(0, 0);
            this.gyroscopeUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.gyroscopeUserControl1.Name = "gyroscopeUserControl1";
            this.gyroscopeUserControl1.p偏航角速率 = 0D;
            tableLayoutPanel2.SetRowSpan(this.gyroscopeUserControl1, 4);
            this.gyroscopeUserControl1.Size = new System.Drawing.Size(480, 480);
            this.gyroscopeUserControl1.TabIndex = 0;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardUserControl1.BackgroundImage")));
            this.dashboardUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardUserControl1.CurrentValue = 0D;
            this.dashboardUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 480);
            this.dashboardUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardUserControl1.Max = 10D;
            this.dashboardUserControl1.Min = 0D;
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.PointerColor = System.Drawing.Color.LightSkyBlue;
            this.dashboardUserControl1.Size = new System.Drawing.Size(120, 120);
            this.dashboardUserControl1.TabIndex = 1;
            this.dashboardUserControl1.Title = "油门";
            this.dashboardUserControl1.Unit = "";
            this.dashboardUserControl1.UnitFormat = "R";
            // 
            // dashboardUserControl2
            // 
            this.dashboardUserControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardUserControl2.BackgroundImage")));
            this.dashboardUserControl2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardUserControl2.CurrentValue = 0D;
            this.dashboardUserControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl2.Location = new System.Drawing.Point(120, 480);
            this.dashboardUserControl2.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardUserControl2.Max = 100D;
            this.dashboardUserControl2.Min = 0D;
            this.dashboardUserControl2.Name = "dashboardUserControl2";
            this.dashboardUserControl2.PointerColor = System.Drawing.Color.Green;
            this.dashboardUserControl2.Size = new System.Drawing.Size(120, 120);
            this.dashboardUserControl2.TabIndex = 2;
            this.dashboardUserControl2.Title = "空速";
            this.dashboardUserControl2.Unit = "km/h";
            this.dashboardUserControl2.UnitFormat = "R";
            // 
            // dashboardUserControl3
            // 
            this.dashboardUserControl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dashboardUserControl3.BackgroundImage")));
            this.dashboardUserControl3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboardUserControl3.CurrentValue = 0D;
            this.dashboardUserControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl3.Location = new System.Drawing.Point(240, 480);
            this.dashboardUserControl3.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardUserControl3.Max = 100D;
            this.dashboardUserControl3.Min = 0D;
            this.dashboardUserControl3.Name = "dashboardUserControl3";
            this.dashboardUserControl3.PointerColor = System.Drawing.Color.Red;
            this.dashboardUserControl3.Size = new System.Drawing.Size(120, 120);
            this.dashboardUserControl3.TabIndex = 3;
            this.dashboardUserControl3.Title = "地速";
            this.dashboardUserControl3.Unit = "km/h";
            this.dashboardUserControl3.UnitFormat = "R";
            // 
            // directionDashboardUserControl1
            // 
            this.directionDashboardUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("directionDashboardUserControl1.BackgroundImage")));
            this.directionDashboardUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.directionDashboardUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directionDashboardUserControl1.d地速方向 = 0D;
            this.directionDashboardUserControl1.k空速方向 = 0D;
            this.directionDashboardUserControl1.Location = new System.Drawing.Point(360, 480);
            this.directionDashboardUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.directionDashboardUserControl1.Name = "directionDashboardUserControl1";
            this.directionDashboardUserControl1.Size = new System.Drawing.Size(120, 120);
            this.directionDashboardUserControl1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BIT.PilotlessPlane.Client.Properties.Resources.地图区;
            this.pictureBox1.Location = new System.Drawing.Point(480, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BIT.PilotlessPlane.Client.Properties.Resources.指示灯区;
            this.pictureBox2.Location = new System.Drawing.Point(480, 360);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem1.Text = "查看帧";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // backgroundWorker_Binding
            // 
            this.backgroundWorker_Binding.WorkerReportsProgress = true;
            this.backgroundWorker_Binding.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_Binding_DoWork);
            this.backgroundWorker_Binding.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_Binding_ProgressChanged);
            this.backgroundWorker_Binding.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_Binding_RunWorkerCompleted);
            // 
            // timer_UpdateUI
            // 
            this.timer_UpdateUI.Enabled = true;
            this.timer_UpdateUI.Interval = 33;
            this.timer_UpdateUI.Tick += new System.EventHandler(this.timer_UpdateUI_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地面站";
            this.Load += new System.EventHandler(this.MainForm_Load);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GyroscopeUserControl gyroscopeUserControl1;
        private DashboardUserControl dashboardUserControl1;
        private DashboardUserControl dashboardUserControl2;
        private DashboardUserControl dashboardUserControl3;
        private DirectionDashboardUserControl directionDashboardUserControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_Binding;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer_UpdateUI;


    }
}

