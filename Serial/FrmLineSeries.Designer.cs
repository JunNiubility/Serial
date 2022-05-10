namespace Serial
{
    partial class FrmLineSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLineSeries));
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.timecount = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.circlePanel = new Serial.CirclePanel();
            this.mysql_tsb = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotView1
            // 
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(957, 742);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.plotView1);
            this.panel1.Location = new System.Drawing.Point(124, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 742);
            this.panel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.mysql_tsb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1102, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "保存PDF";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton2.Text = "保存PNG";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // timecount
            // 
            this.timecount.AutoSize = true;
            this.timecount.Location = new System.Drawing.Point(12, 41);
            this.timecount.Name = "timecount";
            this.timecount.Size = new System.Drawing.Size(65, 12);
            this.timecount.TabIndex = 4;
            this.timecount.Text = "累计时间：";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(74, 41);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(53, 12);
            this.time_lbl.TabIndex = 5;
            this.time_lbl.Text = "00:00:00";
            // 
            // circlePanel
            // 
            this.circlePanel.Angle = 90F;
            this.circlePanel.CirInnerColor = System.Drawing.Color.Red;
            this.circlePanel.CirOutColor = System.Drawing.SystemColors.Highlight;
            this.circlePanel.Location = new System.Drawing.Point(12, 65);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Padding = new System.Windows.Forms.Padding(2);
            this.circlePanel.Size = new System.Drawing.Size(163, 163);
            this.circlePanel.StrFont = new System.Drawing.Font("我在红尘中等你", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.circlePanel.TabIndex = 3;
            // 
            // mysql_tsb
            // 
            this.mysql_tsb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mysql_tsb.Image = ((System.Drawing.Image)(resources.GetObject("mysql_tsb.Image")));
            this.mysql_tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mysql_tsb.Name = "mysql_tsb";
            this.mysql_tsb.Size = new System.Drawing.Size(47, 22);
            this.mysql_tsb.Text = "Mysql";
            this.mysql_tsb.Click += new System.EventHandler(this.mysql_tsb_Click);
            // 
            // FrmLineSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 782);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.timecount);
            this.Controls.Add(this.circlePanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLineSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "温湿度实时显示";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private CirclePanel circlePanel;
        private System.Windows.Forms.Label timecount;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.ToolStripButton mysql_tsb;
    }
}

