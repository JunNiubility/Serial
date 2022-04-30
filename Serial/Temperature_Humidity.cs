using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial
{
    public partial class Temperature_Humidity : Form
    {
        public List<double> dataT { set; get; }
        public List<double> dataH { set; get; }

        public Temperature_Humidity()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public static void ShowChildFormInMDI(Form childFrm, Form parentFrm)//显示子窗体
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
        }

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

        private void makeSerialPort(SerialPort serialPort)
        {
            serialPort.PortName = serialport_cbb.Text;
            serialPort.BaudRate = Convert.ToInt32(baundrate_cbb.Text);
            serialPort.DataBits = Convert.ToInt32(data_cbb.Text);
            switch (check_cbb.Text.ToString())
            {
                case "0校验":
                    serialPort.Parity = Parity.Space;
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
                    serialPort.Parity = Parity.None;
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] receiveTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(receiveTemp, 0, receiveTemp.Length);
            this.Invoke(new EventHandler(
                delegate
                {
                    string str = Encoding.GetEncoding("gb2312").GetString(receiveTemp);
                    str = str.Replace("\0", "\\0");
                    string[] splitStr= { "T:", "H:" };
                    string[] dataTH = str.Split(splitStr, StringSplitOptions.RemoveEmptyEntries);
                    dataT.Add(Convert.ToDouble(dataTH[0]));
                    dataH.Add(Convert.ToDouble(dataTH[1]));
                }
            ));
        }

        private void timerGetTime_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time_lbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Temperature_Humidity_Shown(object sender, EventArgs e)
        {

        }

    }
}
