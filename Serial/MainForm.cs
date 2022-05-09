using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Serial
{
    public partial class MainForm : Form
    {
        #region 字段
        private List<byte> receiveBuffer = new List<byte>();//接收串口数据
        private string sendBuffer;//发送串口数据     
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;            
        }        
        #region 窗体
        /// <summary>
        /// 显示子窗体
        /// </summary>
        /// <param name="childFrm">子窗体</param>
        /// <param name="parentFrm">父窗体</param>
        public static void ShowChildFormInMDI(Form childFrm, Form parentFrm)
        {
            if (Application.OpenForms[childFrm.Name] != null)
            {
                Application.OpenForms[childFrm.Name].Activate();
                childFrm.Dispose();
            }
            else
            {
                childFrm.Show(parentFrm);
            }
        }
        #endregion
        #region 进制转换函数
        /// <summary>
        /// 将encode编码的字符串str转为十六进制Hex的字符串
        /// </summary>
        /// <param name="_str">字符串</param>
        /// <param name="encode">字符串编码</param>
        /// <returns></returns>
        private string StringToHexString(string _str, Encoding encode)
        {

            //将字符串转换成字节数组。
            byte[] buffer = encode.GetBytes(_str);
            //定义一个string类型的变量，用于存储转换后的值。
            string result = string.Empty;
            for (int i = 0; i < buffer.Length; i++)
            {
                //将每一个字节数组转换成16进制的字符串，以空格相隔开。
                result += Convert.ToString(buffer[i], 16) + " ";
            }
            return result;
        }
        /// <summary>
        /// 将十六进制的字符串转为encode编码格式的字符串
        /// </summary>
        /// <param name="hex">十六进制字符串</param>
        /// <param name="encode">字符串编码</param>
        /// <returns></returns>
        private string HexStringToString(string hex, Encoding encode)
        {
            //去掉空格
            hex = hex.Replace(" ", "");
            byte[] buffer = new byte[hex.Length / 2];
            string result = string.Empty;
            for (int i = 0; i < hex.Length / 2; i++)
            {
                result = hex.Substring(i * 2, 2);
                buffer[i] = Convert.ToByte(result, 16);
            }
            //返回指定编码格式的字符串
            return encode.GetString(buffer);
        }
        #endregion
        #region 初始化  
        /// <summary>
        /// 串口初始设置
        /// </summary>
        /// <param name="serialPort">串口</param>
        private void makeSerialPort(SerialPort serialPort)
        {
            serialPort.PortName = serialport_cbb.Text;
            serialPort.BaudRate = Convert.ToInt32(baundrate_cbb.Text);
            serialPort.DataBits = Convert.ToInt32(data_cbb.Text);
            switch (check_cbb.Text.ToString())
            {
                case "0校验":
                    serialPort.Parity = Parity.None;
                    break;
                case "1校验":
                    serialPort.Parity = Parity.Mark;
                    break;
                case "奇校验":
                    serialPort.Parity = Parity.Odd;
                    break;
                case "偶校验":
                    serialPort.Parity = Parity.Even;
                    break;
                case "无校验":
                    serialPort.Parity = Parity.Space;
                    break;
                default:
                    break;
            }
            switch (stop_cbb.Text.ToString())
            {
                case "1位":
                    serialPort.StopBits = StopBits.One;
                    break;
                case "1.5位":
                    serialPort.StopBits = StopBits.OnePointFive;
                    break;
                case "2位":
                    serialPort.StopBits = StopBits.Two;
                    break;
                default:
                    break;
            }
            if (RTS_cbx.Checked)
                serialPort.RtsEnable = true;
            else
                serialPort.RtsEnable = false;
            if (DTR_cbx.Checked)
                serialPort.DtrEnable = true;
            else
                serialPort.DtrEnable = false;
            serialport_cbb.Enabled = false;
            baundrate_cbb.Enabled = false;
            data_cbb.Enabled = false;
            check_cbb.Enabled = false;
            stop_cbb.Enabled = false;
            RTS_cbx.Enabled = false;
            DTR_cbx.Enabled = false;
        }
        #endregion
        #region 事件
        /// <summary>
        /// 窗体初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                serialport_cbb.Items.Add("COM" + i.ToString());
            }
            serialport_cbb.Text = serialport_cbb.Items[0].ToString();
            baundrate_cbb.Text = "9600";
            check_cbb.Text = "0校验";
            data_cbb.Text = "8";
            stop_cbb.Text = "1位";            
        }
        /// <summary>
        /// 打开按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_btn_Click(object sender, EventArgs e)
        {
            if (open_btn.Tag.ToString() == "true")
            {
                if (serialPort1.IsOpen == false)
                {
                    try
                    {
                        makeSerialPort(serialPort1);                        
                        open_btn.Tag = "false";
                        open_btn.Text = "关闭串口";
                        serialPort1.Open();
                        serialPort1.DiscardInBuffer();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(serialPort1.PortName + "打开失败！", "警告");
                        serialPort1.Close();
                        open_btn.Tag = "true";
                        open_btn.Text = "打开串口";
                        serialport_cbb.Enabled = true;
                        baundrate_cbb.Enabled = true;
                        data_cbb.Enabled = true;
                        check_cbb.Enabled = true;
                        stop_cbb.Enabled = true;
                        RTS_cbx.Enabled = true;
                        DTR_cbx.Enabled = true;
                    }
                }
            }
            else if (open_btn.Tag.ToString() == "false")
            {
                serialPort1.Close();
                open_btn.Tag = "true";
                open_btn.Text = "打开串口";
                serialport_cbb.Enabled = true;
                baundrate_cbb.Enabled = true;
                data_cbb.Enabled = true;
                check_cbb.Enabled = true;
                stop_cbb.Enabled = true;
                RTS_cbx.Enabled = true;
                DTR_cbx.Enabled = true;
            }
        }
        /// <summary>
        /// 自动扫描端口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动扫描端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialport_cbb.Items.Clear();
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            string[] sSubKeys = keyCom.GetValueNames();
            foreach (var sValue in sSubKeys)
            {
                string portName = (string)keyCom.GetValue(sValue);
                serialport_cbb.Items.Insert(0, portName);
            }
            serialport_cbb.Text = serialport_cbb.Items[0].ToString();
        }
        /// <summary>
        /// 清除按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manalclear_btn_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            recive_tbx.Text = "";
        }
        /// <summary>
        /// 停止按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (stop_btn.Tag.ToString() == "true")
            {
                stop_btn.Tag = "false";
                stop_btn.Text = "取消暂停";
            }
            else
            {
                stop_btn.Tag = "true";
                stop_btn.Text = "暂停";
            }
        }
        /// <summary>
        /// 保存按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (recievefile_tbx.Text != "")
            {
                if (recive_tbx.Text != "")
                {
                    try
                    {
                        //通过指定文件获取文件流
                        FileStream fs = File.OpenWrite(recievefile_tbx.Text);
                        //将字符串转换为字节数组
                        Byte[] info = Encoding.Default.GetBytes(recive_tbx.Text);
                        //向文件流中写入文件
                        fs.Write(info, 0, info.Length);
                        fs.Close();   //关闭文件流
                        MessageBox.Show("文件保存成功！");
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("文件内容不能为空");
                }
            }
            else
            {
                MessageBox.Show("文件路径不能为空");
            }
        }
        /// <summary>
        /// 选择文件按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coosefile_btn_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "文本文件(*.txt)|*.txt";         //设置打开文件的类型
                saveFileDialog1.ShowDialog();  //打开选择文件对话框
                recievefile_tbx.Text = saveFileDialog1.FileName;  //获取打开的文件名                
            }
            catch
            {

            }
        }
        /// <summary>
        /// 手动发送按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manalsend_btn_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];
            if (serialPort1.IsOpen && send_tbx.Text != "")
            {
                if (!hexsend_cbx.Checked)//发送模式是字符模式
                {
                    try
                    {
                        serialPort1.Write(Encoding.GetEncoding("gb2312").GetBytes(send_tbx.Text), 0, Encoding.GetEncoding("gb2312").GetByteCount(send_tbx.Text));
                    }
                    catch
                    {
                        MessageBox.Show("端口发送失败，系统将关闭当前串口", "错误");
                        serialPort1.Close();//关闭串口
                    }
                }
                else
                {
                    if (send_tbx.Text.Length % 2 == 0)//偶数个数字
                    {
                        for (int i = 0; i < send_tbx.Text.Length / 2; i++)
                        {
                            try
                            {
                                Data[0] = Convert.ToByte(send_tbx.Text.Substring(i * 2, 2), 16);
                            }
                            catch
                            {
                                MessageBox.Show("请核对输入的十六进制数据格式", "错误");
                            }

                            try
                            {
                                serialPort1.Write(Data, 0, 1);
                            }
                            catch
                            {
                                MessageBox.Show("端口发送失败，系统将关闭当前串口", "错误");
                                serialPort1.Close();//关闭串口
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入偶数个16进制数字", "错误");
                    }
                }
            }
        }
        /// <summary>
        /// 清除发送按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearsend_btn_Click(object sender, EventArgs e)
        {
            send_tbx.Text = "";
        }
        /// <summary>
        /// 打开文件按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openfile_btn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "文本文件(*.txt)|*.txt";         //设置打开文件的类型
                openFileDialog1.ShowDialog();  //打开选择文件对话框
                sendfile_tbx.Text = openFileDialog1.FileName;  //获取打开的文件名                
            }
            catch
            {

            }
        }
        /// <summary>
        /// 串口接收数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (stop_btn.Tag.ToString() == "false") return;            
            if (!hexrecieve_cbx.Checked)//如果接受模式为字符模式
            {
                string str = string.Empty;
                while (this.serialPort1.BytesToRead > 0)
                {
                    str += this.serialPort1.ReadExisting();  //数据读取,直到读完缓冲区数据
                }
                recive_tbx.AppendText(str);
            }
            else
            { //如果接收模式为数据接收
                byte[] data = new byte[serialPort1.BytesToRead];
                serialPort1.Read(data, 0, data.Length);
                foreach (byte menber in data)                                                   //遍历用法
                {
                    string str = menber.ToString("X2").ToUpper() + " ";
                    recive_tbx.AppendText(str);
                }
            }            
        }        
        /// <summary>
        /// Hex选择框接收变化事件事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hexrecieve_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (recive_tbx.Text == "") return;
            if (!hexrecieve_cbx.Checked)
            {
                recive_tbx.Text = HexStringToString(recive_tbx.Text, Encoding.ASCII);
            }
            else
            {
                recive_tbx.Text = StringToHexString(recive_tbx.Text, Encoding.ASCII).ToUpper();
            }
        }
        /// <summary>
        /// 自动清除复选框变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoclear_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (autoclear_cbx.Checked)
                autoclearTime.Start();
            else
                autoclearTime.Stop();
        }
        /// <summary>
        /// 发送区文字改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void send_tbx_Leave(object sender, EventArgs e)
        {
            sendBuffer = "";
            try
            {
                if (hexsend_cbx.Checked)
                {
                    sendBuffer = StringToHexString(send_tbx.Text, Encoding.GetEncoding("gb2312"));
                }
                else
                {
                    sendBuffer = send_tbx.Text;
                }
            }
            catch
            { }
        }
        /// <summary>
        /// Hex选择框发送改变时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hexsend_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (send_tbx.Text == "") return;
            try
            {
                if (!hexsend_cbx.Checked)
                {
                    send_tbx.Text = HexStringToString(send_tbx.Text, Encoding.GetEncoding("gb2312"));
                }
                else
                {
                    send_tbx.Text = StringToHexString(send_tbx.Text, Encoding.GetEncoding("gb2312")).ToUpper();
                }
            }
            catch
            { }
        }
        /// <summary>
        /// 发送文件按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendfile_btn_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = File.OpenRead(openFileDialog1.FileName); //打开现有文件以进行读取
                byte[] bs = new byte[1024]; //定义缓存
                while (fs.Read(bs, 0, bs.Length) > 0)   //每次读取1024个字节 ，判断结果是否大于0
                {
                    send_tbx.Text = Encoding.Default.GetString(bs); //把字节数组所有字节转为一个字符串
                }
                fs.Close(); //关闭文件流
                manalsend_btn_Click(sender, e);
            }
            catch
            {

            }
        }
        /// <summary>
        /// 默认串口配置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 默认串口配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialport_cbb.Text = serialport_cbb.Items[0].ToString();
            baundrate_cbb.Text = "9600";
            check_cbb.Text = "0校验";
            data_cbb.Text = "8";
            stop_cbb.Text = "1位";
            RTS_cbx.CheckState = CheckState.Unchecked;
            DTR_cbx.CheckState = CheckState.Unchecked;
            autoclear_cbx.CheckState = CheckState.Unchecked;
            hexrecieve_cbx.CheckState = CheckState.Unchecked;
            autosend_cbx.CheckState = CheckState.Unchecked;
            hexsend_cbx.CheckState = CheckState.Unchecked;
            recievefile_tbx.Text = "";
            sendfile_tbx.Text = "";
            autosend_tbx.Text = "";
        }
        /// <summary>
        /// 软件信息事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 软件信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本串口助手功能：\r\n" +
                "基本的串口助手功能，对温湿风压雨等数据进行实时显示\r\n" +
                "作者：雍俊\r\n" +
                "版本：1.0\r\n" +
                "当前版本功能有限，更多功能敬请期待",
                "软件信息");
        }
        /// <summary>
        /// 湿度功能事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 温湿度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature_Humidity temperature_humidityForm = new Temperature_Humidity();
            ShowChildFormInMDI(temperature_humidityForm, this);
        }
        /// <summary>
        /// 等待更新事件提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitForDate(object sender, EventArgs e)
        {
            MessageBox.Show("本功能暂无，敬请期待！", "提示");
        }
        /// <summary>
        /// 使用帮助事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 使用帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = @"D:\26706\Documents\data.txt";
            info.Arguments = "";
            info.WindowStyle = ProcessWindowStyle.Normal;
            Process pro = Process.Start(info);
        }
        /// <summary>
        /// 自动清除的时间触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoclearTime_Tick(object sender, EventArgs e)
        {
            if (recive_tbx.Text.Length >= 512)
            {
                receiveBuffer.Clear();
                recive_tbx.Text = "";
            }
        }
        /// <summary>
        /// 自动发送的时间触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autosend_Time_Tick(object sender, EventArgs e)
        {
            manalsend_btn_Click(sender, e);
        }
        /// <summary>
        /// 自动发送选择框变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autosend_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (autosend_cbx.Checked)
            {
                if (autosend_tbx.Text == "")
                {
                    MessageBox.Show("请输入自动发送时间", "警告");
                    autosend_cbx.CheckState = CheckState.Unchecked;
                    return;
                }
                else
                {
                    autosend_Time.Interval = Convert.ToInt32(autosend_tbx.Text);
                    autosend_Time.Start();
                }
            }
            else
                autosend_Time.Stop();
        }
        /// <summary>
        /// 湿度功能事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 温度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature temperatureForm = new Temperature();
            ShowChildFormInMDI(temperatureForm, this);
        }
        #endregion
    }
}
