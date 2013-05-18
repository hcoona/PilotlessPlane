namespace BIT.PilotlessPlane.Client.Views
{
    partial class FrameForm
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
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.GroupBox groupBox_FrameA;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            this.textBox_FrameA = new System.Windows.Forms.TextBox();
            this.textBox_FrameB = new System.Windows.Forms.TextBox();
            this.textBox_FrameC = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupBox_FrameA = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1.SuspendLayout();
            groupBox_FrameA.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(groupBox_FrameA, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 2, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox_FrameA
            // 
            groupBox_FrameA.Controls.Add(this.textBox_FrameA);
            groupBox_FrameA.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox_FrameA.Location = new System.Drawing.Point(3, 3);
            groupBox_FrameA.Name = "groupBox_FrameA";
            groupBox_FrameA.Size = new System.Drawing.Size(260, 594);
            groupBox_FrameA.TabIndex = 0;
            groupBox_FrameA.TabStop = false;
            groupBox_FrameA.Text = "A帧";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.textBox_FrameB);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(269, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(260, 594);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "B帧";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(this.textBox_FrameC);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(535, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(262, 594);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "C帧";
            // 
            // textBox_FrameA
            // 
            this.textBox_FrameA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FrameA.Location = new System.Drawing.Point(3, 22);
            this.textBox_FrameA.Multiline = true;
            this.textBox_FrameA.Name = "textBox_FrameA";
            this.textBox_FrameA.ReadOnly = true;
            this.textBox_FrameA.Size = new System.Drawing.Size(254, 569);
            this.textBox_FrameA.TabIndex = 0;
            // 
            // textBox_FrameB
            // 
            this.textBox_FrameB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FrameB.Location = new System.Drawing.Point(3, 22);
            this.textBox_FrameB.Multiline = true;
            this.textBox_FrameB.Name = "textBox_FrameB";
            this.textBox_FrameB.ReadOnly = true;
            this.textBox_FrameB.Size = new System.Drawing.Size(254, 569);
            this.textBox_FrameB.TabIndex = 0;
            // 
            // textBox_FrameC
            // 
            this.textBox_FrameC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FrameC.Location = new System.Drawing.Point(3, 22);
            this.textBox_FrameC.Multiline = true;
            this.textBox_FrameC.Name = "textBox_FrameC";
            this.textBox_FrameC.ReadOnly = true;
            this.textBox_FrameC.Size = new System.Drawing.Size(256, 569);
            this.textBox_FrameC.TabIndex = 0;
            // 
            // FrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(tableLayoutPanel1);
            this.Font = new System.Drawing.Font("SimSun", 12F);
            this.Name = "FrameForm";
            this.Text = "FrameForm";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox_FrameA.ResumeLayout(false);
            groupBox_FrameA.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FrameA;
        private System.Windows.Forms.TextBox textBox_FrameB;
        private System.Windows.Forms.TextBox textBox_FrameC;
    }
}