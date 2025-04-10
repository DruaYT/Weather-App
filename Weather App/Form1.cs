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
    public partial class Form1 : Form
    {
        public static string currentLocation = "Stratford,CA";
        public static string currentCondition;

        public static double tempCurrent = 0;

        WeatherControl CurrentC;
        public Form1()
        {
            InitializeComponent();

            WeatherControl c = new WeatherControl();

            c.Width = this.Width;
            c.Height = this.Height;

            CurrentC = c;

            this.Controls.Add(c);

            this.SuspendLayout();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (CurrentC != null)
            {
                CurrentC.Width = this.Width;
                CurrentC.Height = this.Height;

                CurrentC.resize();
            }
        }
    }
}
