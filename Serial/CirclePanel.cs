using Serial.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial
{
    public partial class CirclePanel : UserControl
    {
        public CirclePanel()
        {
            InitializeComponent();
            this.Angle = 90;
            this.CirInnerColor = Color.Red;
            this.CirOutColor = Color.Black;
            this.IndexColor = Brushes.Red;
            this.StrFont = new Font("宋体", this.Width / 20,FontStyle.Bold);
            this.FontColor = Brushes.Black;
        }
        private float _angle;
        [Category("自定义数据"), Description("圆盘指针的角度")]
        public float Angle
        {
            get { return _angle; }
            set { _angle = value; this.Invalidate(); }
        }

        private Color _cirInnerColor;
        [Category("自定义数据"), Description("圆中心颜色")]
        public Color CirInnerColor
        {
            get { return _cirInnerColor; }
            set { _cirInnerColor = value; this.Invalidate(); }
        }

        private Color _cirOutColor;
        [Category("自定义数据"), Description("圆盘颜色")]
        public Color CirOutColor
        {
            get { return _cirOutColor; }
            set { _cirOutColor = value; this.Invalidate(); }
        }

        private Brush _indexColor;

        [Category("自定义数据"), Description("圆中心颜色")]
        public Brush IndexColor
        {
            get { return _indexColor; }
            set { _indexColor = value; this.Invalidate(); }
        }

        private Brush _fontColor;
        [Category("自定义数据"), Description("圆盘标签字体")]
        public Brush FontColor
        {
            get { return _fontColor; }
            set { _fontColor = value; this.Invalidate(); }
        }

        private Font _strFont;
        [Category("自定义数据"), Description("圆盘标签字体大小")]
        public Font StrFont
        {
            get { return _strFont; }
            set { _strFont = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.Height = this.Width;
            Graphics graphics = e.Graphics;
            float cenX = (float)this.Width / 2;
            float cenY = (float)this.Height / 2;
            float startX = (float)this.Width / 40;
            float startY = (float)this.Height / 40;
            float width = (float)this.Width / 40 * 38;
            float height = (float)this.Height / 40 * 38;
            float cirR = (float)(width / 2.3);
            float innerCirR = (float)(width / 20);

            float cirSX = cenX - width / 40;
            float cirSY = cenY - height / 40;
            RectangleF cirRect = new RectangleF(new PointF(cirSX, cirSY), new SizeF(width / 20, height / 20));
            Pen pen = new Pen(CirOutColor, this.Width / 50);
            RectangleF rectanglef = new RectangleF(new PointF(startX, startY), new SizeF(width, height));
            graphics.DrawArc(pen, rectanglef, 0, 360);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            graphics.DrawArc(new Pen(CirInnerColor, width / 20), cirRect, 0, 360);

            PointF point1 = new PointF(cenX + (float)(cirR * Math.Cos(this._angle * 3.14 / 180)), cenY + (float)(cirR * Math.Sin(this._angle * 3.14 / 180)));
            PointF point2 = new PointF(cenX + (float)(innerCirR * Math.Cos((_angle - 90) * 3.14 / 180)), cenY + (float)(innerCirR * Math.Sin((_angle - 90) * 3.14 / 180)));
            PointF point3 = new PointF(cenX + (float)(innerCirR * Math.Cos((_angle + 90) * 3.14 / 180)), cenY + (float)(innerCirR * Math.Sin((_angle + 90) * 3.14 / 180)));
            graphics.FillPolygon(_indexColor, new PointF[3] { point1, point2, point3 }, FillMode.Winding);

            StringFormat stf = new StringFormat();
            stf.Alignment = StringAlignment.Center;
            graphics.DrawString("N", _strFont, _fontColor, new PointF(cenX, width / 20),stf);
            graphics.DrawString("S", _strFont, _fontColor, new PointF(cenX, width / 20 * 18),stf);
            graphics.DrawString("W", _strFont, _fontColor, new PointF(width / 20*2, cenY),stf);
            graphics.DrawString("E", _strFont, _fontColor, new PointF(width / 20 * 19, cenY),stf);
        }
    }
}
