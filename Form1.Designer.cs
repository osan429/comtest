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
            this.cb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_cycleCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_send = new System.Windows.Forms.Button();
            this.bt_disconnect = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.tb_testCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_config = new System.Windows.Forms.TextBox();
            this.bt_config = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_OutFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ch_CRLF);
            this.groupBox1.Controls.Add(this.cb_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionSetting";
            // 
            // ch_CRLF
            // 
            this.ch_CRLF.AutoSize = true;
            this.ch_CRLF.Checked = true;
            this.ch_CRLF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_CRLF.Location = new System.Drawing.Point(64, 59);
            this.ch_CRLF.Margin = new System.Windows.Forms.Padding(2);
            this.ch_CRLF.Name = "ch_CRLF";
            this.ch_CRLF.Size = new System.Drawing.Size(59, 16);
            this.ch_CRLF.TabIndex = 8;
            this.ch_CRLF.Text = "CR+LF";
            this.ch_CRLF.UseVisualStyleBackColor = true;
            // 
            // cb_port
            // 
            this.cb_port.FormattingEnabled = true;
            this.cb_port.Location = new System.Drawing.Point(64, 31);
            this.cb_port.Margin = new System.Windows.Forms.Padding(2);
            this.cb_port.Name = "cb_port";
            this.cb_port.Size = new System.Drawing.Size(82, 20);
            this.cb_port.TabIndex = 1;
            this.cb_port.Text = "COM1";
            this.cb_port.DropDown += new System.EventHandler(this.comboBox_port_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tb_cycleCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bt_send);
            this.groupBox2.Controls.Add(this.bt_disconnect);
            this.groupBox2.Controls.Add(this.bt_connect);
            this.groupBox2.Controls.Add(this.tb_testCycle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(204, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(605, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TestSetting";
            // 
            // tb_cycleCount
            // 
            this.tb_cycleCount.Enabled = false;
            this.tb_cycleCount.Location = new System.Drawing.Point(89, 83);
            this.tb_cycleCount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_cycleCount.Name = "tb_cycleCount";
            this.tb_cycleCount.Size = new System.Drawing.Size(90, 22);
            this.tb_cycleCount.TabIndex = 11;
            this.tb_cycleCount.TabStop = false;
            this.tb_cycleCount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cycle count";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(211, 53);
            this.bt_send.Margin = new System.Windows.Forms.Padding(2);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(64, 22);
            this.bt_send.TabIndex = 6;
            this.bt_send.Text = "Star";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // bt_disconnect
            // 
            this.bt_disconnect.Location = new System.Drawing.Point(427, 89);
            this.bt_disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.bt_disconnect.Name = "bt_disconnect";
            this.bt_disconnect.Size = new System.Drawing.Size(80, 27);
            this.bt_disconnect.TabIndex = 3;
            this.bt_disconnect.Text = "Disconnection";
            this.bt_disconnect.UseVisualStyleBackColor = true;
            this.bt_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // bt_connect
            // 
            this.bt_connect.AutoSize = true;
            this.bt_connect.Location = new System.Drawing.Point(427, 55);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(2);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(78, 27);
            this.bt_connect.TabIndex = 2;
            this.bt_connect.Text = "Connection";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // tb_testCycle
            // 
            this.tb_testCycle.Location = new System.Drawing.Point(89, 53);
            this.tb_testCycle.Margin = new System.Windows.Forms.Padding(2);
            this.tb_testCycle.Name = "tb_testCycle";
            this.tb_testCycle.Size = new System.Drawing.Size(90, 22);
            this.tb_testCycle.TabIndex = 1;
            this.tb_testCycle.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Test cycle";
            // 
            // tb_config
            // 
            this.tb_config.Location = new System.Drawing.Point(8, 20);
            this.tb_config.Margin = new System.Windows.Forms.Padding(2);
            this.tb_config.Name = "tb_config";
            this.tb_config.Size = new System.Drawing.Size(163, 22);
            this.tb_config.TabIndex = 8;
            // 
            // bt_config
            // 
            this.bt_config.Location = new System.Drawing.Point(83, 46);
            this.bt_config.Margin = new System.Windows.Forms.Padding(2);
            this.bt_config.Name = "bt_config";
            this.bt_config.Size = new System.Drawing.Size(88, 24);
            this.bt_config.TabIndex = 7;
            this.bt_config.Text = "Config Read";
            this.bt_config.UseVisualStyleBackColor = true;
            this.bt_config.Click += new System.EventHandler(this.bt_config_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(204, 122);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(605, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Message";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(2, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(601, 87);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(204, 232);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(605, 133);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read Message";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(2, 17);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(601, 114);
            this.textBox2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.91776F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.08224F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 367);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_OutFileName);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.tb_config);
            this.groupBox5.Controls.Add(this.bt_config);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 123);
            this.groupBox5.Name = "groupBox5";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox5, 2);
            this.groupBox5.Size = new System.Drawing.Size(196, 241);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Config & OutFileName";
            // 
            // tb_OutFileName
            // 
            this.tb_OutFileName.Location = new System.Drawing.Point(11, 112);
            this.tb_OutFileName.Name = "tb_OutFileName";
            this.tb_OutFileName.Size = new System.Drawing.Size(159, 22);
            this.tb_OutFileName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(811, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_disconnect;
        private System.Windows.Forms.Button bt_connect;
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
        private System.Windows.Forms.TextBox tb_config;
        private System.Windows.Forms.TextBox tb_cycleCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_OutFileName;
        private System.Windows.Forms.Label label2;
    }
}

