using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;//
using System.Threading.Tasks;//
using System.Text.RegularExpressions;//
using System.Data.OleDb;//

namespace CSharp_simple_SerialComm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort sp = new SerialPort();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //获取所有串口名称
            string[] serialName = SerialPort.GetPortNames();
            foreach (string s in serialName)
            {
                //把串口名称添加到Combox
                cbSerialName.Items.Add(s);
            }
            //初始化设置，设置默认值
            cbSerialName.SelectedIndex = 0;
            cbBaudRate.SelectedIndex = 1;
            cbParity.SelectedIndex = 0;
            cbStop.SelectedIndex = 0;
            cbDataBits.SelectedIndex = 3;
            rb16Send.Select();
            rb16Rcv.Select();
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen)
            {

                // DateTime dt = DateTime.Now;//输出当前时间
                // textBoxRcv.Text += dt.GetDateTimeFormats('f')[0].ToString() + "\r\n";
                try
                {
                    Byte[] receivedData = new Byte[sp.BytesToRead];        //创建接收字节数组
                    sp.Read(receivedData, 0, receivedData.Length);         //读取数据,读取到receivedData中的是字符的ASCII码
                    sp.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                    //以字符串显示
                    if (rbStrRcv.Checked)
                    {
                        string strRcv = null;
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += ((char)Convert.ToInt32(receivedData[i]));//把字节转换成整型，再强转成char
                        }
                        tbRcv.Text += strRcv + "\r\n";             //显示信息                    
                       /* if (!tbRecConvert.Text.Contains("\n"))  //转换字符串
                        {
                            tbRecConvert.Text += strRcv;
                        }
                        else
                        {
                            tbRecConvert.Text = strRcv;
                        }
                        if (tbRecConvert.Text.Length.CompareTo(10) == 0)    //过滤字符串
                        {
                            tbtest.Text = tbRecConvert.Text;
                        }*/

                    }
                    //以16进制显示
                    if (rb16Rcv.Checked)
                    {
                        string strRcv = null;
                        //int decNum = 0;//存储十进制
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += receivedData[i].ToString("X2");  //16进制显示
                        }
                        tbRcv.Text += strRcv + "\r\n";
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "出错提示");
                    tbSend.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "错误提示");
            }
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                try
                {
                    //串口号
                    string serialName = cbSerialName.SelectedItem.ToString();
                    sp.PortName = serialName;
                    sp.BaudRate = Convert.ToInt32(cbBaudRate.Text);   //波特率
                    sp.DataBits = Convert.ToInt32(cbDataBits.Text);   //数据位

                    switch (cbStop.Text)           //停止位
                    {
                        case "1":
                            sp.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp.StopBits = StopBits.Two;
                            break;
                        default:
                            break;
                    }

                    switch (cbParity.Text)             //校验位
                    {
                        case "无":
                            sp.Parity = Parity.None;
                            break;
                        case "奇校验":
                            sp.Parity = Parity.Odd;
                            break;
                        case "偶校验":
                            sp.Parity = Parity.Even;
                            break;
                        default:
                            break;
                    }

                    if (sp.IsOpen == true)   //如果是开着的，先关一下，再开，直接打开可能会出问题
                    {
                        sp.Close();
                    }

                    sp.Open();
                    btnOpenSerial.Text = "关闭串口";
                    //打开串口之后，把串口配置选项都禁用掉
                    cbSerialName.Enabled = false;
                    cbBaudRate.Enabled = false;
                    cbDataBits.Enabled = false;
                    cbParity.Enabled = false;
                    cbStop.Enabled = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    timer2.Enabled = false;
                    return;
                }
            }
            else
            {
                //关闭串口
                sp.Close();
                btnOpenSerial.Text = "打开串口";
                //启用配置选项
                cbSerialName.Enabled = true;
                cbStop.Enabled = true;
                cbParity.Enabled = true;
                cbDataBits.Enabled = true;
                cbBaudRate.Enabled = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!sp.IsOpen)
            {
                MessageBox.Show("请先打开串口！");
                return;
            }

            string strSend = tbSend.Text;

            if (rb16Send.Checked)         //以16进制格式进行发送
            {
                string strBuf = strSend;
                string sendnoNull = strBuf.Trim();      //去掉空格
                string[] sendArray = strBuf.Split(' ');  //以空格分割

                byte[] b = new byte[sendArray.Length];
                //逐个将字符转为16进制字节数据
                for (int i = 0; i < sendArray.Length; i++)
                {
                    b[i] = Convert.ToByte(sendArray[i], 16);
                }

                sp.Write(b, 0, b.Length);
            }
            else              //以字符串格式发送
            {
                sp.WriteLine(tbSend.Text);
            }
        }

        private void tbSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb16Send.Checked == true)      //以16进制格式发送数据时，只能输入特定字符
            {
                //正则匹配
                string patten = "[0-9a-fA-F]|\b|0x|0X| "; //“\b”：退格键
                Regex r = new Regex(patten);
                Match m = r.Match(e.KeyChar.ToString());

                if (m.Success)//&&(txtSend.Text.LastIndexOf(" ") != txtSend.Text.Length-1))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            tbSend.Text = "";   //清空发送数据文本框
        }

        private void btnClearRcv_Click(object sender, EventArgs e)
        {
            tbRcv.Text = "";  //清空接收数据文本框
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  //退出按钮
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }

        private void cbTimeSend_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimeSend.Checked)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string strSecond = tbPeriod.Text;
            try
            {
                int isecond = int.Parse(strSecond) * 1000;//Interval以微秒为单位
                timer2.Interval = isecond;
                if (timer2.Enabled == true && sp.IsOpen == true)
                {
                    btnSend.PerformClick();
                }
            }
            catch (System.Exception ex)
            {
                timer2.Enabled = false;
                MessageBox.Show("错误的定时输入！" + ex.Message, "Error");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString();
        }

        /*private void tbtest_TextChanged(object sender, EventArgs e)
        {
            if (lbRec.Items.Contains(tbtest.Text))
            {
                return;
            }
            else
            {
                lbRec.Items.Add(tbtest.Text);
                tbRow.Text = lbRec.Items.Count.ToString();
            }

        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            lbRec.Items.Clear();
        }*/
        
    }
}
