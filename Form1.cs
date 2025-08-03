using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        //private SerialPort serialPort;
        //private System.Windows.Forms.Timer serialTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeSerialMonitor();
        }

        private void InitializeSerialMonitor()
        {
            // Populate available serial ports
            RefreshPortList();

            // Baud rates
            comboBoxBaud.SelectedItem = "115200";

            // Data bits
            comboBoxDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            comboBoxDataBits.SelectedItem = "8";

            // Stop bits and Parity
            comboBoxStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboBoxStopBits.SelectedItem = StopBits.One.ToString();

            comboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBoxParity.SelectedItem = Parity.None.ToString();

            settingsPanel.Visible = false;

            // Timer setup
            serialTimer = new System.Windows.Forms.Timer
            {
                Interval = 100
            };
            serialTimer.Tick += SerialTimer_Tick;
        }

        private void RefreshPortList()
        {
            comboBoxPort.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(ports);
            if (ports.Length > 0)
                comboBoxPort.SelectedIndex = 0;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                try
                {
                    serialPort = new SerialPort
                    {
                        PortName = comboBoxPort.Text,
                        BaudRate = int.Parse(comboBoxBaud.Text),
                        DataBits = int.Parse(comboBoxDataBits.Text),
                        StopBits = Enum.Parse<StopBits>(comboBoxStopBits.Text),
                        Parity = Enum.Parse<Parity>(comboBoxParity.Text),
                        Handshake = Handshake.None,
                        Encoding = Encoding.UTF8,
                        ReadTimeout = 500,
                        WriteTimeout = 500
                    };

                    serialPort.Open();
                    serialTimer.Start();

                    SetUIConnected(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening port:\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DisconnectSerialPort();
            }
        }

        private void DisconnectSerialPort()
        {
            try
            {
                serialTimer.Stop();
                serialPort.Close();
                serialPort.Dispose();
                serialPort = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error closing port:\n{ex.Message}", "Disconnection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            SetUIConnected(false);
        }

        private void SetUIConnected(bool connected)
        {
            buttonConnect.Text = connected ? "Disconnect" : "Connect";
            comboBoxPort.Enabled = !connected;
            comboBoxBaud.Enabled = !connected;
            settingsToggle.Enabled = !connected;
        }

        private void SerialTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort?.IsOpen == true)
            {
                try
                {
                    string data = serialPort.ReadExisting();
                    if (!string.IsNullOrEmpty(data))
                        textBoxOutput.AppendText(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Serial read error:\n{ex.Message}", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void settingsToggle_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }
    }
}
