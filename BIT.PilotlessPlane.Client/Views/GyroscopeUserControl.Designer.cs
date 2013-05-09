namespace BIT.PilotlessPlane.Client.Views
{
    partial class GyroscopeUserControl
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
            // GyroscopeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Margin = new System.Windows.Forms.Padding(48, 24, 48, 24);
            this.Name = "GyroscopeUserControl";
            this.Size = new System.Drawing.Size(480, 480);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GyroscopeUserControl_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
