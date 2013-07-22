using System;
using System.Configuration;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using BIT.PilotlessPlane.Providers.Implement.Local;
using BIT.PilotlessPlane.Providers.Implement.SerialPort;
using LocalDataResources = BIT.PilotlessPlane.Providers.Implement.Local.Properties.Resources;

namespace BIT.PilotlessPlane.Client.Views
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            this.comboBox_PortName.DataSource = SerialPort.GetPortNames();
            this.comboBox_BaudRate.DataSource = new[] { 1200, 1800, 2400, 4800, 7200, 9600, 14400, 19200, 38400, 57600, 115200, 128000 };
            this.comboBox_Parity.DataSource = Enum.GetValues(typeof(Parity));
            this.comboBox_DataBits.DataSource = new[] { 4, 5, 6, 7, 8 };
            this.comboBox_StopBits.DataSource = Enum.GetValues(typeof(StopBits));

            LoadSettings();
        }

        private void LoadSettings()
        {
            this.UseLocal = Global.UseLocal;

            this.LocalDelay = Global.LocalDelay;

            if (SerialPort.GetPortNames().Contains(Global.PortName))
            {
                this.PortName = Global.PortName;
            }
            else
            {
                comboBox_PortName.SelectedIndex = 0;
            }
            this.BaudRate = Global.BaudRate;
            this.Parity = Global.Parity;
            this.DataBits = Global.DataBits;
            this.StopBits = Global.StopBits;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.UseLocal)
            {
                this.groupBox_Local.Enabled = true;
                this.groupBox_SerialPort.Enabled = false;
            }
            else
            {
                this.groupBox_Local.Enabled = false;
                this.groupBox_SerialPort.Enabled = true;
            }
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UseLocal"].Value = this.UseLocal.ToString(CultureInfo.InvariantCulture);
            config.AppSettings.Settings["LocalDelay"].Value = this.LocalDelay.ToString(CultureInfo.InvariantCulture);
            config.AppSettings.Settings["PortName"].Value = this.PortName;
            config.AppSettings.Settings["BaudRate"].Value = this.BaudRate.ToString(CultureInfo.InvariantCulture);
            config.AppSettings.Settings["Parity"].Value = this.Parity.ToString();
            config.AppSettings.Settings["DataBits"].Value = this.DataBits.ToString(CultureInfo.InvariantCulture);
            config.AppSettings.Settings["StopBits"].Value = this.StopBits.ToString();
            config.Save(ConfigurationSaveMode.Modified, true);

            Hide();
            BuildMainForm().ShowDialog();
            Application.Exit();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private MainForm BuildMainForm()
        {
            if (UseLocal)
            {
                return new MainForm(new LocalFrameProvider(LocalDataResources._20130510_txt));
            }
            else
            {
                return new MainForm(new SerialPortFrameProvider(
                    this.PortName,
                    this.BaudRate,
                    this.Parity,
                    this.DataBits,
                    this.StopBits));
            }
        }

        public bool UseLocal
        {
            get { return this.radioButton1.Checked; }
            set
            {
                if (value)
                {
                    this.radioButton1.Checked = true;
                }
                else
                {
                    this.radioButton2.Checked = true;
                }
            }
        }
        public int LocalDelay
        {
            get { return (int)this.numericUpDown_LocalDelay.Value; }
            set { this.numericUpDown_LocalDelay.Value = value; }
        }
        public string PortName
        {
            get { return (string)this.comboBox_PortName.SelectedItem; }
            set { this.comboBox_PortName.SelectedItem = value; }
        }
        public int BaudRate
        {
            get { return (int)this.comboBox_BaudRate.SelectedItem; }
            set { this.comboBox_BaudRate.SelectedItem = value; }
        }
        public Parity Parity
        {
            get { return (Parity)this.comboBox_Parity.SelectedItem; }
            set { this.comboBox_Parity.SelectedItem = value; }
        }
        public int DataBits
        {
            get { return (int)this.comboBox_DataBits.SelectedItem; }
            set { this.comboBox_DataBits.SelectedItem = value; }
        }
        public StopBits StopBits
        {
            get { return (StopBits)this.comboBox_StopBits.SelectedItem; }
            set { this.comboBox_StopBits.SelectedItem = value; }
        }
    }
}
