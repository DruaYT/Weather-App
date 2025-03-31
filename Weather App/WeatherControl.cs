using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class WeatherControl : UserControl
    {
        public PointF defaultSize = new PointF(893, 587);

        int sec, min, hour;

        bool IS_MILITARY_TIME, IS_CELCIUS; 

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

                labelTime.Location = new Point(f.Width - (int)(1.1*labelTime.Width), 0);
                labelDay1.Location = new Point(0, f.Height / 5);
                labelDay2.Location = new Point((int)(labelDay1.Width * 1.1), f.Height / 5);
                labelDay3.Location = new Point(labelDay2.Location.X + (int)(labelDay2.Width * 1.1), f.Height / 5);
                labelDay4.Location = new Point(labelDay3.Location.X + (int)(labelDay3.Width * 1.1), f.Height / 5);
                labelDay5.Location = new Point(labelDay4.Location.X + (int)(labelDay4.Width * 1.1), f.Height / 5);
                labelDay6.Location = new Point(labelDay5.Location.X + (int)(labelDay5.Width * 1.1), f.Height / 5);
                labelDay7.Location = new Point(labelDay6.Location.X + (int)(labelDay6.Width * 1.1), f.Height / 5);
            }
            catch
            {
                this.SuspendLayout();
            }
            
        }

        private void WeatherControl_Load(object sender, EventArgs e)
        {
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
