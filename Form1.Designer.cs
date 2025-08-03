namespace SerialMonitor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button settingsToggle;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Panel settingsPanel;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer serialTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            serialPort = new System.IO.Ports.SerialPort(components);
            serialTimer = new System.Windows.Forms.Timer(components);

            comboBoxPort = new ComboBox();
            comboBoxBaud = new ComboBox();
            comboBoxDataBits = new ComboBox();
            comboBoxStopBits = new ComboBox();
            comboBoxParity = new ComboBox();

            buttonConnect = new Button();
            buttonReset = new Button();
            settingsToggle = new Button();

            labelPort = new Label();
            labelBaud = new Label();
            labelDataBits = new Label();
            labelStopBits = new Label();
            labelParity = new Label();

            settingsPanel = new Panel();
            textBoxOutput = new TextBox();

            // Serial Port Setup
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Encoding = System.Text.Encoding.UTF8;
            serialPort.Handshake = System.IO.Ports.Handshake.None;
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.PortName = "COM1";

            // Port ComboBox
            comboBoxPort.Location = new Point(60, 17);
            comboBoxPort.Size = new Size(150, 28);

            // Baud ComboBox
            comboBoxBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            comboBoxBaud.Location = new Point(274, 17);
            comboBoxBaud.Size = new Size(166, 28);

            // Connect Button
            buttonConnect.Location = new Point(446, 15);
            buttonConnect.Size = new Size(150, 30);
            buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);

            // Reset Button
            buttonReset.Location = new Point(600, 15);
            buttonReset.Size = new Size(100, 30);
            buttonReset.Text = "Refresh";

            // Settings Toggle Button
            settingsToggle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            settingsToggle.Location = new Point(705, 12);
            settingsToggle.Size = new Size(40, 35);
            settingsToggle.Text = "☰";
            settingsToggle.UseVisualStyleBackColor = true;
            settingsToggle.Click += new EventHandler(settingsToggle_Click);

            // Labels
            labelPort.Location = new Point(20, 20);
            labelPort.Size = new Size(40, 23);
            labelPort.Text = "Port:";

            labelBaud.Location = new Point(213, 20);
            labelBaud.Size = new Size(50, 23);
            labelBaud.Text = "Baud:";

            labelDataBits.Location = new Point(10, 10);
            labelDataBits.Size = new Size(100, 23);
            labelDataBits.Text = "Data Bits:";

            labelStopBits.Location = new Point(10, 50);
            labelStopBits.Size = new Size(100, 23);
            labelStopBits.Text = "Stop Bits:";

            labelParity.Location = new Point(10, 90);
            labelParity.Size = new Size(100, 23);
            labelParity.Text = "Parity:";

            // Advanced Settings Panel
            comboBoxDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            comboBoxDataBits.Location = new Point(120, 10);
            comboBoxDataBits.Size = new Size(100, 28);

            comboBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            comboBoxStopBits.Location = new Point(120, 50);
            comboBoxStopBits.Size = new Size(100, 28);

            comboBoxParity.Items.AddRange(new object[] { "None", "Odd", "Even" });
            comboBoxParity.Location = new Point(120, 90);
            comboBoxParity.Size = new Size(100, 28);

            settingsPanel.Controls.Add(labelDataBits);
            settingsPanel.Controls.Add(comboBoxDataBits);
            settingsPanel.Controls.Add(labelStopBits);
            settingsPanel.Controls.Add(comboBoxStopBits);
            settingsPanel.Controls.Add(labelParity);
            settingsPanel.Controls.Add(comboBoxParity);
            settingsPanel.Location = new Point(12, 400);
            settingsPanel.Size = new Size(250, 130);
            settingsPanel.Visible = false;

            // Output TextBox
            textBoxOutput.Location = new Point(12, 60);
            textBoxOutput.Multiline = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(732, 320);

            // Form Setup
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 550);
            Controls.Add(labelPort);
            Controls.Add(comboBoxPort);
            Controls.Add(labelBaud);
            Controls.Add(comboBoxBaud);
            Controls.Add(buttonConnect);
            Controls.Add(buttonReset);
            Controls.Add(settingsToggle);
            Controls.Add(textBoxOutput);
            Controls.Add(settingsPanel);
            Name = "Form1";
            Text = "Serial Monitor";

            settingsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
