using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Weather_App
{
    public partial class WeatherControl : UserControl
    {
        List<Day> days = new List<Day>();

        List<Label> dayLabels = new List<Label>();
        List<Label> statLabels = new List<Label>();

        List<PictureBox> symbols = new List<PictureBox>();

        public PointF defaultSize = new PointF(893, 587);

        int sec, min, hour;

        bool IS_MILITARY_TIME, IS_CELCIUS=true;

        public WeatherControl()
        {
            InitializeComponent();
        }

        public Image GetImage(string cond)
        {
            Image ret;
            switch (cond)
            {
                case "few clouds" :
                    ret = Properties.Resources.few_clouds;
                    return ret;

                case "light rain":
                    ret = Properties.Resources.light_rain;
                    return ret;

                case "moderate rain":
                    ret = Properties.Resources.moderate_rain;
                    return ret;

                case "heavy rain":
                    ret = Properties.Resources.heavy_rain;
                    return ret;

                case "very heavy rain":
                    ret = Properties.Resources.moderate_rain;
                    return ret;

                case "rain and snow":
                    ret = Properties.Resources.rain_and_snow;
                    return ret;

                case "light snow":
                    ret = Properties.Resources.light_snow;
                    return ret;

                case "moderate snow":
                    ret = Properties.Resources.moderate_snow;
                    return ret;

                case "heavy snow":
                    ret = Properties.Resources.heavy_snow;
                    return ret;

                case "very heavy snow":
                    ret = Properties.Resources.very_heavy_snow;
                    return ret;

                case "overcast clouds":
                    ret = Properties.Resources.overcast_clouds;
                    return ret;

                case "mostly cloudy":
                    ret = Properties.Resources.mostly_cloudy;
                    return ret;

                case "broken up clouds":
                    ret = Properties.Resources.overcast_clouds;
                    return ret;

                case "scattered clouds":
                    ret = Properties.Resources.scattered_clouds;
                    return ret;
            }

            return null;
        }

        public void resize()
        {
            Form f = this.FindForm();
            try
            {
                for(int l = 0; l < 7; l++)
                {
                    Day day = days[l];

                    dayLabels[l].Width = (int)(f.Width / 7.7);
                    dayLabels[l].Height = (int)(f.Height / 20);

                    statLabels[l].Width = (int)(f.Width / 7.7);
                    statLabels[l].Height = (int)(f.Height / 3);

                    symbols[l].Width = (int)(f.Width / 7.7);
                    symbols[l].Height = symbols[l].Width;

                    statLabels[l].Text = $"{day.tempHigh}°C\n\r{day.tempLow}°C\n\r \n\r{day.condition}\n\r{day.precipitation}\n\r \n\r{day.windDirection} \n\r {day.windSpeed}";

                    if (l == 0)
                    {
                        dayLabels[l].Location = new Point(0, f.Height / 5);
                    }
                    else
                    {
                        dayLabels[l].Location = new Point(dayLabels[l - 1].Location.X + (int)(dayLabels[l - 1].Width * 1.1), f.Height / 5);
                    }

                    Image a = GetImage(days[l].condition);

                    statLabels[l].Location = new Point(dayLabels[l].Location.X, dayLabels[l].Location.Y + dayLabels[l].Height);

                    symbols[l].Location = new Point(dayLabels[l].Location.X, statLabels[l].Location.Y + statLabels[l].Height);

                    symbols[l].SizeMode = PictureBoxSizeMode.StretchImage;
                    symbols[l].Image = a;

                    dayLabels[l].Text = DateTime.Today.AddDays(l).DayOfWeek.ToString();
                }

                labelTime.Location = new Point(f.Width - (int)(1.1*labelTime.Width), 0);

                if (IS_CELCIUS == true)
                {
                    CurrentWeatherStats.Text = $"{Form1.currentLocation} \n\r{Convert.ToInt32(Form1.tempCurrent)}°C";
                }
                else
                {
                    CurrentWeatherStats.Text = $"{Form1.currentLocation} \n\r{(Convert.ToInt32(Form1.tempCurrent)*(9/5))+32} F";
                }
                
            }
            catch
            {
                this.SuspendLayout();
            }
            
        }

        private void updateWeather()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={Form1.currentLocation}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("date");

                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");

                reader.ReadToFollowing("precipitation");
                d.precipitation = $"{Convert.ToDecimal(reader.GetAttribute("probability")) * 100}% {reader.GetAttribute("type")}";

                reader.ReadToFollowing("windDirection");
                d.windDirection = $"{reader.GetAttribute("deg")}° [{reader.GetAttribute("name")}]";

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = $"{reader.GetAttribute("mps")} m/s";

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                days.Add(d);
            }

        }

        private void labelStat1_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void labelStat1_Paint(object sender, PaintEventArgs e)
        {
            resize();
        }

        private void updateCurrent()
        {
            string v;
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={Form1.currentLocation}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            while (reader.Read()) 
            {
                reader.ReadToFollowing("city");

                reader.ReadToFollowing("temperature");
                v = reader.GetAttribute("value");

                if (v != null)
                {
                    Form1.tempCurrent = Convert.ToDouble(v);
                }
            }

        }

        private void WeatherControl_Load(object sender, EventArgs e)
        {
            statLabels.Add(labelStat1);
            statLabels.Add(labelStat2);
            statLabels.Add(labelStat3);
            statLabels.Add(labelStat4);
            statLabels.Add(labelStat5);
            statLabels.Add(labelStat6);
            statLabels.Add(labelStat7);

            dayLabels.Add(labelDay1);
            dayLabels.Add(labelDay2);
            dayLabels.Add(labelDay3);
            dayLabels.Add(labelDay4);
            dayLabels.Add(labelDay5);
            dayLabels.Add(labelDay6);
            dayLabels.Add(labelDay7);

            symbols.Add(pictureDay1);
            symbols.Add(pictureDay2);
            symbols.Add(pictureDay3);
            symbols.Add(pictureDay4);
            symbols.Add(pictureDay5);
            symbols.Add(pictureDay6);
            symbols.Add(pictureDay7);

            updateCurrent();

            updateWeather();

            resize();

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
