﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using Image = OxyPlot.Reporting.Image;
using SvgExporter = OxyPlot.WindowsForms.SvgExporter;

namespace Serial
{
    /// <summary>
    /// 温湿度实时显示曲线窗体类
    /// </summary>
    public partial class FrmLineSeries : Form
    {
        #region 字段
        private DateTimeAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴
        private PlotModel _myPlotModel;//坐标轴
        private THW THWMethod;//温湿度串口配置
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="THWForm"></param>
        public FrmLineSeries(THW THWForm)
        {
            InitializeComponent();
            System.Drawing.StringFormat.GenericTypographic.FormatFlags &= ~StringFormatFlags.LineLimit;
            THWMethod = THWForm;
        }

        #region 事件
        /// <summary>
        /// 窗体初始化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //定义model
            _myPlotModel = new PlotModel()
            {
                Title = "温湿度实时曲线",
                LegendTitle = "Legend",
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Inside,
                LegendPosition = LegendPosition.TopRight,
                LegendBackground = OxyColor.FromAColor(200, OxyColors.Beige),
                LegendBorder = OxyColors.Black,
                DefaultFont = "微软雅黑",
            };
            //X轴
            _dateAxis = new DateTimeAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalLength = 80,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                StringFormat = "HH:mm:ss",
                Title = "时间"
            };
            _myPlotModel.Axes.Add(_dateAxis);

            //Y轴
            _valueAxis = new LinearAxis()
            {
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IntervalLength = 40,
                Angle = -90,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 100,
                Minimum = -25,
                Title = "温度 ℃ / 湿度 % / 风速 m/s"
            };
            _myPlotModel.Axes.Add(_valueAxis);

            //添加标注线，温度上下限和湿度上下限
            //var lineTempMaxAnnotation = new OxyPlot.Annotations.LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Color = OxyColors.Blue,
            //    LineStyle = LineStyle.LongDashDot,
            //    Y = 10,
            //    Text = "Tmin:10",
            //};
            //_myPlotModel.Annotations.Add(lineTempMaxAnnotation);

            //var lineTempMinAnnotation = new LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Y = 30,
            //    Text = "Tmax:30",
            //    Color = OxyColors.Red,
            //    LineStyle = LineStyle.LongDashDot,
            //};
            //_myPlotModel.Annotations.Add(lineTempMinAnnotation);

            //var lineHumiMaxAnnotation = new OxyPlot.Annotations.LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Color = OxyColors.Red,
            //    LineStyle = LineStyle.LongDashDot,
            //    Y = 75,
            //    Text = "Hmax:75",
            //};
            //_myPlotModel.Annotations.Add(lineHumiMaxAnnotation);

            //var lineHumiMinAnnotation = new LineAnnotation()
            //{
            //    Type = LineAnnotationType.Horizontal,
            //    Y = 35,
            //    Text = "Hmin:35",
            //    Color = OxyColors.Blue,
            //    LineStyle = LineStyle.LongDashDot,
            //};
            //_myPlotModel.Annotations.Add(lineHumiMinAnnotation);

            //添加三条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Red,
                StrokeThickness = 2,
                MarkerSize = 3,
                MarkerStroke = OxyColors.IndianRed,
                MarkerType = MarkerType.Diamond,
                Title = "温度",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);

            series = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2,
                MarkerSize = 3,
                MarkerStroke = OxyColors.BlueViolet,
                MarkerType = MarkerType.Triangle,
                Title = "湿度",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);

            series = new LineSeries()
            {
                Color = OxyColors.Green,
                StrokeThickness = 2,
                MarkerSize = 3,
                MarkerStroke = OxyColors.GreenYellow,
                MarkerType = MarkerType.Star,
                Title = "风速",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);

            //plotView1.Font = Font;
            plotView1.Model = _myPlotModel;

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    var date = DateTime.Now;
                    _myPlotModel.Axes[0].Maximum = DateTimeAxis.ToDouble(date.AddSeconds(1));

                    var lineSer = plotView1.Model.Series[0] as LineSeries;
                    lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), THWMethod.SendData().temperature));
                    if (lineSer.Points.Count > 100)
                    {
                        lineSer.Points.RemoveAt(0);
                    }

                    lineSer = plotView1.Model.Series[1] as LineSeries;
                    lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), THWMethod.SendData().humidity));
                    if (lineSer.Points.Count > 100)
                    {
                        lineSer.Points.RemoveAt(0);
                    }

                    lineSer = plotView1.Model.Series[2] as LineSeries;
                    lineSer.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), THWMethod.SendData().windSpeed));
                    if (lineSer.Points.Count > 100)
                    {
                        lineSer.Points.RemoveAt(0);
                    }

                    var strSql = "insert into thw_datas (CountSecond,NowTime,Temperature,Humidity,WindDirection,WindSpeed) values (@CountSecond,@NowTime,@Temperature,@Humidity,@WindDirection,@WindSpeed)";
                    MySqlParameter[] para = new MySqlParameter[]
                    {
                        new MySqlParameter("@CountSecond", THWMethod.SendData().countSecond),
                        new MySqlParameter("@NowTime", DateTime.Now.ToString()),
                        new MySqlParameter("@Temperature",THWMethod.SendData().temperature),
                        new MySqlParameter("@Humidity",THWMethod.SendData().humidity),
                        new MySqlParameter("@WindDirection",THWMethod.SendData().windDirection),
                        new MySqlParameter("@WindSpeed",THWMethod.SendData().windSpeed)
                    };
                    if (!MySQLHelper.Handle(strSql, para))
                    {
                        MessageBox.Show("数据库添加失败","警告");
                    }

                    this.circlePanel.Angle = (float)THWMethod.SendData().windDirection - 90;

                    int count = THWMethod.SendData().countSecond;
                    this.time_lbl.Text = (count / 3600).ToString() + ":" + (count / 60 % 60).ToString() + ":" + (count % 60).ToString();
                    _myPlotModel.InvalidatePlot(true);                                   
                    Thread.Sleep(1000);
                }
            });
        }
        /// <summary>
        /// 保存为PDF功能事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.pdf");
            using (var s = File.Create(path))
            {
                PdfExporter.Export(plotView1.Model, s, 800, 500);
            }
        }
        /// <summary>
        /// 保存为图片功能事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "data.png");
            using (var s = File.Create(path))

            {
                PngExporter png = new PngExporter();
                png.Background = OxyColors.White;
                png.Export(plotView1.Model, s);
                PngExporter.Export(plotView1.Model, "data.png", 800, 500);
                PdfExporter.Export(plotView1.Model, s, 800, 500);
            }
        }
        #endregion

        private void mysql_tsb_Click(object sender, EventArgs e)
        {
            MysqlFrm mysqlFrm = new MysqlFrm();
            mysqlFrm.ShowDialog();
        }
    }
}
