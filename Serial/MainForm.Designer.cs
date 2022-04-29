
namespace Serial
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.serialport_cbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.recievefile_tbx = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.coosefile_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.manalclear_btn = new System.Windows.Forms.Button();
            this.hexrecieve_cbx = new System.Windows.Forms.CheckBox();
            this.autoclear_cbx = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.autosend_tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sendfile_tbx = new System.Windows.Forms.TextBox();
            this.sendfile_btn = new System.Windows.Forms.Button();
            this.openfile_btn = new System.Windows.Forms.Button();
            this.clearsend_btn = new System.Windows.Forms.Button();
            this.manalsend_btn = new System.Windows.Forms.Button();
            this.hexsend_cbx = new System.Windows.Forms.CheckBox();
            this.autosend_cbx = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.recive_tbx = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.send_tbx = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.串口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动扫描端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.默认串口配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.软件信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.温室风压雨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.温湿度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.温度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.湿度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.风向风速ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大气压ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.雨量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.温湿风压雨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoclearTime = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.autosend_Time = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.DTR_cbx);
            this.groupBox1.Controls.Add(this.RTS_cbx);
            this.groupBox1.Controls.Add(this.stop_cbb);
            this.groupBox1.Controls.Add(this.data_cbb);
            this.groupBox1.Controls.Add(this.check_cbb);
            this.groupBox1.Controls.Add(this.baundrate_cbb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serialport_cbb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(216, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // serialport_cbb
            // 
            this.serialport_cbb.FormattingEnabled = true;
            this.serialport_cbb.Location = new System.Drawing.Point(77, 26);
            this.serialport_cbb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serialport_cbb.Name = "serialport_cbb";
            this.serialport_cbb.Size = new System.Drawing.Size(121, 28);
            this.serialport_cbb.TabIndex = 1;
            this.serialport_cbb.TextChanged += new System.EventHandler(this.allTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recievefile_tbx);
            this.groupBox2.Controls.Add(this.save_btn);
            this.groupBox2.Controls.Add(this.coosefile_btn);
            this.groupBox2.Controls.Add(this.stop_btn);
            this.groupBox2.Controls.Add(this.manalclear_btn);
            this.groupBox2.Controls.Add(this.hexrecieve_cbx);
            this.groupBox2.Controls.Add(this.autoclear_cbx);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 304);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(216, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收配置";
            // 
            // recievefile_tbx
            // 
            this.recievefile_tbx.Location = new System.Drawing.Point(7, 118);
            this.recievefile_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recievefile_tbx.Name = "recievefile_tbx";
            this.recievefile_tbx.Size = new System.Drawing.Size(191, 27);
            this.recievefile_tbx.TabIndex = 6;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save_btn.Location = new System.Drawing.Point(104, 88);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(93, 24);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "保存数据";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // coosefile_btn
            // 
            this.coosefile_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.coosefile_btn.Location = new System.Drawing.Point(4, 88);
            this.coosefile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coosefile_btn.Name = "coosefile_btn";
            this.coosefile_btn.Size = new System.Drawing.Size(93, 24);
            this.coosefile_btn.TabIndex = 4;
            this.coosefile_btn.Text = "选择路径";
            this.coosefile_btn.UseVisualStyleBackColor = true;
            this.coosefile_btn.Click += new System.EventHandler(this.coosefile_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stop_btn.Location = new System.Drawing.Point(104, 58);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(93, 24);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Tag = "true";
            this.stop_btn.Text = "暂停";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // manalclear_btn
            // 
            this.manalclear_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manalclear_btn.Location = new System.Drawing.Point(104, 28);
            this.manalclear_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manalclear_btn.Name = "manalclear_btn";
            this.manalclear_btn.Size = new System.Drawing.Size(93, 24);
            this.manalclear_btn.TabIndex = 2;
            this.manalclear_btn.Text = "手动清空";
            this.manalclear_btn.UseVisualStyleBackColor = true;
            this.manalclear_btn.Click += new System.EventHandler(this.manalclear_btn_Click);
            // 
            // hexrecieve_cbx
            // 
            this.hexrecieve_cbx.AutoSize = true;
            this.hexrecieve_cbx.Location = new System.Drawing.Point(5, 58);
            this.hexrecieve_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hexrecieve_cbx.Name = "hexrecieve_cbx";
            this.hexrecieve_cbx.Size = new System.Drawing.Size(91, 24);
            this.hexrecieve_cbx.TabIndex = 1;
            this.hexrecieve_cbx.Text = "十六进制";
            this.hexrecieve_cbx.UseVisualStyleBackColor = true;
            this.hexrecieve_cbx.CheckedChanged += new System.EventHandler(this.hexrecieve_cbx_CheckedChanged);
            // 
            // autoclear_cbx
            // 
            this.autoclear_cbx.AutoSize = true;
            this.autoclear_cbx.Location = new System.Drawing.Point(7, 28);
            this.autoclear_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autoclear_cbx.Name = "autoclear_cbx";
            this.autoclear_cbx.Size = new System.Drawing.Size(91, 24);
            this.autoclear_cbx.TabIndex = 0;
            this.autoclear_cbx.Text = "自动清空";
            this.autoclear_cbx.UseVisualStyleBackColor = true;
            this.autoclear_cbx.CheckedChanged += new System.EventHandler(this.autoclear_cbx_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.autosend_tbx);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.sendfile_tbx);
            this.groupBox3.Controls.Add(this.sendfile_btn);
            this.groupBox3.Controls.Add(this.openfile_btn);
            this.groupBox3.Controls.Add(this.clearsend_btn);
            this.groupBox3.Controls.Add(this.manalsend_btn);
            this.groupBox3.Controls.Add(this.hexsend_cbx);
            this.groupBox3.Controls.Add(this.autosend_cbx);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(12, 462);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(216, 186);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送配置";
            // 
            // autosend_tbx
            // 
            this.autosend_tbx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autosend_tbx.Location = new System.Drawing.Point(123, 151);
            this.autosend_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autosend_tbx.Name = "autosend_tbx";
            this.autosend_tbx.Size = new System.Drawing.Size(76, 25);
            this.autosend_tbx.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "自动发送周期ms";
            // 
            // sendfile_tbx
            // 
            this.sendfile_tbx.Location = new System.Drawing.Point(7, 118);
            this.sendfile_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendfile_tbx.Name = "sendfile_tbx";
            this.sendfile_tbx.Size = new System.Drawing.Size(191, 27);
            this.sendfile_tbx.TabIndex = 6;
            // 
            // sendfile_btn
            // 
            this.sendfile_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendfile_btn.Location = new System.Drawing.Point(104, 88);
            this.sendfile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendfile_btn.Name = "sendfile_btn";
            this.sendfile_btn.Size = new System.Drawing.Size(93, 24);
            this.sendfile_btn.TabIndex = 5;
            this.sendfile_btn.Text = "发送文件";
            this.sendfile_btn.UseVisualStyleBackColor = true;
            this.sendfile_btn.Click += new System.EventHandler(this.sendfile_btn_Click);
            // 
            // openfile_btn
            // 
            this.openfile_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openfile_btn.Location = new System.Drawing.Point(4, 88);
            this.openfile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openfile_btn.Name = "openfile_btn";
            this.openfile_btn.Size = new System.Drawing.Size(93, 24);
            this.openfile_btn.TabIndex = 4;
            this.openfile_btn.Text = "打开文件";
            this.openfile_btn.UseVisualStyleBackColor = true;
            this.openfile_btn.Click += new System.EventHandler(this.openfile_btn_Click);
            // 
            // clearsend_btn
            // 
            this.clearsend_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearsend_btn.Location = new System.Drawing.Point(104, 58);
            this.clearsend_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearsend_btn.Name = "clearsend_btn";
            this.clearsend_btn.Size = new System.Drawing.Size(93, 24);
            this.clearsend_btn.TabIndex = 3;
            this.clearsend_btn.Text = "清空发送";
            this.clearsend_btn.UseVisualStyleBackColor = true;
            this.clearsend_btn.Click += new System.EventHandler(this.clearsend_btn_Click);
            // 
            // manalsend_btn
            // 
            this.manalsend_btn.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.manalsend_btn.Location = new System.Drawing.Point(104, 28);
            this.manalsend_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manalsend_btn.Name = "manalsend_btn";
            this.manalsend_btn.Size = new System.Drawing.Size(93, 24);
            this.manalsend_btn.TabIndex = 2;
            this.manalsend_btn.Text = "手动发送";
            this.manalsend_btn.UseVisualStyleBackColor = true;
            this.manalsend_btn.Click += new System.EventHandler(this.manalsend_btn_Click);
            // 
            // hexsend_cbx
            // 
            this.hexsend_cbx.AutoSize = true;
            this.hexsend_cbx.Location = new System.Drawing.Point(5, 58);
            this.hexsend_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hexsend_cbx.Name = "hexsend_cbx";
            this.hexsend_cbx.Size = new System.Drawing.Size(91, 24);
            this.hexsend_cbx.TabIndex = 1;
            this.hexsend_cbx.Text = "十六进制";
            this.hexsend_cbx.UseVisualStyleBackColor = true;
            this.hexsend_cbx.CheckedChanged += new System.EventHandler(this.hexsend_cbx_CheckedChanged);
            // 
            // autosend_cbx
            // 
            this.autosend_cbx.AutoSize = true;
            this.autosend_cbx.Location = new System.Drawing.Point(7, 28);
            this.autosend_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autosend_cbx.Name = "autosend_cbx";
            this.autosend_cbx.Size = new System.Drawing.Size(91, 24);
            this.autosend_cbx.TabIndex = 0;
            this.autosend_cbx.Text = "自动发送";
            this.autosend_cbx.UseVisualStyleBackColor = true;
            this.autosend_cbx.CheckedChanged += new System.EventHandler(this.autosend_cbx_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.recive_tbx);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(235, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(592, 409);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收区";
            // 
            // recive_tbx
            // 
            this.recive_tbx.Location = new System.Drawing.Point(5, 26);
            this.recive_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recive_tbx.Multiline = true;
            this.recive_tbx.Name = "recive_tbx";
            this.recive_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recive_tbx.Size = new System.Drawing.Size(577, 364);
            this.recive_tbx.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.send_tbx);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(235, 396);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(592, 252);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "发送区";
            // 
            // send_tbx
            // 
            this.send_tbx.Location = new System.Drawing.Point(7, 22);
            this.send_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.send_tbx.Multiline = true;
            this.send_tbx.Name = "send_tbx";
            this.send_tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.send_tbx.Size = new System.Drawing.Size(576, 223);
            this.send_tbx.TabIndex = 0;
            this.send_tbx.Leave += new System.EventHandler(this.send_tbx_Leave);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口ToolStripMenuItem,
            this.温室风压雨ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(829, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 串口ToolStripMenuItem
            // 
            this.串口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自动扫描端口ToolStripMenuItem,
            this.默认串口配置ToolStripMenuItem,
            this.软件信息ToolStripMenuItem});
            this.串口ToolStripMenuItem.Name = "串口ToolStripMenuItem";
            this.串口ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.串口ToolStripMenuItem.Text = "串口";
            // 
            // 自动扫描端口ToolStripMenuItem
            // 
            this.自动扫描端口ToolStripMenuItem.Name = "自动扫描端口ToolStripMenuItem";
            this.自动扫描端口ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.自动扫描端口ToolStripMenuItem.Text = "自动扫描端口";
            this.自动扫描端口ToolStripMenuItem.Click += new System.EventHandler(this.自动扫描端口ToolStripMenuItem_Click);
            // 
            // 默认串口配置ToolStripMenuItem
            // 
            this.默认串口配置ToolStripMenuItem.Name = "默认串口配置ToolStripMenuItem";
            this.默认串口配置ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.默认串口配置ToolStripMenuItem.Text = "默认串口配置";
            this.默认串口配置ToolStripMenuItem.Click += new System.EventHandler(this.默认串口配置ToolStripMenuItem_Click);
            // 
            // 软件信息ToolStripMenuItem
            // 
            this.软件信息ToolStripMenuItem.Name = "软件信息ToolStripMenuItem";
            this.软件信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.软件信息ToolStripMenuItem.Text = "软件信息";
            this.软件信息ToolStripMenuItem.Click += new System.EventHandler(this.软件信息ToolStripMenuItem_Click);
            // 
            // 温室风压雨ToolStripMenuItem
            // 
            this.温室风压雨ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.温湿度ToolStripMenuItem,
            this.温度ToolStripMenuItem,
            this.湿度ToolStripMenuItem,
            this.风向风速ToolStripMenuItem,
            this.大气压ToolStripMenuItem,
            this.雨量ToolStripMenuItem,
            this.温湿风压雨ToolStripMenuItem});
            this.温室风压雨ToolStripMenuItem.Name = "温室风压雨ToolStripMenuItem";
            this.温室风压雨ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.温室风压雨ToolStripMenuItem.Text = "温室风压雨";
            // 
            // 温湿度ToolStripMenuItem
            // 
            this.温湿度ToolStripMenuItem.Name = "温湿度ToolStripMenuItem";
            this.温湿度ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.温湿度ToolStripMenuItem.Text = "温湿度";
            this.温湿度ToolStripMenuItem.Click += new System.EventHandler(this.温湿度ToolStripMenuItem_Click);
            // 
            // 温度ToolStripMenuItem
            // 
            this.温度ToolStripMenuItem.Name = "温度ToolStripMenuItem";
            this.温度ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.温度ToolStripMenuItem.Text = "温度";
            this.温度ToolStripMenuItem.Click += new System.EventHandler(this.温度ToolStripMenuItem_Click);
            // 
            // 湿度ToolStripMenuItem
            // 
            this.湿度ToolStripMenuItem.Name = "湿度ToolStripMenuItem";
            this.湿度ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.湿度ToolStripMenuItem.Text = "湿度";
            // 
            // 风向风速ToolStripMenuItem
            // 
            this.风向风速ToolStripMenuItem.Name = "风向风速ToolStripMenuItem";
            this.风向风速ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.风向风速ToolStripMenuItem.Text = "风向、风速";
            this.风向风速ToolStripMenuItem.Click += new System.EventHandler(this.WaitForDate);
            // 
            // 大气压ToolStripMenuItem
            // 
            this.大气压ToolStripMenuItem.Name = "大气压ToolStripMenuItem";
            this.大气压ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.大气压ToolStripMenuItem.Text = "大气压";
            this.大气压ToolStripMenuItem.Click += new System.EventHandler(this.WaitForDate);
            // 
            // 雨量ToolStripMenuItem
            // 
            this.雨量ToolStripMenuItem.Name = "雨量ToolStripMenuItem";
            this.雨量ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.雨量ToolStripMenuItem.Text = "雨量";
            this.雨量ToolStripMenuItem.Click += new System.EventHandler(this.WaitForDate);
            // 
            // 温湿风压雨ToolStripMenuItem
            // 
            this.温湿风压雨ToolStripMenuItem.Name = "温湿风压雨ToolStripMenuItem";
            this.温湿风压雨ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.温湿风压雨ToolStripMenuItem.Text = "温湿风压雨";
            this.温湿风压雨ToolStripMenuItem.Click += new System.EventHandler(this.WaitForDate);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于软件ToolStripMenuItem,
            this.使用帮助ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于软件ToolStripMenuItem
            // 
            this.关于软件ToolStripMenuItem.Name = "关于软件ToolStripMenuItem";
            this.关于软件ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.关于软件ToolStripMenuItem.Text = "关于软件";
            // 
            // 使用帮助ToolStripMenuItem
            // 
            this.使用帮助ToolStripMenuItem.Name = "使用帮助ToolStripMenuItem";
            this.使用帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.使用帮助ToolStripMenuItem.Text = "使用帮助";
            this.使用帮助ToolStripMenuItem.Click += new System.EventHandler(this.使用帮助ToolStripMenuItem_Click);
            // 
            // autoclearTime
            // 
            this.autoclearTime.Tick += new System.EventHandler(this.autoclearTime_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "data";
            // 
            // autosend_Time
            // 
            this.autosend_Time.Tick += new System.EventHandler(this.autosend_Time_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 652);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口助手_V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.CheckBox DTR_cbx;
        private System.Windows.Forms.CheckBox RTS_cbx;
        private System.Windows.Forms.ComboBox stop_cbb;
        private System.Windows.Forms.ComboBox data_cbb;
        private System.Windows.Forms.ComboBox check_cbb;
        private System.Windows.Forms.ComboBox baundrate_cbb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serialport_cbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox recievefile_tbx;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button coosefile_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button manalclear_btn;
        private System.Windows.Forms.CheckBox hexrecieve_cbx;
        private System.Windows.Forms.CheckBox autoclear_cbx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox autosend_tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sendfile_tbx;
        private System.Windows.Forms.Button sendfile_btn;
        private System.Windows.Forms.Button openfile_btn;
        private System.Windows.Forms.Button clearsend_btn;
        private System.Windows.Forms.Button manalsend_btn;
        private System.Windows.Forms.CheckBox hexsend_cbx;
        private System.Windows.Forms.CheckBox autosend_cbx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox recive_tbx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox send_tbx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 串口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动扫描端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 默认串口配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 软件信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 温室风压雨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 温湿度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 温度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 湿度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 风向风速ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大气压ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 雨量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 温湿风压雨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用帮助ToolStripMenuItem;
        private System.Windows.Forms.Timer autoclearTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer autosend_Time;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

