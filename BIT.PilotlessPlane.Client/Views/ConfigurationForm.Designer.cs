namespace BIT.PilotlessPlane.Client.Views
{
    partial class ConfigurationForm
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox_SerialPort = new System.Windows.Forms.GroupBox();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_PortName = new System.Windows.Forms.ComboBox();
            this.button_Accept = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox_Local = new System.Windows.Forms.GroupBox();
            this.numericUpDown_LocalDelay = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox_SerialPort.SuspendLayout();
            this.groupBox_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LocalDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 122);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 12);
            label5.TabIndex = 9;
            label5.Text = "停止位：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 12);
            label4.TabIndex = 8;
            label4.Text = "数据位：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 70);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 12);
            label3.TabIndex = 5;
            label3.Text = "校验：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 12);
            label2.TabIndex = 2;
            label2.Text = "波特率：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 17);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 12);
            label1.TabIndex = 1;
            label1.Text = "串口：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(8, 17);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 12);
            label6.TabIndex = 0;
            label6.Text = "模拟延迟时间：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "本地测试数据";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "串口数据";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox_SerialPort
            // 
            this.groupBox_SerialPort.Controls.Add(label5);
            this.groupBox_SerialPort.Controls.Add(label4);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_StopBits);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_DataBits);
            this.groupBox_SerialPort.Controls.Add(label3);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_Parity);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_BaudRate);
            this.groupBox_SerialPort.Controls.Add(label2);
            this.groupBox_SerialPort.Controls.Add(label1);
            this.groupBox_SerialPort.Controls.Add(this.comboBox_PortName);
            this.groupBox_SerialPort.Enabled = false;
            this.groupBox_SerialPort.Location = new System.Drawing.Point(12, 106);
            this.groupBox_SerialPort.Name = "groupBox_SerialPort";
            this.groupBox_SerialPort.Size = new System.Drawing.Size(231, 150);
            this.groupBox_SerialPort.TabIndex = 2;
            this.groupBox_SerialPort.TabStop = false;
            this.groupBox_SerialPort.Text = "串口配置";
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Location = new System.Drawing.Point(96, 119);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 20);
            this.comboBox_StopBits.TabIndex = 7;
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Location = new System.Drawing.Point(96, 93);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(121, 20);
            this.comboBox_DataBits.TabIndex = 6;
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Location = new System.Drawing.Point(96, 67);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Parity.TabIndex = 4;
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Location = new System.Drawing.Point(96, 41);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 20);
            this.comboBox_BaudRate.TabIndex = 3;
            // 
            // comboBox_PortName
            // 
            this.comboBox_PortName.FormattingEnabled = true;
            this.comboBox_PortName.Location = new System.Drawing.Point(96, 14);
            this.comboBox_PortName.Name = "comboBox_PortName";
            this.comboBox_PortName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_PortName.TabIndex = 0;
            // 
            // button_Accept
            // 
            this.button_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Accept.Location = new System.Drawing.Point(168, 262);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(75, 23);
            this.button_Accept.TabIndex = 3;
            this.button_Accept.Text = "保存并启动";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.Location = new System.Drawing.Point(87, 262);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "退出";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // groupBox_Local
            // 
            this.groupBox_Local.Controls.Add(this.numericUpDown_LocalDelay);
            this.groupBox_Local.Controls.Add(label6);
            this.groupBox_Local.Location = new System.Drawing.Point(12, 34);
            this.groupBox_Local.Name = "groupBox_Local";
            this.groupBox_Local.Size = new System.Drawing.Size(231, 44);
            this.groupBox_Local.TabIndex = 5;
            this.groupBox_Local.TabStop = false;
            this.groupBox_Local.Text = "测试配置";
            // 
            // numericUpDown_LocalDelay
            // 
            this.numericUpDown_LocalDelay.Location = new System.Drawing.Point(96, 15);
            this.numericUpDown_LocalDelay.Name = "numericUpDown_LocalDelay";
            this.numericUpDown_LocalDelay.Size = new System.Drawing.Size(121, 21);
            this.numericUpDown_LocalDelay.TabIndex = 1;
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.button_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(258, 291);
            this.Controls.Add(this.groupBox_Local);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Accept);
            this.Controls.Add(this.groupBox_SerialPort);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "确认配置";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.groupBox_SerialPort.ResumeLayout(false);
            this.groupBox_SerialPort.PerformLayout();
            this.groupBox_Local.ResumeLayout(false);
            this.groupBox_Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LocalDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox_SerialPort;
        private System.Windows.Forms.ComboBox comboBox_PortName;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox_Local;
        private System.Windows.Forms.NumericUpDown numericUpDown_LocalDelay;
    }
}