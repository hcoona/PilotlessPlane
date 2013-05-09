namespace BIT.PilotlessPlane.Client.Views
{
    partial class DashboardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DashboardUserControl
            // 
            this.BackgroundImage = global::BIT.PilotlessPlane.Client.Properties.Resources.仪表_12刻度;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "DashboardUserControl";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DashboardUserControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
