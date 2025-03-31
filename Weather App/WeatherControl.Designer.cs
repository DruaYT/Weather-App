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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(703, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}
