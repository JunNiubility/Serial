using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Serial
{
    public partial class Temperature_Humidity : Form
    {
        public Temperature_Humidity()
        {
            InitializeComponent();
        }

        private void Temperature_Humidity_Load(object sender, EventArgs e)
        {

        }

        private void 自动扫描ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 默认端口配置toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void open_btn_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            int width = this.Width;
            int height = this.Height;

            Rectangle rct = new Rectangle(0, 0, width / 4, height / 4);
            Pen pen = new Pen(Color.Red);
            graphics.DrawArc(pen, rct, 0, 120);//绘制弧线，弧线是由Rectangle构成的椭圆的的弧线组成,顺时针从0到360，水平向右是0度。

            rct = new Rectangle(0, 0, width / 3, width / 3);
            Brush brush = new SolidBrush(Color.Green);
            graphics.DrawPie(pen, rct, 0, 120);//绘制扇形
            graphics.FillPie(brush, rct, 0, 120);//填充扇形;
        }
    }
}
