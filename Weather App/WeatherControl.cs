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
                labelTime.Location = new Point(f.Width - (int)(1.1*labelTime.Width), 0);
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
