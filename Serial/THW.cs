﻿using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Serial
{
    /// <summary>
    /// 温湿度窗体模块
    /// </summary>
    public partial class THW : Form
    {
        #region 字段        
        private DataToSave dataToSave { set; get; }
        public Func<DataToSave> SendData;//发送数据委托
        #endregion
        private DataToSave SendToForm()
        {
            return dataToSave;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public THW()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 显示子窗体函数
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

        #region 进制转换
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
        #region 事件
        /// <summary>
        /// 温湿度窗体初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Temperature_Humidity_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");

            for (int i = 0; i <= 255; i++)
            {
                serialport_cbb.Items.Add("COM" + i.ToString());
            }
            serialport_cbb.Text = serialport_cbb.Items[0].ToString();
            baundrate_cbb.Text = "9600";
            check_cbb.Text = "0校验";
            data_cbb.Text = "8";
            stop_cbb.Text = "1位";
            自动扫描ToolStripMenuItem_Click(sender, e);
        }
        /// <summary>
        /// 自动扫描事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动扫描ToolStripMenuItem_Click(object sender, EventArgs e)
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
        /// 默认端口配置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 默认端口配置toolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialport_cbb.Text = serialport_cbb.Items[0].ToString();
            baundrate_cbb.Text = "9600";
            check_cbb.Text = "0校验";
            data_cbb.Text = "8";
            stop_cbb.Text = "1位";
            RTS_cbx.CheckState = CheckState.Unchecked;
            DTR_cbx.CheckState = CheckState.Unchecked;
        }
        /// <summary>
        /// 串口初始化函数
        /// </summary>
        /// <param name="serialPort"></param>
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

        /// <summary>
        /// 打开按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_btn_Click(object sender, EventArgs e)
        {
            FrmLineSeries frmLineSeries = new FrmLineSeries(this);
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
                        ShowChildFormInMDI(frmLineSeries, this);
                    }
                    catch (Exception)
                    {
                        frmLineSeries.Close();
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
                if (Application.OpenForms[frmLineSeries.Name] == null)
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
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("请先关闭实时显示界面", "警告");
                }
            }
        }
        /// <summary>
        /// 串口接收数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] receiveTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(receiveTemp, 0, receiveTemp.Length);
            this.Invoke(new EventHandler(
                delegate
                {
                    string str = Encoding.GetEncoding("gb2312").GetString(receiveTemp);
                    //str = "T-P:23.5H-P:56%S-P:32\r\nT-M:43.2H-M:58%S-M:9.8D-M:211TIME:95s";
                    str = str.Replace("\0", "\\0");
                    string[] splitStr = { "T-P:", "H-P:", "S-P:", "T-M:", "H-M:", "%S-M:", "D-M:", "TIME:", "s" };
                    string[] dataTHW = str.Split(splitStr, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        dataToSave.temperature = Convert.ToDouble(dataTHW[3]);
                        dataToSave.humidity = Convert.ToDouble(dataTHW[4]);
                        dataToSave.windSpeed = Convert.ToDouble(dataTHW[5]);
                        dataToSave.windDirection = Convert.ToDouble(dataTHW[6]);
                        dataToSave.countSecond = (int)Convert.ToInt32(dataTHW[7]);
                        dataToSave.nowTime = DateTime.Now.ToString();

                        dataToSave.windDirection += 360;
                        dataToSave.windDirection %= 360;
                        double dataWD = dataToSave.windDirection;

                        if ((337 < dataWD && dataWD <= 360) || (0 <= dataWD && dataWD <= 22))
                            wd_tbx.Text = "北风吹";
                        else if (22 < dataWD && dataWD <= 67)
                            wd_tbx.Text = "东北风";
                        else if (67 < dataWD && dataWD <= 112)
                            wd_tbx.Text = "东风吹";
                        else if (112 < dataWD && dataWD <= 157)
                            wd_tbx.Text = "东南风";
                        else if (157 < dataWD && dataWD <= 202)
                            wd_tbx.Text = "南风吹";
                        else if (202 < dataWD && dataWD <= 247)
                            wd_tbx.Text = "西南风";
                        else if (247 < dataWD && dataWD <= 292)
                            wd_tbx.Text = "西风吹";
                        else if (292 < dataWD && dataWD <= 337)
                            wd_tbx.Text = "西北风";

                        temp_tbx.Text = dataToSave.temperature.ToString();
                        humidity_tbx.Text = dataToSave.humidity.ToString();
                        ws_tbx.Text = dataToSave.windSpeed.ToString();
                        time_lbl.Text = dataToSave.nowTime;
                    }
                    catch
                    {

                    }

                }
            ));
        }
        /// <summary>
        /// 实时时间更新触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGetTime_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        /// <summary>
        /// 温湿度实时曲线初值初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Temperature_Humidity_Shown(object sender, EventArgs e)
        {
            dataToSave = new DataToSave(191, DateTime.Now.ToString(), 25, 80, 0, 3.4);
            SendData = SendToForm;
            temp_tbx.Text = dataToSave.temperature.ToString();
            humidity_tbx.Text = dataToSave.humidity.ToString();
            wd_tbx.Text = "北风吹";
            ws_tbx.Text = dataToSave.windSpeed.ToString();
        }
        #endregion
    }
}
