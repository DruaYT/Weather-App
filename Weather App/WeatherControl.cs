using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather_App
{
    public partial class WeatherControl : UserControl
    {
        List<Day> days = new List<Day>();

        string currentLocation = "Stratford,CA", tempCurrent;

        public PointF defaultSize = new PointF(893, 587);

        int sec, min, hour;

        bool IS_MILITARY_TIME, IS_CELCIUS=true; 

        public WeatherControl()
        {
            InitializeComponent();
        }

        private void resize()
        {
            Form f = this.FindForm();
            try
            {
                labelDay1.Width = (int)(this.Width / 7.7);
                labelDay2.Width = (int)(this.Width / 7.7);
                labelDay3.Width = (int)(this.Width / 7.7);
                labelDay4.Width = (int)(this.Width / 7.7);
                labelDay5.Width = (int)(this.Width / 7.7);
                labelDay6.Width = (int)(this.Width / 7.7);
                labelDay7.Width = (int)(this.Width / 7.7);

                labelStat1.Width = (int)(this.Width / 7.7);
                labelStat2.Width = (int)(this.Width / 7.7);
                labelStat3.Width = (int)(this.Width / 7.7);
                labelStat4.Width = (int)(this.Width / 7.7);
                labelStat5.Width = (int)(this.Width / 7.7);
                labelStat6.Width = (int)(this.Width / 7.7);
                labelStat7.Width = (int)(this.Width / 7.7);

                labelTime.Location = new Point(f.Width - (int)(1.1*labelTime.Width), 0);
                labelDay1.Location = new Point(0, f.Height / 5);
                labelDay2.Location = new Point((int)(labelDay1.Width * 1.1), f.Height / 5);
                labelDay3.Location = new Point(labelDay2.Location.X + (int)(labelDay2.Width * 1.1), f.Height / 5);
                labelDay4.Location = new Point(labelDay3.Location.X + (int)(labelDay3.Width * 1.1), f.Height / 5);
                labelDay5.Location = new Point(labelDay4.Location.X + (int)(labelDay4.Width * 1.1), f.Height / 5);
                labelDay6.Location = new Point(labelDay5.Location.X + (int)(labelDay5.Width * 1.1), f.Height / 5);
                labelDay7.Location = new Point(labelDay6.Location.X + (int)(labelDay6.Width * 1.1), f.Height / 5);

                labelStat1.Location = new Point(labelDay1.Location.X, labelDay1.Location.Y + labelDay1.Height);
                labelStat2.Location = new Point(labelDay2.Location.X, labelDay2.Location.Y + labelDay2.Height);
                labelStat3.Location = new Point(labelDay3.Location.X, labelDay3.Location.Y + labelDay3.Height);
                labelStat4.Location = new Point(labelDay4.Location.X, labelDay4.Location.Y + labelDay4.Height);
                labelStat5.Location = new Point(labelDay5.Location.X, labelDay5.Location.Y + labelDay5.Height);
                labelStat6.Location = new Point(labelDay6.Location.X, labelDay6.Location.Y + labelDay6.Height);
                labelStat7.Location = new Point(labelDay7.Location.X, labelDay7.Location.Y + labelDay7.Height);

                labelDay1.Text = DateTime.Today.DayOfWeek.ToString();
                labelDay2.Text = DateTime.Today.AddDays(1).DayOfWeek.ToString();
                labelDay3.Text = DateTime.Today.AddDays(2).DayOfWeek.ToString();
                labelDay4.Text = DateTime.Today.AddDays(3).DayOfWeek.ToString();
                labelDay5.Text = DateTime.Today.AddDays(4).DayOfWeek.ToString();
                labelDay6.Text = DateTime.Today.AddDays(5).DayOfWeek.ToString();
                labelDay7.Text = DateTime.Today.AddDays(6).DayOfWeek.ToString();

                if (IS_CELCIUS == true)
                {
                    CurrentWeatherStats.Text = $"{currentLocation} \n\r{Convert.ToInt32(tempCurrent)}°C";
                }
                else
                {
                    CurrentWeatherStats.Text = $"{currentLocation} \n\r{(Convert.ToInt32(tempCurrent)*(9/5))+32} F";
                }
                
            }
            catch
            {
                this.SuspendLayout();
            }
            
        }

        private void updateWeather()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={currentLocation}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read()) 
            { 
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("date");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                days.Add(d);
            }

        }

        private void updateCurrent()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={currentLocation}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read()) 
            {
                reader.ReadToFollowing("city");

                reader.ReadToFollowing("temperature");
                tempCurrent = reader.GetAttribute("value");
            }

        }

        private void WeatherControl_Load(object sender, EventArgs e)
        {
            updateCurrent();
            resize();
            updateWeather();
            tickTimer.Enabled = true;
            IS_MILITARY_TIME = false;
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            sec = DateTime.Now.Second;
            min = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;

            if (IS_MILITARY_TIME == false)
            {
                if (hour > 12)
                {
                    labelTime.Text = $"{(hour - 12).ToString("00")}:{min.ToString("00")}:{sec.ToString("00")} PM";
                }
                else
                {
                    labelTime.Text = $"{(hour - 12).ToString("00")}:{min.ToString("00")}:{sec.ToString("00")} AM";
                }
            }
            else
            {
                labelTime.Text = $"{(hour).ToString("00")}:{min.ToString("00")}:{sec.ToString("00")}";
            }

                
        }
    }
}
