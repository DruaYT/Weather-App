namespace Weather_App
{
    partial class WeatherControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurrentWeatherStats = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.labelDay1 = new System.Windows.Forms.Label();
            this.labelDay2 = new System.Windows.Forms.Label();
            this.labelDay3 = new System.Windows.Forms.Label();
            this.labelDay4 = new System.Windows.Forms.Label();
            this.labelDay5 = new System.Windows.Forms.Label();
            this.labelDay6 = new System.Windows.Forms.Label();
            this.labelDay7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentWeatherStats
            // 
            this.CurrentWeatherStats.AutoSize = true;
            this.CurrentWeatherStats.Font = new System.Drawing.Font("MS PGothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWeatherStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CurrentWeatherStats.Location = new System.Drawing.Point(3, 0);
            this.CurrentWeatherStats.Name = "CurrentWeatherStats";
            this.CurrentWeatherStats.Size = new System.Drawing.Size(287, 68);
            this.CurrentWeatherStats.TabIndex = 0;
            this.CurrentWeatherStats.Text = "LOCATION_NAME\r\nTEMP°C";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("MS PGothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTime.Location = new System.Drawing.Point(606, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(287, 44);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00 AM";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 50;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // labelDay1
            // 
            this.labelDay1.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay1.ForeColor = System.Drawing.Color.White;
            this.labelDay1.Location = new System.Drawing.Point(6, 134);
            this.labelDay1.Name = "labelDay1";
            this.labelDay1.Size = new System.Drawing.Size(147, 42);
            this.labelDay1.TabIndex = 2;
            this.labelDay1.Text = "DAY";
            this.labelDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay2
            // 
            this.labelDay2.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay2.ForeColor = System.Drawing.Color.White;
            this.labelDay2.Location = new System.Drawing.Point(143, 134);
            this.labelDay2.Name = "labelDay2";
            this.labelDay2.Size = new System.Drawing.Size(147, 42);
            this.labelDay2.TabIndex = 3;
            this.labelDay2.Text = "DAY";
            this.labelDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay3
            // 
            this.labelDay3.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay3.ForeColor = System.Drawing.Color.White;
            this.labelDay3.Location = new System.Drawing.Point(282, 134);
            this.labelDay3.Name = "labelDay3";
            this.labelDay3.Size = new System.Drawing.Size(147, 42);
            this.labelDay3.TabIndex = 4;
            this.labelDay3.Text = "DAY";
            this.labelDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay4
            // 
            this.labelDay4.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay4.ForeColor = System.Drawing.Color.White;
            this.labelDay4.Location = new System.Drawing.Point(419, 134);
            this.labelDay4.Name = "labelDay4";
            this.labelDay4.Size = new System.Drawing.Size(147, 42);
            this.labelDay4.TabIndex = 5;
            this.labelDay4.Text = "DAY";
            this.labelDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay5
            // 
            this.labelDay5.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay5.ForeColor = System.Drawing.Color.White;
            this.labelDay5.Location = new System.Drawing.Point(560, 134);
            this.labelDay5.Name = "labelDay5";
            this.labelDay5.Size = new System.Drawing.Size(147, 42);
            this.labelDay5.TabIndex = 6;
            this.labelDay5.Text = "DAY";
            this.labelDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay6
            // 
            this.labelDay6.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay6.ForeColor = System.Drawing.Color.White;
            this.labelDay6.Location = new System.Drawing.Point(699, 134);
            this.labelDay6.Name = "labelDay6";
            this.labelDay6.Size = new System.Drawing.Size(147, 42);
            this.labelDay6.TabIndex = 7;
            this.labelDay6.Text = "DAY";
            this.labelDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay7
            // 
            this.labelDay7.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay7.ForeColor = System.Drawing.Color.White;
            this.labelDay7.Location = new System.Drawing.Point(821, 134);
            this.labelDay7.Name = "labelDay7";
            this.labelDay7.Size = new System.Drawing.Size(147, 42);
            this.labelDay7.TabIndex = 8;
            this.labelDay7.Text = "DAY";
            this.labelDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.labelDay7);
            this.Controls.Add(this.labelDay6);
            this.Controls.Add(this.labelDay5);
            this.Controls.Add(this.labelDay4);
            this.Controls.Add(this.labelDay3);
            this.Controls.Add(this.labelDay2);
            this.Controls.Add(this.labelDay1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.CurrentWeatherStats);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(893, 587);
            this.Load += new System.EventHandler(this.WeatherControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentWeatherStats;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Label labelDay1;
        private System.Windows.Forms.Label labelDay2;
        private System.Windows.Forms.Label labelDay3;
        private System.Windows.Forms.Label labelDay4;
        private System.Windows.Forms.Label labelDay5;
        private System.Windows.Forms.Label labelDay6;
        private System.Windows.Forms.Label labelDay7;
    }
}
