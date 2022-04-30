
namespace Serial
{
    partial class Temperature_Humidity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Temperature_Humidity));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.humidity_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.datenow = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.temp_tbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tempnow = new System.Windows.Forms.Label();
            this.timenow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.DTR_cbx = new System.Windows.Forms.CheckBox();
            this.RTS_cbx = new System.Windows.Forms.CheckBox();
            this.stop_cbb = new System.Windows.Forms.ComboBox();
            this.data_cbb = new System.Windows.Forms.ComboBox();
            this.check_cbb = new System.Windows.Forms.ComboBox();
            this.baundrate_cbb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serialport_cbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.串口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动扫描端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认端口配置toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerGetTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.humidity_tbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.datenow);
            this.groupBox1.Controls.Add(this.time_lbl);
            this.groupBox1.Controls.Add(this.temp_tbx);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tempnow);
            this.groupBox1.Controls.Add(this.timenow);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(17, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(215, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据面板";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "%";
            // 
            // humidity_tbx
            // 
            this.humidity_tbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.humidity_tbx.Location = new System.Drawing.Point(100, 145);
            this.humidity_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.humidity_tbx.Name = "humidity_tbx";
            this.humidity_tbx.ReadOnly = true;
            this.humidity_tbx.Size = new System.Drawing.Size(77, 27);
            this.humidity_tbx.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前湿度：";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(104, 40);
            this.datelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(93, 20);
            this.datelbl.TabIndex = 6;
            this.datelbl.Text = "2022-01-01";
            // 
            // datenow
            // 
            this.datenow.AutoSize = true;
            this.datenow.Location = new System.Drawing.Point(16, 40);
            this.datenow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(84, 20);
            this.datenow.TabIndex = 5;
            this.datenow.Text = "当前日期：";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(104, 76);
            this.time_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(71, 20);
            this.time_lbl.TabIndex = 4;
            this.time_lbl.Text = "00:00:00";
            // 
            // temp_tbx
            // 
            this.temp_tbx.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.temp_tbx.Location = new System.Drawing.Point(100, 109);
            this.temp_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.temp_tbx.Name = "temp_tbx";
            this.temp_tbx.ReadOnly = true;
            this.temp_tbx.Size = new System.Drawing.Size(77, 27);
            this.temp_tbx.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "℃";
            // 
            // tempnow
            // 
            this.tempnow.AutoSize = true;
            this.tempnow.Location = new System.Drawing.Point(16, 112);
            this.tempnow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tempnow.Name = "tempnow";
            this.tempnow.Size = new System.Drawing.Size(84, 20);
            this.tempnow.TabIndex = 1;
            this.tempnow.Text = "当前温度：";
            // 
            // timenow
            // 
            this.timenow.AutoSize = true;
            this.timenow.Location = new System.Drawing.Point(16, 76);
            this.timenow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timenow.Name = "timenow";
            this.timenow.Size = new System.Drawing.Size(84, 20);
            this.timenow.TabIndex = 0;
            this.timenow.Text = "当前时间：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.open_btn);
            this.groupBox2.Controls.Add(this.DTR_cbx);
            this.groupBox2.Controls.Add(this.RTS_cbx);
            this.groupBox2.Controls.Add(this.stop_cbb);
            this.groupBox2.Controls.Add(this.data_cbb);
            this.groupBox2.Controls.Add(this.check_cbb);
            this.groupBox2.Controls.Add(this.baundrate_cbb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.serialport_cbb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(15, 238);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(216, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口配置";
            // 
            // open_btn
            // 
            this.open_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.open_btn.Location = new System.Drawing.Point(77, 198);
            this.open_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(121, 52);
            this.open_btn.TabIndex = 12;
            this.open_btn.Tag = "true";
            this.open_btn.Text = "打开串口";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // DTR_cbx
            // 
            this.DTR_cbx.AutoSize = true;
            this.DTR_cbx.Location = new System.Drawing.Point(21, 226);
            this.DTR_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTR_cbx.Name = "DTR_cbx";
            this.DTR_cbx.Size = new System.Drawing.Size(61, 24);
            this.DTR_cbx.TabIndex = 11;
            this.DTR_cbx.Text = "DTR";
            this.DTR_cbx.UseVisualStyleBackColor = true;
            // 
            // RTS_cbx
            // 
            this.RTS_cbx.AutoSize = true;
            this.RTS_cbx.Location = new System.Drawing.Point(21, 196);
            this.RTS_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTS_cbx.Name = "RTS_cbx";
            this.RTS_cbx.Size = new System.Drawing.Size(59, 24);
            this.RTS_cbx.TabIndex = 10;
            this.RTS_cbx.Text = "RTS";
            this.RTS_cbx.UseVisualStyleBackColor = true;
            // 
            // stop_cbb
            // 
            this.stop_cbb.FormattingEnabled = true;
            this.stop_cbb.Items.AddRange(new object[] {
            "1位",
            "1.5位",
            "2位"});
            this.stop_cbb.Location = new System.Drawing.Point(77, 162);
            this.stop_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_cbb.Name = "stop_cbb";
            this.stop_cbb.Size = new System.Drawing.Size(121, 28);
            this.stop_cbb.TabIndex = 9;
            // 
            // data_cbb
            // 
            this.data_cbb.FormattingEnabled = true;
            this.data_cbb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.data_cbb.Location = new System.Drawing.Point(77, 128);
            this.data_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.data_cbb.Name = "data_cbb";
            this.data_cbb.Size = new System.Drawing.Size(121, 28);
            this.data_cbb.TabIndex = 8;
            // 
            // check_cbb
            // 
            this.check_cbb.FormattingEnabled = true;
            this.check_cbb.Items.AddRange(new object[] {
            "0校验",
            "1校验",
            "奇校验",
            "偶校验",
            "无校验"});
            this.check_cbb.Location = new System.Drawing.Point(77, 94);
            this.check_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.check_cbb.Name = "check_cbb";
            this.check_cbb.Size = new System.Drawing.Size(121, 28);
            this.check_cbb.TabIndex = 7;
            // 
            // baundrate_cbb
            // 
            this.baundrate_cbb.FormattingEnabled = true;
            this.baundrate_cbb.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            ""});
            this.baundrate_cbb.Location = new System.Drawing.Point(77, 60);
            this.baundrate_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baundrate_cbb.Name = "baundrate_cbb";
            this.baundrate_cbb.Size = new System.Drawing.Size(121, 28);
            this.baundrate_cbb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "校验位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "波特率";
            // 
            // serialport_cbb
            // 
            this.serialport_cbb.FormattingEnabled = true;
            this.serialport_cbb.Location = new System.Drawing.Point(77, 26);
            this.serialport_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serialport_cbb.Name = "serialport_cbb";
            this.serialport_cbb.Size = new System.Drawing.Size(121, 28);
            this.serialport_cbb.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "端口号";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 串口ToolStripMenuItem
            // 
            this.串口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动扫描端口ToolStripMenuItem,
            this.默认端口配置toolStripMenuItem});
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.串口ToolStripMenuItem.Text = "串口";
            // 
            // 自动扫描端口ToolStripMenuItem
            // 
            this.自动扫描端口ToolStripMenuItem.Name = "自动扫描端口ToolStripMenuItem";
            this.自动扫描端口ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.自动扫描端口ToolStripMenuItem.Text = "自动扫描端口";
            this.自动扫描端口ToolStripMenuItem.Click += new System.EventHandler(this.自动扫描ToolStripMenuItem_Click);
            // 
            // 默认端口配置toolStripMenuItem
            // 
            this.默认端口配置toolStripMenuItem.Name = "默认端口配置toolStripMenuItem";
            this.默认端口配置toolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.默认端口配置toolStripMenuItem.Text = "默认端口配置";
            this.默认端口配置toolStripMenuItem.Click += new System.EventHandler(this.默认端口配置toolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(16, 501);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(215, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "存储";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerGetTime
            // 
            this.timerGetTime.Enabled = true;
            this.timerGetTime.Interval = 1000;
            this.timerGetTime.Tick += new System.EventHandler(this.timerGetTime_Tick);
            // 
            // Temperature_Humidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Temperature_Humidity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温湿度上位机";
            this.Load += new System.EventHandler(this.Temperature_Humidity_Load);
            this.Shown += new System.EventHandler(this.Temperature_Humidity_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tempnow;
        private System.Windows.Forms.Label timenow;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.TextBox temp_tbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label datenow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox humidity_tbx;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动扫描端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认端口配置toolStripMenuItem;
        private System.Windows.Forms.CheckBox DTR_cbx;
        private System.Windows.Forms.CheckBox RTS_cbx;
        private System.Windows.Forms.ComboBox stop_cbb;
        private System.Windows.Forms.ComboBox data_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox baundrate_cbb;
        private System.Windows.Forms.ComboBox serialport_cbb;
        private System.Windows.Forms.Button open_btn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerGetTime;
    }
}