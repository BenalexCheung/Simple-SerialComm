namespace CSharp_simple_SerialComm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbSerialName = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rb16Send = new System.Windows.Forms.RadioButton();
            this.rbStrSend = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb16Rcv = new System.Windows.Forms.RadioButton();
            this.rbStrRcv = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTimeSend = new System.Windows.Forms.CheckBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbRcv = new System.Windows.Forms.TextBox();
            this.btnClearRcv = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSerialName
            // 
            this.cbSerialName.FormattingEnabled = true;
            this.cbSerialName.Location = new System.Drawing.Point(47, 46);
            this.cbSerialName.Name = "cbSerialName";
            this.cbSerialName.Size = new System.Drawing.Size(121, 26);
            this.cbSerialName.TabIndex = 0;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(47, 104);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 26);
            this.cbBaudRate.TabIndex = 0;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParity.Location = new System.Drawing.Point(47, 160);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 26);
            this.cbParity.TabIndex = 0;
            // 
            // cbStop
            // 
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStop.Location = new System.Drawing.Point(211, 104);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 26);
            this.cbStop.TabIndex = 0;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(211, 160);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 26);
            this.cbDataBits.TabIndex = 0;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(211, 46);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(121, 35);
            this.btnOpenSerial.TabIndex = 1;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rb16Send
            // 
            this.rb16Send.AutoSize = true;
            this.rb16Send.Location = new System.Drawing.Point(40, 27);
            this.rb16Send.Name = "rb16Send";
            this.rb16Send.Size = new System.Drawing.Size(60, 22);
            this.rb16Send.TabIndex = 2;
            this.rb16Send.TabStop = true;
            this.rb16Send.Text = "Hex";
            this.rb16Send.UseVisualStyleBackColor = true;
            // 
            // rbStrSend
            // 
            this.rbStrSend.AutoSize = true;
            this.rbStrSend.Location = new System.Drawing.Point(40, 75);
            this.rbStrSend.Name = "rbStrSend";
            this.rbStrSend.Size = new System.Drawing.Size(60, 22);
            this.rbStrSend.TabIndex = 2;
            this.rbStrSend.TabStop = true;
            this.rbStrSend.Text = "Str";
            this.rbStrSend.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStrSend);
            this.groupBox1.Controls.Add(this.rb16Send);
            this.groupBox1.Location = new System.Drawing.Point(47, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发送";
            // 
            // rb16Rcv
            // 
            this.rb16Rcv.AutoSize = true;
            this.rb16Rcv.Location = new System.Drawing.Point(24, 27);
            this.rb16Rcv.Name = "rb16Rcv";
            this.rb16Rcv.Size = new System.Drawing.Size(60, 22);
            this.rb16Rcv.TabIndex = 2;
            this.rb16Rcv.TabStop = true;
            this.rb16Rcv.Text = "Hex";
            this.rb16Rcv.UseVisualStyleBackColor = true;
            // 
            // rbStrRcv
            // 
            this.rbStrRcv.AutoSize = true;
            this.rbStrRcv.Location = new System.Drawing.Point(24, 75);
            this.rbStrRcv.Name = "rbStrRcv";
            this.rbStrRcv.Size = new System.Drawing.Size(60, 22);
            this.rbStrRcv.TabIndex = 2;
            this.rbStrRcv.TabStop = true;
            this.rbStrRcv.Text = "Str";
            this.rbStrRcv.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbStrRcv);
            this.groupBox2.Controls.Add(this.rb16Rcv);
            this.groupBox2.Location = new System.Drawing.Point(211, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收";
            // 
            // cbTimeSend
            // 
            this.cbTimeSend.AutoSize = true;
            this.cbTimeSend.Location = new System.Drawing.Point(62, 359);
            this.cbTimeSend.Name = "cbTimeSend";
            this.cbTimeSend.Size = new System.Drawing.Size(106, 22);
            this.cbTimeSend.TabIndex = 5;
            this.cbTimeSend.Text = "自动发送";
            this.cbTimeSend.UseVisualStyleBackColor = true;
            this.cbTimeSend.CheckedChanged += new System.EventHandler(this.cbTimeSend_CheckedChanged);
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(277, 353);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(55, 28);
            this.tbPeriod.TabIndex = 6;
            this.tbPeriod.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "周期(s):";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(32, 402);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(337, 102);
            this.tbSend.TabIndex = 8;
            this.tbSend.Text = "FE F1 A0 01 00 00 00 00 00 00 A1 FF";
            this.tbSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSend_KeyPress);
            // 
            // btnClearSend
            // 
            this.btnClearSend.Location = new System.Drawing.Point(47, 525);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(121, 35);
            this.btnClearSend.TabIndex = 1;
            this.btnClearSend.Text = "清空";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(211, 525);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbRcv
            // 
            this.tbRcv.Location = new System.Drawing.Point(397, 51);
            this.tbRcv.Multiline = true;
            this.tbRcv.Name = "tbRcv";
            this.tbRcv.ReadOnly = true;
            this.tbRcv.Size = new System.Drawing.Size(468, 453);
            this.tbRcv.TabIndex = 8;
            // 
            // btnClearRcv
            // 
            this.btnClearRcv.Location = new System.Drawing.Point(474, 525);
            this.btnClearRcv.Name = "btnClearRcv";
            this.btnClearRcv.Size = new System.Drawing.Size(121, 35);
            this.btnClearRcv.TabIndex = 1;
            this.btnClearRcv.Text = "清空";
            this.btnClearRcv.UseVisualStyleBackColor = true;
            this.btnClearRcv.Click += new System.EventHandler(this.btnClearRcv_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(638, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(965, 29);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(180, 24);
            this.toolStripStatusTime.Text = "toolStripStatusTime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 641);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbRcv);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPeriod);
            this.Controls.Add(this.cbTimeSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearRcv);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClearSend);
            this.Controls.Add(this.btnOpenSerial);
            this.Controls.Add(this.cbDataBits);
            this.Controls.Add(this.cbStop);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbSerialName);
            this.Name = "Form1";
            this.Text = "SeriralComm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerialName;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton rb16Send;
        private System.Windows.Forms.RadioButton rbStrSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb16Rcv;
        private System.Windows.Forms.RadioButton rbStrRcv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTimeSend;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbRcv;
        private System.Windows.Forms.Button btnClearRcv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
    }
}

