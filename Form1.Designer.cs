namespace SerialSense
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
            System.Text.ASCIIEncoding asciiEncodingSealed1 = new System.Text.ASCIIEncoding();
            System.Text.DecoderReplacementFallback decoderReplacementFallback1 = new System.Text.DecoderReplacementFallback();
            System.Text.EncoderReplacementFallback encoderReplacementFallback1 = new System.Text.EncoderReplacementFallback();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            settingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // serialPort
            // 
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.DiscardNull = false;
            serialPort.DtrEnable = false;
            serialPort.Handshake = System.IO.Ports.Handshake.None;
            serialPort.NewLine = "\n";
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.ParityReplace = 63;
            serialPort.PortName = "COM1";
            serialPort.ReadBufferSize = 4096;
            serialPort.ReadTimeout = -1;
            serialPort.ReceivedBytesThreshold = 1;
            serialPort.RtsEnable = false;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.WriteBufferSize = 2048;
            serialPort.WriteTimeout = -1;
            // 
            // comboBoxPort
            // 
            comboBoxPort.Location = new Point(60, 17);
            comboBoxPort.Name = "comboBoxPort";
            comboBoxPort.Size = new Size(150, 28);
            comboBoxPort.TabIndex = 1;
            // 
            // comboBoxBaud
            // 
            comboBoxBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            comboBoxBaud.Location = new Point(274, 17);
            comboBoxBaud.Name = "comboBoxBaud";
            comboBoxBaud.Size = new Size(166, 28);
            comboBoxBaud.TabIndex = 3;
            // 
            // comboBoxDataBits
            // 
            comboBoxDataBits.Items.AddRange(new object[] { "5", "6", "7", "8" });
            comboBoxDataBits.Location = new Point(120, 10);
            comboBoxDataBits.Name = "comboBoxDataBits";
            comboBoxDataBits.Size = new Size(100, 28);
            comboBoxDataBits.TabIndex = 1;
            // 
            // comboBoxStopBits
            // 
            comboBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            comboBoxStopBits.Location = new Point(120, 50);
            comboBoxStopBits.Name = "comboBoxStopBits";
            comboBoxStopBits.Size = new Size(100, 28);
            comboBoxStopBits.TabIndex = 3;
            // 
            // comboBoxParity
            // 
            comboBoxParity.Items.AddRange(new object[] { "None", "Odd", "Even" });
            comboBoxParity.Location = new Point(120, 90);
            comboBoxParity.Name = "comboBoxParity";
            comboBoxParity.Size = new Size(100, 28);
            comboBoxParity.TabIndex = 5;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(446, 15);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(150, 30);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "Connect";
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(600, 15);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(100, 30);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Refresh";
            buttonReset.Click += buttonReset_Click;
            // 
            // settingsToggle
            // 
            settingsToggle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            settingsToggle.Location = new Point(705, 12);
            settingsToggle.Name = "settingsToggle";
            settingsToggle.Size = new Size(40, 35);
            settingsToggle.TabIndex = 6;
            settingsToggle.Text = "☰";
            settingsToggle.UseVisualStyleBackColor = true;
            settingsToggle.Click += settingsToggle_Click;
            // 
            // labelPort
            // 
            labelPort.Location = new Point(20, 20);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(40, 23);
            labelPort.TabIndex = 0;
            labelPort.Text = "Port:";
            // 
            // labelBaud
            // 
            labelBaud.Location = new Point(213, 20);
            labelBaud.Name = "labelBaud";
            labelBaud.Size = new Size(50, 23);
            labelBaud.TabIndex = 2;
            labelBaud.Text = "Baud:";
            // 
            // labelDataBits
            // 
            labelDataBits.Location = new Point(10, 10);
            labelDataBits.Name = "labelDataBits";
            labelDataBits.Size = new Size(100, 23);
            labelDataBits.TabIndex = 0;
            labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            labelStopBits.Location = new Point(10, 50);
            labelStopBits.Name = "labelStopBits";
            labelStopBits.Size = new Size(100, 23);
            labelStopBits.TabIndex = 2;
            labelStopBits.Text = "Stop Bits:";
            // 
            // labelParity
            // 
            labelParity.Location = new Point(10, 90);
            labelParity.Name = "labelParity";
            labelParity.Size = new Size(100, 23);
            labelParity.TabIndex = 4;
            labelParity.Text = "Parity:";
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(labelDataBits);
            settingsPanel.Controls.Add(comboBoxDataBits);
            settingsPanel.Controls.Add(labelStopBits);
            settingsPanel.Controls.Add(comboBoxStopBits);
            settingsPanel.Controls.Add(labelParity);
            settingsPanel.Controls.Add(comboBoxParity);
            settingsPanel.Location = new Point(12, 400);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(250, 130);
            settingsPanel.TabIndex = 8;
            settingsPanel.Visible = false;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(12, 60);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(732, 320);
            textBoxOutput.TabIndex = 7;
            // 
            // Form1
            // 
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Serial Monitor";
            settingsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
