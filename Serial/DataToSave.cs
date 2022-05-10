using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial
{
    public class DataToSave
    {
        public int countSecond { get; set; }
        public string nowTime { get; set; }
        public double temperature { get; set; }
        public double humidity { get; set; }
        public double windDirection { get; set; }
        public double windSpeed { get; set; }

        public DataToSave(int CountSecond, string NowTime, double Temperature, double Humidity, double WindDirection, double WindSpeed)
        {
            countSecond = CountSecond;
            nowTime = NowTime;
            temperature = Temperature;
            humidity = Humidity;
            windDirection = WindDirection;
            windSpeed = WindSpeed;
        }
        public DataToSave()
        {

        }
    }
}
