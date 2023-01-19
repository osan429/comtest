using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comtest
{
    public partial class Form1 : Form
    {
        public Thread ReadThread;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_send.Enabled = false;
        }

        private void comboBox_port_DropDown(object sender, EventArgs e)
        {
            cb_port.Items.Clear();//不清除的話每次按下就會新增一次項目
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cb_port.Items.Add(port);
            }
        }

        private void cb_baudrate_DropDown(object sender, EventArgs e)
        {
            cb_baudrate.Items.Clear();  
            cb_baudrate.Items.Add("19200");
            cb_baudrate.Items.Add("9600");
            cb_baudrate.Items.Add("4800");
            cb_baudrate.Items.Add("2400");
        }

        private void cb_parity_DropDown(object sender, EventArgs e)
        {
            cb_parity.Items.Clear();    
            cb_parity.Items.Add("Space");
            cb_parity.Items.Add("Odd");
            cb_parity.Items.Add("Even");
            cb_parity.Items.Add("Mark");
            cb_parity.Items.Add("None");
 
        }

        private void cb_databits_DropDown(object sender, EventArgs e)
        {
            cb_databits.Items.Clear();
            cb_databits.Items.Add("8");
            cb_databits.Items.Add("7");
            cb_databits.Items.Add("6");
            cb_databits.Items.Add("5");
        }

        private void cb_stopbits_DropDown(object sender, EventArgs e)
        {
            cb_stopbits.Items.Clear();
            //C# 不支援 stopbit "None"
          //  cb_stopbits.Items.Add("None");
            cb_stopbits.Items.Add("One");
            cb_stopbits.Items.Add("OnePointFive");
            cb_stopbits.Items.Add("Two");
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            serialPort1= new SerialPort();
            serialPort1.PortName = cb_port.Text;
            serialPort1.BaudRate = int.Parse(cb_baudrate.Text);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cb_parity.Text);
            serialPort1.DataBits = int.Parse(cb_databits.Text);
            serialPort1.StopBits = (StopBits) Enum.Parse(typeof(StopBits), cb_stopbits.Text);
            //serialPort1.ReadTimeout = 500;
            //serialPort1.WriteTimeout = 500;
            //需要新增異常處理
            try
            {
                serialPort1.Open();
                if (serialPort1.IsOpen)
                {
                    ReadSerialData();
                    button_connect.Enabled = false; 
                    button_disconnect.Enabled = true;
                    bt_send.Enabled = true;
                }
            }
            catch (Exception eo)
            {
                MessageBox.Show("Serial Port Open Error:" + eo.Message);
            }         
         
        
        }

        private void ReadSerialData()
        {
            try
            {
                //產生讀取Thread
                ReadThread = new Thread(ReceiveData);
                ReadThread.Start();
            }
            catch (Exception et)
            {

                MessageBox.Show("Read Thread Fail :" + et.Message);
            }
            
        }

        private void ReceiveData()
        {
            while (serialPort1.IsOpen)
            {


                //ShowSerialData(serialPort1.ReadExisting());
                ShowSerialData(serialPort1.ReadLine());
                Thread.Sleep(100);
    
            }   
        }
        //更新TEXTBOX時避免多執行續存取異常使用委派
        public delegate void ShowSerialDataDelegate(string r);
        private void ShowSerialData(string v)
        {
            if (textBox2.InvokeRequired) 
            {
                ShowSerialDataDelegate aaa = ShowSerialData;
                Invoke(aaa, v);    
            }
            else 
            {
                if(v != "") { 
                    textBox2.AppendText(Environment.NewLine + v);
                    textBox2.ScrollToCaret();
                    writeToFile(v);
                }
                
            }
        }

        //將接收資料輸出到檔案
        private void writeToFile(string v)
        {
            try
            {
                string path = @".\Log.txt";
                //sw.Write(v);    
                //sw.Flush(); 
                //sw.Close();
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(v);

                    }
                }
                else 
                {
                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(v);

                    }
                }

                
                                
            }
            catch (Exception f)
            {

                MessageBox.Show("Log 輸出錯誤 :" ,f.Message);
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                button_connect.Enabled = true;
                button_disconnect.Enabled = false; 
                bt_send.Enabled = false;
                  
                
            }
            catch (Exception ec)
            {

                MessageBox.Show("Serial Port Close Fail :" + ec);
            }
            
        }

        private async void bt_send_Click(object sender, EventArgs e)
        {
            int commandNumber = listSendCommand.Count;
            string c;
            int d;
            int cycle = int.Parse(tb_testCycle.Text);
            string endString;
            if (ch_CRLF.Checked)
            {
                endString = "\r\n";
            }
            else
            {
                endString= "\n";
            }
            if (commandNumber == 0) 
            {
                MessageBox.Show("指令不存在");
            }

            if (cycle == 0)
            {
                MessageBox.Show("次數不能為 0");
            }

            if (serialPort1.IsOpen) 
            {
                //執行設定cycle數
                for (int i =0 ; i < cycle; i++)
                {
                    for (int j = 0; j < commandNumber; j++) 
                    {
                        //讀取list內部指令並發送
                        c = listSendCommand[j];
                        d = listCommandDelayTime[j];
                        serialPort1.Write(c + endString);
                        //Thread.Sleep(d);
                        await Task.Delay(d);

                        //serialPort1.WriteLine(tb_send.Text);
                        textBox1.AppendText(Environment.NewLine + c);
                        textBox1.ScrollToCaret();


                    }
                    tb_cycleCount.Text = Convert.ToString(i+1);
                
                
                }
                
                
            }
        }

        //檔案讀取存放字串
        private void bt_config_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog= new OpenFileDialog();
            DialogResult n = fileDialog.ShowDialog();
            if (n == DialogResult.Cancel)
            {
                MessageBox.Show("操作取消");
            }
            else 
            {
               CommandRead(fileDialog.FileName);
                tb_config.Text = fileDialog.SafeFileName;     
  
                
            }
        }

        //string arraylist for command 
        //int arraylist for delaytime
        List<string> listSendCommand = new List<string>();
        List<int> listCommandDelayTime = new List<int>();
        private void CommandRead(string fileName)
        {
            listSendCommand.Clear();
            listCommandDelayTime.Clear();   
            try
            {
                FileStream stream = new FileStream(fileName, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1) 
                {
                    listSendCommand.Add(reader.ReadLine());
                    listCommandDelayTime.Add(int.Parse(reader.ReadLine()));
                }
                stream.Close();
            }
            catch (Exception f)
            {

                MessageBox.Show("File Open Fail : ", f.Message);
            }
        }
    }
}
