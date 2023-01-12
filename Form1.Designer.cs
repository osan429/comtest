namespace comtest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ch_CRLF = new System.Windows.Forms.CheckBox();
            this.cb_stopbits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_databits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_cycleCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_config = new System.Windows.Forms.TextBox();
            this.bt_config = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.tb_testCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ch_CRLF);
            this.groupBox1.Controls.Add(this.cb_stopbits);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_databits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_parity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_baudrate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionSetting";
            // 
            // ch_CRLF
            // 
            this.ch_CRLF.AutoSize = true;
            this.ch_CRLF.Checked = true;
            this.ch_CRLF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_CRLF.Location = new System.Drawing.Point(96, 319);
            this.ch_CRLF.Name = "ch_CRLF";
            this.ch_CRLF.Size = new System.Drawing.Size(85, 22);
            this.ch_CRLF.TabIndex = 8;
            this.ch_CRLF.Text = "CR+LF";
            this.ch_CRLF.UseVisualStyleBackColor = true;
            // 
            // cb_stopbits
            // 
            this.cb_stopbits.FormattingEnabled = true;
            this.cb_stopbits.Location = new System.Drawing.Point(96, 235);
            this.cb_stopbits.Name = "cb_stopbits";
            this.cb_stopbits.Size = new System.Drawing.Size(121, 26);
            this.cb_stopbits.TabIndex = 1;
            this.cb_stopbits.Text = "1";
            this.cb_stopbits.DropDown += new System.EventHandler(this.cb_stopbits_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "StopBits";
            // 
            // cb_databits
            // 
            this.cb_databits.FormattingEnabled = true;
            this.cb_databits.Location = new System.Drawing.Point(96, 184);
            this.cb_databits.Name = "cb_databits";
            this.cb_databits.Size = new System.Drawing.Size(121, 26);
            this.cb_databits.TabIndex = 1;
            this.cb_databits.Text = "7";
            this.cb_databits.DropDown += new System.EventHandler(this.cb_databits_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "DataBits";
            // 
            // cb_parity
            // 
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(96, 136);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(121, 26);
            this.cb_parity.TabIndex = 1;
            this.cb_parity.Text = "Even";
            this.cb_parity.DropDown += new System.EventHandler(this.cb_parity_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(96, 47);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(121, 26);
            this.cb_port.TabIndex = 1;
            this.cb_port.Text = "COM5";
            this.cb_port.DropDown += new System.EventHandler(this.comboBox_port_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate";
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Location = new System.Drawing.Point(96, 86);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(124, 26);
            this.cb_baudrate.TabIndex = 0;
            this.cb_baudrate.Text = "9600";
            this.cb_baudrate.DropDown += new System.EventHandler(this.cb_baudrate_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tb_cycleCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_config);
            this.groupBox2.Controls.Add(this.bt_config);
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.button_disconnect);
            this.groupBox2.Controls.Add(this.button_connect);
            this.groupBox2.Controls.Add(this.tb_testCycle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(226, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TestSetting";
            // 
            // tb_cycleCount
            // 
            this.tb_cycleCount.Enabled = false;
            this.tb_cycleCount.Location = new System.Drawing.Point(134, 125);
            this.tb_cycleCount.Name = "tb_cycleCount";
            this.tb_cycleCount.Size = new System.Drawing.Size(133, 29);
            this.tb_cycleCount.TabIndex = 11;
            this.tb_cycleCount.TabStop = false;
            this.tb_cycleCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cycle count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Config File";
            // 
            // tb_config
            // 
            this.tb_config.Location = new System.Drawing.Point(134, 28);
            this.tb_config.Name = "tb_config";
            this.tb_config.Size = new System.Drawing.Size(243, 29);
            this.tb_config.TabIndex = 8;
            // 
            // bt_config
            // 
            this.bt_config.Location = new System.Drawing.Point(396, 26);
            this.bt_config.Name = "bt_config";
            this.bt_config.Size = new System.Drawing.Size(132, 29);
            this.bt_config.TabIndex = 7;
            this.bt_config.Text = "Config Read";
            this.bt_config.UseVisualStyleBackColor = true;
            this.bt_config.Click += new System.EventHandler(this.bt_config_Click);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(441, 128);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(87, 29);
            this.bt_send.TabIndex = 6;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(641, 133);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(120, 40);
            this.button_disconnect.TabIndex = 3;
            this.button_disconnect.Text = "Disconnection";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.AutoSize = true;
            this.button_connect.Location = new System.Drawing.Point(641, 83);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(117, 40);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Connection";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // tb_testCycle
            // 
            this.tb_testCycle.Location = new System.Drawing.Point(134, 80);
            this.tb_testCycle.Name = "tb_testCycle";
            this.tb_testCycle.Size = new System.Drawing.Size(133, 29);
            this.tb_testCycle.TabIndex = 1;
            this.tb_testCycle.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Test cycle";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(226, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Message";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(765, 136);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(226, 362);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(770, 162);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read Message";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(764, 134);
            this.textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(996, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_stopbits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_databits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox tb_testCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.CheckBox ch_CRLF;
        private System.Windows.Forms.Button bt_config;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_config;
        private System.Windows.Forms.TextBox tb_cycleCount;
        private System.Windows.Forms.Label label7;
    }
}

