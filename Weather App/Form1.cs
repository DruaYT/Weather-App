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
        public Form1()
        {
            InitializeComponent();
            WeatherControl c = new WeatherControl();
            c.Width = this.Width;
            c.Height = this.Height;
            this.Controls.Add(c);
            this.SuspendLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
