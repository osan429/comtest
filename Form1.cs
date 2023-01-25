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



        private void button_connect_Click(object sender, EventArgs e)
        {
            serialPort1= new SerialPort();
            serialPort1.PortName = cb_port.Text;
            serialPort1.BaudRate = int.Parse(listSerialSet[0]);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), listSerialSet[1]);
            serialPort1.DataBits = int.Parse(listSerialSet[2]);
            serialPort1.StopBits = (StopBits) Enum.Parse(typeof(StopBits), listSerialSet[3]);
            serialPort1.ReadTimeout = 100;
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

                if (serialPort1.BytesToRead>0)
                {
                    ShowSerialData(serialPort1.ReadLine());
                }
              
                //ShowSerialData(serialPort1.ReadExisting());
                
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

        /// <summary>
        /// 讀取檔案內的設定及指令
        /// </summary>
        //string arraylist for command 
        List<string> listSerialSet = new List<string>();
        //string arraylist for command 
        List<string> listSendCommand = new List<string>();
        //int arraylist for delaytime
        List<int> listCommandDelayTime = new List<int>();
        
        private void CommandRead(string fileName)
        {
            listSerialSet.Clear();
            listSendCommand.Clear();
            listCommandDelayTime.Clear();
            string fd;
            try
            {
                FileStream stream = new FileStream(fileName, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1) 
                {
                    fd = reader.ReadLine();
                    switch (fd.Substring(0,2) )
                    {
                        case "S:":
                            //讀取Srial連線設定
                            SrialSetRead(fd.Substring(2), listSerialSet);
                            break;

                        case "C:":
                            //讀取輸出指令
                            listSendCommand.Add(fd.Substring(2));
                            break;

                        case "T:":
                            //讀取執行時間設定
                            listCommandDelayTime.Add(int.Parse(fd.Substring(2)));
                            break;
                            
                        case "//":
                            //讀取內容為註釋
                            break;

                        default:
                            MessageBox.Show("檔案內容讀取異常");
                            break;
                    }
                    
                    //listSendCommand.Add(reader.ReadLine());
                    //listCommandDelayTime.Add(int.Parse(reader.ReadLine()));
                }
                stream.Close();
            }
            catch (Exception f)
            {

                MessageBox.Show("File Open Fail : ", f.Message);
            }
        }
        /// <summary>
        /// 將檔案內的Srial連線設定讀取出來到list
        /// </summary>
        /// <param name="v"></param> 連線設定值；各項設定以":"分隔
        /// <param name="listSerialSet"></param> 存儲設定的list
        /// <exception cref="NotImplementedException"></exception>
        private void SrialSetRead(string v, List<string> listSerialSet)
        {
            string[] subs = v.Split(':');

            foreach (var sub in subs)
            {
                listSerialSet.Add(sub);
            }
        }
    }
}
